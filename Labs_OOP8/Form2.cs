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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Main = this.Owner as Form1;
            Main.dataGridView1.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,dateTimePicker1.Text);
        }
    }
}
