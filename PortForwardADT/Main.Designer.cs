namespace PortForwardADT
{
    partial class PortForwardADT
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenPorts = new System.Windows.Forms.Button();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.TcpCheck = new System.Windows.Forms.CheckBox();
            this.UdpCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortsNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AllowСonnection = new System.Windows.Forms.CheckBox();
            this.BlockConnection = new System.Windows.Forms.CheckBox();
            this.EnableSecureConnection = new System.Windows.Forms.CheckBox();
            this.Line = new System.Windows.Forms.Label();
            this.Line3 = new System.Windows.Forms.Label();
            this.Incoming = new System.Windows.Forms.CheckBox();
            this.Outbound = new System.Windows.Forms.CheckBox();
            this.Line2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenPorts
            // 
            this.OpenPorts.Location = new System.Drawing.Point(75, 228);
            this.OpenPorts.Name = "OpenPorts";
            this.OpenPorts.Size = new System.Drawing.Size(121, 23);
            this.OpenPorts.TabIndex = 0;
            this.OpenPorts.Text = "Открыть";
            this.OpenPorts.UseVisualStyleBackColor = true;
            this.OpenPorts.Click += new System.EventHandler(this.OpenPorts_Click);
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(58, 16);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(177, 20);
            this.TextPort.TabIndex = 1;
            this.TextPort.TextChanged += new System.EventHandler(this.TextPort_TextChanged);
            // 
            // TcpCheck
            // 
            this.TcpCheck.AutoSize = true;
            this.TcpCheck.Location = new System.Drawing.Point(58, 68);
            this.TcpCheck.Name = "TcpCheck";
            this.TcpCheck.Size = new System.Drawing.Size(47, 17);
            this.TcpCheck.TabIndex = 2;
            this.TcpCheck.Text = "TCP";
            this.TcpCheck.UseVisualStyleBackColor = true;
            this.TcpCheck.CheckedChanged += new System.EventHandler(this.TcpCheck_CheckedChanged);
            // 
            // UdpCheck
            // 
            this.UdpCheck.AutoSize = true;
            this.UdpCheck.Location = new System.Drawing.Point(186, 68);
            this.UdpCheck.Name = "UdpCheck";
            this.UdpCheck.Size = new System.Drawing.Size(49, 17);
            this.UdpCheck.TabIndex = 3;
            this.UdpCheck.Text = "UDP";
            this.UdpCheck.UseVisualStyleBackColor = true;
            this.UdpCheck.CheckedChanged += new System.EventHandler(this.UdpCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port:";
            // 
            // PortsNames
            // 
            this.PortsNames.Location = new System.Drawing.Point(58, 42);
            this.PortsNames.Name = "PortsNames";
            this.PortsNames.Size = new System.Drawing.Size(177, 20);
            this.PortsNames.TabIndex = 5;
            this.PortsNames.TextChanged += new System.EventHandler(this.PortsNames_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // AllowСonnection
            // 
            this.AllowСonnection.AutoSize = true;
            this.AllowСonnection.Location = new System.Drawing.Point(55, 146);
            this.AllowСonnection.Name = "AllowСonnection";
            this.AllowСonnection.Size = new System.Drawing.Size(106, 17);
            this.AllowСonnection.TabIndex = 7;
            this.AllowСonnection.Text = "allow connection";
            this.AllowСonnection.UseVisualStyleBackColor = true;
            this.AllowСonnection.CheckedChanged += new System.EventHandler(this.AllowСonnection_CheckedChanged);
            // 
            // BlockConnection
            // 
            this.BlockConnection.AutoSize = true;
            this.BlockConnection.Location = new System.Drawing.Point(55, 192);
            this.BlockConnection.Name = "BlockConnection";
            this.BlockConnection.Size = new System.Drawing.Size(153, 17);
            this.BlockConnection.TabIndex = 8;
            this.BlockConnection.Text = "Block a secure connection";
            this.BlockConnection.UseVisualStyleBackColor = true;
            this.BlockConnection.CheckedChanged += new System.EventHandler(this.BlockConnection_CheckedChanged);
            // 
            // EnableSecureConnection
            // 
            this.EnableSecureConnection.AutoSize = true;
            this.EnableSecureConnection.Location = new System.Drawing.Point(55, 169);
            this.EnableSecureConnection.Name = "EnableSecureConnection";
            this.EnableSecureConnection.Size = new System.Drawing.Size(150, 17);
            this.EnableSecureConnection.TabIndex = 9;
            this.EnableSecureConnection.Text = "Enable secure connection";
            this.EnableSecureConnection.UseVisualStyleBackColor = true;
            this.EnableSecureConnection.CheckedChanged += new System.EventHandler(this.EnableSecureConnection_CheckedChanged);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(23, 88);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(240, 13);
            this.Line.TabIndex = 10;
            this.Line.Text = "*---------------------------------------------------------------------------*";
            // 
            // Line3
            // 
            this.Line3.AutoSize = true;
            this.Line3.Location = new System.Drawing.Point(23, 212);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(240, 13);
            this.Line3.TabIndex = 11;
            this.Line3.Text = "*---------------------------------------------------------------------------*";
            // 
            // Incoming
            // 
            this.Incoming.AutoSize = true;
            this.Incoming.Location = new System.Drawing.Point(55, 110);
            this.Incoming.Name = "Incoming";
            this.Incoming.Size = new System.Drawing.Size(69, 17);
            this.Incoming.TabIndex = 12;
            this.Incoming.Text = "Incoming";
            this.Incoming.UseVisualStyleBackColor = true;
            this.Incoming.CheckedChanged += new System.EventHandler(this.Incoming_CheckedChanged);
            // 
            // Outbound
            // 
            this.Outbound.AutoSize = true;
            this.Outbound.Location = new System.Drawing.Point(167, 110);
            this.Outbound.Name = "Outbound";
            this.Outbound.Size = new System.Drawing.Size(73, 17);
            this.Outbound.TabIndex = 13;
            this.Outbound.Text = "Outbound";
            this.Outbound.UseVisualStyleBackColor = true;
            this.Outbound.CheckedChanged += new System.EventHandler(this.Outbound_CheckedChanged);
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.Location = new System.Drawing.Point(23, 130);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(240, 13);
            this.Line2.TabIndex = 14;
            this.Line2.Text = "*---------------------------------------------------------------------------*";
            // 
            // PortForwardADT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 263);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Outbound);
            this.Controls.Add(this.Incoming);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.EnableSecureConnection);
            this.Controls.Add(this.BlockConnection);
            this.Controls.Add(this.AllowСonnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PortsNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UdpCheck);
            this.Controls.Add(this.TcpCheck);
            this.Controls.Add(this.TextPort);
            this.Controls.Add(this.OpenPorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PortForwardADT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PortForwardADT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPorts;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.CheckBox TcpCheck;
        private System.Windows.Forms.CheckBox UdpCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortsNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AllowСonnection;
        private System.Windows.Forms.CheckBox BlockConnection;
        private System.Windows.Forms.CheckBox EnableSecureConnection;
        private System.Windows.Forms.Label Line;
        private System.Windows.Forms.Label Line3;
        private System.Windows.Forms.CheckBox Incoming;
        private System.Windows.Forms.CheckBox Outbound;
        private System.Windows.Forms.Label Line2;
    }
}

