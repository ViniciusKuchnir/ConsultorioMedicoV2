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
    public partial class F_Pacientes : Form
    {
        public F_Pacientes()
        {
            InitializeComponent();
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            F_CadastroPaciente f_CadastroPaciente = new F_CadastroPaciente();
            f_CadastroPaciente.ShowDialog();
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            F_ListaPacientes f_ListaPacientes = new F_ListaPacientes();
            f_ListaPacientes.ShowDialog();
        }

        private void btnExcluirPaciente_Click(object sender, EventArgs e)
        {
            F_ExcluirPaciente f_ExcluirPaciente = new F_ExcluirPaciente();
            f_ExcluirPaciente.ShowDialog();
        }
    }
}
