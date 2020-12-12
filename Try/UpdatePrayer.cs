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
    public partial class UpdatePrayer : Form
    {
        private Prayer prayer;

        public UpdatePrayer()
        {
            InitializeComponent();
        }

        public UpdatePrayer(Prayer prayer): this()
        {
            this.prayer = prayer;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrayerList_form pl = new PrayerList_form();
            pl.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Prayer p = new Prayer(
                Convert.ToInt32(lbl_prayerid.Text),
                rtb_prayerw.Text
                );



            if (PrayerClient.updatePrayer(p).Equals("success"))
            {
                MessageBox.Show("Prayer is sucessfully updated.");
            }

            this.Hide();
            PrayerList_form pl = new PrayerList_form();
            pl.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_prayerw.Clear();
            rtb_prayerw.Focus();
        }
    }
}
