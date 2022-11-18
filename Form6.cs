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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.zayDBDataSet.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet._Doljnost_". При необходимости она может быть перемещена или удалена.
            this.doljnost_TableAdapter.Fill(this.zayDBDataSet._Doljnost_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.zayDBDataSet.Sotrudnik);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddForm6 af = new AddForm6();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm6 sf = new SearchForm6();
            sf.Owner = this;
            sf.Show();
        }

        private void AddBtn2_Click(object sender, EventArgs e)
        {
            AddForm7 af = new AddForm7();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchForm7 sf = new SearchForm7();
            sf.Owner = this;
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doljnostBindingSource.EndEdit();
            doljnost_TableAdapter.Update(zayDBDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sotrudnikBindingSource.EndEdit();
            sotrudnikTableAdapter.Update(zayDBDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.EndEdit();
            postavshikTableAdapter.Update(zayDBDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm8 af = new AddForm8();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form7 af = new Form7();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchForm8 sf = new SearchForm8();
            sf.Owner = this;
            sf.Show();
        }
    }
}
