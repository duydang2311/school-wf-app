using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using WFApp.DAOs;
using WFApp.Helpers;
using WFApp.Models;

namespace WFApp.ViewModels;

public class StaffManageViewModel : INotifyPropertyChanged
{
	private string id = string.Empty;
	private string nationalId = string.Empty;
	private string name = string.Empty;
	private string phoneNumber = string.Empty;
	private string? gender;
	private string email = string.Empty;
	private string? degree;
	private DateTime birthday = DateTimePicker.MinimumDateTime;
	private string address = string.Empty;
	private DateTime checkInDate = DateTime.Now;
	private string? filterValue;
	private BindingSource staffModelBindingSource;
	private string helpText = string.Empty;
	private Color helpTextColor = Color.Red;

	public event PropertyChangedEventHandler? PropertyChanged;

	public string Id
	{
		get => id;
		set { id = value; OnPropertyChanged(); }
	}

	public string NationalId
	{
		get => nationalId;
		set { nationalId = value; OnPropertyChanged(); }
	}

	public string Name
	{
		get => name;
		set { name = value; OnPropertyChanged(); }
	}

	public string? Gender
	{
		get => gender;
		set { gender = value; OnPropertyChanged(); }
	}

	public string Email
	{
		get => email;
		set { email = value; OnPropertyChanged(); }
	}

	public string? Degree
	{
		get => degree;
		set { degree = value; OnPropertyChanged(); }
	}

	public string PhoneNumber
	{
		get => phoneNumber;
		set { phoneNumber = value; OnPropertyChanged(); }
	}

	public DateTime Birthday
	{
		get => birthday;
		set { birthday = value; OnPropertyChanged(); }
	}

	public string Address
	{
		get => address;
		set { address = value; OnPropertyChanged(); }
	}

	public DateTime CheckInDate
	{
		get => checkInDate;
		set { checkInDate = value; OnPropertyChanged(); }
	}

	public string? Filter
	{
		get => filterValue;
		set { filterValue = value; OnPropertyChanged(); }
	}

	public string HelpText
	{
		get => helpText;
		set { helpText = value; OnPropertyChanged(); }
	}

	public Color HelpTextColor
	{
		get => helpTextColor;
		set { helpTextColor = value; OnPropertyChanged(); }
	}

	public StaffManageViewModel(BindingSource staffModelBindingSource)
	{
		this.staffModelBindingSource = staffModelBindingSource;
		Task.Run(async () =>
		{
			if (!await StaffDAO.Instance.EnsureTableAsync().ConfigureAwait(false))
			{
				return;
			}
			var table = await StaffDAO.Instance.GetAllStaffsAsync().ConfigureAwait(false);
			if (table is null)
			{
				return;
			}
			staffModelBindingSource.DataSource = table;
		});
	}

	public void OnGridViewCellValueChanged(object? sender, DataGridViewCellEventArgs e)
	{
		_ = StaffDAO.Instance.UpdateAsync((DataTable)staffModelBindingSource.DataSource);
	}

	private DataGridViewRow? lastRow;
	public void OnGridViewCurrentCellChanged(object? sender, EventArgs e)
	{
		if (sender is not DataGridView gridView
		|| gridView.CurrentRow is null
		|| gridView.CurrentRow == lastRow)
		{
			return;
		}
		var table = (DataTable)staffModelBindingSource.DataSource;
		var dataRow = table.Rows[gridView.CurrentRow.Index];
		if (dataRow.RowState == DataRowState.Deleted)
		{
			return;
		}
		Id = dataRow.IsNull("Id") ? string.Empty : (string)dataRow["Id"];
		NationalId = dataRow.IsNull("NationalId") ? string.Empty : (string)dataRow["NationalId"];
		Name = dataRow.IsNull("Name") ? string.Empty : (string)dataRow["Name"];
		PhoneNumber = dataRow.IsNull("PhoneNumber") ? string.Empty : (string)dataRow["PhoneNumber"];
		Gender = dataRow.IsNull("IsMale") ? null : (bool)dataRow["IsMale"] ? "Nam" : "Nữ";
		Email = dataRow.IsNull("Email") ? string.Empty : (string)dataRow["Email"];
		Address = dataRow.IsNull("Address") ? string.Empty : (string)dataRow["Address"];
		Degree = dataRow.IsNull("Degree") ? null : (string)dataRow["Degree"];
		Birthday = dataRow.IsNull("Birthday") ? DateTimePicker.MinimumDateTime : (DateTime)dataRow["Birthday"];
		CheckInDate = dataRow.IsNull("CheckInDate") ? DateTimePicker.MinimumDateTime : (DateTime)dataRow["CheckInDate"];
		lastRow = gridView.CurrentRow;
	}

	public async void OnAddButtonClick(object? sender, EventArgs e)
	{
		Id = Id.Trim();
		if (string.IsNullOrEmpty(Id))
		{
			Error("Hãy nhập mã nhân viên.");
			return;
		}

		var dataTable = (DataTable)staffModelBindingSource.DataSource;
		foreach (DataRow r in dataTable.Rows)
		{
			if (!r.IsNull("Id") && (string)r["Id"] == Id)
			{
				Error("Mã nhân viên đã tồn tại.");
				return;
			}
		}

		Email = Email.Trim();
		if (!ValidationHelper.IsEmail(Email))
		{
			Error("Email không hợp lệ.");
			return;
		}
		Name = Name.Trim();
		Address = Address.Trim();
		NationalId = NationalId.Trim();
		PhoneNumber = PhoneNumber.Trim();
		var row = dataTable.NewRow();
		SetAllRowFields(row);
		dataTable.Rows.Add(row);

		try
		{
			var count = await StaffDAO.Instance.UpdateAsync(dataTable);
			if (count != 0)
			{
				Success($"Đã thêm nhân viên {Id}.");
			}
			else
			{
				Warning($"Nhân viên {Id} chưa được thêm vào thành công.");
			}
		}
		catch (Exception ex)
		{
			Error(ex.Message);
		}
	}

	public async void OnModifyButtonClick(object? sender, EventArgs e)
	{
		Id = Id.Trim();
		if (string.IsNullOrEmpty(Id))
		{
			Error("Hãy nhập mã nhân viên.");
			return;
		}

		var dataTable = (DataTable)staffModelBindingSource.DataSource;
		foreach (DataRow r in dataTable.Rows)
		{
			if (!r.IsNull("Id") && (string)r["Id"] == Id)
			{
				Email = Email.Trim();
				if (!ValidationHelper.IsEmail(Email))
				{
					Error("Email không hợp lệ.");
					return;
				}
				Name = Name.Trim();
				Address = Address.Trim();
				NationalId = NationalId.Trim();
				PhoneNumber = PhoneNumber.Trim();
				SetAllRowFields(r);
				Info($"Đang thực hiện thay đổi với nhân viên {Id}.");
				try
				{
					var count = await StaffDAO.Instance.UpdateAsync(dataTable);
					if (count != 0)
					{
						Success($"Đã chỉnh sửa nhân viên {Id}.");
					}
					else
					{
						Warning($"Không có thay đổi nào được thực hiện cho nhân viên {Id}.");
					}
				}
				catch (Exception ex)
				{
					Error(ex.Message);
				}
				return;
			}
		}
		Error("Mã nhân viên không tồn tại.");
	}

	public void OnSearchButtonClick(object? sender, EventArgs e)
	{

	}

	public async void OnDeleteButtonClick(object? sender, EventArgs e)
	{
		Id = Id.Trim();
		if (string.IsNullOrEmpty(Id))
		{
			Error("Hãy nhập mã nhân viên.");
			return;
		}

		var dataTable = (DataTable)staffModelBindingSource.DataSource;
		foreach (DataRow r in dataTable.Rows)
		{
			if (!r.IsNull("Id") && (string)r["Id"] == Id)
			{
				try
				{
					r.Delete();
					var count = await StaffDAO.Instance.UpdateAsync(dataTable);
					if (count == 0)
					{
						Warning($"Nhân viên {Id} chưa được xóa thành công.");
						return;
					}
					Success($"Đã xóa nhân viên {Id}.");
				}
				catch (Exception ex)
				{
					Error(ex.Message);
				}
				return;
			}
		}
		Error("Mã nhân viên không tồn tại.");
	}

	private void OnPropertyChanged([CallerMemberName] string name = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	private void Error(string text) => DisplayHelpText(Color.Red, text);
	private void Success(string text) => DisplayHelpText(Color.Green, text);
	private void Info(string text) => DisplayHelpText(Color.Blue, text);
	private void Warning(string text) => DisplayHelpText(Color.DarkGoldenrod, text);
	private void DisplayHelpText(Color color, string text)
	{
		HelpTextColor = color;
		HelpText = text;
	}

	private void SetAllRowFields(DataRow row)
	{
		row.SetField("Id", Id);
		row.SetField("NationalId", NationalId);
		row.SetField("Name", Name);
		row.SetField("Email", Email);
		row.SetField("Address", Address);
		row.SetField("PhoneNumber", PhoneNumber);
		row.SetField("IsMale", Gender == "Nam");
		row.SetField("Degree", Degree);
		row.SetField("Birthday", Birthday);
		row.SetField("CheckInDate", CheckInDate);
	}
}
