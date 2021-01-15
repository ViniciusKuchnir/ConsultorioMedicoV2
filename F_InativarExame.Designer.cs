
namespace ConsultorioMedicoFormulario
{
    partial class F_InativarExame
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
            this.mskCodigoExameInativarExame = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpfPacienteInativarExame = new System.Windows.Forms.MaskedTextBox();
            this.btnInativarExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código do Exame:";
            // 
            // mskCodigoExameInativarExame
            // 
            this.mskCodigoExameInativarExame.Location = new System.Drawing.Point(150, 9);
            this.mskCodigoExameInativarExame.Mask = "000000000";
            this.mskCodigoExameInativarExame.Name = "mskCodigoExameInativarExame";
            this.mskCodigoExameInativarExame.Size = new System.Drawing.Size(58, 20);
            this.mskCodigoExameInativarExame.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF do Paciente:";
            // 
            // mskCpfPacienteInativarExame
            // 
            this.mskCpfPacienteInativarExame.Location = new System.Drawing.Point(150, 35);
            this.mskCpfPacienteInativarExame.Mask = "999.999.999-99";
            this.mskCpfPacienteInativarExame.Name = "mskCpfPacienteInativarExame";
            this.mskCpfPacienteInativarExame.Size = new System.Drawing.Size(86, 20);
            this.mskCpfPacienteInativarExame.TabIndex = 13;
            // 
            // btnInativarExame
            // 
            this.btnInativarExame.Location = new System.Drawing.Point(10, 61);
            this.btnInativarExame.Name = "btnInativarExame";
            this.btnInativarExame.Size = new System.Drawing.Size(227, 45);
            this.btnInativarExame.TabIndex = 16;
            this.btnInativarExame.Text = "Inativar Exame";
            this.btnInativarExame.UseVisualStyleBackColor = true;
            this.btnInativarExame.Click += new System.EventHandler(this.btnInativarExame_Click);
            // 
            // F_InativarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 118);
            this.Controls.Add(this.btnInativarExame);
            this.Controls.Add(this.mskCpfPacienteInativarExame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCodigoExameInativarExame);
            this.Controls.Add(this.label1);
            this.Name = "F_InativarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inativar Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoExameInativarExame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpfPacienteInativarExame;
        private System.Windows.Forms.Button btnInativarExame;
    }
}