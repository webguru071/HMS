using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
namespace Diagnostic_Center
{
    class connection
    {
      // static string conn = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        static string conn = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\national_db\database.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection sql = new SqlConnection(conn);

    }
}
