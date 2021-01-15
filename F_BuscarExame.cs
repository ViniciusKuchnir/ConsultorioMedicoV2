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
    public partial class F_BuscarExame : Form
    {
        public int codigoExame { get; set; }
        public F_BuscarExame()
        {
            InitializeComponent();
        }

        private void btnBuscarExame_Click(object sender, EventArgs e)
        {
            codigoExame = Convert.ToInt32(mskCodigoBuscarExame.Text);

            ExameDAO exameDao = new ExameDAO();
            DataTable dataTable = exameDao.BuscarExame(codigoExame);
            dgvResultadoBuscarExame.DataSource = dataTable;
            dgvResultadoBuscarExame.Refresh();
            

        
        }
    }
}
