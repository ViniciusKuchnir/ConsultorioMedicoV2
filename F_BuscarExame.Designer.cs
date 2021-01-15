
namespace ConsultorioMedicoFormulario
{
    partial class F_BuscarExame
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
            this.mskCodigoBuscarExame = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarExame = new System.Windows.Forms.Button();
            this.dgvResultadoBuscarExame = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBuscarExame)).BeginInit();
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
            // mskCodigoBuscarExame
            // 
            this.mskCodigoBuscarExame.Location = new System.Drawing.Point(156, 9);
            this.mskCodigoBuscarExame.Mask = "000000000";
            this.mskCodigoBuscarExame.Name = "mskCodigoBuscarExame";
            this.mskCodigoBuscarExame.Size = new System.Drawing.Size(63, 20);
            this.mskCodigoBuscarExame.TabIndex = 2;
            // 
            // btnBuscarExame
            // 
            this.btnBuscarExame.Location = new System.Drawing.Point(12, 109);
            this.btnBuscarExame.Name = "btnBuscarExame";
            this.btnBuscarExame.Size = new System.Drawing.Size(444, 39);
            this.btnBuscarExame.TabIndex = 12;
            this.btnBuscarExame.Text = "Buscar Exame";
            this.btnBuscarExame.UseVisualStyleBackColor = true;
            this.btnBuscarExame.Click += new System.EventHandler(this.btnBuscarExame_Click);
            // 
            // dgvResultadoBuscarExame
            // 
            this.dgvResultadoBuscarExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBuscarExame.Location = new System.Drawing.Point(12, 35);
            this.dgvResultadoBuscarExame.Name = "dgvResultadoBuscarExame";
            this.dgvResultadoBuscarExame.Size = new System.Drawing.Size(443, 68);
            this.dgvResultadoBuscarExame.TabIndex = 13;
            // 
            // F_BuscarExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 160);
            this.Controls.Add(this.dgvResultadoBuscarExame);
            this.Controls.Add(this.btnBuscarExame);
            this.Controls.Add(this.mskCodigoBuscarExame);
            this.Controls.Add(this.label1);
            this.Name = "F_BuscarExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Exame";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBuscarExame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskCodigoBuscarExame;
        private System.Windows.Forms.Button btnBuscarExame;
        private System.Windows.Forms.DataGridView dgvResultadoBuscarExame;
    }
}