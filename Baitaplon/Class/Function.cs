using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon.Class
{
    internal class Function
    {
        private static string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True; Connect Timeout=30";
        private static string connectionString1 = "Data Source=DESKTOP-BQHAF2N;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False; Connect Timeout=30";
        private static string connectionString2 = "Data Source=LAPTOP-AO872B0H\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=False";

        public static SqlConnection Conn;
        public static string connString;

        public static void Connect()
        {
            try
            {
                if (Conn == null || Conn.State == ConnectionState.Closed)
                {
                    Conn = new SqlConnection(connectionString);

                    try
                    {
                        Conn.Open();

                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"SQL Exception: {ex.Message}");
                        Conn = new SqlConnection(connectionString1);

                        try
                        {
                            Conn.Open();

                        }
                        catch (SqlException ex1)
                        {

                            Console.WriteLine($"SQL Exception: {ex1.Message}");
                            Conn = new SqlConnection(connectionString2);

                            try
                            {
                                Conn.Open();
                            }
                            catch (SqlException ex2)
                            {
                                Console.WriteLine($"SQL Exception: {ex2.Message}");
                                MessageBox.Show("❌Error: " + ex2.Message);
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Exception: {ex.Message}");
                MessageBox.Show("❌Error: " + ex.Message);

                Application.Exit();
            }
        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
                Conn.Dispose();
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            return table;

        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Function.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;

            cbo.ValueMember = ma;    // Truong gia tri
            cbo.DisplayMember = ten;    // Truong hien thi
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Function.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public static string FirstRow(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Function.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
        public static float FirstRowNumberSafe(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, Conn))
            {
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                    return 0f;
                if (float.TryParse(result.ToString(), out float f))
                    return f;
                return 0f;
            }
        }
        
    }
}
