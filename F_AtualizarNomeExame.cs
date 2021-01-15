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
    public partial class F_AtualizarNomeExame : Form
    {
        public string nomeAtual { get; set; }
        public string novoNome { get; set; }
        public F_AtualizarNomeExame()
        {
            InitializeComponent();
        }

        private void btnAtualizarNomeExame_Click(object sender, EventArgs e)
        {
                nomeAtual = txbNomeAtualAtualizarExame.Text;
                novoNome = txbNovoNomeAtualizarExame.Text;
                ExameDAO exameDAO = new ExameDAO();
                exameDAO.AtualizarNomeExame(nomeAtual, novoNome);        
        }
    }
}
