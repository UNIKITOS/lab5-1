using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaycev
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[1].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Grafik_raboti"] = textGrafik_raboti.Text;
                main.zayDBDataSet.Tables[1].Rows.Add(nRow);
                main.byhgalteriyaTableAdapter.Update(main.zayDBDataSet.Byhgalteriya);
                main.zayDBDataSet.Tables[1].AcceptChanges();
                main.dataGridView1.Refresh();
                textGrafik_raboti.Text = "";
            }
        }
    }
}
