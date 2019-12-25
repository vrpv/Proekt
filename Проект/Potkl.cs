using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Проект
{
    class Potkl
    {
        public static MySqlConnection Potcl()
        {
            var host = "localhost";
            var port = 3306;
            var database = "vadyas";
            var username = "root";
            var password = "";

            var connString = "Server=" + host + ";Database=" + database
                             + ";port=" + port + ";User Id=" + username + ";password=" + password;

            var conn = new MySqlConnection(connString);
            return conn;
        }


        public static int Avtonom { get; set; }
    }
}