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

        private void btnCLientes_Click(object sender, EventArgs e)
        {
            infosCliente1.BringToFront();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            telaEquipe1.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            telaInicial1.BringToFront();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            telaFornecedores1.BringToFront();
        }
    }
}
