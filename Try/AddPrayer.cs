using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try
{
    public partial class AddPrayer : Form
    {
        public AddPrayer()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_prayerw.Clear();
            rtb_prayerw.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Prayer p = new Prayer(
                Convert.ToInt32(lbl_prayerid.Text),
                rtb_prayerw.Text
                );

            string response = PrayerClient.addPrayer(p);

            if (response.Equals("success"))
            {
                MessageBox.Show("Prayer is sucessfully added.");
            }


            this.Hide();
            DailyPrayer dl = new DailyPrayer();
            dl.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrayerList_form pl = new PrayerList_form();
            pl.Show();
        }
    }
}
