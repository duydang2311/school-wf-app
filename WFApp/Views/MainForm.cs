using VehicleIN;
using WFApp.ViewModels;

namespace WFApp.Views;

public partial class MainForm : Form
{
	private readonly MainFormViewModel viewModel;

	public MainForm()
	{
		InitializeComponent();
		manageStaffToolStripMenuItem.Tag = new StaffManageUserControl();
		manageVehicleCheckInToolStripMenuItem.Tag = new VehicleCheckInUserControl();
		manageVehicleCheckOutToolStripMenuItem.Tag = new VehicleCheckOutUserControl();
		viewModel = new MainFormViewModel(pagePanel, manageStaffToolStripMenuItem);
		manageToolStripMenuItem.DropDownItemClicked += (obj, e) =>
		{
			if (e.ClickedItem is not null)
			{
				viewModel.ActiveItem = e.ClickedItem;
			}
		};
	}
}
