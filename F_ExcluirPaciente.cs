using ConsultorioMedicoFormulario.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioMedicoFormulario
{
    

    public partial class F_ExcluirPaciente : Form
    {
        public string nome {get; set;}
        public string cpf {get; set;}
        public F_ExcluirPaciente()
        {
            InitializeComponent();
        }

        private void btnExcluirPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                nome = txbNomePacienteExcluir.Text;
                cpf = mskCpfPacienteExcluir.Text;
                PacientesDAO pacienteDao = new PacientesDAO();
                pacienteDao.ExcluirPaciente(nome, cpf);
            }
            catch (Exception)
            {
                MessageBox.Show("Paciente Não Encontado.Tente Novamente!");
            }
            
        }

    }
}
