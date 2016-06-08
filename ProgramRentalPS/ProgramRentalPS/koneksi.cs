using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;


namespace ProgramRentalPS
{
    class koneksi
    {
        public static SqlConnection getKoneksi()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ProgramRentalPS\ProgramRentalPS\DbRental.mdf;Integrated Security=True;User Instance=True");
            return connection;
        }
    }
}
