using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleIN
{
	public partial class VehicleCheckInUserControl : UserControl
	{
		// VeinDAO veindao = new VeinDAO();
		public VehicleCheckInUserControl()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void VehicleIN_Load(object sender, EventArgs e)
		{
			ShowList();
		}
		private void ShowList()
		{
			// this.gvvein.DataSource = veindao.Listvein();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// this.Close();
			// VehicleOUT veout = new VehicleOUT();
			// veout.Show();
		}
	}
}
