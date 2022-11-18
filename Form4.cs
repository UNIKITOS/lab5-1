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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet._Posetitel_". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet._Posetitel_". При необходимости она может быть перемещена или удалена.


            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Dannie_ob_yslyge". При необходимости она может быть перемещена или удалена.
            this.dannie_ob_yslygeTableAdapter.Fill(this.zayDBDataSet.Dannie_ob_yslyge);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zayDBDataSet.Priobretenie_yslygi". При необходимости она может быть перемещена или удалена.
            this.priobretenie_yslygiTableAdapter.Fill(this.zayDBDataSet.Priobretenie_yslygi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm4 af = new AddForm4();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm4 sf = new SearchForm4();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            priobretenieYslygiBindingSource.EndEdit();
            priobretenie_yslygiTableAdapter.Update(zayDBDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
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
