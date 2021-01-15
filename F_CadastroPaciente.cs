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
    public partial class F_CadastroPaciente : Form
    {
        public string nome{ get; set; }
        public int idade{ get; set; }
        public float peso{ get; set; }
        public float altura{ get; set;}
        public string cpf{ get; set; }

        public F_CadastroPaciente()
        {
            InitializeComponent();
        }


        private void btnCadastrarPaciente_Click_1(object sender, EventArgs e)
        {
            nome = txtNomeCadastroPaciente.Text;
            idade = Convert.ToInt32(mskIdadeCadastroPaciente.Text);
            peso = float.Parse(mskPesoCadastroPaciente.Text);
            altura = float.Parse(mskAlturaCadastroPaciente.Text);
            cpf = mskCpfCadastroPaciente.Text;

            PacientesDAO pacienteDao = new PacientesDAO();

            pacienteDao.CadastrarPaciente(nome, idade, peso, altura, cpf);
        }
    }
}
