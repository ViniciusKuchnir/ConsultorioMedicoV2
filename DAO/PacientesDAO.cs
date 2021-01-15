using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedicoFormulario.DAO
{
    public class PacientesDAO
    {
        public DataTable GetPacientes() {

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Paciente";
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void ExcluirPaciente(string nome, string cpf) { 

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM Pacientes WHERE nome = @nome AND cpf = @cpf";
            comando.Parameters.Add(DAOUtils.GetParametro("@nome", nome));
            comando.Parameters.Add(DAOUtils.GetParametro("@cpf", cpf));
            comando.ExecuteNonQuery(); 
        }

        public void CadastrarPaciente(string nome, int idade,float peso,float altura,string cpf) {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Paciente (nome,idade,peso,altura,cpf) values (@nome, @idade, @peso, @altura, @cpf)";
            comando.Parameters.Add(DAOUtils.GetParametro("@nome", nome));
            comando.Parameters.Add(DAOUtils.GetParametro("@idade", idade));
            comando.Parameters.Add(DAOUtils.GetParametro("@peso",peso));
            comando.Parameters.Add(DAOUtils.GetParametro("@altura", altura));
            comando.Parameters.Add(DAOUtils.GetParametro("@cpf", cpf));
            comando.ExecuteNonQuery();
        }

        public int contarPacientes() {

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM Paciente";
            return (int)comando.ExecuteScalar();

        }
    }
}
