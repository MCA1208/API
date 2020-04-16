using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;


namespace API.Service
{
    public class UserService 
    {
        
        DataTable dt = new DataTable();
        SqlConnection con;
        SqlCommand comando;

        public DataTable SpGetAllClient(string cnn)
        {
            con = new SqlConnection(cnn);
            comando = new SqlCommand("spGetAllClient", con);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);

            return dt;

        }

    }
}
