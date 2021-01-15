
namespace ConsultorioMedicoFormulario
{
    partial class F_CadastroExame
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
            this.txbNomeCadastroExame = new System.Windows.Forms.TextBox();
            this.mskCpfCadastroExame = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarExame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCodigoCadastroExame = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Paciente:";
            // 
            // txbNomeCadastroExame
            // 
            this.txbNomeCadastroExame.Location = new System.Drawing.Point(139, 9);
            this.txbNomeCadastroExame.Name = "txbNomeCadastroExame";
            this.txbNomeCadastroExame.Size = new System.Drawing.Size(259, 20);
            this.txbNomeCadastroExame.TabIndex = 3;
            // 
            // mskCpfCadastroExame
            // 
            this.mskCpfCadastroExame.Location = new System.Drawing.Point(139, 35);
            this.mskCpfCadastroExame.Mask = "999.999.999-99";
            this.mskCpfCadastroExame.Name = "mskCpfCadastroExame";
            this.mskCpfCadastroExame.Size = new System.Drawing.Size(86, 20);
            this.mskCpfCadastroExame.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF :";
            // 
            // btnCadastrarExame
            // 
            this.btnCadastrarExame.Location = new System.Drawing.Point(12, 89);
            this.btnCadastrarExame.Name = "btnCadastrarExame";
            this.btnCadastrarExame.Size = new System.Drawing.Size(390, 38);
            this.btnCadastrarExame.TabIndex = 11;
            this.btnCadastrarExame.Text = "Cadastrar Exame";
            this.btnCadastrarExame.UseVisualStyleBackColor = true;
            this.btnCadastrarExame.Click += new System.EventHandler(this.btnCadastrarExame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // mskCodigoCadastroExame
            // 
            this.mskCodigoCadastroExame.Location = new System.Drawing.Point(139, 63);
            this.mskCodigoCadastroExame.Mask = "000000000";
            this.mskCodigoCadastroExame.Name = "mskCodigoCadastroExame";
            this.mskCodigoCadastroExame.Size = new System.Drawing.Size(63, 20);
            this.mskCodigoCadastroExame.TabIndex = 1;
            // 
            // F_CadastroExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 139);
            this.Controls.Add(this.btnCadastrarExame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCpfCadastroExame);
            this.Controls.Add(this.txbNomeCadastroExame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskCodigoCadastroExame);
            this.Controls.Add(this.label1);
            this.Name = "F_CadastroExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNomeCadastroExame;
        private System.Windows.Forms.MaskedTextBox mskCpfCadastroExame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoCadastroExame;
    }
}