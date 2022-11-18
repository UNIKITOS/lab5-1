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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.zayDBDataSet.Brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.zayDBDataSet.Tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Tip". При необходимости она может быть перемещена или удалена.
            this.tipTableAdapter.Fill(this.zayDBDataSet.Tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Spisok_tovarov". При необходимости она может быть перемещена или удалена.
            this.spisok_tovarovTableAdapter.Fill(this.zayDBDataSet.Spisok_tovarov);

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm13 af = new AddForm13();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm13 af = new SearchForm13();
            af.Owner = this;
            af.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddForm14 af = new AddForm14();
            af.Owner = this;
            af.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SearchForm14 af = new SearchForm14();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchForm16 af = new SearchForm16();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddForm15 af = new AddForm15();
            af.Owner = this;
            af.Show();
        }
    }
}
