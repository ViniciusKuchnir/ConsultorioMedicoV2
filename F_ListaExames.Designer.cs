
namespace ConsultorioMedicoFormulario
{
    partial class F_ListaExames
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
            this.dgvListaExames = new System.Windows.Forms.DataGridView();
            this.stsInfoExames = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExames)).BeginInit();
            this.stsInfoExames.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaExames
            // 
            this.dgvListaExames.AllowUserToDeleteRows = false;
            this.dgvListaExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaExames.Location = new System.Drawing.Point(12, 12);
            this.dgvListaExames.Name = "dgvListaExames";
            this.dgvListaExames.ReadOnly = true;
            this.dgvListaExames.Size = new System.Drawing.Size(444, 404);
            this.dgvListaExames.TabIndex = 1;
            this.dgvListaExames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaExames_CellContentClick);
            // 
            // stsInfoExames
            // 
            this.stsInfoExames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsInfoExames.Location = new System.Drawing.Point(0, 428);
            this.stsInfoExames.Name = "stsInfoExames";
            this.stsInfoExames.Size = new System.Drawing.Size(468, 22);
            this.stsInfoExames.TabIndex = 2;
            this.stsInfoExames.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // F_ListaExames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.stsInfoExames);
            this.Controls.Add(this.dgvListaExames);
            this.Name = "F_ListaExames";
            this.Text = "Lista Exames";
            this.Load += new System.EventHandler(this.F_ListaExames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExames)).EndInit();
            this.stsInfoExames.ResumeLayout(false);
            this.stsInfoExames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaExames;
        private System.Windows.Forms.StatusStrip stsInfoExames;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}