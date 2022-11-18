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
    public partial class AddForm8 : Form
    {
        public AddForm8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 main = this.Owner as Form6;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[6].NewRow();
                int rc = main.dataGridView3.RowCount + 1;
                nRow[0] = rc;
                nRow["Nazvanie_postavshika"] = textNazvanie_postavshika.Text;
                nRow["FIO_postavshika"] = textFIO.Text;
                nRow["Nomer_telefona"] = textNomer.Text;
                nRow["Adres_postavshika"] = textAdres.Text;
                main.zayDBDataSet.Tables[6].Rows.Add(nRow);
                main.postavshikTableAdapter.Update(main.zayDBDataSet.Postavshik);
                main.zayDBDataSet.Tables[6].AcceptChanges();
                main.dataGridView3.Refresh();
                textNazvanie_postavshika.Text = "";
            }
        }
    }
}
