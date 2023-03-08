using WFApp.ViewModels;

namespace WFApp.Views;

public partial class StaffManageUserControl : UserControl
{
	private StaffManageViewModel ViewModel { get; }
	public StaffManageUserControl()
	{
		InitializeComponent();

		Load += new EventHandler(OnLoad);
		ViewModel = new StaffManageViewModel(staffModelBindingSource);
	}

	private void OnLoad(object? sender, EventArgs e)
	{
		idTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Id));
		nameTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Name));
		nationalIdTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.NationalId));
		emailTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Email));
		birthdayDateTimePicker.DataBindings.Add("Value", ViewModel, nameof(ViewModel.Birthday));
		checkInDateTimePicker.DataBindings.Add("Value", ViewModel, nameof(ViewModel.CheckInDate));
		addressTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.Address));
		phoneNumberTextBox.DataBindings.Add("Text", ViewModel, nameof(ViewModel.PhoneNumber));
		genderComboBox.DataBindings.Add("SelectedItem", ViewModel, nameof(ViewModel.Gender));
		degreeComboBox.DataBindings.Add("SelectedItem", ViewModel, nameof(ViewModel.Degree));
		filterComboBox.DataBindings.Add("SelectedItem", ViewModel, nameof(ViewModel.Filter));
		helpLabel.DataBindings.Add("Text", ViewModel, nameof(ViewModel.HelpText));
		helpLabel.DataBindings.Add("ForeColor", ViewModel, nameof(ViewModel.HelpTextColor));
		staffDataGridView.CellValueChanged += new DataGridViewCellEventHandler(ViewModel.OnGridViewCellValueChanged);
		staffDataGridView.CurrentCellChanged += new EventHandler(ViewModel.OnGridViewCurrentCellChanged);
		addButton.Click += new EventHandler(ViewModel.OnAddButtonClick);
		modifyButton.Click += new EventHandler(ViewModel.OnModifyButtonClick);
		searchButton.Click += new EventHandler(ViewModel.OnSearchButtonClick);
		deleteButton.Click += new EventHandler(ViewModel.OnDeleteButtonClick);
	}
}
