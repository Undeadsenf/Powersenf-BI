using System.ComponentModel;
using System.Windows.Forms;

namespace PowerSenfBiApp
{
    partial class UCDbQueryLoad
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbQueryBox1 = new System.Windows.Forms.TextBox();
            this.columnLoadButtonX = new System.Windows.Forms.Button();
            this.pieLoadButtonX = new System.Windows.Forms.Button();
            this.lineLoadButtonX = new System.Windows.Forms.Button();
            this.barLoadButtonX = new System.Windows.Forms.Button();
            this.loadTableButton1 = new System.Windows.Forms.Button();
            this.columLoadButtonY = new System.Windows.Forms.Button();
            this.pieLoadButtonY = new System.Windows.Forms.Button();
            this.lineLoadButtonY = new System.Windows.Forms.Button();
            this.barLoadButtonY = new System.Windows.Forms.Button();
            this.clearChartDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Query and Visualization";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(72, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(932, 512);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // dbQueryBox1
            // 
            this.dbQueryBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dbQueryBox1.Location = new System.Drawing.Point(151, 553);
            this.dbQueryBox1.Multiline = true;
            this.dbQueryBox1.Name = "dbQueryBox1";
            this.dbQueryBox1.Size = new System.Drawing.Size(368, 68);
            this.dbQueryBox1.TabIndex = 2;
            // 
            // columnLoadButtonX
            // 
            this.columnLoadButtonX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.columnLoadButtonX.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnLoadButtonX.Location = new System.Drawing.Point(0, 35);
            this.columnLoadButtonX.Name = "columnLoadButtonX";
            this.columnLoadButtonX.Size = new System.Drawing.Size(73, 68);
            this.columnLoadButtonX.TabIndex = 3;
            this.columnLoadButtonX.Text = "Load column X";
            this.columnLoadButtonX.UseVisualStyleBackColor = false;
            this.columnLoadButtonX.Click += new System.EventHandler(this.columnLoadButtonX_Click);
            // 
            // pieLoadButtonX
            // 
            this.pieLoadButtonX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pieLoadButtonX.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieLoadButtonX.Location = new System.Drawing.Point(0, 183);
            this.pieLoadButtonX.Name = "pieLoadButtonX";
            this.pieLoadButtonX.Size = new System.Drawing.Size(73, 68);
            this.pieLoadButtonX.TabIndex = 4;
            this.pieLoadButtonX.Text = "Load pie X";
            this.pieLoadButtonX.UseVisualStyleBackColor = false;
            this.pieLoadButtonX.Click += new System.EventHandler(this.pieLoadButtonX_Click);
            // 
            // lineLoadButtonX
            // 
            this.lineLoadButtonX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineLoadButtonX.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLoadButtonX.Location = new System.Drawing.Point(0, 331);
            this.lineLoadButtonX.Name = "lineLoadButtonX";
            this.lineLoadButtonX.Size = new System.Drawing.Size(73, 68);
            this.lineLoadButtonX.TabIndex = 5;
            this.lineLoadButtonX.Text = "Load line X";
            this.lineLoadButtonX.UseVisualStyleBackColor = false;
            this.lineLoadButtonX.Click += new System.EventHandler(this.lineLoadButtonX_Click);
            // 
            // barLoadButtonX
            // 
            this.barLoadButtonX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.barLoadButtonX.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLoadButtonX.Location = new System.Drawing.Point(0, 479);
            this.barLoadButtonX.Name = "barLoadButtonX";
            this.barLoadButtonX.Size = new System.Drawing.Size(73, 68);
            this.barLoadButtonX.TabIndex = 6;
            this.barLoadButtonX.Text = "Load bar X";
            this.barLoadButtonX.UseVisualStyleBackColor = false;
            this.barLoadButtonX.Click += new System.EventHandler(this.barLoadButtonX_Click);
            // 
            // loadTableButton1
            // 
            this.loadTableButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadTableButton1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTableButton1.Location = new System.Drawing.Point(72, 553);
            this.loadTableButton1.Name = "loadTableButton1";
            this.loadTableButton1.Size = new System.Drawing.Size(73, 68);
            this.loadTableButton1.TabIndex = 7;
            this.loadTableButton1.Text = "Load Table";
            this.loadTableButton1.UseVisualStyleBackColor = true;
            this.loadTableButton1.Click += new System.EventHandler(this.loadTableButton1_Click);
            // 
            // columLoadButtonY
            // 
            this.columLoadButtonY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.columLoadButtonY.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columLoadButtonY.Location = new System.Drawing.Point(0, 109);
            this.columLoadButtonY.Name = "columLoadButtonY";
            this.columLoadButtonY.Size = new System.Drawing.Size(73, 68);
            this.columLoadButtonY.TabIndex = 8;
            this.columLoadButtonY.Text = "Load column Y";
            this.columLoadButtonY.UseVisualStyleBackColor = false;
            this.columLoadButtonY.Click += new System.EventHandler(this.columnLoadButtonY_Click);
            // 
            // pieLoadButtonY
            // 
            this.pieLoadButtonY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pieLoadButtonY.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieLoadButtonY.Location = new System.Drawing.Point(0, 257);
            this.pieLoadButtonY.Name = "pieLoadButtonY";
            this.pieLoadButtonY.Size = new System.Drawing.Size(73, 68);
            this.pieLoadButtonY.TabIndex = 9;
            this.pieLoadButtonY.Text = "Load pie Y";
            this.pieLoadButtonY.UseVisualStyleBackColor = false;
            this.pieLoadButtonY.Click += new System.EventHandler(this.pieLoadButtonY_Click);
            // 
            // lineLoadButtonY
            // 
            this.lineLoadButtonY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineLoadButtonY.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLoadButtonY.Location = new System.Drawing.Point(0, 405);
            this.lineLoadButtonY.Name = "lineLoadButtonY";
            this.lineLoadButtonY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lineLoadButtonY.Size = new System.Drawing.Size(73, 68);
            this.lineLoadButtonY.TabIndex = 10;
            this.lineLoadButtonY.Text = "Load line Y";
            this.lineLoadButtonY.UseVisualStyleBackColor = false;
            this.lineLoadButtonY.Click += new System.EventHandler(this.lineLoadButtonY_Click);
            // 
            // barLoadButtonY
            // 
            this.barLoadButtonY.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.barLoadButtonY.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLoadButtonY.Location = new System.Drawing.Point(0, 553);
            this.barLoadButtonY.Name = "barLoadButtonY";
            this.barLoadButtonY.Size = new System.Drawing.Size(73, 68);
            this.barLoadButtonY.TabIndex = 11;
            this.barLoadButtonY.Text = "Load bar Y";
            this.barLoadButtonY.UseVisualStyleBackColor = false;
            this.barLoadButtonY.Click += new System.EventHandler(this.barLoadButtonY_Click);
            // 
            // clearChartDataButton
            // 
            this.clearChartDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearChartDataButton.BackColor = System.Drawing.Color.Red;
            this.clearChartDataButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearChartDataButton.Location = new System.Drawing.Point(931, 553);
            this.clearChartDataButton.Name = "clearChartDataButton";
            this.clearChartDataButton.Size = new System.Drawing.Size(73, 68);
            this.clearChartDataButton.TabIndex = 12;
            this.clearChartDataButton.Text = "Clear all Chart data";
            this.clearChartDataButton.UseVisualStyleBackColor = false;
            this.clearChartDataButton.Click += new System.EventHandler(this.clearChartDataButton_click);
            // 
            // UCDbQueryLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.clearChartDataButton);
            this.Controls.Add(this.barLoadButtonY);
            this.Controls.Add(this.lineLoadButtonY);
            this.Controls.Add(this.pieLoadButtonY);
            this.Controls.Add(this.columLoadButtonY);
            this.Controls.Add(this.loadTableButton1);
            this.Controls.Add(this.barLoadButtonX);
            this.Controls.Add(this.lineLoadButtonX);
            this.Controls.Add(this.pieLoadButtonX);
            this.Controls.Add(this.columnLoadButtonX);
            this.Controls.Add(this.dbQueryBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UCDbQueryLoad";
            this.Size = new System.Drawing.Size(1007, 646);
            this.Load += new System.EventHandler(this.OnDbQueryLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button clearChartDataButton;

        private System.Windows.Forms.Button columLoadButtonY;
        private System.Windows.Forms.Button pieLoadButtonY;
        private System.Windows.Forms.Button lineLoadButtonY;
        private System.Windows.Forms.Button barLoadButtonY;

        private System.Windows.Forms.Button loadTableButton1;

        private System.Windows.Forms.Button columnLoadButtonX;
        private System.Windows.Forms.Button pieLoadButtonX;
        private System.Windows.Forms.Button lineLoadButtonX;
        private System.Windows.Forms.Button barLoadButtonX;

        private System.Windows.Forms.TextBox dbQueryBox1;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}