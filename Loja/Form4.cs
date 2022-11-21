using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label2.Visible = true;
                return;
            }
            else
            {
                label2.Visible = false;
            }

            if (textBox3.Text == "")
            {
                label5.Visible = true;
                return;
            }
            else 
            {
                label5.Visible = false;
            }
            Form1.utilizador = textBox2.Text;
            Form1 pobjFrom = (Form1)this.MdiParent;
            pobjFrom.MostrarLogin(Form1.utilizador);
            
            this.Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
