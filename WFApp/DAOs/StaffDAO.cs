using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using WFApp.Helpers;
using WFApp.Models;

namespace WFApp.DAOs;

public class StaffDAO
{
	private SqlDataAdapter adapter = new SqlDataAdapter(string.Empty, DatabaseModel.Instance.ConnectionString);

	public static StaffDAO Instance { get; } = new StaffDAO();

	private StaffDAO() { }

	public async Task<bool> EnsureTableAsync()
	{
		using var conn = await DbHelper.OpenConnectionAsync().ConfigureAwait(false);
		if (conn is null)
		{
			return false;
		}
		using var cmd = conn.CreateCommand();
		cmd.CommandText =
		@"
			IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Staffs' and xtype='U')
					CREATE TABLE Staffs(
					Id VARCHAR(11) PRIMARY KEY,
					NationalId VARCHAR(11),
					Name NVARCHAR(64),
					PhoneNumber VARCHAR(13),
					IsMale BIT DEFAULT 1,
					Email VARCHAR(128),
					Degree NVARCHAR(16),
					Birthday DATETIME,
					Address NVARCHAR(128),
					CheckInDate DATETIME,
				);
		";
		await cmd.ExecuteNonQueryAsync();
		return true;
	}

	public async Task<DataTable?> GetAllStaffsAsync()
	{
		var table = new DataTable();
		adapter.SelectCommand.CommandText = "SELECT * FROM Staffs;";
		await Task.Run(() =>
		{
			_ = new SqlCommandBuilder(adapter);
			try
			{
				adapter.Fill(table);
			}
			catch (InvalidOperationException ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}).ConfigureAwait(false);
		adapter.RowUpdated += (obj, e) =>
		{
			Debug.WriteLine(obj + " " + e);
		};
		return table;
	}

	public async Task<int> UpdateAsync(DataTable table)
	{
		return await Task.Run(() => adapter.Update(table))
			.ConfigureAwait(false);
	}
}
