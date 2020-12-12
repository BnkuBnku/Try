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
    public partial class PrayerList_form : Form
    {
        public PrayerList_form()
        {
            InitializeComponent();
        }

        private void PrayerList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            string result = PrayerClient.GetAllPrayer();
            List<Prayer> pray = JsonConvert.DeserializeObject<List<Prayer>>(result);
            foreach (var p in pray)
            {
                prayergrid.Rows.Add(
                p.Prayerid,
                p.Prayerw
                );
            };
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPrayer ap = new AddPrayer();
            ap.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            PrayerClient.deletePrayer(Convert.ToInt32(prayergrid.CurrentRow.Cells[0].Value));
            prayergrid.Rows.Clear();
            LoadList();
        }

        private void btn_updateprayer_Click(object sender, EventArgs e)
        {
            this.Hide();

            Prayer p = new Prayer(
            Convert.ToInt32(prayergrid.CurrentRow.Cells[0].Value),
            prayergrid.CurrentRow.Cells[1].Value.ToString()
            );

            UpdatePrayer up = new UpdatePrayer(p);
            up.Show();
        }
    }
}
