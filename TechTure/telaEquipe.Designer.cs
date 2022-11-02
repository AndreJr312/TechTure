
namespace TechTure
{
    partial class telaEquipe
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
            this.painelEquipe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.painelEquipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelEquipe
            // 
            this.painelEquipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.painelEquipe.Controls.Add(this.label1);
            this.painelEquipe.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelEquipe.Location = new System.Drawing.Point(0, 0);
            this.painelEquipe.Name = "painelEquipe";
            this.painelEquipe.Size = new System.Drawing.Size(950, 105);
            this.painelEquipe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "EQUIPE";
            // 
            // telaEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.painelEquipe);
            this.Name = "telaEquipe";
            this.Size = new System.Drawing.Size(950, 753);
            this.painelEquipe.ResumeLayout(false);
            this.painelEquipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelEquipe;
        private System.Windows.Forms.Label label1;
    }
}
