﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados
{
    public class ConexaoDB
    {
        internal static SqlConnection Open()
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Programacao;Data Source=DESKTOP-5DU07HG");
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
