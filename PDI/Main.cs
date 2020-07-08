using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDI
{
    class Main
    {
        private static int companyID = 1;
        private static string userName;//="admin";
        public static int RDRMID = 1;// = 1;//ROlE DETAIL AND ROLEMASTERID FOR FORM AND REPORTS RIGHTS

        public static int CompanyID
        {
            get
            {
                return companyID;
            }

            set
            {
                companyID = value;
            }
        }

        public static string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        public static void OnlyDigits(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public static bool CheckFormRights()
        {
            String USERNAME = UserName.ToUpper();
            if (string.Compare("ADMIN", USERNAME) == 0) return true;
            else return false;
        }
        public static bool CheckUserName(string name)
        {
            string Compare = "";
            Compare = SQL.Q1("SELECT CASE WHEN EXISTS (SELECT TOP 1 * FROM login  WHERE username = '" + name + "' And CompanyID=" + Main.CompanyID + ") THEN CAST (1 AS BIT) ELSE CAST (0 AS BIT) END");
            if (string.Compare("True", Compare) == 0) return true;
            else return false;
        }
        public static bool checkPassword(string name, string password)
        {
            string oPassword = "";
            oPassword = SQL.Q1("Select password from login where username='" + name + "'");
            if (string.Compare(password, oPassword) == 0) return true;
            else return false;
        }
        public void load_form(Form form_name, string form_title)//, string type)
        {
            string fname;
            try
            {
                fname = form_title;
                {
                    var withBlock = form_name;
                    withBlock.Dock = DockStyle.Fill;
                    withBlock.WindowState = FormWindowState.Maximized;
                    withBlock.Show();
                    withBlock.WindowState = FormWindowState.Maximized;
                    form_name.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void fillCombo(ComboBox combo, String TableName, String DisplayMember, String ValueMember, String Condition, String Key)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + " where " + Condition + " AND And CompanyID=" + Main.CompanyID + "", SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void fillCombo(ComboBox combo, String TableName, String DisplayMember, String ValueMember, String Condition)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + " where " + Condition + "", SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void fillComboWithQuery(ComboBox combo, String DisplayMember, String Query)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand(Query, SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void getCompany(ComboBox combo, String TableName, String DisplayMember, String ValueMember, String Condition)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + "  where " + Condition + "", SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void fillComboWithoutCondition(ComboBox combo, String TableName, String DisplayMember, String ValueMember)//, List<T> Models, string Name, string Value)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var tb1 = new DataTable();
                var cmd1 = new SqlCommand("select " + ValueMember + " , " + DisplayMember + " from " + TableName + "", SQL.Con);
                SqlDataReader d1;
                d1 = cmd1.ExecuteReader();
                tb1.Load(d1);
                combo.DisplayMember = DisplayMember;
                combo.ValueMember = ValueMember;
                combo.DataSource = tb1;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void fillDgv(DataGridView DataGridView, String Query)
        {
            try
            {
                if (SQL.Con.State == ConnectionState.Open)
                {
                    SQL.Con.Close();
                }
                SQL.Con.Open();
                var cmd2 = new SqlCommand(Query, SQL.Con);
                var da = new SqlDataAdapter(cmd2);
                var ds = new DataTable();
                da.Fill(ds);
                DataGridView.DataSource = ds;
                SQL.Con.Close();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data Grid View");
            }
        }
    }
}

