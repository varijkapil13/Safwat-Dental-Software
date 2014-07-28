using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using KryptonForm;


namespace DentalGood
{
    class CommonFunction
    {
        public static int GetNextValue(int entity)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select lastdata from nextvalues where KeyNo=" + entity.ToString();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int a = dr.GetInt32(0);
            a++;
            dr.Close();
            cmd.CommandText = "update nextvalues set lastdata=@LD where keyno=" + entity.ToString();
            cmd.Parameters.AddWithValue("@LD", a);
            cmd.ExecuteNonQuery();
            return (a);
        }
    }
}
