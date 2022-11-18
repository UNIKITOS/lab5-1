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
    public partial class AddForm15 : Form
    {
        public AddForm15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 main = this.Owner as Form9;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[10].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow["Naimenovanie_tipa"] = texttip.Text;
                main.zayDBDataSet.Tables[10].Rows.Add(nRow);
                main.tipTableAdapter.Update(main.zayDBDataSet.Tip);
                main.zayDBDataSet.Tables[10].AcceptChanges();
                main.dataGridView2.Refresh();
                texttip.Text = "";
            }
        }
    }
}
