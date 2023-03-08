namespace WFApp.Models;

public class DatabaseModel
{
	public string ConnectionString { get; set; } = string.Empty;

	public static DatabaseModel Instance { get; } = new DatabaseModel("Data Source=localhost;Initial Catalog=wfapp;Integrated Security=True;Pooling=False;User Id=sa;Password=123danCkoi;TrustServerCertificate=True");

	private DatabaseModel(string connectionString)
	{
		ConnectionString = connectionString;
	}
}
