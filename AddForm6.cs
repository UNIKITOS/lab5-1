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
    public partial class AddForm6 : Form
    {
        public AddForm6()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["fam_sota"] = textfam_sot.Text;
                nRow["Im_sota"] = textim_sota.Text;
                nRow["Ot_sota"] = textOt_sota.Text;
                nRow["Data_rojd'"] = textData_rojd.Text;
                main.zayDBDataSet.Tables[8].Rows.Add(nRow);
                main.sotrudnikTableAdapter.Update(main.zayDBDataSet.Sotrudnik);
                main.zayDBDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                textfam_sot.Text = "";
            }
        }
    }
}
