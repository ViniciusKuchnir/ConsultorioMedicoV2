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

    public partial class F_VisualizacaoDoExame : Form
    {
        public F_VisualizacaoDoExame()
        {
            InitializeComponent();
        }

        public F_VisualizacaoDoExame(int codigoExame)
        {
            InitializeComponent();
            ExameDAO exameDao = new ExameDAO();
            lblNomePaciente.Text = exameDao.BuscarNomeExame(codigoExame).ToString();
            lblIdadePaciente.Text = exameDao.BuscarCpfExame(codigoExame).ToString();

            if (exameDao.BuscarExameAtivo(codigoExame) == true)
            {
                lblExameAtivo.Text = "Inativo";
            }
            else
            {
                lblExameAtivo.Text = "Ativo";
            }
        }
    }
}
