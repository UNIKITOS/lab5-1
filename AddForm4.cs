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
    public partial class AddForm4 : Form
    {
        public AddForm4()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Nomer yslygi"] = textNomer_yslygi.Text;
                main.zayDBDataSet.Tables[7].Rows.Add(nRow);
                main.priobretenie_yslygiTableAdapter.Update(main.zayDBDataSet.Priobretenie_yslygi);
                main.zayDBDataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                textNomer_yslygi.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
