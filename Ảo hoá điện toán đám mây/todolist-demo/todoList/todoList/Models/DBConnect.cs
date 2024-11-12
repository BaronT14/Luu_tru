using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace todoList.Models
{
    public class DBConnect
    {
        public string conStr = "Data Source = localhost,1444; database = TodoListDB; User ID = sa; password = DemoDocker@";
        public List<todoUser> getData(int userId)
        {
            List<todoUser> dsp = new List<todoUser>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select * from Todos where UserId = " + userId;
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                todoUser dp = new todoUser();
                dp.todoId = Convert.ToInt32(rdr.GetValue(0).ToString());
                dp.title = rdr.GetValue(2).ToString();
                dp.desc = rdr.GetValue(3).ToString();
                dp.isComplete = rdr.GetValue(4).ToString();
                dp.createAt = rdr.GetValue(5).ToString();
                dp.deadline = rdr.GetValue(6).ToString();
                dp.prior = Convert.ToInt32(rdr.GetValue(7).ToString());
                dsp.Add(dp);
            }
            con.Close();
            return dsp;
        }


    }
}
