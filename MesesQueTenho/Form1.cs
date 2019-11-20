
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesesQueTenho
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

        Meses rui = new Meses();
        private void Button1_Click_1(object sender, EventArgs e)
        {
            rui.recebe = textBox1.Text;
            label2.Text = rui.envia;
        }
    }
}