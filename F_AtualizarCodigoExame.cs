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
    public partial class F_AtualizarCodigoExame : Form
    {
        public int codigoAtual { get; set; }
        public int novoCodigo { get; set; }
        public F_AtualizarCodigoExame()
        {
            InitializeComponent();
        }

        private void btnAtualizarCodigoExame_Click(object sender, EventArgs e)
        {
            codigoAtual = Convert.ToInt32(mskCodigoAtualAtualizarExame.Text);
            novoCodigo = Convert.ToInt32(mskNovoCodigoAtualizarExame.Text);

            ExameDAO exameDao = new ExameDAO();
            exameDao.AtualizarCodigoExame(codigoAtual,novoCodigo);
        }

        private void F_AtualizarCodigoExame_Load(object sender, EventArgs e)
        {

        }
    }
}
