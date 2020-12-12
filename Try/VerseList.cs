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
    public partial class VerseList : Form
    {
        public VerseList()
        {
            InitializeComponent();
        }

        private void VerseList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            string result = VerseClient.GetAllVerse();
            List<Verses> verse = JsonConvert.DeserializeObject<List<Verses>>(result);
            foreach (var v in verse)
            {
                versegrid.Rows.Add(
                v.Verseid,
                v.Versesw
                );
            };
        }

        private void btn_addverse_Click(object sender, EventArgs e)
        {
            this.Hide();
            addverse_form av = new addverse_form();
            av.Show();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            VerseClient.deleteVerse(Convert.ToInt32(versegrid.CurrentRow.Cells[0].Value));
            versegrid.Rows.Clear();
            LoadList();
        }

        private void btn_updateverse_Click(object sender, EventArgs e)
        {
            this.Hide();

            Verses v = new Verses(
            Convert.ToInt32(versegrid.CurrentRow.Cells[0].Value),
            versegrid.CurrentRow.Cells[1].Value.ToString()
            );

            UpdateVerse uv = new UpdateVerse(v);
            uv.Show();
        }
    }
}
