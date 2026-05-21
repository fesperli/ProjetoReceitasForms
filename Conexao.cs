using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetoReceitasC_
{
    public static class Conexao
    {
        private static string connectionString =
            "Server=localhost,1433;Database=GerenciadorReceitasDB;User Id=sa;Password=SqlServer@2022;Encrypt=True;TrustServerCertificate=True;";

        public static IDbConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}
