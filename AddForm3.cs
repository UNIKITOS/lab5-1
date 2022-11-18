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
    public partial class AddForm3 : Form
    {
        public AddForm3()
        {
            InitializeComponent();
        }

        private void AddForm3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn2(object sender, EventArgs e)
        {


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[12].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Data postavki"] = textData_postavki.Text;
                nRow["Symma postavki"] = textSymma_postavki.Text;
                nRow["Summa zakaza"] = textSymma_zakaza.Text;
                nRow["Kolichestvo_tovara"] = textKolichestvo_tovara.Text;
                main.zayDBDataSet.Tables[12].Rows.Add(nRow);
                main.zakupka_tovarovTableAdapter.Update(main.zayDBDataSet.Zakupka_tovarov);
                main.zayDBDataSet.Tables[12].AcceptChanges();
                main.dataGridView1.Refresh();
                textData_postavki.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
