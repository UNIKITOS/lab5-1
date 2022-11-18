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
    public partial class AddForm13 : Form
    {
        public AddForm13()
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
                DataRow nRow = main.zayDBDataSet.Tables[9].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow["Cena_za_1_edinicy"] = textcena1.Text;
                nRow["Kolichestvo tovara"] = textkolich.Text;
                
                main.zayDBDataSet.Tables[9].Rows.Add(nRow);
                main.spisok_tovarovTableAdapter.Update(main.zayDBDataSet.Spisok_tovarov);
                main.zayDBDataSet.Tables[9].AcceptChanges();
                main.dataGridView1.Refresh();
                textcena1.Text = "";
            }
        }

        private void AddForm13_Load(object sender, EventArgs e)
        {
            
        }
    }
}
