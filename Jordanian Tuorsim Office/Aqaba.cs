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
    public partial class Aqaba : Form
    {
        public Aqaba()
        {
            InitializeComponent();
        }

        private void Aqaba_Load(object sender, EventArgs e)
        {
            btnBookticket.Hide();
        }

        private void btnBookticket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking with us <3");
        }

        private void btn_Citybeach_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Aqaba.BackgroundImage = Properties.Resources.city_beach;
            lbl1_Aqaba.Text = "Enjoy a tour from Amman to Aqaba\n with your family and enjoy the sea.";
            lbl2_Aqaba.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 3 days.";
            lbl3_Aqaba.Text = "From 129.99US per person";

        }

        private void btn_Berenicebeach_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Aqaba.BackgroundImage = Properties.Resources.berenice_beach;
            lbl1_Aqaba.Text = "Berenice Beach Club is a premium tourist\ndestination in Aqaba, right in the heart\nof Aqaba’s Marine Park";
            lbl2_Aqaba.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 3-4 hours.";
            lbl3_Aqaba.Text = "From 59.99US per person";
        }

        private void btn_Aqabacastle_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Aqaba.BackgroundImage = Properties.Resources.aqaba_castle;
            lbl1_Aqaba.Text = "Enjoy the history of this historic castle\nand all the nice places around it\nwith a tour from aqaba.";
            lbl2_Aqaba.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 2 hours.";
            lbl3_Aqaba.Text = "From 39.99US per person";
        }
    }
}
