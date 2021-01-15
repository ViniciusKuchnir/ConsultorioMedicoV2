
namespace ConsultorioMedicoFormulario
{
    partial class F_AtualizarCodigoExame
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
            this.label1 = new System.Windows.Forms.Label();
            this.mskCodigoAtualAtualizarExame = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskNovoCodigoAtualizarExame = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizarCodigoExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atual Código:";
            // 
            // mskCodigoAtualAtualizarExame
            // 
            this.mskCodigoAtualAtualizarExame.Location = new System.Drawing.Point(122, 9);
            this.mskCodigoAtualAtualizarExame.Mask = "000000000";
            this.mskCodigoAtualAtualizarExame.Name = "mskCodigoAtualAtualizarExame";
            this.mskCodigoAtualAtualizarExame.Size = new System.Drawing.Size(70, 20);
            this.mskCodigoAtualAtualizarExame.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Novo Código:";
            // 
            // mskNovoCodigoAtualizarExame
            // 
            this.mskNovoCodigoAtualizarExame.Location = new System.Drawing.Point(122, 35);
            this.mskNovoCodigoAtualizarExame.Mask = "000000000";
            this.mskNovoCodigoAtualizarExame.Name = "mskNovoCodigoAtualizarExame";
            this.mskNovoCodigoAtualizarExame.Size = new System.Drawing.Size(70, 20);
            this.mskNovoCodigoAtualizarExame.TabIndex = 4;
            // 
            // btnAtualizarCodigoExame
            // 
            this.btnAtualizarCodigoExame.Location = new System.Drawing.Point(12, 61);
            this.btnAtualizarCodigoExame.Name = "btnAtualizarCodigoExame";
            this.btnAtualizarCodigoExame.Size = new System.Drawing.Size(180, 41);
            this.btnAtualizarCodigoExame.TabIndex = 13;
            this.btnAtualizarCodigoExame.Text = "Atualizar Código";
            this.btnAtualizarCodigoExame.UseVisualStyleBackColor = true;
            this.btnAtualizarCodigoExame.Click += new System.EventHandler(this.btnAtualizarCodigoExame_Click);
            // 
            // F_AtualizarCodigoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 114);
            this.Controls.Add(this.btnAtualizarCodigoExame);
            this.Controls.Add(this.mskNovoCodigoAtualizarExame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCodigoAtualAtualizarExame);
            this.Controls.Add(this.label1);
            this.Name = "F_AtualizarCodigoExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Codigo";
            this.Load += new System.EventHandler(this.F_AtualizarCodigoExame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoAtualAtualizarExame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskNovoCodigoAtualizarExame;
        private System.Windows.Forms.Button btnAtualizarCodigoExame;
    }
}