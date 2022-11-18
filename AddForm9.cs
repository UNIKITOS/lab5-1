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
    public partial class AddForm9 : Form
    {
        public AddForm9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 main = this.Owner as Form7;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Posetitel'_familiya"] = textfam.Text;
                nRow["Posetitel'_imya"] = textimpos.Text;
                nRow["Nomer_telefona"] = texttlef.Text;
                
                main.zayDBDataSet.Tables[5].Rows.Add(nRow);
                main.posetitel_TableAdapter.Update(main.zayDBDataSet._Posetitel_);
                main.zayDBDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                textfam.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void texttlef_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
