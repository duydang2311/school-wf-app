using System.Diagnostics;
using Microsoft.Data.SqlClient;
using WFApp.Models;

namespace WFApp.Helpers;

public static class DbHelper
{
	public static async Task<SqlConnection?> OpenConnectionAsync()
	{
		try
		{
			var conn = new SqlConnection(DatabaseModel.Instance.ConnectionString);
			await conn.OpenAsync();
			return conn;
		}
		catch (Exception ex)
		{
			Debug.WriteLine(ex.Message);
		}
		return default;
	}
}
