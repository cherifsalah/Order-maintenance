﻿//Class NorthwindDB , one method :GetConnection 
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4Assignement
{
    public static class NorthwindDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
