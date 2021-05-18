namespace provadisperata
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_open = new System.Windows.Forms.Button();
            this.progressBarS1 = new System.Windows.Forms.ProgressBar();
            this.button_close = new System.Windows.Forms.Button();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.progressBarS2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.progressBarS3 = new System.Windows.Forms.ProgressBar();
            this.progressBar_statusCOM = new System.Windows.Forms.ProgressBar();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxS6 = new System.Windows.Forms.TextBox();
            this.progressBarS6 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxS5 = new System.Windows.Forms.TextBox();
            this.progressBarS5 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxS4 = new System.Windows.Forms.TextBox();
            this.progressBarS4 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(424, 382);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(73, 32);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "OPEN";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // progressBarS1
            // 
            this.progressBarS1.Location = new System.Drawing.Point(36, 72);
            this.progressBarS1.Maximum = 4096;
            this.progressBarS1.Name = "progressBarS1";
            this.progressBarS1.Size = new System.Drawing.Size(608, 22);
            this.progressBarS1.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(503, 382);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(73, 32);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(650, 72);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(100, 22);
            this.textBoxS1.TabIndex = 3;
            this.textBoxS1.TextChanged += new System.EventHandler(this.textBoxS1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SENSOR1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "SENSOR2";
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(650, 117);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(100, 22);
            this.textBoxS2.TabIndex = 6;
            // 
            // progressBarS2
            // 
            this.progressBarS2.Location = new System.Drawing.Point(36, 117);
            this.progressBarS2.Maximum = 4096;
            this.progressBarS2.Name = "progressBarS2";
            this.progressBarS2.Size = new System.Drawing.Size(608, 22);
            this.progressBarS2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "SENSOR3";
            // 
            // textBoxS3
            // 
            this.textBoxS3.Location = new System.Drawing.Point(650, 162);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(100, 22);
            this.textBoxS3.TabIndex = 9;
            // 
            // progressBarS3
            // 
            this.progressBarS3.Location = new System.Drawing.Point(36, 162);
            this.progressBarS3.Maximum = 4096;
            this.progressBarS3.Name = "progressBarS3";
            this.progressBarS3.Size = new System.Drawing.Size(608, 22);
            this.progressBarS3.TabIndex = 8;
            // 
            // progressBar_statusCOM
            // 
            this.progressBar_statusCOM.Location = new System.Drawing.Point(744, 390);
            this.progressBar_statusCOM.Name = "progressBar_statusCOM";
            this.progressBar_statusCOM.Size = new System.Drawing.Size(42, 38);
            this.progressBar_statusCOM.TabIndex = 11;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.AllowDrop = true;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(34, 390);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox_baudRate.TabIndex = 12;
            this.comboBox_baudRate.DropDown += new System.EventHandler(this.comboBox_baudRate_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "BaudRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "COMport";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.AllowDrop = true;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(185, 390);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(121, 24);
            this.comboBox_comPort.TabIndex = 14;
            this.comboBox_comPort.DropDown += new System.EventHandler(this.comboBox_comPort_DropDown);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "SENSOR6";
            // 
            // textBoxS6
            // 
            this.textBoxS6.Location = new System.Drawing.Point(650, 302);
            this.textBoxS6.Name = "textBoxS6";
            this.textBoxS6.Size = new System.Drawing.Size(100, 22);
            this.textBoxS6.TabIndex = 23;
            // 
            // progressBarS6
            // 
            this.progressBarS6.Location = new System.Drawing.Point(36, 302);
            this.progressBarS6.Maximum = 4096;
            this.progressBarS6.Name = "progressBarS6";
            this.progressBarS6.Size = new System.Drawing.Size(608, 22);
            this.progressBarS6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "SENSOR5";
            // 
            // textBoxS5
            // 
            this.textBoxS5.Location = new System.Drawing.Point(650, 257);
            this.textBoxS5.Name = "textBoxS5";
            this.textBoxS5.Size = new System.Drawing.Size(100, 22);
            this.textBoxS5.TabIndex = 20;
            // 
            // progressBarS5
            // 
            this.progressBarS5.Location = new System.Drawing.Point(36, 257);
            this.progressBarS5.Maximum = 4096;
            this.progressBarS5.Name = "progressBarS5";
            this.progressBarS5.Size = new System.Drawing.Size(608, 22);
            this.progressBarS5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "SENSOR4";
            // 
            // textBoxS4
            // 
            this.textBoxS4.Location = new System.Drawing.Point(650, 212);
            this.textBoxS4.Name = "textBoxS4";
            this.textBoxS4.Size = new System.Drawing.Size(100, 22);
            this.textBoxS4.TabIndex = 17;
            // 
            // progressBarS4
            // 
            this.progressBarS4.Location = new System.Drawing.Point(36, 212);
            this.progressBarS4.Maximum = 4096;
            this.progressBarS4.Name = "progressBarS4";
            this.progressBarS4.Size = new System.Drawing.Size(608, 22);
            this.progressBarS4.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(669, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "ADC unit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "COM CLOSED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 453);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxS6);
            this.Controls.Add(this.progressBarS6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxS5);
            this.Controls.Add(this.progressBarS5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxS4);
            this.Controls.Add(this.progressBarS4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_comPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_baudRate);
            this.Controls.Add(this.progressBar_statusCOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxS3);
            this.Controls.Add(this.progressBarS3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.progressBarS2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxS1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.progressBarS1);
            this.Controls.Add(this.button_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ProgressBar progressBarS1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.ProgressBar progressBarS2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.ProgressBar progressBarS3;
        private System.Windows.Forms.ProgressBar progressBar_statusCOM;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxS6;
        private System.Windows.Forms.ProgressBar progressBarS6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxS5;
        private System.Windows.Forms.ProgressBar progressBarS5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxS4;
        private System.Windows.Forms.ProgressBar progressBarS4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

