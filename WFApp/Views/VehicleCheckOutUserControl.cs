namespace WFApp.Views;

public partial class VehicleCheckOutUserControl : UserControl
{
	// VeoutDAO veindao = new VeoutDAO();
	public VehicleCheckOutUserControl()
	{
		InitializeComponent();
	}

	private void VehicleOUT_Load(object sender, EventArgs e)
	{
		ShowList();
	}
	private void ShowList()
	{
		// this.gvveout.DataSource = veindao.Listveout();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		// this.Close();
		// VehicleCheckInUserControl vein = new VehicleCheckInUserControl();
		// vein.Show();
	}
}
