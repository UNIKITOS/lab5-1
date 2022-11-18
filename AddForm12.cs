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
    public partial class AddForm12 : Form
    {
        public AddForm12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 main = this.Owner as Form7;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[4].NewRow();
                int rc = main.dataGridView3.RowCount + 1;
                nRow[0] = rc;
                nRow["Vid"] = textVid.Text;

                main.zayDBDataSet.Tables[4].Rows.Add(nRow);
                main.naimenovanie_yslygiTableAdapter.Update(main.zayDBDataSet.Naimenovanie_yslygi);
                main.zayDBDataSet.Tables[4].AcceptChanges();
                main.dataGridView3.Refresh();
                textVid.Text = "";
            }
        }
    }
}
