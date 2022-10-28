using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = new Server();

        }
        public SimulationCase(Server s)
        {
            this.AssignedServer = s;
        }
        public SimulationCase(Server s, int RandomInterArrival, int RandomService, int InterArrivalTime, int ArrivalTime,int CustomerNumber)
        {
            this.AssignedServer = s;

            this.RandomInterArrival = RandomInterArrival;
            this.RandomService = RandomService;

            this.ArrivalTime = ArrivalTime;
            this.InterArrival = InterArrivalTime;

            this.CustomerNumber = CustomerNumber;
        }



        //tmp constractor
        public SimulationCase(Server s, int RandomInterArrival, int InterArrivalTime, int ArrivalTime, int RandomService, int ServiceTime, int StartTime, int EndTime, int TimeInQueue, int CustomerNumber)
        {
            this.AssignedServer = s;

            this.RandomInterArrival = RandomInterArrival;
            this.ArrivalTime = ArrivalTime;
            this.InterArrival = InterArrivalTime;  

            this.RandomService = RandomService;
            this.ServiceTime = ServiceTime;

            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.TimeInQueue = TimeInQueue;

            this.CustomerNumber = CustomerNumber;

            this.AssignedServer.ClientsCount = 1;
            this.AssignedServer.WatingTime += this.TimeInQueue;
            this.AssignedServer.FinishTime = this.EndTime;
        }
        //-------------------------------------------------------------

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServiceTime { get; set; }
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }

        //----------------------------------
        public List<TimeDistribution> arivalTD;
        public int prevArrivalTime;


        // Sets and returns the service time for assigned server
        public int setServiceTime()
        {
            // Loops through all probabilities of the assigned server
            for (int i = 0; i < this.AssignedServer.TimeDistribution.Count; ++i)
            {
                // Check if the random service value is within the range of the probability distribution range
                if (this.RandomService >= this.AssignedServer.TimeDistribution[i].MinRange
                    && this.RandomService <= this.AssignedServer.TimeDistribution[i].MaxRange)
                {
                    // Set the service time and increment the total working time for the assigned server
                    this.ServiceTime = this.AssignedServer.TimeDistribution[i].Time;
                    this.AssignedServer.TotalWorkingTime += this.ServiceTime;
                    break;
                }
            }
            return this.ServiceTime;
        }

        // Sets and returns the start time for assigned server
        public int setStartTime()
        {
            this.StartTime = Math.Max(this.AssignedServer.FinishTime, this.ArrivalTime);
            this.AssignedServer.ClientsCount += 1;

            return this.StartTime;
        }

        // Calculates and returns time in queue for customer (If the finish time of the assigned server is more than the arrival time of the customer)
        public int setTimeInQueue()
        {
            if (this.AssignedServer.FinishTime > this.ArrivalTime)
            {
                this.TimeInQueue = this.StartTime - this.ArrivalTime; // Time in queue the customer will have to wait
                this.AssignedServer.ClientsWatingCount += 1; // Increment the amount of customers in queue due to the busy server
                this.AssignedServer.WatingTime += this.TimeInQueue;
            }
            else
                this.TimeInQueue = 0;
            return this.TimeInQueue ;

        }

        // Returns the end time for server
        public int setEndTime()
        {
            this.EndTime = this.StartTime + this.ServiceTime;
            this.AssignedServer.FinishTime = this.EndTime;

            return this.EndTime;
        }

        // Builds case row
        public int buildCase()
        {
            this.setServiceTime(); // Sets the service time
            this.setStartTime(); // Sets the start time of service

            this.setTimeInQueue(); // Sets the time in queue of customer
            int endTime =  this.setEndTime();

            return endTime;

        }

    }
}
