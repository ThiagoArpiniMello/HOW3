using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cadastrousuario = new Form1();
            cadastrousuario.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cadastrousuario = new Form2();
            cadastrousuario.ShowDialog();
        }
    }
}
