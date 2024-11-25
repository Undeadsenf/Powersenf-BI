using System.ComponentModel;

namespace PowerSenfBiApp
{
    partial class UCOpen
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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.loadCsvButton = new System.Windows.Forms.Button();
            this.labelOpenStatus = new System.Windows.Forms.Label();
            this.buttonOpenCsv = new System.Windows.Forms.Button();
            this.barLoadButton = new System.Windows.Forms.Button();
            this.lineLoadButton = new System.Windows.Forms.Button();
            this.pieLoadButton = new System.Windows.Forms.Button();
            this.columnLoadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clearChartDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilePath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilePath.Location = new System.Drawing.Point(271, 552);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(193, 49);
            this.labelFilePath.TabIndex = 0;
            // 
            // loadCsvButton
            // 
            this.loadCsvButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadCsvButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadCsvButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCsvButton.Location = new System.Drawing.Point(271, 555);
            this.loadCsvButton.Name = "loadCsvButton";
            this.loadCsvButton.Size = new System.Drawing.Size(193, 36);
            this.loadCsvButton.TabIndex = 1;
            this.loadCsvButton.Text = "load CSV to Table";
            this.loadCsvButton.UseVisualStyleBackColor = false;
            this.loadCsvButton.Click += new System.EventHandler(this.loadCsvButton_Click);
            // 
            // labelOpenStatus
            // 
            this.labelOpenStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOpenStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenStatus.Location = new System.Drawing.Point(72, 552);
            this.labelOpenStatus.Name = "labelOpenStatus";
            this.labelOpenStatus.Size = new System.Drawing.Size(193, 49);
            this.labelOpenStatus.TabIndex = 2;
            // 
            // buttonOpenCsv
            // 
            this.buttonOpenCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenCsv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpenCsv.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenCsv.Location = new System.Drawing.Point(72, 555);
            this.buttonOpenCsv.Name = "buttonOpenCsv";
            this.buttonOpenCsv.Size = new System.Drawing.Size(193, 36);
            this.buttonOpenCsv.TabIndex = 3;
            this.buttonOpenCsv.Text = "Open CSV file";
            this.buttonOpenCsv.UseVisualStyleBackColor = false;
            this.buttonOpenCsv.Click += new System.EventHandler(this.buttonOpenCsv_Click);
            // 
            // barLoadButton
            // 
            this.barLoadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.barLoadButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLoadButton.Location = new System.Drawing.Point(0, 257);
            this.barLoadButton.Name = "barLoadButton";
            this.barLoadButton.Size = new System.Drawing.Size(73, 68);
            this.barLoadButton.TabIndex = 11;
            this.barLoadButton.Text = "Load to bar chart";
            this.barLoadButton.UseVisualStyleBackColor = false;
            this.barLoadButton.Click += new System.EventHandler(this.barLoadButton_Click);
            // 
            // lineLoadButton
            // 
            this.lineLoadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineLoadButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLoadButton.Location = new System.Drawing.Point(0, 183);
            this.lineLoadButton.Name = "lineLoadButton";
            this.lineLoadButton.Size = new System.Drawing.Size(73, 68);
            this.lineLoadButton.TabIndex = 10;
            this.lineLoadButton.Text = "Load to line chart";
            this.lineLoadButton.UseVisualStyleBackColor = false;
            this.lineLoadButton.Click += new System.EventHandler(this.lineLoadButton_Click);
            // 
            // pieLoadButton
            // 
            this.pieLoadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pieLoadButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieLoadButton.Location = new System.Drawing.Point(0, 109);
            this.pieLoadButton.Name = "pieLoadButton";
            this.pieLoadButton.Size = new System.Drawing.Size(73, 68);
            this.pieLoadButton.TabIndex = 9;
            this.pieLoadButton.Text = "Load to pie chart";
            this.pieLoadButton.UseVisualStyleBackColor = false;
            this.pieLoadButton.Click += new System.EventHandler(this.pieLoadButton_Click);
            // 
            // columnLoadButton
            // 
            this.columnLoadButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.columnLoadButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnLoadButton.Location = new System.Drawing.Point(0, 35);
            this.columnLoadButton.Name = "columnLoadButton";
            this.columnLoadButton.Size = new System.Drawing.Size(73, 68);
            this.columnLoadButton.TabIndex = 8;
            this.columnLoadButton.Text = "Load to column chart";
            this.columnLoadButton.UseVisualStyleBackColor = false;
            this.columnLoadButton.Click += new System.EventHandler(this.columnLoadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(72, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(932, 514);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "CSV file load and Visualization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearChartDataButton
            // 
            this.clearChartDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearChartDataButton.BackColor = System.Drawing.Color.Red;
            this.clearChartDataButton.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearChartDataButton.Location = new System.Drawing.Point(931, 552);
            this.clearChartDataButton.Name = "clearChartDataButton";
            this.clearChartDataButton.Size = new System.Drawing.Size(73, 68);
            this.clearChartDataButton.TabIndex = 13;
            this.clearChartDataButton.Text = "Clear all chart data";
            this.clearChartDataButton.UseVisualStyleBackColor = false;
            this.clearChartDataButton.Click += new System.EventHandler(this.clearChartDataButton_Click);
            // 
            // UCOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.clearChartDataButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barLoadButton);
            this.Controls.Add(this.lineLoadButton);
            this.Controls.Add(this.pieLoadButton);
            this.Controls.Add(this.columnLoadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpenCsv);
            this.Controls.Add(this.labelOpenStatus);
            this.Controls.Add(this.loadCsvButton);
            this.Controls.Add(this.labelFilePath);
            this.Name = "UCOpen";
            this.Size = new System.Drawing.Size(1007, 661);
            this.Load += new System.EventHandler(this.UCOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button clearChartDataButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button barLoadButton;
        private System.Windows.Forms.Button lineLoadButton;
        private System.Windows.Forms.Button pieLoadButton;
        private System.Windows.Forms.Button columnLoadButton;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button buttonOpenCsv;

        private System.Windows.Forms.Label labelOpenStatus;

        private System.Windows.Forms.Button loadCsvButton;

        private System.Windows.Forms.Label labelFilePath;

        #endregion
    }
}