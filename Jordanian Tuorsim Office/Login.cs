using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Jordanian_Tuorsim_Office
{
    public partial class Login : Form
    {
        private string connectstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=toursim office.accdb";
        private OleDbConnection con;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Login()
        {
            con = new OleDbConnection(connectstring);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Movable_form(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAddorLogin_Click(object sender, EventArgs e)
        {
            string insertCommand;
            try
            {
                insertCommand = $"Insert Into Accounts ([Username], [Password], [PhoneNUM])" +
                $"values('{txtUser.Text}', '{txtPass.Text}', '{txtPhone.Text}')";
                OleDbCommand command = new OleDbCommand(insertCommand, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                con.Close();
                insertCommand = $"Select * from Accounts where [Username] = '{txtUser.Text}' and [Password] = '{txtPass.Text}' and [PhoneNUM] = '{txtPhone.Text}'";
                OleDbCommand command = new OleDbCommand(insertCommand, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }  
            this.Close();
        }
    }
}
