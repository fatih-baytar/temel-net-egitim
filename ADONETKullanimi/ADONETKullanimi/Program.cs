
using System.Data.SqlClient;
//ADO.NET
SqlConnection connection = new SqlConnection("Server=FATIHPC\\SQLEXPRESS;Database=Okul;User Id=sa;Password=Password1");
SqlCommand cmd = new SqlCommand("Select * From Ogrenci", connection);

if (connection.State == System.Data.ConnectionState.Closed)
    connection.Open();

var reader = cmd.ExecuteReader();
while (reader.Read())
{
    var okunan = reader["Firstname"];
    Console.WriteLine(okunan);
}