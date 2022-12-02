namespace ArduinoHardwareMonitor
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
            this.comboHardware = new System.Windows.Forms.ComboBox();
            this.comboSensorType = new System.Windows.Forms.ComboBox();
            this.comboComPort = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboHardware
            // 
            this.comboHardware.FormattingEnabled = true;
            this.comboHardware.Location = new System.Drawing.Point(27, 45);
            this.comboHardware.Name = "comboHardware";
            this.comboHardware.Size = new System.Drawing.Size(366, 21);
            this.comboHardware.TabIndex = 1;
            this.comboHardware.SelectedIndexChanged += new System.EventHandler(this.comboHardware_SelectedIndexChanged);
            // 
            // comboSensorType
            // 
            this.comboSensorType.Enabled = false;
            this.comboSensorType.FormattingEnabled = true;
            this.comboSensorType.Location = new System.Drawing.Point(27, 106);
            this.comboSensorType.Name = "comboSensorType";
            this.comboSensorType.Size = new System.Drawing.Size(172, 21);
            this.comboSensorType.TabIndex = 2;
            this.comboSensorType.SelectedIndexChanged += new System.EventHandler(this.comboSensorType_SelectedIndexChanged);
            // 
            // comboComPort
            // 
            this.comboComPort.Enabled = false;
            this.comboComPort.FormattingEnabled = true;
            this.comboComPort.Location = new System.Drawing.Point(221, 106);
            this.comboComPort.Name = "comboComPort";
            this.comboComPort.Size = new System.Drawing.Size(172, 21);
            this.comboComPort.TabIndex = 3;
            this.comboComPort.SelectedIndexChanged += new System.EventHandler(this.comboComPort_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(27, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 43);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(221, 161);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 43);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "COM Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hardware";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboComPort);
            this.Controls.Add(this.comboSensorType);
            this.Controls.Add(this.comboHardware);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Hardware Monitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHardware;
        private System.Windows.Forms.ComboBox comboSensorType;
        private System.Windows.Forms.ComboBox comboComPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

