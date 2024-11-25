using System.Threading;
using System.Windows.Forms;

namespace PowerSenfBiApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelButtonBar = new System.Windows.Forms.Panel();
            this.buttonChart = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonOpenCsv = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonDbConnection = new System.Windows.Forms.Button();
            this.buttonDbQuery = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelStatusBar = new System.Windows.Forms.Panel();
            this.chartStatusLabel4 = new System.Windows.Forms.Label();
            this.chartStatusLabel3 = new System.Windows.Forms.Label();
            this.chartStatusLabel2 = new System.Windows.Forms.Label();
            this.chartStatusLabel1 = new System.Windows.Forms.Label();
            this.panelButtonBar.SuspendLayout();
            this.panelStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.Lavender;
            this.panelContainer.Location = new System.Drawing.Point(73, 128);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1019, 510);
            this.panelContainer.TabIndex = 0;
            // 
            // panelButtonBar
            // 
            this.panelButtonBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.panelButtonBar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelButtonBar.Controls.Add(this.buttonChart);
            this.panelButtonBar.Controls.Add(this.buttonAbout);
            this.panelButtonBar.Controls.Add(this.buttonOpenCsv);
            this.panelButtonBar.Controls.Add(this.buttonHome);
            this.panelButtonBar.Controls.Add(this.buttonDbConnection);
            this.panelButtonBar.Controls.Add(this.buttonDbQuery);
            this.panelButtonBar.Location = new System.Drawing.Point(0, 64);
            this.panelButtonBar.Name = "panelButtonBar";
            this.panelButtonBar.Size = new System.Drawing.Size(73, 574);
            this.panelButtonBar.TabIndex = 3;
            // 
            // buttonChart
            // 
            this.buttonChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChart.BackgroundImage")));
            this.buttonChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChart.Location = new System.Drawing.Point(0, 299);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(73, 68);
            this.buttonChart.TabIndex = 6;
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbout.BackgroundImage")));
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbout.Location = new System.Drawing.Point(0, 505);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(73, 68);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonOpenCsv
            // 
            this.buttonOpenCsv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenCsv.BackgroundImage")));
            this.buttonOpenCsv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenCsv.Location = new System.Drawing.Point(0, 225);
            this.buttonOpenCsv.Name = "buttonOpenCsv";
            this.buttonOpenCsv.Size = new System.Drawing.Size(73, 68);
            this.buttonOpenCsv.TabIndex = 5;
            this.buttonOpenCsv.UseVisualStyleBackColor = true;
            this.buttonOpenCsv.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHome.BackgroundImage")));
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Location = new System.Drawing.Point(0, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(73, 68);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonDbConnection
            // 
            this.buttonDbConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDbConnection.BackgroundImage")));
            this.buttonDbConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDbConnection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDbConnection.Location = new System.Drawing.Point(0, 77);
            this.buttonDbConnection.Name = "buttonDbConnection";
            this.buttonDbConnection.Size = new System.Drawing.Size(73, 68);
            this.buttonDbConnection.TabIndex = 3;
            this.buttonDbConnection.UseVisualStyleBackColor = true;
            this.buttonDbConnection.Click += new System.EventHandler(this.buttonDbConnection_Click);
            // 
            // buttonDbQuery
            // 
            this.buttonDbQuery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDbQuery.BackgroundImage")));
            this.buttonDbQuery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDbQuery.Location = new System.Drawing.Point(0, 151);
            this.buttonDbQuery.Name = "buttonDbQuery";
            this.buttonDbQuery.Size = new System.Drawing.Size(73, 68);
            this.buttonDbQuery.TabIndex = 4;
            this.buttonDbQuery.UseVisualStyleBackColor = true;
            this.buttonDbQuery.Click += new System.EventHandler(this.buttonDbQuery_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panelStatusBar
            // 
            this.panelStatusBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatusBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelStatusBar.Controls.Add(this.chartStatusLabel4);
            this.panelStatusBar.Controls.Add(this.chartStatusLabel3);
            this.panelStatusBar.Controls.Add(this.chartStatusLabel2);
            this.panelStatusBar.Controls.Add(this.chartStatusLabel1);
            this.panelStatusBar.Location = new System.Drawing.Point(73, 64);
            this.panelStatusBar.Name = "panelStatusBar";
            this.panelStatusBar.Size = new System.Drawing.Size(1019, 64);
            this.panelStatusBar.TabIndex = 4;
            // 
            // chartStatusLabel4
            // 
            this.chartStatusLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartStatusLabel4.BackColor = System.Drawing.Color.Red;
            this.chartStatusLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartStatusLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartStatusLabel4.Location = new System.Drawing.Point(755, 6);
            this.chartStatusLabel4.Name = "chartStatusLabel4";
            this.chartStatusLabel4.Size = new System.Drawing.Size(114, 55);
            this.chartStatusLabel4.TabIndex = 3;
            this.chartStatusLabel4.Text = "Bar chart status";
            this.chartStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatusLabel3
            // 
            this.chartStatusLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartStatusLabel3.BackColor = System.Drawing.Color.Red;
            this.chartStatusLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartStatusLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartStatusLabel3.Location = new System.Drawing.Point(503, 6);
            this.chartStatusLabel3.Name = "chartStatusLabel3";
            this.chartStatusLabel3.Size = new System.Drawing.Size(114, 55);
            this.chartStatusLabel3.TabIndex = 2;
            this.chartStatusLabel3.Text = "Line chart status";
            this.chartStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatusLabel2
            // 
            this.chartStatusLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartStatusLabel2.BackColor = System.Drawing.Color.Red;
            this.chartStatusLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartStatusLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartStatusLabel2.Location = new System.Drawing.Point(256, 6);
            this.chartStatusLabel2.Name = "chartStatusLabel2";
            this.chartStatusLabel2.Size = new System.Drawing.Size(114, 55);
            this.chartStatusLabel2.TabIndex = 1;
            this.chartStatusLabel2.Text = "Pie chart status";
            this.chartStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartStatusLabel1
            // 
            this.chartStatusLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chartStatusLabel1.BackColor = System.Drawing.Color.Red;
            this.chartStatusLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartStatusLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartStatusLabel1.Location = new System.Drawing.Point(6, 6);
            this.chartStatusLabel1.Name = "chartStatusLabel1";
            this.chartStatusLabel1.Size = new System.Drawing.Size(114, 55);
            this.chartStatusLabel1.TabIndex = 0;
            this.chartStatusLabel1.Text = "Column chart status";
            this.chartStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 641);
            this.Controls.Add(this.panelStatusBar);
            this.Controls.Add(this.panelButtonBar);
            this.Controls.Add(this.panelContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainForm";
            this.Text = "Powersenf BI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelButtonBar.ResumeLayout(false);
            this.panelStatusBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label chartStatusLabel2;
        private System.Windows.Forms.Label chartStatusLabel3;
        private System.Windows.Forms.Label chartStatusLabel4;

        private System.Windows.Forms.Label chartStatusLabel1;

        private System.Windows.Forms.Panel panelStatusBar;

        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

        private System.Windows.Forms.Button buttonChart;

        private System.Windows.Forms.Panel panelButtonBar;

        private System.Windows.Forms.Button buttonOpenCsv;

        private System.Windows.Forms.Button buttonDbQuery;

        private System.Windows.Forms.Button buttonDbConnection;

        private System.Windows.Forms.Button buttonAbout;

        private System.Windows.Forms.Button buttonHome;

        private System.Windows.Forms.Panel panelContainer;

        #endregion
    }
}