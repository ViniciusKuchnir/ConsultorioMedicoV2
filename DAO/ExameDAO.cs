using ConsultorioMedicoFormulario.DAO;
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
    public class ExameDAO
    {
        public DataTable GetExames()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Exame";
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void CadastrarExame(int codigo,string nome, string cpf) {

                DbConnection conexao = DAOUtils.GetConexao();
                DbCommand comando = DAOUtils.GetComando(conexao);
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Exame (codigoExame,nomePaciente,cpfPaciente,exameInativo) VALUES(@codigoExame,@nomePaciente,@cpfPaciente,@exameInativo)";
                comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigo));
                comando.Parameters.Add(DAOUtils.GetParametro("@nomePaciente", nome));
                comando.Parameters.Add(DAOUtils.GetParametro("@cpfPaciente", cpf));
                comando.Parameters.Add(DAOUtils.GetParametro("@exameInativo", false));
                comando.ExecuteNonQuery();     

        }

        public DataTable BuscarExame(int codigoExame) {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Exame WHERE codigoExame = @codigoExame";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame",codigoExame));
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void AtualizarNomeExame(string nomeAtual, string novoNome) {
            
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET nomePaciente = @novoNome WHERE nomePaciente = @nomeAtual ";
            comando.Parameters.Add(DAOUtils.GetParametro("@novoNome", novoNome));
            comando.Parameters.Add(DAOUtils.GetParametro("@nomeAtual", nomeAtual));
            comando.ExecuteNonQuery();
        }

        public void AtualizarCodigoExame(int codigoAtual, int novoCodigo) {

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET codigoExame = @novoCodigo WHERE codigoExame = @codigoAtual ";
            comando.Parameters.Add(DAOUtils.GetParametro("@novoCodigo", novoCodigo));
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoAtual", codigoAtual));
            comando.ExecuteNonQuery();
        }

        public void AtualizarCpfExame(string cpfAtual, string novoCpf) {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET cpfPaciente = @novoCpf WHERE cpfPaciente = @cpfAtual ";
            comando.Parameters.Add(DAOUtils.GetParametro("@novoCpf", novoCpf));
            comando.Parameters.Add(DAOUtils.GetParametro("@cpfAtual", cpfAtual));
            comando.ExecuteNonQuery();
        }

        public void InativarExame(int codigoExame, string cpfPaciente) {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET exameInativo = @exameInativo WHERE codigoExame = @codigoExame AND cpfPaciente = @cpfPaciente";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigoExame));
            comando.Parameters.Add(DAOUtils.GetParametro("@cpfPaciente", cpfPaciente));
            comando.Parameters.Add(DAOUtils.GetParametro("@exameInativo", true));
            comando.ExecuteNonQuery();
        }

        public DataTable GetExamesINativos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Exame WHERE exameInativo = @exameInativo";
            comando.Parameters.Add(DAOUtils.GetParametro("@exameInativo", true));
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void AtivarExame(int codigoExame) {

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Exame SET exameInativo = @exameInativo WHERE codigoExame = @codigoExame";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigoExame));
            comando.Parameters.Add(DAOUtils.GetParametro("@exameInativo", false));
            comando.ExecuteNonQuery();
        }

        public string BuscarNomeExame(int codigoExame) {

            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT nomePaciente FROM Exame WHERE codigoExame = @codigoExame";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigoExame));
            return (string)comando.ExecuteScalar();
        }

        public string BuscarCpfExame(int codigoExame) {
            
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT cpfPaciente FROM Exame WHERE codigoExame = @codigoExame";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigoExame));
            return (string)comando.ExecuteScalar();
        }

        public bool BuscarExameAtivo(int codigoExame) {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT ExameInativo FROM Exame WHERE codigoExame = @codigoExame";
            comando.Parameters.Add(DAOUtils.GetParametro("@codigoExame", codigoExame));
            return (bool)comando.ExecuteScalar();

        }

        public int ContarExames() {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM Exame";
            return (int)comando.ExecuteScalar();
        }
    }
}
