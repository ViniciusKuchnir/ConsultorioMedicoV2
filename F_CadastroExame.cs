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
    public partial class F_CadastroExame : Form
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int codigo { get; set; }
        public F_CadastroExame()
        {
            InitializeComponent();
        }

        private void btnCadastrarExame_Click(object sender, EventArgs e)
        {
            try
            {
                nome = txbNomeCadastroExame.Text;
                cpf = mskCpfCadastroExame.Text;
                codigo = Convert.ToInt32(mskCodigoCadastroExame.Text);

                ExameDAO exameDao = new ExameDAO();
                exameDao.CadastrarExame(codigo, nome, cpf);
                MessageBox.Show("Exame Cadastrado com Sucesso");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           

           
        }
    }
}
