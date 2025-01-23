
using DSact;
using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-1RK86KH; Initial Catalog = DataInfo; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<data> datainfo()
        {
            var selectStatement = "SELECT * FROM DataInfo ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var datainfo = new List<data>();

            while (reader.Read())
            {
                datainfo.Add(new data
                {
                    Name = reader["Name"].ToString(),
                    //BirthYear = Convert.ToInt32(reader["BirthYear"].ToString()),
                    Age = Convert.ToInt32(reader["Age"].ToString()),
                    BirthPlace = reader["BirthPlace"].ToString(),
                   
                });
            }

            sqlConnection.Close();
            return datainfo;
        }
    }
}
