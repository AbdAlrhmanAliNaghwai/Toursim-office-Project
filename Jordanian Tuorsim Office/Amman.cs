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
    public partial class Amman : Form
    {

        public Amman()
        {
            InitializeComponent();
        }

        private void btn_Romantheater_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Amman.BackgroundImage = Properties.Resources.roman_theater;
            lbl1_Amman.Text = "See the highlights of ancient and modern Amman " + "\n" +
                "on this private 4-hour city tour, "+ "\n" +
                "discovering the many different faces of \n" +
                "Jordan’s capital.";
            lbl2_Amman.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 4-8 hours\n";
            lbl3_Amman.Text = "From 47.99US per person";
        }

        private void Amman_Load(object sender, EventArgs e)
        {
            btnBookticket.Hide();
        }

        private void btn_TheRoyalAutomobileMuseum_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Amman.BackgroundImage = Properties.Resources.royal_automible;
            lbl1_Amman.Text = "See all the amazing Royal Automobile " + "\n" +
                "on this private tour, " + "\n" +
                "discovering the many different Royal cars";
            lbl2_Amman.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 6-8 hours.\n5. Pick avaliable from hotels in Amman";
            lbl3_Amman.Text = "From 29.99US per person";
        }

        private void btnBookticket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for booking with us <3");
        }

        private void btn_KingAbdullahMosque_Click(object sender, EventArgs e)
        {
            btnBookticket.Show();
            pnl_Amman.BackgroundImage = Properties.Resources.king_abullah_first_mosque;
            lbl1_Amman.Text = "Check the majestic King Abdullah First Mosque " + "\n" +
                "on this private tour.";
            lbl2_Amman.Text = "About this ticket.\n1. Free cancellation up to 24 hours.\n2. Book now and pay later.\n3. Private group.\n4. Duration is 2-3 hours.";
            lbl3_Amman.Text = "From 13.99US per person";
        }
    }
}
