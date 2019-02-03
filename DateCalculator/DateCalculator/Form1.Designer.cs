namespace DateCalculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pkrStart = new System.Windows.Forms.DateTimePicker();
            this.pkrEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalMinutes = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pkrStart
            // 
            this.pkrStart.Location = new System.Drawing.Point(169, 41);
            this.pkrStart.Name = "pkrStart";
            this.pkrStart.Size = new System.Drawing.Size(247, 20);
            this.pkrStart.TabIndex = 0;
            // 
            // pkrEnd
            // 
            this.pkrEnd.Location = new System.Drawing.Point(169, 96);
            this.pkrEnd.Name = "pkrEnd";
            this.pkrEnd.Size = new System.Drawing.Size(247, 20);
            this.pkrEnd.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(169, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalMinutes
            // 
            this.txtTotalMinutes.Location = new System.Drawing.Point(236, 150);
            this.txtTotalMinutes.Name = "txtTotalMinutes";
            this.txtTotalMinutes.Size = new System.Drawing.Size(146, 20);
            this.txtTotalMinutes.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(12, 41);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(150, 29);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Date and Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(12, 96);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(143, 29);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "End Date and Time";
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.AutoSize = true;
            this.lblTotalMinutes.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinutes.Location = new System.Drawing.Point(77, 147);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(118, 29);
            this.lblTotalMinutes.TabIndex = 6;
            this.lblTotalMinutes.Text = "Total Minutes";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(465, 268);
            this.Controls.Add(this.lblTotalMinutes);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtTotalMinutes);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pkrEnd);
            this.Controls.Add(this.pkrStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "TTR/SLA Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pkrStart;
        private System.Windows.Forms.DateTimePicker pkrEnd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotalMinutes;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblTotalMinutes;
    }
}

