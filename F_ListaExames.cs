using ConsultorioMedicoFormulario.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedicoFormulario
{
    public partial class F_ListaExames : Form
    {

        public F_ListaExames()
        {
            InitializeComponent();
        }

        private void F_ListaExames_Load(object sender, EventArgs e)
        {
            ExameDAO exameDao = new ExameDAO();
            DataTable dataTable = exameDao.GetExames();
            dgvListaExames.DataSource = dataTable;
            dgvListaExames.Refresh();
            CarregarStatusStrip();
        }
        
        private void CarregarStatusStrip()
        {
          ExameDAO exameDao = new ExameDAO();
            int quantidadeExames = exameDao.ContarExames();
            stsInfoExames.Items[0].Text = quantidadeExames.ToString() + " Exames";
        }

        private void dgvListaExames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
