
namespace ConsultorioMedicoFormulario
{
    partial class F_AtualizarExame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAtualizarNomeExame = new System.Windows.Forms.Button();
            this.btnAtualizarCodigoExame = new System.Windows.Forms.Button();
            this.btnAtualizarCpfExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtualizarNomeExame
            // 
            this.btnAtualizarNomeExame.Location = new System.Drawing.Point(12, 10);
            this.btnAtualizarNomeExame.Name = "btnAtualizarNomeExame";
            this.btnAtualizarNomeExame.Size = new System.Drawing.Size(105, 43);
            this.btnAtualizarNomeExame.TabIndex = 5;
            this.btnAtualizarNomeExame.Text = "Atualizar Nome";
            this.btnAtualizarNomeExame.UseVisualStyleBackColor = true;
            this.btnAtualizarNomeExame.Click += new System.EventHandler(this.btnAtualizarNomeExame_Click);
            // 
            // btnAtualizarCodigoExame
            // 
            this.btnAtualizarCodigoExame.Location = new System.Drawing.Point(123, 10);
            this.btnAtualizarCodigoExame.Name = "btnAtualizarCodigoExame";
            this.btnAtualizarCodigoExame.Size = new System.Drawing.Size(105, 43);
            this.btnAtualizarCodigoExame.TabIndex = 6;
            this.btnAtualizarCodigoExame.Text = "Atualizar Código";
            this.btnAtualizarCodigoExame.UseVisualStyleBackColor = true;
            this.btnAtualizarCodigoExame.Click += new System.EventHandler(this.btnAtualizarCodigoExame_Click);
            // 
            // btnAtualizarCpfExame
            // 
            this.btnAtualizarCpfExame.Location = new System.Drawing.Point(234, 10);
            this.btnAtualizarCpfExame.Name = "btnAtualizarCpfExame";
            this.btnAtualizarCpfExame.Size = new System.Drawing.Size(105, 43);
            this.btnAtualizarCpfExame.TabIndex = 7;
            this.btnAtualizarCpfExame.Text = "Atualizar CPF";
            this.btnAtualizarCpfExame.UseVisualStyleBackColor = true;
            this.btnAtualizarCpfExame.Click += new System.EventHandler(this.btnAtualizarCpfExame_Click);
            // 
            // F_AtualizarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 65);
            this.Controls.Add(this.btnAtualizarCpfExame);
            this.Controls.Add(this.btnAtualizarCodigoExame);
            this.Controls.Add(this.btnAtualizarNomeExame);
            this.Name = "F_AtualizarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Exame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarNomeExame;
        private System.Windows.Forms.Button btnAtualizarCodigoExame;
        private System.Windows.Forms.Button btnAtualizarCpfExame;
    }
}