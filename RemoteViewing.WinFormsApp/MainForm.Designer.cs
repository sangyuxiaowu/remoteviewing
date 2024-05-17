namespace RemoteViewing.WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Vnc.VncClient vncClient1 = new Vnc.VncClient();
            mainTableLayoutPanel = new TableLayoutPanel();
            topTableLayoutPanel = new TableLayoutPanel();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnConnect = new Button();
            lblHostname = new Label();
            lblPort = new Label();
            txtHostname = new TextBox();
            txtPort = new TextBox();
            vncControl = new Windows.Forms.VncControl();
            mainTableLayoutPanel.SuspendLayout();
            topTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.AutoSize = true;
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(topTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(vncControl, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(4);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle());
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(742, 591);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // topTableLayoutPanel
            // 
            topTableLayoutPanel.AutoSize = true;
            topTableLayoutPanel.ColumnCount = 7;
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.00001F));
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00001F));
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            topTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99998F));
            topTableLayoutPanel.Controls.Add(txtPassword, 6, 0);
            topTableLayoutPanel.Controls.Add(lblPassword, 5, 0);
            topTableLayoutPanel.Controls.Add(btnConnect, 0, 0);
            topTableLayoutPanel.Controls.Add(lblHostname, 1, 0);
            topTableLayoutPanel.Controls.Add(lblPort, 3, 0);
            topTableLayoutPanel.Controls.Add(txtHostname, 2, 0);
            topTableLayoutPanel.Controls.Add(txtPort, 4, 0);
            topTableLayoutPanel.Dock = DockStyle.Fill;
            topTableLayoutPanel.Location = new Point(0, 0);
            topTableLayoutPanel.Margin = new Padding(0);
            topTableLayoutPanel.Name = "topTableLayoutPanel";
            topTableLayoutPanel.RowCount = 1;
            topTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            topTableLayoutPanel.Size = new Size(742, 46);
            topTableLayoutPanel.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(638, 4);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(563, 0);
            lblPassword.Margin = new Padding(15, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 46);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            btnConnect.AutoSize = true;
            btnConnect.Location = new Point(4, 4);
            btnConnect.Margin = new Padding(4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(76, 38);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += OnClick;
            // 
            // lblHostname
            // 
            lblHostname.AutoSize = true;
            lblHostname.Dock = DockStyle.Fill;
            lblHostname.Location = new Point(99, 0);
            lblHostname.Margin = new Padding(15, 0, 4, 0);
            lblHostname.Name = "lblHostname";
            lblHostname.Size = new Size(70, 46);
            lblHostname.TabIndex = 1;
            lblHostname.Text = "Hostname:";
            lblHostname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Dock = DockStyle.Fill;
            lblPort.Location = new Point(402, 0);
            lblPort.Margin = new Padding(15, 0, 4, 0);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 46);
            lblPort.TabIndex = 2;
            lblPort.Text = "Port:";
            lblPort.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHostname
            // 
            txtHostname.Dock = DockStyle.Fill;
            txtHostname.Location = new Point(177, 4);
            txtHostname.Margin = new Padding(4);
            txtHostname.Name = "txtHostname";
            txtHostname.Size = new Size(206, 23);
            txtHostname.TabIndex = 1;
            txtHostname.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            txtPort.Dock = DockStyle.Fill;
            txtPort.Location = new Point(445, 4);
            txtPort.Margin = new Padding(4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(99, 23);
            txtPort.TabIndex = 2;
            txtPort.Text = "5900";
            // 
            // vncControl
            // 
            vncControl.AllowClipboardSharingFromServer = true;
            vncControl.AllowClipboardSharingToServer = true;
            vncControl.AllowInput = true;
            vncControl.AllowRemoteCursor = true;
            vncControl.BackColor = Color.Black;
            vncClient1.MaxUpdateRate = 15D;
            vncClient1.UserData = null;
            vncControl.Client = vncClient1;
            vncControl.Dock = DockStyle.Fill;
            vncControl.HideLocalCursor = false;
            vncControl.Location = new Point(5, 52);
            vncControl.Margin = new Padding(5, 6, 5, 6);
            vncControl.Name = "vncControl";
            vncControl.Size = new Size(732, 533);
            vncControl.TabIndex = 4;
            vncControl.Connected += OnConnected;
            vncControl.ConnectionFailed += OnConnectionFailed;
            vncControl.Closed += OnClosed;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 591);
            Controls.Add(mainTableLayoutPanel);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "RemoteViewing - Example VNC Client";
            WindowState = FormWindowState.Maximized;
            mainTableLayoutPanel.ResumeLayout(false);
            mainTableLayoutPanel.PerformLayout();
            topTableLayoutPanel.ResumeLayout(false);
            topTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtPort;
        private Windows.Forms.VncControl vncControl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
    }
}
