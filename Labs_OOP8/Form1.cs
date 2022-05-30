using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_OOP8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Обновление", "—", "2000000 руб", "250000 руб", "01.01.2020");
            dataGridView1.Rows.Add("Перестройка", "—", "23000000 руб", "2580000 руб", "01.01.2015");
            dataGridView1.Rows.Add("Замена мебели", "—", "200000 руб", "30000 руб", "01.07.2021");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
        }
    }
}
