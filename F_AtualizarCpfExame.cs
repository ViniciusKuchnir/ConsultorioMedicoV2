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
    public partial class F_AtualizarCpfExame : Form
    {
        public string cpfAtual { get; set; }
        public string novoCpf { get; set; }
        public F_AtualizarCpfExame()
        {
            InitializeComponent();
        }

        private void btnAtualizarCpfExame_Click(object sender, EventArgs e)
        {
            cpfAtual = mskCpfAtualAtualizarExame.Text;
            novoCpf = mskNovoCpfAtualizarExame.Text;
            ExameDAO exameDao = new ExameDAO();
            exameDao.AtualizarCpfExame(cpfAtual,novoCpf);
            MessageBox.Show("CPF Atualizado Com Sucesso");
        }
    }
}
