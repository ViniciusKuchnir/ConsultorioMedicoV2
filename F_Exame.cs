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
    public partial class F_Exame : Form
    {
        public F_Exame()
        {
            InitializeComponent();
        }

        private void btnCadastrarExame_Click(object sender, EventArgs e)
        {
            F_CadastroExame f_CadastroExame = new F_CadastroExame();
            f_CadastroExame.ShowDialog();
        }

        private void btnBuscarExame_Click(object sender, EventArgs e)
        {
            F_BuscarExame f_BuscarExame = new F_BuscarExame();
            f_BuscarExame.ShowDialog();
        }
        private void btnVisualizarExame_Click(object sender, EventArgs e)
        {
            F_VisualizarExame f_VisualizarExame = new F_VisualizarExame();
            f_VisualizarExame.ShowDialog();
        }

        private void btnAtualizarExame_Click(object sender, EventArgs e)
        {
            F_AtualizarExame f_AtualizarExame = new F_AtualizarExame();
            f_AtualizarExame.ShowDialog();
        }

        private void btnListarExames_Click(object sender, EventArgs e)
        {
            F_ListaExames f_ListaExames = new F_ListaExames();
            f_ListaExames.ShowDialog();
        }

        private void btnListarExamesInativos_Click(object sender, EventArgs e)
        {
            F_ListaExamesInativos f_ListaExamesInativos = new F_ListaExamesInativos();
            f_ListaExamesInativos.ShowDialog();
        }

        private void btnInativarExame_Click(object sender, EventArgs e)
        {
            F_InativarExame f_InativarExame = new F_InativarExame();
            f_InativarExame.ShowDialog();
        }
    }
}
