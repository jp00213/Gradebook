﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook.DAL
{
    public class AccountDAL
    {
        public bool IsPasswordCorrect(string user, string pass)
        {
            Boolean result = false;

            string selectStatement =
                "SELECT Count(*) " +
                "FROM Account " +
                "WHERE Username = @Username AND Password = @Password ";

            using (SqlConnection connection = GradebookDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@Username", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Username"].Value = user;
                    selectCommand.Parameters.Add("@Password", System.Data.SqlDbType.VarChar);
                    selectCommand.Parameters["@Password"].Value = pass;

                    Int32 count = (Int32)selectCommand.ExecuteScalar();
                    if (count > 0) { result = true; }
                }
            }
            return result;
        }
    }
}
