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
    public partial class F_ListaPacientes : Form
    {
        public F_ListaPacientes()
        {
            InitializeComponent();
        }

        private void F_ListaPacientes_Load(object sender, EventArgs e)
        {
            PacientesDAO pacienteDao = new PacientesDAO();
            DataTable dataTable = pacienteDao.GetPacientes();
            dgvListaPacientes.DataSource = dataTable;
            dgvListaPacientes.Refresh();
            CarregarStatusStrip();
        }

        private void CarregarStatusStrip()
        {
            PacientesDAO pacienteDao = new PacientesDAO();
            int quantidadePacientes = pacienteDao.contarPacientes();
            stsInfoPacientes.Items[0].Text = quantidadePacientes.ToString() + " Pacientes";
        }

        private void dgvListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
