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
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos Login e Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtLogin.Text == "andre" && txtSenha.Text == "12345")
            {
                MenuPrincipall menu = new MenuPrincipall();
                menu.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }

        }
    }
}
