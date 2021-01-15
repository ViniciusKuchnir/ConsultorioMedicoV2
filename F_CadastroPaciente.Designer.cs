
namespace ConsultorioMedicoFormulario
{
    partial class F_CadastroPaciente
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
            this.txtNomeCadastroPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskIdadeCadastroPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskPesoCadastroPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskAlturaCadastroPaciente = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfCadastroPaciente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // txtNomeCadastroPaciente
            // 
            this.txtNomeCadastroPaciente.Location = new System.Drawing.Point(77, 9);
            this.txtNomeCadastroPaciente.Name = "txtNomeCadastroPaciente";
            this.txtNomeCadastroPaciente.Size = new System.Drawing.Size(330, 20);
            this.txtNomeCadastroPaciente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Idade :";
            // 
            // mskIdadeCadastroPaciente
            // 
            this.mskIdadeCadastroPaciente.Location = new System.Drawing.Point(76, 35);
            this.mskIdadeCadastroPaciente.Mask = "099";
            this.mskIdadeCadastroPaciente.Name = "mskIdadeCadastroPaciente";
            this.mskIdadeCadastroPaciente.Size = new System.Drawing.Size(29, 20);
            this.mskIdadeCadastroPaciente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso :";
            // 
            // mskPesoCadastroPaciente
            // 
            this.mskPesoCadastroPaciente.Location = new System.Drawing.Point(77, 61);
            this.mskPesoCadastroPaciente.Mask = "09.9";
            this.mskPesoCadastroPaciente.Name = "mskPesoCadastroPaciente";
            this.mskPesoCadastroPaciente.Size = new System.Drawing.Size(39, 20);
            this.mskPesoCadastroPaciente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Altura :";
            // 
            // mskAlturaCadastroPaciente
            // 
            this.mskAlturaCadastroPaciente.Location = new System.Drawing.Point(76, 87);
            this.mskAlturaCadastroPaciente.Mask = "9.99";
            this.mskAlturaCadastroPaciente.Name = "mskAlturaCadastroPaciente";
            this.mskAlturaCadastroPaciente.Size = new System.Drawing.Size(39, 20);
            this.mskAlturaCadastroPaciente.TabIndex = 7;
            // 
            // mskCpfCadastroPaciente
            // 
            this.mskCpfCadastroPaciente.Location = new System.Drawing.Point(76, 113);
            this.mskCpfCadastroPaciente.Mask = "999.999.999-99";
            this.mskCpfCadastroPaciente.Name = "mskCpfCadastroPaciente";
            this.mskCpfCadastroPaciente.Size = new System.Drawing.Size(86, 20);
            this.mskCpfCadastroPaciente.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF :";
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(12, 139);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(387, 35);
            this.btnCadastrarPaciente.TabIndex = 10;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click_1);
            // 
            // F_CadastroPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 186);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskCpfCadastroPaciente);
            this.Controls.Add(this.mskAlturaCadastroPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskPesoCadastroPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskIdadeCadastroPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCadastroPaciente);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_CadastroPaciente";
            this.Text = "Cadastrar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCadastroPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskIdadeCadastroPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskPesoCadastroPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskAlturaCadastroPaciente;
        private System.Windows.Forms.MaskedTextBox mskCpfCadastroPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarPaciente;
    }
}