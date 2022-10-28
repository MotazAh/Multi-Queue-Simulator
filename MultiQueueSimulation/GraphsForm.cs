using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class GraphsForm : Form
    {
        private List<SimulationCase> SimulationTable { get; set; }
        private int numOfServers;
        public GraphsForm(List<SimulationCase> st, int numOfServers)
        {
            InitializeComponent();

            this.SimulationTable = st;
            this.numOfServers = numOfServers;

            for (int i = 1; i <= numOfServers; i++)
                comboBox_ServerId.Items.Add(i);
            comboBox_ServerId.SelectedIndex = 0;

            InitGraphs();

            // Show the first server's graph
            ShowGraph(1);
        }

        private void InitGraphs()
        {
            var objChart = chart_ServerBusyTime.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            // Time (X axis)
            objChart.AxisX.Minimum = 0;
            objChart.AxisX.Maximum = SimulationTable[SimulationTable.Count - 1].EndTime;

            objChart.AxisX.Title = "Time";
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            // Busy/Idle (Y axis)
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 1;

            objChart.AxisY.Title = "B(t)";

            // Clear
            chart_ServerBusyTime.Series.Clear();
            chart_ServerBusyTime.Legends.Clear();

            int seriesCount = 0;

            // Loop through all servers (Creating a series for each)
            for (int serverID = 1; serverID <= numOfServers; serverID++)
            {
                // Add a series and set the chart type
                chart_ServerBusyTime.Series.Add("Series" + seriesCount.ToString());
                chart_ServerBusyTime.Series[seriesCount].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                chart_ServerBusyTime.Series[seriesCount].Color = Color.FromArgb(70, 200, 80);

                // Add data for selected server to a series
                foreach (SimulationCase row in SimulationTable)
                {
                    if (row.AssignedServer.ID == serverID)
                    {
                        // Start point from Y = 0, X = Start Time
                        chart_ServerBusyTime.Series[seriesCount].Points.AddXY(row.StartTime, 0);
                        // Next point from Y = 1, X = Start Time
                        chart_ServerBusyTime.Series[seriesCount].Points.AddXY(row.StartTime, 1);
                        // Next point from Y = 1, X = End Time
                        chart_ServerBusyTime.Series[seriesCount].Points.AddXY(row.EndTime, 1);
                        // Next point from Y = 0, X = End Time
                        chart_ServerBusyTime.Series[seriesCount].Points.AddXY(row.EndTime, 0);
                    }
                }

                // Creates a point if none exist so the graph remains properly visible
                if (chart_ServerBusyTime.Series[seriesCount].Points.Count == 0)
                {
                    chart_ServerBusyTime.Series[seriesCount].Points.AddXY(0, 0);
                }
                chart_ServerBusyTime.Series[seriesCount].Enabled = false;
                seriesCount++;
            }
        }

        private void ShowGraph(int serverID)
        {
            // Updates the title
            chart_ServerBusyTime.Titles[0].Text = "Server " + serverID.ToString();

            // Enables the chosen server ID's graph and disables the others
            for (int i = 0; i < chart_ServerBusyTime.Series.Count; i++)
            {
                chart_ServerBusyTime.Series[i].Enabled = false;
            }
            chart_ServerBusyTime.Series[serverID - 1].Enabled = true;
        }

        private void comboBox_ServerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGraph((int)comboBox_ServerId.SelectedItem);
        }
    }
}
