
namespace assignment1
{
    partial class TrainDisplay
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
            this.lbl_currentstation = new System.Windows.Forms.Label();
            this.lbl_Platform = new System.Windows.Forms.Label();
            this.txt_CurrentStation = new System.Windows.Forms.TextBox();
            this.txt_Platform = new System.Windows.Forms.TextBox();
            this.lbl_TimeOfArrival = new System.Windows.Forms.Label();
            this.txt_TimeOfArrival = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_currentstation
            // 
            this.lbl_currentstation.AutoSize = true;
            this.lbl_currentstation.Location = new System.Drawing.Point(111, 120);
            this.lbl_currentstation.Name = "lbl_currentstation";
            this.lbl_currentstation.Size = new System.Drawing.Size(80, 13);
            this.lbl_currentstation.TabIndex = 0;
            this.lbl_currentstation.Text = "Current Station:";
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.Location = new System.Drawing.Point(111, 160);
            this.lbl_Platform.Name = "lbl_Platform";
            this.lbl_Platform.Size = new System.Drawing.Size(48, 13);
            this.lbl_Platform.TabIndex = 1;
            this.lbl_Platform.Text = "Platform:";
            // 
            // txt_CurrentStation
            // 
            this.txt_CurrentStation.Enabled = false;
            this.txt_CurrentStation.Location = new System.Drawing.Point(197, 117);
            this.txt_CurrentStation.Name = "txt_CurrentStation";
            this.txt_CurrentStation.ReadOnly = true;
            this.txt_CurrentStation.Size = new System.Drawing.Size(100, 20);
            this.txt_CurrentStation.TabIndex = 2;
            // 
            // txt_Platform
            // 
            this.txt_Platform.Enabled = false;
            this.txt_Platform.Location = new System.Drawing.Point(197, 157);
            this.txt_Platform.Name = "txt_Platform";
            this.txt_Platform.ReadOnly = true;
            this.txt_Platform.Size = new System.Drawing.Size(100, 20);
            this.txt_Platform.TabIndex = 3;
            // 
            // lbl_TimeOfArrival
            // 
            this.lbl_TimeOfArrival.AutoSize = true;
            this.lbl_TimeOfArrival.Location = new System.Drawing.Point(111, 200);
            this.lbl_TimeOfArrival.Name = "lbl_TimeOfArrival";
            this.lbl_TimeOfArrival.Size = new System.Drawing.Size(77, 13);
            this.lbl_TimeOfArrival.TabIndex = 4;
            this.lbl_TimeOfArrival.Text = "Time of Arrival:";
            // 
            // txt_TimeOfArrival
            // 
            this.txt_TimeOfArrival.Enabled = false;
            this.txt_TimeOfArrival.Location = new System.Drawing.Point(197, 197);
            this.txt_TimeOfArrival.Name = "txt_TimeOfArrival";
            this.txt_TimeOfArrival.ReadOnly = true;
            this.txt_TimeOfArrival.Size = new System.Drawing.Size(100, 20);
            this.txt_TimeOfArrival.TabIndex = 5;
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 278);
            this.Controls.Add(this.txt_TimeOfArrival);
            this.Controls.Add(this.lbl_TimeOfArrival);
            this.Controls.Add(this.txt_Platform);
            this.Controls.Add(this.txt_CurrentStation);
            this.Controls.Add(this.lbl_Platform);
            this.Controls.Add(this.lbl_currentstation);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrainDisplay_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_currentstation;
        private System.Windows.Forms.Label lbl_Platform;
        private System.Windows.Forms.TextBox txt_CurrentStation;
        private System.Windows.Forms.TextBox txt_Platform;
        private System.Windows.Forms.Label lbl_TimeOfArrival;
        private System.Windows.Forms.TextBox txt_TimeOfArrival;
    }
}