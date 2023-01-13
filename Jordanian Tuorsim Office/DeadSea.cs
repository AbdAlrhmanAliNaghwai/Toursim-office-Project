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
    public partial class DeadSea : Form
    {
        public DeadSea()
        {
            InitializeComponent();
        }

        private void DeadSea_Load(object sender, EventArgs e)
        {
            btnBookticket.Hide();
        }

        private void btnBookticket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking with us <3");
        }

        private void btn_bapofjesus_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Deadsea.BackgroundImage = Properties.Resources.jesus;
            lbl1_Deadsea.Text = "Enjoy a tour from the Dead Sea to the place\nwhere Jesus Chirst was Baptis.";
            lbl2_Deadsea.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 2 hours.";
            lbl3_Deadsea.Text = "From 19.99US per person";
        }

        private void btnDeadsea_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Deadsea.BackgroundImage = Properties.Resources.the_dead_sea;
            lbl1_Deadsea.Text = "Enjoy a tour from Amman to the Dead Sea\nand appreciate the spa and health effects\nof the Dead Sea. ";
            lbl2_Deadsea.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 1-3 days.";
            lbl3_Deadsea.Text = "From 89.99US per night";
        }

        private void btnDegireserve_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Deadsea.BackgroundImage = Properties.Resources.ein_gedi;
            lbl1_Deadsea.Text = "Enjoy the nature in the Ein Gedi Nature Reserve\nand relax at a private beach at the Dead Sea.";
            lbl2_Deadsea.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 3-4 hours.";
            lbl3_Deadsea.Text = "From 39.99US per person";
        }
    }
}
