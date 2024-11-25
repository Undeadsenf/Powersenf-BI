using System.ComponentModel;

namespace PowerSenfBiApp
{
    partial class UCDbConnection
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
            this.dBConnectionButton1 = new System.Windows.Forms.Button();
            this.closeconnectionButton1 = new System.Windows.Forms.Button();
            this.dbStatusLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dBConnectionButton1
            // 
            this.dBConnectionButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dBConnectionButton1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBConnectionButton1.Location = new System.Drawing.Point(290, 73);
            this.dBConnectionButton1.Name = "dBConnectionButton1";
            this.dBConnectionButton1.Size = new System.Drawing.Size(426, 127);
            this.dBConnectionButton1.TabIndex = 0;
            this.dBConnectionButton1.Text = "Connect to Northwind-DB";
            this.dBConnectionButton1.UseVisualStyleBackColor = true;
            this.dBConnectionButton1.Click += new System.EventHandler(this.dBConnectionButton1_Click);
            // 
            // closeconnectionButton1
            // 
            this.closeconnectionButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.closeconnectionButton1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeconnectionButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.closeconnectionButton1.Location = new System.Drawing.Point(290, 206);
            this.closeconnectionButton1.Name = "closeconnectionButton1";
            this.closeconnectionButton1.Size = new System.Drawing.Size(426, 127);
            this.closeconnectionButton1.TabIndex = 1;
            this.closeconnectionButton1.Text = "Close DB connection";
            this.closeconnectionButton1.UseVisualStyleBackColor = true;
            this.closeconnectionButton1.Click += new System.EventHandler(this.closeconnectionButton1_Click);
            // 
            // dbStatusLabel1
            // 
            this.dbStatusLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dbStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dbStatusLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbStatusLabel1.Location = new System.Drawing.Point(290, 0);
            this.dbStatusLabel1.Name = "dbStatusLabel1";
            this.dbStatusLabel1.Size = new System.Drawing.Size(426, 70);
            this.dbStatusLabel1.TabIndex = 2;
            this.dbStatusLabel1.Text = "No database connected";
            this.dbStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDbConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dbStatusLabel1);
            this.Controls.Add(this.closeconnectionButton1);
            this.Controls.Add(this.dBConnectionButton1);
            this.Name = "UCDbConnection";
            this.Size = new System.Drawing.Size(1007, 646);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button dBConnectionButton1;
        private System.Windows.Forms.Button closeconnectionButton1;
        private System.Windows.Forms.Label dbStatusLabel1;

        #endregion
    }
}