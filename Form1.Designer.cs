
namespace ConsultorioMedicoFormulario
{
    partial class Form1
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
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Location = new System.Drawing.Point(12, 12);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(96, 43);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnExame
            // 
            this.btnExame.Location = new System.Drawing.Point(147, 12);
            this.btnExame.Name = "btnExame";
            this.btnExame.Size = new System.Drawing.Size(96, 43);
            this.btnExame.TabIndex = 1;
            this.btnExame.Text = "Exame";
            this.btnExame.UseVisualStyleBackColor = true;
            this.btnExame.Click += new System.EventHandler(this.btnExame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 69);
            this.Controls.Add(this.btnExame);
            this.Controls.Add(this.btnPaciente);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnExame;
    }
}

