
namespace TechTure
{
    partial class menuPrincipal
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.menuProjetos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verDadosClientes = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReuniao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prontoCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.menuProjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeCliente,
            this.statusCliente,
            this.responsavelCliente,
            this.dataReuniao,
            this.prontoCliente});
            this.gridCliente.Location = new System.Drawing.Point(59, 235);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.RowHeadersWidth = 51;
            this.gridCliente.RowTemplate.Height = 24;
            this.gridCliente.Size = new System.Drawing.Size(840, 470);
            this.gridCliente.TabIndex = 0;
            // 
            // menuProjetos
            // 
            this.menuProjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.menuProjetos.Controls.Add(this.label1);
            this.menuProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuProjetos.Location = new System.Drawing.Point(0, 0);
            this.menuProjetos.Name = "menuProjetos";
            this.menuProjetos.Size = new System.Drawing.Size(950, 105);
            this.menuProjetos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROJETOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PESQUISAR CLIENTE";
            // 
            // pesquisaCliente
            // 
            this.pesquisaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pesquisaCliente.Location = new System.Drawing.Point(59, 187);
            this.pesquisaCliente.Name = "pesquisaCliente";
            this.pesquisaCliente.Size = new System.Drawing.Size(279, 22);
            this.pesquisaCliente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(590, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "FILTRAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(806, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "ORDENAR";
            // 
            // verDadosClientes
            // 
            this.verDadosClientes.AutoSize = true;
            this.verDadosClientes.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verDadosClientes.Location = new System.Drawing.Point(367, 188);
            this.verDadosClientes.Name = "verDadosClientes";
            this.verDadosClientes.Size = new System.Drawing.Size(105, 21);
            this.verDadosClientes.TabIndex = 6;
            this.verDadosClientes.Text = "VISUALIZAR";
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCliente.HeaderText = "CLIENTE";
            this.nomeCliente.MinimumWidth = 6;
            this.nomeCliente.Name = "nomeCliente";
            // 
            // statusCliente
            // 
            this.statusCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCliente.HeaderText = "ETAPA";
            this.statusCliente.MinimumWidth = 6;
            this.statusCliente.Name = "statusCliente";
            // 
            // responsavelCliente
            // 
            this.responsavelCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responsavelCliente.HeaderText = "RESPONSÁVEL";
            this.responsavelCliente.MinimumWidth = 6;
            this.responsavelCliente.Name = "responsavelCliente";
            // 
            // dataReuniao
            // 
            this.dataReuniao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataReuniao.HeaderText = "PRÓX. REUNIÃO";
            this.dataReuniao.MinimumWidth = 6;
            this.dataReuniao.Name = "dataReuniao";
            // 
            // prontoCliente
            // 
            this.prontoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prontoCliente.HeaderText = "SITUAÇÃO";
            this.prontoCliente.MinimumWidth = 6;
            this.prontoCliente.Name = "prontoCliente";
            this.prontoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prontoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.verDadosClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pesquisaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuProjetos);
            this.Controls.Add(this.gridCliente);
            this.Name = "menuPrincipal";
            this.Size = new System.Drawing.Size(950, 753);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.menuProjetos.ResumeLayout(false);
            this.menuProjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Panel menuProjetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pesquisaCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label verDadosClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReuniao;
        private System.Windows.Forms.DataGridViewComboBoxColumn prontoCliente;
    }
}
