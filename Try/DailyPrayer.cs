using Newtonsoft.Json;
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
    public partial class DailyPrayer : Form
    {
        public DailyPrayer()
        {
            InitializeComponent();
        }

        private void btn_editprayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrayerList_form ap = new PrayerList_form();
            ap.Show();
        }

        private void btn_prayer_Click(object sender, EventArgs e)
        {
            string result = PrayerClient.RandPrayer();
            List<Prayer> prayer = JsonConvert.DeserializeObject<List<Prayer>>(result);
            foreach (var p in prayer)
            {
                MessageBox.Show(
                p.Prayerw
                );
            };

        }

        private void btn_editverse_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerseList vl = new VerseList();
            vl.Show();
        }

        private void btn_Verses_Click(object sender, EventArgs e)
        {
            string result = VerseClient.RandVerses();
            List<Verses> verse = JsonConvert.DeserializeObject<List<Verses>>(result);
            foreach (var v in verse)
            {
                MessageBox.Show(
                v.Versesw
                );
            };
        }
    }
}
