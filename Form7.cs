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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Naimenovanie_yslygi". При необходимости она может быть перемещена или удалена.
            this.naimenovanie_yslygiTableAdapter.Fill(this.zayDBDataSet.Naimenovanie_yslygi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Dannie_ob_yslyge". При необходимости она может быть перемещена или удалена.
            this.dannie_ob_yslygeTableAdapter.Fill(this.zayDBDataSet.Dannie_ob_yslyge);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet._Posetitel_". При необходимости она может быть перемещена или удалена.
            this.posetitel_TableAdapter.Fill(this.zayDBDataSet._Posetitel_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm9 af = new AddForm9();
            af.Owner = this;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm9 af = new SearchForm9();
            af.Owner = this;
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            posetitelBindingSource.EndEdit();
            posetitel_TableAdapter.Update(zayDBDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddForm12 af = new AddForm12();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddForm9 af = new AddForm9();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchForm11 sf = new SearchForm11();
            sf.Owner = this;
            sf.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 af = new Form9();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SearchForm12 af = new SearchForm12();
            af.Owner = this;
            af.Show();
        }
    }
}
