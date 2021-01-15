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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            F_Pacientes f_Pacientes = new F_Pacientes();
            f_Pacientes.ShowDialog();
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            F_Exame f_Exame = new F_Exame();
            f_Exame.ShowDialog();
        }
    }
}
