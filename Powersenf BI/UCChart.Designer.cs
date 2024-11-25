using System;
using System.ComponentModel;

namespace PowerSenfBiApp
{
    partial class UCChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.columnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.barChart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pieChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.columnChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lineChart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 646);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // barChart
            // 
            chartArea1.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea1);
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.barChart.Legends.Add(legend1);
            this.barChart.Location = new System.Drawing.Point(507, 326);
            this.barChart.Name = "barChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.barChart.Series.Add(series1);
            this.barChart.Size = new System.Drawing.Size(498, 317);
            this.barChart.TabIndex = 3;
            this.barChart.Text = "chart4";
            // 
            // pieChart
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea2);
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.pieChart.Legends.Add(legend2);
            this.pieChart.Location = new System.Drawing.Point(507, 3);
            this.pieChart.Name = "pieChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChart.Series.Add(series2);
            this.pieChart.Size = new System.Drawing.Size(498, 317);
            this.pieChart.TabIndex = 1;
            this.pieChart.Text = "chart2";
            // 
            // columnChart
            // 
            chartArea3.Name = "ChartArea1";
            this.columnChart.ChartAreas.Add(chartArea3);
            this.columnChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.columnChart.Legends.Add(legend3);
            this.columnChart.Location = new System.Drawing.Point(3, 3);
            this.columnChart.Name = "columnChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.columnChart.Series.Add(series3);
            this.columnChart.Size = new System.Drawing.Size(498, 317);
            this.columnChart.TabIndex = 0;
            this.columnChart.Text = "chart1";
            // 
            // lineChart
            // 
            chartArea4.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea4);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.lineChart.Legends.Add(legend4);
            this.lineChart.Location = new System.Drawing.Point(3, 326);
            this.lineChart.Name = "lineChart";
            this.lineChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.lineChart.Series.Add(series4);
            this.lineChart.Size = new System.Drawing.Size(498, 317);
            this.lineChart.TabIndex = 2;
            this.lineChart.Text = "chart3";
            // 
            // UCChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCChart";
            this.Size = new System.Drawing.Size(1008, 646);
            this.Load += new System.EventHandler(this.UCChart_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart columnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}