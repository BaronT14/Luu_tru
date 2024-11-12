//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SqlClient;

//namespace QuanLyNhaHang
//{
//    class CNDatabase
//    {
//        public static string chuoiketnoi = "Data Source = DESKTOP-PNS3015\\SQLEXPRESS; Initial Catalog=QLSV; User ID=sa; Password=123";
//        public SqlConnection con = new SqlConnection();
//        public CNDatabase()
//        {
//            con = new SqlConnection(chuoiketnoi);
//        }
//        public void Open()
//        {
//            if (con.State == ConnectionState.Closed)
//            {
//                con.Open();
//            }
//        }
//        public void Close()
//        {
//            if (con.State == ConnectionState.Open)
//            {
//                con.Close();
//            }
//        }
//        public int getNonQuery(string sqlquery)
//        {
//            Open();
//            SqlCommand cmd = new SqlCommand(sqlquery, con);
//            int kq = cmd.ExecuteNonQuery();
//            Close();
//            return kq;
//        }
//        public DataTable getDataTable(string sqlquery)
//        {
//            DataSet ds = new DataSet();
//            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
//            da.Fill(ds);
//            return ds.Tables[0];
//        }
//        public int getScarlar(string sqlquery)
//        {
//            Open();
//            SqlCommand cmd = new SqlCommand(sqlquery, con);
//            int kq = (int)cmd.ExecuteScalar();
//            Close();
//            return kq;
//        }
//    }
//}
