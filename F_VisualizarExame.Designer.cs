
namespace ConsultorioMedicoFormulario
{
    partial class F_VisualizarExame
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
            this.mskCodigoVisualizacaoExame = new System.Windows.Forms.MaskedTextBox();
            this.btnVisualizarExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código do Exame:";
            // 
            // mskCodigoVisualizacaoExame
            // 
            this.mskCodigoVisualizacaoExame.Location = new System.Drawing.Point(156, 9);
            this.mskCodigoVisualizacaoExame.Mask = "000000000";
            this.mskCodigoVisualizacaoExame.Name = "mskCodigoVisualizacaoExame";
            this.mskCodigoVisualizacaoExame.Size = new System.Drawing.Size(64, 20);
            this.mskCodigoVisualizacaoExame.TabIndex = 2;
            // 
            // btnVisualizarExame
            // 
            this.btnVisualizarExame.Location = new System.Drawing.Point(12, 35);
            this.btnVisualizarExame.Name = "btnVisualizarExame";
            this.btnVisualizarExame.Size = new System.Drawing.Size(208, 41);
            this.btnVisualizarExame.TabIndex = 13;
            this.btnVisualizarExame.Text = "Visualizar Exame";
            this.btnVisualizarExame.UseVisualStyleBackColor = true;
            this.btnVisualizarExame.Click += new System.EventHandler(this.btnVisualizarExame_Click);
            // 
            // F_VisualizarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 88);
            this.Controls.Add(this.btnVisualizarExame);
            this.Controls.Add(this.mskCodigoVisualizacaoExame);
            this.Controls.Add(this.label1);
            this.Name = "F_VisualizarExame";
            this.Text = "Visualizar Exame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoVisualizacaoExame;
        private System.Windows.Forms.Button btnVisualizarExame;
    }
}