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
    public partial class F_InativarExame : Form
    {
        public int codigoExame { get; set; }
        public string cpfPaciente{ get; set; }

        public F_InativarExame()
        {
            InitializeComponent();
        }

        private void btnInativarExame_Click(object sender, EventArgs e)
        {
            codigoExame = Convert.ToInt32(mskCodigoExameInativarExame.Text);
            cpfPaciente = mskCpfPacienteInativarExame.Text;

            ExameDAO exameDao = new ExameDAO();
            exameDao.InativarExame(codigoExame,cpfPaciente);
        
        }
    }
}
