
namespace ConsultorioMedicoFormulario
{
    partial class F_ListaExamesInativos
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
            this.dgvExamesInativos = new System.Windows.Forms.DataGridView();
            this.btnAtivarExameListaExameInativos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesInativos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamesInativos
            // 
            this.dgvExamesInativos.AllowUserToDeleteRows = false;
            this.dgvExamesInativos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamesInativos.Location = new System.Drawing.Point(12, 12);
            this.dgvExamesInativos.Name = "dgvExamesInativos";
            this.dgvExamesInativos.ReadOnly = true;
            this.dgvExamesInativos.Size = new System.Drawing.Size(443, 366);
            this.dgvExamesInativos.TabIndex = 1;
            // 
            // btnAtivarExameListaExameInativos
            // 
            this.btnAtivarExameListaExameInativos.Location = new System.Drawing.Point(12, 384);
            this.btnAtivarExameListaExameInativos.Name = "btnAtivarExameListaExameInativos";
            this.btnAtivarExameListaExameInativos.Size = new System.Drawing.Size(443, 40);
            this.btnAtivarExameListaExameInativos.TabIndex = 11;
            this.btnAtivarExameListaExameInativos.Text = "Ativar Exame";
            this.btnAtivarExameListaExameInativos.UseVisualStyleBackColor = true;
            this.btnAtivarExameListaExameInativos.Click += new System.EventHandler(this.btnAtivarExameListaExameInativos_Click);
            // 
            // F_ListaExamesInativos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 436);
            this.Controls.Add(this.btnAtivarExameListaExameInativos);
            this.Controls.Add(this.dgvExamesInativos);
            this.Name = "F_ListaExamesInativos";
            this.Text = "Lista Exames Inativos";
            this.Load += new System.EventHandler(this.F_ListaExamesInativos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamesInativos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamesInativos;
        private System.Windows.Forms.Button btnAtivarExameListaExameInativos;
    }
}