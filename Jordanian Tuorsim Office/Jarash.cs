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
    public partial class Jarash : Form
    {
        public Jarash()
        {
            InitializeComponent();
        }

        private void Jarash_Load(object sender, EventArgs e)
        {
            btnBookticket.Hide();
        }

        private void btn_Jerashruins_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnlJerash.BackgroundImage = Properties.Resources.jerash_ruins;
            lbl1_Jerash.Text = "Explore some of Northern Jordan’s ancient treasures\n" +
                "and ruins on a private day tour to Jerash.";
            lbl2_Jerash.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 5-8 hours. \n5. Pickup included.";
            lbl3_Jerash.Text = "From 69.99US per person";
        }

        private void btnBookticket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking with us <3");
        }

        private void btn_Ajlouncastle_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnlJerash.BackgroundImage = Properties.Resources.ajloun_castle;
            lbl1_Jerash.Text = "Explore some of Northern Jordan’s\nancient treasures and ruins on a private day\ntour to Jerash, Ajloun Castle.";
            lbl2_Jerash.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 3-4 hours.";
            lbl3_Jerash.Text = "From 31.99US per person";
        }
    }
}
