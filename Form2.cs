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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Spisok_tovarov". При необходимости она может быть перемещена или удалена.
            this.spisok_tovarovTableAdapter.Fill(this.zayDBDataSet.Spisok_tovarov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zayDBDataSet.Sotrudnik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.zayDBDataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Zakupka_tovarov". При необходимости она может быть перемещена или удалена.
            this.zakupka_tovarovTableAdapter.Fill(this.zayDBDataSet.Zakupka_tovarov);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm3 af = new AddForm3();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm3 sf = new SearchForm3();
            sf.Owner = this;
            sf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zakupkatovarovBindingSource.EndEdit();
            zakupka_tovarovTableAdapter.Update(zayDBDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 af = new Form4();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
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
