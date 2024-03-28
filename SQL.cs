using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

public class SQL
{
    private static string connectionString = "Server=192.168.1.2;Database=Library;User Id=sa;Password=Dsov@0605;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}

