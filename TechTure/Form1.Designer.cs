
namespace TechTure
{
    partial class MenuPrincipall
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipall));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnCLientes = new System.Windows.Forms.Button();
            this.btnProjetos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telaEquipe1 = new TechTure.telaEquipe();
            this.infosCliente1 = new TechTure.infosCliente();
            this.menuPrincipal1 = new TechTure.menuPrincipal();
            this.telaInicial1 = new TechTure.TelaInicial();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnOpcoes);
            this.panel1.Controls.Add(this.btnTarefas);
            this.panel1.Controls.Add(this.btnContatos);
            this.panel1.Controls.Add(this.btnServicos);
            this.panel1.Controls.Add(this.btnCLientes);
            this.panel1.Controls.Add(this.btnProjetos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 723);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(0, 555);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(250, 75);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuário Logado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(11, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "André";
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.ForeColor = System.Drawing.Color.White;
            this.btnOpcoes.Location = new System.Drawing.Point(0, 480);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(250, 75);
            this.btnOpcoes.TabIndex = 6;
            this.btnOpcoes.Text = "OPÇÕES";
            this.btnOpcoes.UseVisualStyleBackColor = true;
            // 
            // btnTarefas
            // 
            this.btnTarefas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Location = new System.Drawing.Point(0, 405);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(250, 75);
            this.btnTarefas.TabIndex = 5;
            this.btnTarefas.Text = "TAREFAS";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.ForeColor = System.Drawing.Color.White;
            this.btnContatos.Location = new System.Drawing.Point(0, 330);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(250, 75);
            this.btnContatos.TabIndex = 4;
            this.btnContatos.Text = "FORNECEDORES";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.White;
            this.btnServicos.Location = new System.Drawing.Point(0, 255);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(250, 75);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "SERVIÇOS";
            this.btnServicos.UseVisualStyleBackColor = true;
            // 
            // btnCLientes
            // 
            this.btnCLientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCLientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLientes.ForeColor = System.Drawing.Color.White;
            this.btnCLientes.Location = new System.Drawing.Point(0, 180);
            this.btnCLientes.Name = "btnCLientes";
            this.btnCLientes.Size = new System.Drawing.Size(250, 75);
            this.btnCLientes.TabIndex = 2;
            this.btnCLientes.Text = "CLIENTES";
            this.btnCLientes.UseVisualStyleBackColor = true;
            this.btnCLientes.Click += new System.EventHandler(this.btnCLientes_Click);
            // 
            // btnProjetos
            // 
            this.btnProjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnProjetos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjetos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetos.ForeColor = System.Drawing.Color.White;
            this.btnProjetos.Location = new System.Drawing.Point(0, 105);
            this.btnProjetos.Name = "btnProjetos";
            this.btnProjetos.Size = new System.Drawing.Size(250, 75);
            this.btnProjetos.TabIndex = 1;
            this.btnProjetos.Text = "PROJETOS";
            this.btnProjetos.UseVisualStyleBackColor = false;
            this.btnProjetos.Click += new System.EventHandler(this.btnProjetos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // telaEquipe1
            // 
            this.telaEquipe1.AutoSize = true;
            this.telaEquipe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaEquipe1.Location = new System.Drawing.Point(250, 0);
            this.telaEquipe1.Name = "telaEquipe1";
            this.telaEquipe1.Size = new System.Drawing.Size(932, 723);
            this.telaEquipe1.TabIndex = 4;
            // 
            // infosCliente1
            // 
            this.infosCliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infosCliente1.Location = new System.Drawing.Point(250, 0);
            this.infosCliente1.Name = "infosCliente1";
            this.infosCliente1.Size = new System.Drawing.Size(932, 723);
            this.infosCliente1.TabIndex = 3;
            // 
            // menuPrincipal1
            // 
            this.menuPrincipal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPrincipal1.Location = new System.Drawing.Point(250, 0);
            this.menuPrincipal1.Name = "menuPrincipal1";
            this.menuPrincipal1.Size = new System.Drawing.Size(932, 723);
            this.menuPrincipal1.TabIndex = 2;
            // 
            // telaInicial1
            // 
            this.telaInicial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telaInicial1.Location = new System.Drawing.Point(250, 0);
            this.telaInicial1.Name = "telaInicial1";
            this.telaInicial1.Size = new System.Drawing.Size(932, 723);
            this.telaInicial1.TabIndex = 1;
            // 
            // MenuPrincipall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1182, 723);
            this.Controls.Add(this.telaEquipe1);
            this.Controls.Add(this.infosCliente1);
            this.Controls.Add(this.menuPrincipal1);
            this.Controls.Add(this.telaInicial1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechTure";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnCLientes;
        private System.Windows.Forms.Button btnProjetos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TelaInicial telaInicial1;
        private menuPrincipal menuPrincipal1;
        private System.Windows.Forms.Button btnSair;
        private infosCliente infosCliente1;
        private telaEquipe telaEquipe1;
    }
}

