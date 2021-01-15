
namespace ConsultorioMedicoFormulario
{
    partial class F_Pacientes
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
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(105, 43);
            this.btnCadastrarPaciente.TabIndex = 1;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.Location = new System.Drawing.Point(123, 12);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(105, 43);
            this.btnListarPacientes.TabIndex = 2;
            this.btnListarPacientes.Text = "Listar Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = true;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(66, 61);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(105, 43);
            this.btnExcluirPaciente.TabIndex = 3;
            this.btnExcluirPaciente.Text = "Excluir Pacientes";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            this.btnExcluirPaciente.Click += new System.EventHandler(this.btnExcluirPaciente_Click);
            // 
            // F_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 116);
            this.Controls.Add(this.btnExcluirPaciente);
            this.Controls.Add(this.btnListarPacientes);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.MaximizeBox = false;
            this.Name = "F_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Button btnListarPacientes;
        private System.Windows.Forms.Button btnExcluirPaciente;
    }
}