
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.painelProjetos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaCliente = new System.Windows.Forms.TextBox();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.responsavelCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReuniao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prontoCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.painelProjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCliente
            // 
            this.gridCliente.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
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
            // painelProjetos
            // 
            this.painelProjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.painelProjetos.Controls.Add(this.label1);
            this.painelProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelProjetos.Location = new System.Drawing.Point(0, 0);
            this.painelProjetos.Name = "painelProjetos";
            this.painelProjetos.Size = new System.Drawing.Size(950, 105);
            this.painelProjetos.TabIndex = 1;
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
            // btnVerCliente
            // 
            this.btnVerCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnVerCliente.FlatAppearance.BorderSize = 0;
            this.btnVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerCliente.Location = new System.Drawing.Point(360, 183);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(140, 30);
            this.btnVerCliente.TabIndex = 7;
            this.btnVerCliente.Text = "VISUALIZAR";
            this.btnVerCliente.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(558, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "FILTRAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(759, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "ORDENAR";
            this.button2.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.statusCliente.HeaderText = "ETAPA";
            this.statusCliente.Items.AddRange(new object[] {
            "PLANTA-BAIXA",
            "VOLUMETRIA",
            "COMPATIBILIZAÇÃO",
            "EXECUTIVO",
            "INTERIORES",
            "EXEC. INTERIORES",
            "OBRA"});
            this.statusCliente.MinimumWidth = 6;
            this.statusCliente.Name = "statusCliente";
            this.statusCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.prontoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prontoCliente.HeaderText = "SITUAÇÃO";
            this.prontoCliente.Items.AddRange(new object[] {
            "CONCLUIDO",
            "ANDAMENTO",
            "PAUSADO"});
            this.prontoCliente.MinimumWidth = 6;
            this.prontoCliente.Name = "prontoCliente";
            this.prontoCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.prontoCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.pesquisaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.painelProjetos);
            this.Controls.Add(this.gridCliente);
            this.Name = "menuPrincipal";
            this.Size = new System.Drawing.Size(950, 753);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.painelProjetos.ResumeLayout(false);
            this.painelProjetos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.Panel painelProjetos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pesquisaCliente;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavelCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReuniao;
        private System.Windows.Forms.DataGridViewComboBoxColumn prontoCliente;
    }
}
