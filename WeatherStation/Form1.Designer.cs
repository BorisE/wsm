namespace WeatherStation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnList = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtComName = new System.Windows.Forms.TextBox();
            this.outText = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(170, 24);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(13, 24);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(141, 20);
            this.txtComName.TabIndex = 1;
            this.txtComName.Text = "COM5";
            // 
            // outText
            // 
            this.outText.Location = new System.Drawing.Point(13, 98);
            this.outText.Multiline = true;
            this.outText.Name = "outText";
            this.outText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outText.Size = new System.Drawing.Size(562, 375);
            this.outText.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 498);
            this.Controls.Add(this.outText);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox outText;
        private System.Windows.Forms.Button btnStart;
    }
}

