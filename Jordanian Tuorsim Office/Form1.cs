using System.Runtime.InteropServices;

namespace Jordanian_Tuorsim_Office
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Amman_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            Amman amman = new Amman();
            amman.Dock = DockStyle.Fill;
            amman.TopLevel = false;
            pnl_Main.Controls.Add(amman);
            amman.Show();
        }

        private void btn_Jarash_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            Jarash jerash = new Jarash();
            jerash.Dock = DockStyle.Fill;
            jerash.TopLevel = false;
            pnl_Main.Controls.Add(jerash);
            jerash.Show();
        }

        private void btn_aqaba_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            Aqaba aqaba = new Aqaba();
            aqaba.Dock = DockStyle.Fill;
            aqaba.TopLevel = false;
            pnl_Main.Controls.Add(aqaba);
            aqaba.Show();
        }

        private void btn_Petra_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            Petra petra = new Petra();
            petra.Dock = DockStyle.Fill;
            petra.TopLevel = false;
            pnl_Main.Controls.Add(petra);
            petra.Show();
        }

        private void btn_DeadSea_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            DeadSea deadSea = new DeadSea();
            deadSea.Dock = DockStyle.Fill;  
            deadSea.TopLevel = false;
            pnl_Main.Controls.Add(deadSea);
            deadSea.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

        }

        private void pcb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcb_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pcb_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void moveable(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}