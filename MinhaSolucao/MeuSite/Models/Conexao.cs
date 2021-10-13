using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MeuSite.Models
{
    public class Conexao
    {
        public SqlConnection conn;

        public Conexao()
        {
            conn = new SqlConnection(ConfigurationManager.AppSettings["stringbanco"]);
        }
    }
}