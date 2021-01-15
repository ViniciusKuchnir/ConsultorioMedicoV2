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
    public partial class F_VisualizarExame : Form
    {

        public  int codigoExame { get; set; }
        public F_VisualizarExame()
        {
            InitializeComponent();
        }

        private void btnVisualizarExame_Click(object sender, EventArgs e)
        {
            codigoExame = Convert.ToInt32(mskCodigoVisualizacaoExame.Text);
            F_VisualizacaoDoExame f_VisualizacaoDoExame = new F_VisualizacaoDoExame(codigoExame);
            f_VisualizacaoDoExame.ShowDialog();
        }
    }
}
