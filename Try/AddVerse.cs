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
    public partial class addverse_form : Form
    {
        public addverse_form()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Verses v = new Verses(
                Convert.ToInt32(lbl_verseid.Text),
                rtb_versesw.Text
                );

            string response = VerseClient.addVerse(v);

            if (response.Equals("success"))
            {
                MessageBox.Show("Verse is sucessfully added.");
            }


            this.Hide();
            DailyPrayer dl = new DailyPrayer();
            dl.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_versesw.Clear();
            rtb_versesw.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerseList vl = new VerseList();
            vl.Show();
        }
    }
}
