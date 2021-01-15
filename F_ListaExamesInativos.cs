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
    public partial class F_ListaExamesInativos : Form
    {
        public F_ListaExamesInativos()
        {
            InitializeComponent();
        }

        private void F_ListaExamesInativos_Load(object sender, EventArgs e)
        {
            ExameDAO exameDAO = new ExameDAO();
            DataTable dataTable = exameDAO.GetExamesINativos();
            dgvExamesInativos.DataSource = dataTable;
            dgvExamesInativos.Refresh();

        }

        private void btnAtivarExameListaExameInativos_Click(object sender, EventArgs e)
        {
            int codigoExame = (int)dgvExamesInativos.CurrentRow.Cells[0].Value;
            ExameDAO exameDao = new ExameDAO();
            exameDao.AtivarExame(codigoExame);
            MessageBox.Show("Exame Ativado com Sucesso");
            dgvExamesInativos.Refresh();

        }
    }
}
