using System.Data.SqlClient;
using System.Data;

public class DB
{
    private static string conStr = "Data Source=.;Initial Catalog=UETBusSystem;Integrated Security=True";

    public static void RegisterUser(string name, string email, string password)
    {
        using (SqlConnection con = new SqlConnection(conStr))
        {
            string query = "INSERT INTO Users(Name, Email, Password) VALUES(@name, @Email, @Password)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public static bool AuthenticateUser(string email, string password)
    {
        using (SqlConnection con = new SqlConnection(conStr))
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email=@Email AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            return count == 1;
        }
    }

    public static DataTable GetBusRoutes()
    {
        using (SqlConnection con = new SqlConnection(conStr))
        {
            string query = "SELECT * FROM BusRoutes";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
