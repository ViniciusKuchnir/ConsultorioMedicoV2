using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioMedicoFormulario.DAO
{
    public class DAOUtils
    {

        public static DbConnection GetConexao() {

            string server = ConfigurationManager.AppSettings["server"].ToString();
            string database = ConfigurationManager.AppSettings["database"].ToString();
            string user = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            DbConnection conexao= null;

            if (ConfigurationManager.AppSettings["provider"].ToString().Equals("MSSQL"))
            {
                string connectionString = @"Server="+ server +";Database=" + database + ";User Id="+ user +";Password=" + password + ";";
                conexao = new SqlConnection(connectionString); 
            }
            else 
            { 
                string connectionString = "Server =" + server + "; Database =" + database + "; Uid =" + user + "; Pwd =" + password + ";";
                conexao = new MySqlConnection(connectionString);

            }

            conexao.Open();
            return conexao;
        
        }

        public static DbCommand GetComando(DbConnection conexao) {

            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando) {
            return comando.ExecuteReader();
        }

        public static DbParameter GetParametro(string nome, object value) {

            DbParameter parametro = null;
            if (ConfigurationManager.AppSettings["provider"].ToString().Equals("MSSQL"))
            {
                parametro = new SqlParameter(nome, value);
            }
            else 
            {
                parametro = new MySqlParameter(nome, value);
            }
           
            return parametro;
        }
       
    }
}
