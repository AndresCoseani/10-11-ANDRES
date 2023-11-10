using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _10_11_ANDRES
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
            Problema p = new Problema();
            Usuario u = p.Buscar(Convert.ToInt32(txtUserID.Text));
            lblNombre.Text = u.UserName;
            LblEdad.Text = u.Edad.ToString();

        }
    }
}
