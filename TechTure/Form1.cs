using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechTure
{
    public partial class MenuPrincipall : Form
    {
        public MenuPrincipall()
        {
            InitializeComponent();
            telaInicial1.BringToFront();
        }

        private void btnProjetos_Click(object sender, EventArgs e)
        {
            menuPrincipal1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
