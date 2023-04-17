
namespace assignment1
{
    partial class ControlPanel
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
            this.btn_NextStation = new System.Windows.Forms.Button();
            this.btn_AddDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NextStation
            // 
            this.btn_NextStation.Location = new System.Drawing.Point(175, 120);
            this.btn_NextStation.Name = "btn_NextStation";
            this.btn_NextStation.Size = new System.Drawing.Size(150, 87);
            this.btn_NextStation.TabIndex = 0;
            this.btn_NextStation.Text = "Next Station";
            this.btn_NextStation.UseVisualStyleBackColor = true;
            this.btn_NextStation.Click += new System.EventHandler(this.btn_NextStation_Click);
            // 
            // btn_AddDisplay
            // 
            this.btn_AddDisplay.Location = new System.Drawing.Point(213, 334);
            this.btn_AddDisplay.Name = "btn_AddDisplay";
            this.btn_AddDisplay.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDisplay.TabIndex = 1;
            this.btn_AddDisplay.Text = "New display";
            this.btn_AddDisplay.UseVisualStyleBackColor = true;
            this.btn_AddDisplay.Click += new System.EventHandler(this.btn_AddDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btn_AddDisplay);
            this.Controls.Add(this.btn_NextStation);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NextStation;
        private System.Windows.Forms.Button btn_AddDisplay;
    }
}

