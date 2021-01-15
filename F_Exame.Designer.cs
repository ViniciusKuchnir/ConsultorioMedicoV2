
namespace ConsultorioMedicoFormulario
{
    partial class F_Exame
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
            this.btnCadastrarExame = new System.Windows.Forms.Button();
            this.btnBuscarExame = new System.Windows.Forms.Button();
            this.btnVisualizarExame = new System.Windows.Forms.Button();
            this.btnAtualizarExame = new System.Windows.Forms.Button();
            this.btnListarExames = new System.Windows.Forms.Button();
            this.btnListarExamesInativos = new System.Windows.Forms.Button();
            this.btnInativarExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarExame
            // 
            this.btnCadastrarExame.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarExame.Name = "btnCadastrarExame";
            this.btnCadastrarExame.Size = new System.Drawing.Size(105, 43);
            this.btnCadastrarExame.TabIndex = 2;
            this.btnCadastrarExame.Text = "Cadastrar Exame";
            this.btnCadastrarExame.UseVisualStyleBackColor = true;
            this.btnCadastrarExame.Click += new System.EventHandler(this.btnCadastrarExame_Click);
            // 
            // btnBuscarExame
            // 
            this.btnBuscarExame.Location = new System.Drawing.Point(123, 12);
            this.btnBuscarExame.Name = "btnBuscarExame";
            this.btnBuscarExame.Size = new System.Drawing.Size(105, 43);
            this.btnBuscarExame.TabIndex = 3;
            this.btnBuscarExame.Text = "Buscar Exame";
            this.btnBuscarExame.UseVisualStyleBackColor = true;
            this.btnBuscarExame.Click += new System.EventHandler(this.btnBuscarExame_Click);
            // 
            // btnVisualizarExame
            // 
            this.btnVisualizarExame.Location = new System.Drawing.Point(234, 12);
            this.btnVisualizarExame.Name = "btnVisualizarExame";
            this.btnVisualizarExame.Size = new System.Drawing.Size(105, 43);
            this.btnVisualizarExame.TabIndex = 4;
            this.btnVisualizarExame.Text = "Visualizar Exame";
            this.btnVisualizarExame.UseVisualStyleBackColor = true;
            this.btnVisualizarExame.Click += new System.EventHandler(this.btnVisualizarExame_Click);
            // 
            // btnAtualizarExame
            // 
            this.btnAtualizarExame.Location = new System.Drawing.Point(12, 61);
            this.btnAtualizarExame.Name = "btnAtualizarExame";
            this.btnAtualizarExame.Size = new System.Drawing.Size(105, 43);
            this.btnAtualizarExame.TabIndex = 5;
            this.btnAtualizarExame.Text = "Atualizar Exame";
            this.btnAtualizarExame.UseVisualStyleBackColor = true;
            this.btnAtualizarExame.Click += new System.EventHandler(this.btnAtualizarExame_Click);
            // 
            // btnListarExames
            // 
            this.btnListarExames.Location = new System.Drawing.Point(123, 61);
            this.btnListarExames.Name = "btnListarExames";
            this.btnListarExames.Size = new System.Drawing.Size(105, 43);
            this.btnListarExames.TabIndex = 6;
            this.btnListarExames.Text = "Listar Exames";
            this.btnListarExames.UseVisualStyleBackColor = true;
            this.btnListarExames.Click += new System.EventHandler(this.btnListarExames_Click);
            // 
            // btnListarExamesInativos
            // 
            this.btnListarExamesInativos.Location = new System.Drawing.Point(234, 61);
            this.btnListarExamesInativos.Name = "btnListarExamesInativos";
            this.btnListarExamesInativos.Size = new System.Drawing.Size(105, 43);
            this.btnListarExamesInativos.TabIndex = 7;
            this.btnListarExamesInativos.Text = "Listar Exames Inativos";
            this.btnListarExamesInativos.UseVisualStyleBackColor = true;
            this.btnListarExamesInativos.Click += new System.EventHandler(this.btnListarExamesInativos_Click);
            // 
            // btnInativarExame
            // 
            this.btnInativarExame.Location = new System.Drawing.Point(123, 110);
            this.btnInativarExame.Name = "btnInativarExame";
            this.btnInativarExame.Size = new System.Drawing.Size(105, 43);
            this.btnInativarExame.TabIndex = 8;
            this.btnInativarExame.Text = "Inativar Exame";
            this.btnInativarExame.UseVisualStyleBackColor = true;
            this.btnInativarExame.Click += new System.EventHandler(this.btnInativarExame_Click);
            // 
            // F_Exame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 160);
            this.Controls.Add(this.btnInativarExame);
            this.Controls.Add(this.btnListarExamesInativos);
            this.Controls.Add(this.btnListarExames);
            this.Controls.Add(this.btnAtualizarExame);
            this.Controls.Add(this.btnVisualizarExame);
            this.Controls.Add(this.btnBuscarExame);
            this.Controls.Add(this.btnCadastrarExame);
            this.MaximizeBox = false;
            this.Name = "F_Exame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarExame;
        private System.Windows.Forms.Button btnBuscarExame;
        private System.Windows.Forms.Button btnVisualizarExame;
        private System.Windows.Forms.Button btnAtualizarExame;
        private System.Windows.Forms.Button btnListarExames;
        private System.Windows.Forms.Button btnListarExamesInativos;
        private System.Windows.Forms.Button btnInativarExame;
    }
}