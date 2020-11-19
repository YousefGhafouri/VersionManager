using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersionManager.Objects.App;

namespace VersionManager.DAL._Base
{
    public abstract class CoreBase
    {
        protected string ConnectionString
        {
            get
            {
                return MyApps.ConnectionString;
            }
        }

        protected int ExecuteNoneQuery(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                cmd.Connection = con;
                con.Open();
                int retVal = cmd.ExecuteNonQuery();
                con.Close();
                return retVal;
            }
        }
        protected int ExecuteNoneQuery(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                cmd.Parameters.AddRange(commandParameters);
                con.Open();

                int retVal = cmd.ExecuteNonQuery();

                con.Close();
                return retVal;

            }
        }

        protected object ExecuteScaler(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                cmd.Connection = con;
                cmd.CommandTimeout = 400;
                con.Open();
                object retVal = cmd.ExecuteScalar();
                con.Close();
                con.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                return retVal;
            }
        }
        protected object ExecuteScaler(string commandText, CommandType commandType = CommandType.StoredProcedure, params SqlParameter[] commandParameters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandTimeout = 600;
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                cmd.Parameters.AddRange(commandParameters);
                con.Open();

                object retVal = cmd.ExecuteScalar();

                con.Close();
                con.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                return retVal;

            }
        }
        protected object ExecuteScaler(string commandText, CommandType commandType = CommandType.StoredProcedure, int ConnectionPriod = 300, params SqlParameter[] commandParameters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandTimeout = ConnectionPriod;
                cmd.Connection = con;
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                cmd.Parameters.AddRange(commandParameters);
                con.Open();

                object retVal = cmd.ExecuteScalar();

                con.Close();
                con.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                return retVal;

            }
        }

        protected SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            {
                cmd.Connection = con;
                cmd.CommandTimeout = 180;
                bool mustCloseConnection = false;
                try
                {

                    if (con.State != ConnectionState.Open)
                    {
                        mustCloseConnection = true;
                        con.Open();
                    }
                    else
                    {
                        mustCloseConnection = false;
                    }

                    SqlDataReader dataReader;

                    dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    return dataReader;
                }
                catch
                {
                    if (mustCloseConnection)
                        con.Close();

                    throw;
                }
                //return null;
            }
        }

        protected SqlDataReader ExecuteReader(CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = commandType;
            cmd.CommandText = commandText;
            cmd.Parameters.AddRange(commandParameters);

            bool mustCloseConnection = false;
            try
            {

                if (con.State != ConnectionState.Open)
                {
                    mustCloseConnection = true;
                    con.Open();
                }
                else
                {
                    mustCloseConnection = false;
                }

                SqlDataReader dataReader;

                dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return dataReader;
            }
            catch
            {
                if (mustCloseConnection)
                    con.Close();
                throw;
            }


        }
        
        protected DataSet ExecuteDataset(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                cmd.Connection = con;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(ds);
                con.Close();
                return ds;

            }
        }
        protected DataSet ExecuteDataset(CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                cmd.Parameters.AddRange(commandParameters);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(ds);
                con.Close();
                return ds;

            }
        }
        protected DataTable ExecuteDataTable(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                cmd.Connection = con;
                cmd.CommandTimeout = 180;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
    }
}
