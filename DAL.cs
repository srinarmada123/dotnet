using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
namespace project_social_media
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["kc"]);
        public int insert(EL el)
        {
            string qry = "insert into register(firstname,lastname,dateofbirth,emailorphone,password) values(@firstname,@lastname,@dateofbirth,@emailorphone,@password)";
            SqlCommand cmd = new SqlCommand(qry,con);
            cmd.Parameters.AddWithValue("@firstname",el.FIRSTNAME);
            cmd.Parameters.AddWithValue("@lastname", el.LASTNAME);
            cmd.Parameters.AddWithValue("@dateofbirth",el.DOB);
            cmd.Parameters.AddWithValue("@emailorphone", el.EMAILORPHONE);
            cmd.Parameters.AddWithValue("@password", el.PASSWORD);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}