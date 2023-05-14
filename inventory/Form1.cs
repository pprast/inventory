using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.content.Controls.Clear();
            Form2 Form2_Vrb = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.content.Controls.Add(Form2_Vrb);
            Form2_Vrb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.content.Controls.Clear();
            Form3 Form3_Vrb = new Form3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.content.Controls.Add(Form3_Vrb);
            Form3_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.content.Controls.Clear();
            Form4 Form4_Vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.content.Controls.Add(Form4_Vrb);
            Form4_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.content.Controls.Clear();
            Form4 Form4_Vrb = new Form4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.content.Controls.Add(Form4_Vrb);
            Form4_Vrb.Show();
        }
    }
}
