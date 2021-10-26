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
            string qry = "insert into register(firstname,lastname,dateofbirth,emailorphone,password) values(@fname,@lname,@dob,@mailphone,@pword)";
            SqlCommand cmd = new SqlCommand(qry,con);
            cmd.Parameters.AddWithValue("@fname",el.FIRSTNAME);
            cmd.Parameters.AddWithValue("@lname", el.LASTNAME);
            cmd.Parameters.AddWithValue("@dob",el.DOB);
            cmd.Parameters.AddWithValue("@mailphone", el.EMAILORPHONE);
            cmd.Parameters.AddWithValue("@pword", el.PASSWORD);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}