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
    public partial class AddForm14 : Form
    {
        public AddForm14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 main = this.Owner as Form9;
            if (main != null)
            {
                DataRow nRow = main.zayDBDataSet.Tables[0].NewRow();
                int rc = main.dataGridView4.RowCount + 1;
                nRow[0] = rc;
                nRow["naimenovanie branda"] = textbrand.Text;
                main.zayDBDataSet.Tables[0].Rows.Add(nRow);
                main.brandTableAdapter.Update(main.zayDBDataSet.Brand);
                main.zayDBDataSet.Tables[0].AcceptChanges();
                main.dataGridView4.Refresh();
                textbrand.Text = "";
            }
        }
    }
}
