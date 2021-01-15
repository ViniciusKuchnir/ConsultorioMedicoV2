
namespace ConsultorioMedicoFormulario
{
    partial class F_ExcluirPaciente
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
            this.txbNomePacienteExcluir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpfPacienteExcluir = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txbNomePacienteExcluir
            // 
            this.txbNomePacienteExcluir.Location = new System.Drawing.Point(74, 13);
            this.txbNomePacienteExcluir.Name = "txbNomePacienteExcluir";
            this.txbNomePacienteExcluir.Size = new System.Drawing.Size(331, 20);
            this.txbNomePacienteExcluir.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "CPF :";
            // 
            // mskCpfPacienteExcluir
            // 
            this.mskCpfPacienteExcluir.Location = new System.Drawing.Point(74, 39);
            this.mskCpfPacienteExcluir.Mask = "999.999.999-99";
            this.mskCpfPacienteExcluir.Name = "mskCpfPacienteExcluir";
            this.mskCpfPacienteExcluir.Size = new System.Drawing.Size(86, 20);
            this.mskCpfPacienteExcluir.TabIndex = 11;
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(12, 65);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(393, 35);
            this.btnExcluirPaciente.TabIndex = 12;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.btnExcluirPaciente_Click);
            // 
            // F_ExcluirPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 112);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.mskCpfPacienteExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNomePacienteExcluir);
            this.Controls.Add(this.label1);
            this.Name = "F_ExcluirPaciente";
            this.Text = "Excluir Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomePacienteExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpfPacienteExcluir;
        private System.Windows.Forms.Button btnExcluirPaciente;
    }
}