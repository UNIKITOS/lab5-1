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
    public partial class AddForm7 : Form
    {
        public AddForm7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[3].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Naimenovanie doljnosti"] = textNaimenovanie_doljnosti.Text;
                nRow["Oklad"] = textOklad.Text;
                main.zayDBDataSet.Tables[3].Rows.Add(nRow);
                main.sotrudnikTableAdapter.Update(main.zayDBDataSet.Sotrudnik);
                main.zayDBDataSet.Tables[3].AcceptChanges();
                main.dataGridView1.Refresh();
                textNaimenovanie_doljnosti.Text = "";
            }
        }
    }
}
