using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form1 : Form
    {
            public static string utilizador = null;
        public Form1()
        {
            InitializeComponent();
        }



        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MostrarMenu(0);
            //DateTime.Now.ToString("HH:mm");
            label1.Text = DateTime.Now.ToString("HH:mm");


        }

        private void registoAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void MostrarMenu (int mostrar)
        {
            if (mostrar == 0)
            {
                menu.Enabled = false;
                toolStripButton1.Enabled = false;
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;
                
            }
            else
            {
                menu.Enabled = true;
                toolStripButton1.Enabled = true;
                toolStripButton2.Enabled = true;
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = true;
                toolStripButton5.Enabled = true;
            }
        }

        public void MostrarLogin(string u)
        {
            if (u != null)
            {
                toolStripLabel1.Text = utilizador;
            }
            else
            {
                toolStripLabel1.Text = "Login";
            }
            MostrarMenu(1);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.MdiParent = this;
            form4.Show();
            //Nao está correto
            toolStripLabel1.Enabled = false;
            button1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Nao está Correto
            toolStripLabel1.Text = "Login";
            button1.Visible = false;
            toolStripLabel1.Enabled = true;
            MostrarMenu(0);

        }
       
    }
}
