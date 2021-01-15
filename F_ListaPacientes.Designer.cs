
namespace ConsultorioMedicoFormulario
{
    partial class F_ListaPacientes
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
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.stsInfoPacientes = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            this.stsInfoPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.AllowUserToAddRows = false;
            this.dgvListaPacientes.AllowUserToDeleteRows = false;
            this.dgvListaPacientes.AllowUserToOrderColumns = true;
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListaPacientes.MultiSelect = false;
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.ReadOnly = true;
            this.dgvListaPacientes.Size = new System.Drawing.Size(641, 426);
            this.dgvListaPacientes.TabIndex = 0;
            this.dgvListaPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPacientes_CellContentClick);
            // 
            // stsInfoPacientes
            // 
            this.stsInfoPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsInfoPacientes.Location = new System.Drawing.Point(0, 451);
            this.stsInfoPacientes.Name = "stsInfoPacientes";
            this.stsInfoPacientes.Size = new System.Drawing.Size(665, 22);
            this.stsInfoPacientes.TabIndex = 1;
            this.stsInfoPacientes.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // F_ListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 473);
            this.Controls.Add(this.stsInfoPacientes);
            this.Controls.Add(this.dgvListaPacientes);
            this.MaximizeBox = false;
            this.Name = "F_ListaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pacientes";
            this.Load += new System.EventHandler(this.F_ListaPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            this.stsInfoPacientes.ResumeLayout(false);
            this.stsInfoPacientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.StatusStrip stsInfoPacientes;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}