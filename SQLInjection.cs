﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsecureSQLConnection_cs_sample
{
	internal class SQLEncrypt
	{
        public void StringInConstructor()
        {
            SqlConnection conn = new SqlConnection("Encrypt=true");
        }

        public void StringInProperty()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Encrypt=true";

        }

        public void StringInBuilder()
        {
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder();
            conBuilder.Encrypt = true;
            SqlConnection conn = new SqlConnection(conBuilder.ToString());
        }

        public void StringInBuilderProperty()
        {
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder();
            conBuilder.Encrypt = true;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conBuilder.ToString();

        }

        public void StringInInitializer1()
        {
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder() { Encrypt = true};

        }
        public void StringInInitializer2()
        {
            string connectString =
                "Server=1.2.3.4;Database=Anything;UID=ab;Pwd=cd;Encrypt=false";
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder(connectString) { Encrypt = true};

        }

        public void StringInEncryptProperty()
        {
            string connectString =
                "Server=1.2.3.4;Database=Anything;UID=ab;Pwd=cd;Encrypt=false";
            SqlConnectionStringBuilder conBuilder = new SqlConnectionStringBuilder(connectString) { Encrypt = true};
            //BAD, Encrypt set to false
            conBuilder.Encrypt = false; 
        }

        public void TriggerThis()
        {
            // BAD, Encrypt not specified
            SqlConnection conn = new SqlConnection("Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;");
        }

        void Test4()
        {
            string connectString =
                "Server=1.2.3.4;Database=Anything;UID=ab;Pwd=cd";
            // BAD, Encrypt not specified
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            var conn = new SqlConnection(builder.ConnectionString);
        }

        void Test5()
        {
            string connectString =
                "Server=1.2.3.4;Database=Anything;UID=ab;Pwd=cd;Encrypt=false";
            // BAD, Encrypt set to false
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);
            var conn = new SqlConnection(builder.ConnectionString);
        }
    }
}
