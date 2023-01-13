using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jordanian_Tuorsim_Office
{
    public partial class Petra : Form
    {
        public Petra()
        {
            InitializeComponent();
        }

        private void btn_Thetreasury_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Petra.BackgroundImage = Properties.Resources.the_treasury;
            lbl1_Petra.Text = "Visit the ancient rock-carved\ncity of Petra on a tour from Amman.";
            lbl2_Petra.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 2 days. \n5. Pickup from Amman hotels or your home included.";
            lbl3_Petra.Text = "From 199.99US per person";
        }

        private void btnBookticket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking with us <3");
        }

        private void Petra_Load(object sender, EventArgs e)
        {
            btnBookticket.Hide();
        }

        private void btn_Alsiq_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Petra.BackgroundImage = Properties.Resources.al_siq;
            lbl1_Petra.Text = "Visit the ancient rock-carved\ncity of Petra AL-Siq on a tour from Amman.";
            lbl2_Petra.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 2 days. \n5. Pickup from Amman hotels or your home included.";
            lbl3_Petra.Text = "From 199.99US per person";
        }

        private void btn_Wadirum_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Petra.BackgroundImage = Properties.Resources.wadi_rum;
            lbl1_Petra.Text = "Visit the wonderful desert Wadi Rum\non a tour from Amman.";
            lbl2_Petra.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 1-7 days. \n5. Pickup from Amman hotels or your home included.";
            lbl3_Petra.Text = "From 99.99US per night";
        }
    }
}
