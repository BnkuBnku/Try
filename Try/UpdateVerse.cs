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
    public partial class UpdateVerse : Form
    {
        private Verses verses;

        public UpdateVerse()
        {
            InitializeComponent();
        }

        public UpdateVerse(Verses verses) : this()
        {
            this.verses = verses;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Verses v = new Verses(
                Convert.ToInt32(lbl_verseid.Text),
                rtb_versesw.Text
                );



            if (VerseClient.updateVerse(v).Equals("success"))
            {
                MessageBox.Show("Verse is sucessfully updated.");
            }

            this.Hide();
            VerseList vl = new VerseList();
            vl.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerseList vl = new VerseList();
            vl.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_versesw.Clear();
            rtb_versesw.Focus();
        }
    }
}
