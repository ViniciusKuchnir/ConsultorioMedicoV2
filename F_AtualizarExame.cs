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
    public partial class F_AtualizarExame : Form
    {
        public F_AtualizarExame()
        {
            InitializeComponent();
        }

        private void btnAtualizarNomeExame_Click(object sender, EventArgs e)
        {
            F_AtualizarNomeExame f_AtualizarNomeExame = new F_AtualizarNomeExame();
            f_AtualizarNomeExame.ShowDialog();
        }

        private void btnAtualizarCodigoExame_Click(object sender, EventArgs e)
        {
            F_AtualizarCodigoExame f_AtualizarCodigoExame = new F_AtualizarCodigoExame();
            f_AtualizarCodigoExame.ShowDialog();
        }

        private void btnAtualizarCpfExame_Click(object sender, EventArgs e)
        {
            F_AtualizarCpfExame f_AtualizarCpfExame = new F_AtualizarCpfExame();
            f_AtualizarCpfExame.ShowDialog();
        }
    }
}
