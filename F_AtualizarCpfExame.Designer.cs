
namespace ConsultorioMedicoFormulario
{
    partial class F_AtualizarCpfExame
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
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpfAtualAtualizarExame = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskNovoCpfAtualizarExame = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizarCpfExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = " Atual CPF:";
            // 
            // mskCpfAtualAtualizarExame
            // 
            this.mskCpfAtualAtualizarExame.Location = new System.Drawing.Point(103, 12);
            this.mskCpfAtualAtualizarExame.Mask = "999.999.999-99";
            this.mskCpfAtualAtualizarExame.Name = "mskCpfAtualAtualizarExame";
            this.mskCpfAtualAtualizarExame.Size = new System.Drawing.Size(86, 20);
            this.mskCpfAtualAtualizarExame.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Novo CPF:";
            // 
            // mskNovoCpfAtualizarExame
            // 
            this.mskNovoCpfAtualizarExame.Location = new System.Drawing.Point(103, 38);
            this.mskNovoCpfAtualizarExame.Mask = "999.999.999-99";
            this.mskNovoCpfAtualizarExame.Name = "mskNovoCpfAtualizarExame";
            this.mskNovoCpfAtualizarExame.Size = new System.Drawing.Size(86, 20);
            this.mskNovoCpfAtualizarExame.TabIndex = 14;
            // 
            // btnAtualizarCpfExame
            // 
            this.btnAtualizarCpfExame.Location = new System.Drawing.Point(12, 64);
            this.btnAtualizarCpfExame.Name = "btnAtualizarCpfExame";
            this.btnAtualizarCpfExame.Size = new System.Drawing.Size(177, 42);
            this.btnAtualizarCpfExame.TabIndex = 15;
            this.btnAtualizarCpfExame.Text = "Atualizar CPF";
            this.btnAtualizarCpfExame.UseVisualStyleBackColor = true;
            this.btnAtualizarCpfExame.Click += new System.EventHandler(this.btnAtualizarCpfExame_Click);
            // 
            // F_AtualizarCpfExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 118);
            this.Controls.Add(this.btnAtualizarCpfExame);
            this.Controls.Add(this.mskNovoCpfAtualizarExame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCpfAtualAtualizarExame);
            this.Controls.Add(this.label5);
            this.Name = "F_AtualizarCpfExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpfAtualAtualizarExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNovoCpfAtualizarExame;
        private System.Windows.Forms.Button btnAtualizarCpfExame;
    }
}