using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
            this.rnd = new Random();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        // MAKE FUNCTION TO RUN THE SIMULATION

        public int finishTime;
        Random rnd ;

        private int SetInterArrival(List<TimeDistribution> arivalTD, int RandomInterArrival)
        {

            int InterArrival = -1;
            for (int i = 0; i < arivalTD.Count; ++i)
            {
                if (RandomInterArrival >= arivalTD[i].MinRange
                    && RandomInterArrival <= arivalTD[i].MaxRange)
                {
                    InterArrival = arivalTD[i].Time;
                    break;
                }
            }
           
            return InterArrival;
        }

        // Return the server with least utilization and is idle
        private int LeastUtilizationMethod(List<int> ServersIDs)
        {
            decimal lum = 1000000000;
            int serverID = -1;

            foreach (int i in ServersIDs)
            {
                if (this.finishTime == 0)
                    this.finishTime = 1;
                // Calculate the working time to total time ratio of server[i]
                decimal tmp = (Servers[i].TotalWorkingTime / this.finishTime);
                // If the working time is smaller than the previous least then replace it
                if (lum > tmp)
                {
                    lum = tmp;
                    serverID = i;
                }
            }
            return serverID;
        }

        // Return the server with highest priority and is idle (First in the List)
        private int HighestPriorityMethod(List<int> ServersIDs)
        {
            return ServersIDs[0];
        }

        // Return an idle server randomly from List
        private int RandomMethod(List<int> ServersIDs)
        {
            
            int RandomInterArrival = this.rnd.Next(0, ServersIDs.Count);

            return ServersIDs[RandomInterArrival];
        }


        // Return the id of the server who will be idle first
        private List<int> MinFinishTime(List<Server> Servers)
        {
            int minFtime = 1000000000;
            int serverID = -1;

            for (int i = 0; i < Servers.Count; ++i)
            {
                if (minFtime > Servers[i].FinishTime)
                {
                    minFtime = Servers[i].FinishTime;
                    serverID = i;

                }
            }
            List<int> ServersIndecies = new List<int>();

            for (int i = 0; i < this.Servers.Count; ++i)
            {
                if (this.Servers[i].FinishTime == this.Servers[serverID].FinishTime)
                {
                    ServersIndecies.Add(i);
                }
            }
            return ServersIndecies;
        }

        //private void UpdateQ(bool emp, int Interarrival, int prevDelay)
        //{

        //    if (emp)
        //        this.currentQ -= 1;

        //    else {
        //        if (Interarrival < prevDelay)
        //            this.currentQ += 1;
        //        else
        //            this.currentQ = 1;
        //    }
        //    this.maxQ = Math.Max(this.currentQ, this.maxQ);
        //}

        // Return the server depending on the selection method chosen and arrival time
        private int Findserver(Enums.SelectionMethod SelectionMethod ,int arrival)
        {
            List<int> ServersIndecies = new List<int>();
            int serverInd;

            bool emp = false; 
            for (int i = 0; i < this.Servers.Count; ++i)
            {
                // Checks if the server is idle to add to ServerIndecies list
                if (this.Servers[i].FinishTime <= arrival)
                {
                    ServersIndecies.Add(i);
                    emp = true;
                }
            }
            if (!emp) // If no server is idle, choose servers who will be idle first
            {
                ServersIndecies = MinFinishTime(this.Servers);                
            }

            //UpdateQ(emp, Interarrival, prevDelay);

            // Get the server depending on the selection method
            if (SelectionMethod == Enums.SelectionMethod.HighestPriority)
            {
                serverInd = HighestPriorityMethod(ServersIndecies);
            }
            else if(SelectionMethod == Enums.SelectionMethod.Random)
            {
                serverInd = RandomMethod(ServersIndecies);
            }
            else
            {
                serverInd = LeastUtilizationMethod(ServersIndecies);
            }

            return serverInd;
        }

        // Builds the simulation table
        public int BuildSimulationTable()
        {
            this.finishTime = 0;

            int prevArrivalTime = 0;
            int si = Findserver(this.SelectionMethod, 0); // Gets the first server id
            Server s = this.Servers[si];
            SimulationCase sc = new SimulationCase(s, 1, this.rnd.Next(1, 101), 0, 0, 0);
            sc.buildCase(); // Creates row in table
            //SimulationCase sc = new SimulationCase(Servers[0], 1, 0, 0, 1, 2, 0, 2, 0, 0);

            this.SimulationTable.Add(sc); // Adds the row to the table

            int clientCount = 1;
            while (true)
            {
                // Stop the simulation if the stopping condition is met
                if (StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
                {
                    // Stop the simulation if customer number is passed
                    if (clientCount >= this.StoppingNumber)
                        break;
                }
                else
                {
                    // Stop the simulation if finish time is passed
                    if (finishTime >= this.StoppingNumber)
                        break;
                }

                int RandomInterArrival = this.rnd.Next(1, 101); // Pick random value for interarrival time
                int RandomServerTime = this.rnd.Next(1, 101); // Pick random value for server time

                // Get interarrival time from the distribution using the random value
                int InterArrivalTime = SetInterArrival(this.InterarrivalDistribution, RandomInterArrival);
                int ArrivalTime = prevArrivalTime + InterArrivalTime;

                // Get the server
                int serverindex = Findserver(this.SelectionMethod, ArrivalTime);
                Server server = this.Servers[serverindex];

                // Create the row
                SimulationCase simCase = new SimulationCase(server, RandomInterArrival, RandomServerTime, InterArrivalTime, ArrivalTime, clientCount);
                int fTime = simCase.buildCase();

                //this.Servers[serverindex] = simCase.AssignedServer;
                // stoping condition based on time

                this.finishTime = Math.Max(fTime, this.finishTime);
                this.SimulationTable.Add(simCase);
                prevArrivalTime = ArrivalTime;
                ++clientCount;
            }
            return clientCount;
        }


        // Calculates server measures
        private void ServerMeasures()
        {
            // Loops through all servers
            foreach (Server s in this.Servers)
            {
                // Calculate the average service time of server
                if (s.ClientsCount > 0)
                    s.AverageServiceTime = Convert.ToDecimal(s.TotalWorkingTime) / s.ClientsCount;
                else
                    s.AverageServiceTime = 0;
                // Calculate the utilization of the server
                if (this.finishTime > 0)
                    s.Utilization = Convert.ToDecimal(s.TotalWorkingTime) / this.finishTime;
                else
                    s.Utilization = 0;
                // Calculate the idle probability of the server
                s.IdleProbability = 1 - s.Utilization;
            }

        }

        // Calculates waiting measures
        private void WatingMeasures(int clientCount)
        {
            int sumWatingTime = 0;
            int sumWatingCount = 0;
            foreach (Server s in this.Servers)
            {
                // Calculate the waiting time and customers waiting
                sumWatingTime += s.WatingTime;
                sumWatingCount += s.ClientsWatingCount;
            }
            this.PerformanceMeasures.AverageWaitingTime = Convert.ToDecimal(sumWatingTime) / clientCount;
            this.PerformanceMeasures.WaitingProbability = Convert.ToDecimal(sumWatingCount) / clientCount;
        }

        // Find the max queue
        private void MaxQ()
        {
            List<int> arrivalT = new List<int>();
            SortedList<int,int> finishT = new SortedList<int,int>();
            
            // Loop through all rows of the simulation table
            for (int i = 0; i < this.SimulationTable.Count; ++i)
            {
                // Add the arrival time to list
                arrivalT.Add(this.SimulationTable[i].ArrivalTime);
                // Add finish time to array
                finishT[i] = this.SimulationTable[i].StartTime;
                //finish.Add(this.SimulationTable[i].StartTime);
            }
            //List<int> finishT = finish.ToList();


            int currentQ = 0;
            int maxQ = -100;
            int j = 0, k = 0;
            while (j < this.SimulationTable.Count-1 && k < this.SimulationTable.Count-1)
            {
                // Loop through arrivals that arrived before the service start time (There was no server available)
                while (arrivalT[j] < finishT[k])
                {
                    // Increment current queue
                    currentQ += 1;
                    maxQ = Math.Max(maxQ, currentQ);

                    if (j < this.SimulationTable.Count-1)
                        ++j;
                    else
                        break;
                }
                //maxQ = Math.Max(maxQ, currentQ);

                // Loop through rows before the arrival time
                while (arrivalT[j] >= finishT[k])
                {
                    // Decrement the queue
                    if (currentQ > 0)
                        currentQ -= 1;
                    if (j == k)
                        currentQ = 0;

                   if (k < this.SimulationTable.Count - 1)
                        ++k;  
                    else
                        break;

                }

                maxQ = Math.Max(maxQ, currentQ);

            }
            this.PerformanceMeasures.MaxQueueLength = maxQ-1;
        }




        public void setPerformanceMeasures(int clientCount)
        {
            ServerMeasures();
            WatingMeasures(clientCount);
            MaxQ();
        }





    }

}
