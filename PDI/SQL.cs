using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI
{
    class SQL
    {
        //private static SqlConnection con = new SqlConnection(@"Data Source=" + DataSource + ";Initial Catalog=MobileShop;Integrated Security=True;Pooling=False");// ReadCS().ToString()); 
        public static String DataSource = ReadCS();
        private static SqlConnection con = new SqlConnection(DataSource);// ReadCS().ToString()); 
        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
        public static SqlConnection Con
        {

            get
            {
                return con;
            }
        }
        public static string ReadCS()
        {
            var lines = "";
            string Path = Application.StartupPath + @"\SQL.dat";
            if (!File.Exists(Path))
            {
                MessageBox.Show("Unable To Find Connection File ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var streamReader = new StreamReader(Path))
                {
                    try
                    {
                        lines = streamReader.ReadLine();
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "SQL");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQl");
                    }
                }
            }

            return lines;
        }
        public static String Q1(String Query)
        {
            String Result = string.Empty;
            try
            {

                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                Result = cmd.ExecuteScalar().ToString();
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("SQL Scalar Query" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Result;
        }
        public static void NonScalarQuery(String Query)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public static void NonScalarQueryTransaction(String Query, SqlTransaction ST)
        {
            try
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
                Con.Open();
                SqlCommand cmd = new SqlCommand(Query, Con, ST);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL" + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}

