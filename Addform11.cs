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
    public partial class Addform11 : Form
    {
        public Addform11()
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
                DataRow nRow = main.zayDBDataSet.Tables[2].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow["Nomer_stola"] = textnomerst.Text;
                nRow["Vremya_broni"] = textvremya.Text;
                nRow["Cena_yslygi"] = textcena.Text;
                main.zayDBDataSet.Tables[2].Rows.Add(nRow);
                main.dannie_ob_yslygeTableAdapter.Update(main.zayDBDataSet.Dannie_ob_yslyge);
                main.zayDBDataSet.Tables[2].AcceptChanges();
                main.dataGridView2.Refresh();
                textnomerst.Text = "";
            }
        }
    }
}
