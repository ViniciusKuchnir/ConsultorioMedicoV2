
namespace ConsultorioMedicoFormulario
{
    partial class F_AtualizarNomeExame
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbNomeAtualAtualizarExame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNovoNomeAtualizarExame = new System.Windows.Forms.TextBox();
            this.btnAtualizarNomeExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atual Nome do Paciente:";
            // 
            // txbNomeAtualAtualizarExame
            // 
            this.txbNomeAtualAtualizarExame.Location = new System.Drawing.Point(202, 9);
            this.txbNomeAtualAtualizarExame.Name = "txbNomeAtualAtualizarExame";
            this.txbNomeAtualAtualizarExame.Size = new System.Drawing.Size(262, 20);
            this.txbNomeAtualAtualizarExame.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Novo Nome do Paciente:";
            // 
            // txbNovoNomeAtualizarExame
            // 
            this.txbNovoNomeAtualizarExame.Location = new System.Drawing.Point(202, 35);
            this.txbNovoNomeAtualizarExame.Name = "txbNovoNomeAtualizarExame";
            this.txbNovoNomeAtualizarExame.Size = new System.Drawing.Size(262, 20);
            this.txbNovoNomeAtualizarExame.TabIndex = 6;
            // 
            // btnAtualizarNomeExame
            // 
            this.btnAtualizarNomeExame.Location = new System.Drawing.Point(12, 61);
            this.btnAtualizarNomeExame.Name = "btnAtualizarNomeExame";
            this.btnAtualizarNomeExame.Size = new System.Drawing.Size(452, 40);
            this.btnAtualizarNomeExame.TabIndex = 12;
            this.btnAtualizarNomeExame.Text = "Atualizar Nome";
            this.btnAtualizarNomeExame.UseVisualStyleBackColor = true;
            this.btnAtualizarNomeExame.Click += new System.EventHandler(this.btnAtualizarNomeExame_Click);
            // 
            // F_AtualizarNomeExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 113);
            this.Controls.Add(this.btnAtualizarNomeExame);
            this.Controls.Add(this.txbNovoNomeAtualizarExame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNomeAtualAtualizarExame);
            this.Controls.Add(this.label2);
            this.Name = "F_AtualizarNomeExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeAtualAtualizarExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNovoNomeAtualizarExame;
        private System.Windows.Forms.Button btnAtualizarNomeExame;
    }
}