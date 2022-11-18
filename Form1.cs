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

    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zayDBDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Spisok_tovarov". При необходимости она может быть перемещена или удалена.
            this.spisok_tovarovTableAdapter.Fill(this.zayDBDataSet.Spisok_tovarov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Byhgalteriya". При необходимости она может быть перемещена или удалена.
            this.byhgalteriyaTableAdapter.Fill(this.zayDBDataSet.Byhgalteriya);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byhgalteriyaBindingSource.EndEdit();
            byhgalteriyaTableAdapter.Update(zayDBDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 af = new Form6();
            af.Owner = this;
            af.Show();
        }
    }  
}
