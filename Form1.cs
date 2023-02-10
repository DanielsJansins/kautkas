using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

                int textbook1 = int.Parse(textbox1.Text);
                int textbook2 = int.Parse(textbox2.Text);
                int textbook3 = int.Parse(textbox3.Text);

                int sum = textbook1 + textbook2 + textbook3;

                MessageBox.Show("Kopējā summa ir: " + sum);
            }

        }

    }
}
