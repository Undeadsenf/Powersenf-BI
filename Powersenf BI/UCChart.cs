using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PowerSenfBiApp
{
    public partial class UCChart : UserControl
    { 
        private void UCChart_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.columnChartDataCsv != null)
            {
                List<string> cells = GlobalVariables.columnChartDataCsv;
                Dictionary<string, int> frequency = new Dictionary<string, int>();
                foreach (string cell in cells)
                {
                    if (frequency.ContainsKey(cell))
                    {
                        frequency[cell]++;
                    }
                    else
                    {
                        frequency[cell] = 1;
                    }
                }

                // Chart konfigurieren
                string seriesName = GlobalVariables.selectedHeader;
                columnChart.Series[0].Name = seriesName;
                columnChart.Series[seriesName].XValueType = ChartValueType.String;
                columnChart.Series[seriesName].YValueType = ChartValueType.Int32;

                // Datenpunkte hinzufügen
                foreach (var kvp in frequency)
                {
                    columnChart.Series[seriesName].Points.AddXY(kvp.Key, kvp.Value);
                }

                // Achsentitel
                columnChart.ChartAreas[0].AxisX.Interval = 1;
                columnChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                columnChart.ChartAreas[0].AxisY.Title = "Count";
            }
            if (GlobalVariables.pieChartDataCsv != null)
            {
                List<string> cells = GlobalVariables.pieChartDataCsv;
                Dictionary<string, int> frequency = new Dictionary<string, int>();
                foreach (string cell in cells)
                {
                    if (frequency.ContainsKey(cell))
                    {
                        frequency[cell]++;
                    }
                    else
                    {
                        frequency[cell] = 1;
                    }
                }

                // Chart konfigurieren
                string seriesName = GlobalVariables.selectedHeader;
                pieChart.Series[0].Name = seriesName;
                pieChart.Series[seriesName].XValueType = ChartValueType.String;
                pieChart.Series[seriesName].YValueType = ChartValueType.Int32;

                // Datenpunkte hinzufügen
                foreach (var kvp in frequency)
                {
                    pieChart.Series[seriesName].Points.AddXY(kvp.Key, kvp.Value);
                }

                // Achsentitel
                pieChart.ChartAreas[0].AxisX.Interval = 1;
                pieChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                pieChart.ChartAreas[0].AxisY.Title = "Count";
            }
            if (GlobalVariables.lineChartDataCsv != null)
            {
                List<string> cells = GlobalVariables.lineChartDataCsv;
                Dictionary<string, int> frequency = new Dictionary<string, int>();
                foreach (string cell in cells)
                {
                    if (frequency.ContainsKey(cell))
                    {
                        frequency[cell]++;
                    }
                    else
                    {
                        frequency[cell] = 1;
                    }
                }

                // Chart konfigurieren
                string seriesName = GlobalVariables.selectedHeader;
                lineChart.Series[0].Name = seriesName;
                lineChart.Series[seriesName].XValueType = ChartValueType.String;
                lineChart.Series[seriesName].YValueType = ChartValueType.Int32;

                // Datenpunkte hinzufügen
                foreach (var kvp in frequency)
                {
                    lineChart.Series[seriesName].Points.AddXY(kvp.Key, kvp.Value);
                }

                // Achsentitel
                lineChart.ChartAreas[0].AxisX.Interval = 1;
                lineChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                lineChart.ChartAreas[0].AxisY.Title = "Count";
            }
            if (GlobalVariables.barChartDataCsv != null)
            {
                List<string> cells = GlobalVariables.barChartDataCsv;
                Dictionary<string, int> frequency = new Dictionary<string, int>();
                foreach (string cell in cells)
                {
                    if (frequency.ContainsKey(cell))
                    {
                        frequency[cell]++;
                    }
                    else
                    {
                        frequency[cell] = 1;
                    }
                }

                // Chart konfigurieren
                string seriesName = GlobalVariables.selectedHeader;
                barChart.Series[0].Name = seriesName;
                barChart.Series[seriesName].XValueType = ChartValueType.String;
                barChart.Series[seriesName].YValueType = ChartValueType.Int32;

                // Datenpunkte hinzufügen
                foreach (var kvp in frequency)
                {
                    barChart.Series[seriesName].Points.AddXY(kvp.Key, kvp.Value);
                }

                // Achsentitel
                barChart.ChartAreas[0].AxisX.Interval = 1;
                barChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                barChart.ChartAreas[0].AxisY.Title = "Count";
            }
            
            if (GlobalVariables.columnChartDataX != null && GlobalVariables.columnChartDataY != null)
            {
                List<string> cellsX = GlobalVariables.columnChartDataX;
                List<string> cellsY = GlobalVariables.columnChartDataY;
                string seriesName = GlobalVariables.selectedHeader;
                
                columnChart.Series[0].Name = seriesName;
                columnChart.Series[seriesName].XValueType = ChartValueType.String;
                columnChart.Series[seriesName].YValueType = ChartValueType.Double;

                for (int i = 0; i < cellsX.Count; i++)
                {
                    columnChart.Series[seriesName].Points.AddXY(cellsX[i], cellsY[i]);
                }
                columnChart.ChartAreas[0].AxisX.Interval = 1;
                columnChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                columnChart.ChartAreas[0].AxisY.Title = "Count";
            }
            if (GlobalVariables.pieChartDataX != null && GlobalVariables.pieChartDataY != null)

            {
                List<string> cellsX = GlobalVariables.pieChartDataX;
                List<string> cellsY = GlobalVariables.pieChartDataY;
                string seriesName = GlobalVariables.selectedHeader;
                
                pieChart.Series[0].Name = seriesName;
                pieChart.Series[seriesName].XValueType = ChartValueType.String;
                pieChart.Series[seriesName].YValueType = ChartValueType.Double;

                for (int i = 0; i < cellsX.Count; i++)
                {
                    pieChart.Series[seriesName].Points.AddXY(cellsX[i], cellsY[i]);
                }
                pieChart.ChartAreas[0].AxisX.Interval = 1;
                pieChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                pieChart.ChartAreas[0].AxisY.Title = "Count";
            }

            if (GlobalVariables.lineChartDataX != null && GlobalVariables.lineChartDataY != null)

            {
                List<string> cellsX = GlobalVariables.lineChartDataX;
                List<string> cellsY = GlobalVariables.lineChartDataY;
                string seriesName = GlobalVariables.selectedHeader;
                
                lineChart.Series[0].Name = seriesName;
                lineChart.Series[seriesName].XValueType = ChartValueType.String;
                lineChart.Series[seriesName].YValueType = ChartValueType.Double;

                for (int i = 0; i < cellsX.Count; i++)
                {
                    lineChart.Series[seriesName].Points.AddXY(cellsX[i], cellsY[i]);
                }
                lineChart.ChartAreas[0].AxisX.Interval = 1;
                lineChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                lineChart.ChartAreas[0].AxisY.Title = "Count";
            }

            if (GlobalVariables.barChartDataX != null && GlobalVariables.barChartDataY != null)

            {
                List<string> cellsX = GlobalVariables.barChartDataX;
                List<string> cellsY = GlobalVariables.barChartDataY;
                string seriesName = GlobalVariables.selectedHeader;
                
                barChart.Series[0].Name = seriesName;
                barChart.Series[seriesName].XValueType = ChartValueType.String;
                barChart.Series[seriesName].YValueType = ChartValueType.Double;

                for (int i = 0; i < cellsX.Count; i++)
                {
                    barChart.Series[seriesName].Points.AddXY(cellsX[i], cellsY[i]);
                }
                barChart.ChartAreas[0].AxisX.Interval = 1;
                barChart.ChartAreas[0].AxisX.Title = "Distinct elements";
                barChart.ChartAreas[0].AxisY.Title = "Count";
            }
        }
        
        public UCChart()
        {
            InitializeComponent();
        }

        
    }
}