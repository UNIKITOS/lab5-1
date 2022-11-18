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
    public partial class SearchForm14 : Form
    {
        public SearchForm14()
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
                for (int i = 0; i < main.dataGridView4.RowCount; i++)
                {
                    main.dataGridView4.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView4.ColumnCount; j++)
                        if (main.dataGridView4.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView4.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
