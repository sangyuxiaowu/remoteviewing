using System.Net.Sockets;

namespace RemoteViewing.WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (this.vncControl.Client.IsConnected)
            {
                this.vncControl.Client.Close();
            }
            else
            {
                var hostname = this.txtHostname.Text.Trim();
                if (hostname == string.Empty)
                {
                    MessageBox.Show(
                        this,
                        "Hostname isn't set.",
                        "Hostname",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                int port;
                if (!int.TryParse(this.txtPort.Text, out port) || port < 1 || port > 65535)
                {
                    MessageBox.Show(
                        this,
                        "Port must be between 1 and 65535.",
                        "Port",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var options = new Vnc.VncClientConnectOptions();
                if (this.txtPassword.Text != string.Empty)
                {
                    options.Password = this.txtPassword.Text.ToCharArray();
                }

                try
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        try
                        {
                            this.vncControl.Client.Connect(hostname, port, options);
                        }
                        finally
                        {
                            this.Cursor = Cursors.Default;
                        }
                    }
                    catch (Vnc.VncException ex)
                    {
                        MessageBox.Show(
                            this,
                            "Connection failed (" + ex.Reason.ToString() + ").",
                            "Connect",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    catch (SocketException ex)
                    {
                        MessageBox.Show(
                            this,
                            "Connection failed (" + ex.SocketErrorCode.ToString() + ").",
                            "Connect",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    this.vncControl.Focus();
                }
                finally
                {
                    if (options.Password != null)
                    {
                        Array.Clear(options.Password, 0, options.Password.Length);
                    }
                }
            }
        }

        private void OnConnected(object sender, EventArgs e)
        {
            this.btnConnect.Text = "Close";
        }

        private void OnClosed(object sender, EventArgs e)
        {
            this.btnConnect.Text = "Connect";
        }

        private void OnConnectionFailed(object sender, EventArgs e)
        {
        }
    }
}
