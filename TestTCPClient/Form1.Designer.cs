namespace TestTCPClient
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
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnLed_ON = new System.Windows.Forms.Button();
            this.btnLed_OFF = new System.Windows.Forms.Button();
            this.lblReply = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(10, 18);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 0;
            this.lblHost.Text = "Host:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(162, 18);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            this.lblPort.Click += new System.EventHandler(this.lblPort_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(273, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(382, 102);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 25);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(48, 14);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(93, 20);
            this.txtHost.TabIndex = 2;
            this.txtHost.Text = "10.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(197, 14);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(60, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "123";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 58);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(457, 20);
            this.txtSend.TabIndex = 2;
            // 
            // btnLed_ON
            // 
            this.btnLed_ON.Location = new System.Drawing.Point(13, 102);
            this.btnLed_ON.Name = "btnLed_ON";
            this.btnLed_ON.Size = new System.Drawing.Size(75, 23);
            this.btnLed_ON.TabIndex = 3;
            this.btnLed_ON.Text = "LED ON";
            this.btnLed_ON.UseVisualStyleBackColor = true;
            this.btnLed_ON.Click += new System.EventHandler(this.btnLed_ON_Click);
            // 
            // btnLed_OFF
            // 
            this.btnLed_OFF.Location = new System.Drawing.Point(116, 102);
            this.btnLed_OFF.Name = "btnLed_OFF";
            this.btnLed_OFF.Size = new System.Drawing.Size(75, 23);
            this.btnLed_OFF.TabIndex = 3;
            this.btnLed_OFF.Text = "LED OFF";
            this.btnLed_OFF.UseVisualStyleBackColor = true;
            this.btnLed_OFF.Click += new System.EventHandler(this.btnLed_OFF_Click);
            // 
            // lblReply
            // 
            this.lblReply.AutoSize = true;
            this.lblReply.Location = new System.Drawing.Point(223, 107);
            this.lblReply.Name = "lblReply";
            this.lblReply.Size = new System.Drawing.Size(34, 13);
            this.lblReply.TabIndex = 4;
            this.lblReply.Text = "Reply";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(13, 133);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(457, 154);
            this.txtStatus.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(385, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 307);
            this.Controls.Add(this.lblReply);
            this.Controls.Add(this.btnLed_OFF);
            this.Controls.Add(this.btnLed_ON);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnLed_ON;
        private System.Windows.Forms.Button btnLed_OFF;
        private System.Windows.Forms.Label lblReply;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnClose;
    }
}

