namespace WFApp.Views;

partial class MainForm
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageVehicleCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pagePanel = new System.Windows.Forms.Panel();
			this.manageVehicleCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(126, 606);
			this.mainMenuStrip.TabIndex = 1;
			// 
			// manageToolStripMenuItem
			// 
			this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStaffToolStripMenuItem,
            this.manageVehicleCheckInToolStripMenuItem,
            this.manageVehicleCheckOutToolStripMenuItem});
			this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
			this.manageToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
			this.manageToolStripMenuItem.Text = "Quản lý";
			this.manageToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// manageStaffToolStripMenuItem
			// 
			this.manageStaffToolStripMenuItem.Name = "manageStaffToolStripMenuItem";
			this.manageStaffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageStaffToolStripMenuItem.Text = "Nhân viên";
			// 
			// manageVehicleCheckInToolStripMenuItem
			// 
			this.manageVehicleCheckInToolStripMenuItem.Name = "manageVehicleCheckInToolStripMenuItem";
			this.manageVehicleCheckInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageVehicleCheckInToolStripMenuItem.Text = "Phương tiện vào";
			// 
			// pagePanel
			// 
			this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pagePanel.Location = new System.Drawing.Point(126, 0);
			this.pagePanel.Name = "pagePanel";
			this.pagePanel.Size = new System.Drawing.Size(821, 606);
			this.pagePanel.TabIndex = 2;
			// 
			// manageVehicleCheckOutToolStripMenuItem
			// 
			this.manageVehicleCheckOutToolStripMenuItem.Name = "manageVehicleCheckOutToolStripMenuItem";
			this.manageVehicleCheckOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.manageVehicleCheckOutToolStripMenuItem.Text = "Phương tiện ra";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 606);
			this.Controls.Add(this.pagePanel);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion
	private MenuStrip mainMenuStrip;
	private ToolStripMenuItem manageToolStripMenuItem;
	private ToolStripMenuItem manageStaffToolStripMenuItem;
	private ToolStripMenuItem manageVehicleCheckInToolStripMenuItem;
	private Panel pagePanel;
	private ToolStripMenuItem manageVehicleCheckOutToolStripMenuItem;
}
