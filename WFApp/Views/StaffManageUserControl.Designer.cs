namespace WFApp.Views
{
	partial class StaffManageUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.topPanel = new System.Windows.Forms.Panel();
			this.staffGroupBox = new System.Windows.Forms.GroupBox();
			this.staffTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.degreeComboBox = new System.Windows.Forms.ComboBox();
			this.checkInLabel = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.addressLabel = new System.Windows.Forms.Label();
			this.nationalIdTextBox = new System.Windows.Forms.TextBox();
			this.nationalIdLabel = new System.Windows.Forms.Label();
			this.birthdayLabel = new System.Windows.Forms.Label();
			this.degreeLabel = new System.Windows.Forms.Label();
			this.genderLabel = new System.Windows.Forms.Label();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.phoneNumberLabel = new System.Windows.Forms.Label();
			this.idLabel = new System.Windows.Forms.Label();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.genderComboBox = new System.Windows.Forms.ComboBox();
			this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.helpLabel = new System.Windows.Forms.Label();
			this.optionGroupBox = new System.Windows.Forms.GroupBox();
			this.topRightTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.filterLabel = new System.Windows.Forms.Label();
			this.filterComboBox = new System.Windows.Forms.ComboBox();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this.bottomTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.staffGridViewGroupBox = new System.Windows.Forms.GroupBox();
			this.staffDataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nationalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isMaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.degreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.actionGroupBox = new System.Windows.Forms.GroupBox();
			this.actionFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.addButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.modifyButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.topPanel.SuspendLayout();
			this.staffGroupBox.SuspendLayout();
			this.staffTablePanel.SuspendLayout();
			this.optionGroupBox.SuspendLayout();
			this.topRightTablePanel.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.bottomTablePanel.SuspendLayout();
			this.staffGridViewGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).BeginInit();
			this.actionGroupBox.SuspendLayout();
			this.actionFlowPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.staffGroupBox);
			this.topPanel.Controls.Add(this.optionGroupBox);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(883, 262);
			this.topPanel.TabIndex = 0;
			// 
			// staffGroupBox
			// 
			this.staffGroupBox.Controls.Add(this.staffTablePanel);
			this.staffGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.staffGroupBox.Location = new System.Drawing.Point(0, 0);
			this.staffGroupBox.Name = "staffGroupBox";
			this.staffGroupBox.Size = new System.Drawing.Size(611, 262);
			this.staffGroupBox.TabIndex = 0;
			this.staffGroupBox.TabStop = false;
			this.staffGroupBox.Text = "Nhân viên";
			// 
			// staffTablePanel
			// 
			this.staffTablePanel.AutoSize = true;
			this.staffTablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.staffTablePanel.ColumnCount = 4;
			this.staffTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.staffTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.staffTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.staffTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.staffTablePanel.Controls.Add(this.checkInDateTimePicker, 3, 4);
			this.staffTablePanel.Controls.Add(this.degreeComboBox, 3, 2);
			this.staffTablePanel.Controls.Add(this.checkInLabel, 2, 4);
			this.staffTablePanel.Controls.Add(this.addressTextBox, 1, 4);
			this.staffTablePanel.Controls.Add(this.addressLabel, 0, 4);
			this.staffTablePanel.Controls.Add(this.nationalIdTextBox, 3, 3);
			this.staffTablePanel.Controls.Add(this.nationalIdLabel, 2, 3);
			this.staffTablePanel.Controls.Add(this.birthdayLabel, 0, 3);
			this.staffTablePanel.Controls.Add(this.degreeLabel, 2, 2);
			this.staffTablePanel.Controls.Add(this.genderLabel, 0, 2);
			this.staffTablePanel.Controls.Add(this.emailTextBox, 3, 1);
			this.staffTablePanel.Controls.Add(this.emailLabel, 2, 1);
			this.staffTablePanel.Controls.Add(this.nameTextBox, 1, 1);
			this.staffTablePanel.Controls.Add(this.nameLabel, 0, 1);
			this.staffTablePanel.Controls.Add(this.phoneNumberTextBox, 3, 0);
			this.staffTablePanel.Controls.Add(this.phoneNumberLabel, 2, 0);
			this.staffTablePanel.Controls.Add(this.idLabel, 0, 0);
			this.staffTablePanel.Controls.Add(this.idTextBox, 1, 0);
			this.staffTablePanel.Controls.Add(this.genderComboBox, 1, 2);
			this.staffTablePanel.Controls.Add(this.birthdayDateTimePicker, 1, 3);
			this.staffTablePanel.Controls.Add(this.helpLabel, 0, 5);
			this.staffTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.staffTablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.staffTablePanel.Location = new System.Drawing.Point(3, 19);
			this.staffTablePanel.Name = "staffTablePanel";
			this.staffTablePanel.RowCount = 6;
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.staffTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.staffTablePanel.Size = new System.Drawing.Size(605, 240);
			this.staffTablePanel.TabIndex = 0;
			// 
			// checkInDateTimePicker
			// 
			this.checkInDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkInDateTimePicker.CustomFormat = "";
			this.checkInDateTimePicker.Location = new System.Drawing.Point(391, 186);
			this.checkInDateTimePicker.Name = "checkInDateTimePicker";
			this.checkInDateTimePicker.Size = new System.Drawing.Size(211, 23);
			this.checkInDateTimePicker.TabIndex = 23;
			// 
			// degreeComboBox
			// 
			this.degreeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.degreeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.degreeComboBox.FormattingEnabled = true;
			this.degreeComboBox.Items.AddRange(new object[] {
			"Đại học",
			"Cao đẳng",
			"Phổ thông"});
			this.degreeComboBox.Location = new System.Drawing.Point(391, 98);
			this.degreeComboBox.Name = "degreeComboBox";
			this.degreeComboBox.Size = new System.Drawing.Size(211, 23);
			this.degreeComboBox.TabIndex = 21;
			// 
			// checkInLabel
			// 
			this.checkInLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.checkInLabel.AutoSize = true;
			this.checkInLabel.Location = new System.Drawing.Point(305, 190);
			this.checkInLabel.Name = "checkInLabel";
			this.checkInLabel.Size = new System.Drawing.Size(80, 15);
			this.checkInLabel.TabIndex = 18;
			this.checkInLabel.Text = "Ngày vào làm";
			this.checkInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.addressTextBox.Location = new System.Drawing.Point(89, 186);
			this.addressTextBox.MaxLength = 128;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(210, 23);
			this.addressTextBox.TabIndex = 17;
			// 
			// addressLabel
			// 
			this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.addressLabel.AutoSize = true;
			this.addressLabel.Location = new System.Drawing.Point(3, 190);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(43, 15);
			this.addressLabel.TabIndex = 16;
			this.addressLabel.Text = "Địa chỉ";
			this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nationalIdTextBox
			// 
			this.nationalIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nationalIdTextBox.Location = new System.Drawing.Point(391, 142);
			this.nationalIdTextBox.MaxLength = 11;
			this.nationalIdTextBox.Name = "nationalIdTextBox";
			this.nationalIdTextBox.Size = new System.Drawing.Size(211, 23);
			this.nationalIdTextBox.TabIndex = 15;
			// 
			// nationalIdLabel
			// 
			this.nationalIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.nationalIdLabel.AutoSize = true;
			this.nationalIdLabel.Location = new System.Drawing.Point(305, 146);
			this.nationalIdLabel.Name = "nationalIdLabel";
			this.nationalIdLabel.Size = new System.Drawing.Size(43, 15);
			this.nationalIdLabel.TabIndex = 14;
			this.nationalIdLabel.Text = "CMND";
			this.nationalIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// birthdayLabel
			// 
			this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.birthdayLabel.AutoSize = true;
			this.birthdayLabel.Location = new System.Drawing.Point(3, 146);
			this.birthdayLabel.Name = "birthdayLabel";
			this.birthdayLabel.Size = new System.Drawing.Size(60, 15);
			this.birthdayLabel.TabIndex = 12;
			this.birthdayLabel.Text = "Ngày sinh";
			this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// degreeLabel
			// 
			this.degreeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.degreeLabel.AutoSize = true;
			this.degreeLabel.Location = new System.Drawing.Point(305, 102);
			this.degreeLabel.Name = "degreeLabel";
			this.degreeLabel.Size = new System.Drawing.Size(56, 15);
			this.degreeLabel.TabIndex = 10;
			this.degreeLabel.Text = "Bằng cấp";
			this.degreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// genderLabel
			// 
			this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.genderLabel.AutoSize = true;
			this.genderLabel.Location = new System.Drawing.Point(3, 102);
			this.genderLabel.Name = "genderLabel";
			this.genderLabel.Size = new System.Drawing.Size(52, 15);
			this.genderLabel.TabIndex = 8;
			this.genderLabel.Text = "Giới tính";
			this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.emailTextBox.Location = new System.Drawing.Point(391, 54);
			this.emailTextBox.MaxLength = 128;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(211, 23);
			this.emailTextBox.TabIndex = 7;
			// 
			// emailLabel
			// 
			this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(305, 58);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(36, 15);
			this.emailLabel.TabIndex = 6;
			this.emailLabel.Text = "Email";
			this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Location = new System.Drawing.Point(89, 54);
			this.nameTextBox.MaxLength = 64;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(210, 23);
			this.nameTextBox.TabIndex = 5;
			// 
			// nameLabel
			// 
			this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(3, 58);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(80, 15);
			this.nameLabel.TabIndex = 4;
			this.nameLabel.Text = "Tên nhân viên";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneNumberTextBox.Location = new System.Drawing.Point(391, 10);
			this.phoneNumberTextBox.MaxLength = 13;
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(211, 23);
			this.phoneNumberTextBox.TabIndex = 3;
			// 
			// phoneNumberLabel
			// 
			this.phoneNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.phoneNumberLabel.AutoSize = true;
			this.phoneNumberLabel.Location = new System.Drawing.Point(305, 14);
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			this.phoneNumberLabel.Size = new System.Drawing.Size(76, 15);
			this.phoneNumberLabel.TabIndex = 2;
			this.phoneNumberLabel.Text = "Số điện thoại";
			this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// idLabel
			// 
			this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.idLabel.AutoSize = true;
			this.idLabel.Location = new System.Drawing.Point(3, 14);
			this.idLabel.Name = "idLabel";
			this.idLabel.Size = new System.Drawing.Size(79, 15);
			this.idLabel.TabIndex = 0;
			this.idLabel.Text = "Mã nhân viên";
			this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// idTextBox
			// 
			this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.idTextBox.Location = new System.Drawing.Point(89, 10);
			this.idTextBox.MaxLength = 11;
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(210, 23);
			this.idTextBox.TabIndex = 1;
			// 
			// genderComboBox
			// 
			this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genderComboBox.FormattingEnabled = true;
			this.genderComboBox.Items.AddRange(new object[] {
			"Nam",
			"Nữ"});
			this.genderComboBox.Location = new System.Drawing.Point(89, 98);
			this.genderComboBox.Name = "genderComboBox";
			this.genderComboBox.Size = new System.Drawing.Size(210, 23);
			this.genderComboBox.TabIndex = 20;
			// 
			// birthdayDateTimePicker
			// 
			this.birthdayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.birthdayDateTimePicker.Location = new System.Drawing.Point(89, 142);
			this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
			this.birthdayDateTimePicker.Size = new System.Drawing.Size(210, 23);
			this.birthdayDateTimePicker.TabIndex = 22;
			// 
			// helpLabel
			// 
			this.helpLabel.AutoSize = true;
			this.staffTablePanel.SetColumnSpan(this.helpLabel, 4);
			this.helpLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.helpLabel.ForeColor = System.Drawing.Color.Red;
			this.helpLabel.Location = new System.Drawing.Point(3, 225);
			this.helpLabel.Name = "helpLabel";
			this.helpLabel.Size = new System.Drawing.Size(599, 15);
			this.helpLabel.TabIndex = 2;
			// 
			// optionGroupBox
			// 
			this.optionGroupBox.Controls.Add(this.topRightTablePanel);
			this.optionGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.optionGroupBox.Location = new System.Drawing.Point(611, 0);
			this.optionGroupBox.Name = "optionGroupBox";
			this.optionGroupBox.Size = new System.Drawing.Size(272, 262);
			this.optionGroupBox.TabIndex = 4;
			this.optionGroupBox.TabStop = false;
			this.optionGroupBox.Text = "Tùy chọn";
			// 
			// topRightTablePanel
			// 
			this.topRightTablePanel.ColumnCount = 2;
			this.topRightTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.topRightTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.topRightTablePanel.Controls.Add(this.filterLabel, 0, 0);
			this.topRightTablePanel.Controls.Add(this.filterComboBox, 1, 0);
			this.topRightTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.topRightTablePanel.Location = new System.Drawing.Point(3, 19);
			this.topRightTablePanel.Name = "topRightTablePanel";
			this.topRightTablePanel.RowCount = 2;
			this.topRightTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.topRightTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.topRightTablePanel.Size = new System.Drawing.Size(266, 240);
			this.topRightTablePanel.TabIndex = 1;
			// 
			// filterLabel
			// 
			this.filterLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.filterLabel.AutoSize = true;
			this.filterLabel.Location = new System.Drawing.Point(3, 7);
			this.filterLabel.Name = "filterLabel";
			this.filterLabel.Size = new System.Drawing.Size(100, 15);
			this.filterLabel.TabIndex = 0;
			this.filterLabel.Text = "Nội dung cần tìm";
			this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// filterComboBox
			// 
			this.filterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.filterComboBox.FormattingEnabled = true;
			this.filterComboBox.Items.AddRange(new object[] {
			"Mã nhân viên",
			"Tên nhân viên",
			"Số điện thoại",
			"Email"});
			this.filterComboBox.Location = new System.Drawing.Point(109, 3);
			this.filterComboBox.Name = "filterComboBox";
			this.filterComboBox.Size = new System.Drawing.Size(154, 23);
			this.filterComboBox.TabIndex = 1;
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this.bottomTablePanel);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomPanel.Location = new System.Drawing.Point(0, 262);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(883, 224);
			this.bottomPanel.TabIndex = 1;
			// 
			// bottomTablePanel
			// 
			this.bottomTablePanel.ColumnCount = 2;
			this.bottomTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.bottomTablePanel.Controls.Add(this.staffGridViewGroupBox, 0, 0);
			this.bottomTablePanel.Controls.Add(this.actionGroupBox, 1, 0);
			this.bottomTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomTablePanel.Location = new System.Drawing.Point(0, 0);
			this.bottomTablePanel.Name = "bottomTablePanel";
			this.bottomTablePanel.RowCount = 1;
			this.bottomTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.bottomTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.bottomTablePanel.Size = new System.Drawing.Size(883, 224);
			this.bottomTablePanel.TabIndex = 0;
			// 
			// staffGridViewGroupBox
			// 
			this.staffGridViewGroupBox.Controls.Add(this.staffDataGridView);
			this.staffGridViewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.staffGridViewGroupBox.Location = new System.Drawing.Point(3, 3);
			this.staffGridViewGroupBox.Name = "staffGridViewGroupBox";
			this.staffGridViewGroupBox.Size = new System.Drawing.Size(717, 218);
			this.staffGridViewGroupBox.TabIndex = 4;
			this.staffGridViewGroupBox.TabStop = false;
			this.staffGridViewGroupBox.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
			// 
			// staffDataGridView
			// 
			this.staffDataGridView.AllowUserToAddRows = false;
			this.staffDataGridView.AutoGenerateColumns = false;
			this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.idDataGridViewTextBoxColumn,
			this.nationalIdDataGridViewTextBoxColumn,
			this.nameDataGridViewTextBoxColumn,
			this.phoneNumberDataGridViewTextBoxColumn,
			this.isMaleDataGridViewCheckBoxColumn,
			this.emailDataGridViewTextBoxColumn,
			this.degreeDataGridViewTextBoxColumn,
			this.birthdayDataGridViewTextBoxColumn,
			this.addressDataGridViewTextBoxColumn,
			this.checkInDateDataGridViewTextBoxColumn});
			this.staffDataGridView.DataSource = this.staffModelBindingSource;
			this.staffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.staffDataGridView.Location = new System.Drawing.Point(3, 19);
			this.staffDataGridView.Name = "staffDataGridView";
			this.staffDataGridView.RowTemplate.Height = 25;
			this.staffDataGridView.Size = new System.Drawing.Size(711, 196);
			this.staffDataGridView.TabIndex = 0;
			this.staffDataGridView.ReadOnly = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// nationalIdDataGridViewTextBoxColumn
			// 
			this.nationalIdDataGridViewTextBoxColumn.DataPropertyName = "NationalId";
			this.nationalIdDataGridViewTextBoxColumn.HeaderText = "NationalId";
			this.nationalIdDataGridViewTextBoxColumn.Name = "nationalIdDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			// 
			// isMaleDataGridViewCheckBoxColumn
			// 
			this.isMaleDataGridViewCheckBoxColumn.DataPropertyName = "IsMale";
			this.isMaleDataGridViewCheckBoxColumn.HeaderText = "IsMale";
			this.isMaleDataGridViewCheckBoxColumn.Name = "isMaleDataGridViewCheckBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// degreeDataGridViewTextBoxColumn
			// 
			this.degreeDataGridViewTextBoxColumn.DataPropertyName = "Degree";
			this.degreeDataGridViewTextBoxColumn.HeaderText = "Degree";
			this.degreeDataGridViewTextBoxColumn.Name = "degreeDataGridViewTextBoxColumn";
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// checkInDateDataGridViewTextBoxColumn
			// 
			this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
			this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
			this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
			// 
			// staffModelBindingSource
			// 
			this.staffModelBindingSource.DataSource = typeof(WFApp.Models.StaffModel);
			// 
			// actionGroupBox
			// 
			this.actionGroupBox.Controls.Add(this.actionFlowPanel);
			this.actionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.actionGroupBox.Location = new System.Drawing.Point(726, 3);
			this.actionGroupBox.Name = "actionGroupBox";
			this.actionGroupBox.Size = new System.Drawing.Size(154, 218);
			this.actionGroupBox.TabIndex = 1;
			this.actionGroupBox.TabStop = false;
			this.actionGroupBox.Text = "Hành động";
			// 
			// actionFlowPanel
			// 
			this.actionFlowPanel.Controls.Add(this.addButton);
			this.actionFlowPanel.Controls.Add(this.searchButton);
			this.actionFlowPanel.Controls.Add(this.modifyButton);
			this.actionFlowPanel.Controls.Add(this.deleteButton);
			this.actionFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.actionFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.actionFlowPanel.Location = new System.Drawing.Point(3, 19);
			this.actionFlowPanel.Name = "actionFlowPanel";
			this.actionFlowPanel.Size = new System.Drawing.Size(148, 196);
			this.actionFlowPanel.TabIndex = 0;
			// 
			// addButton
			// 
			this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.addButton.AutoSize = true;
			this.addButton.Location = new System.Drawing.Point(3, 3);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(142, 25);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Thêm";
			this.addButton.UseVisualStyleBackColor = true;
			// 
			// searchButton
			// 
			this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.searchButton.AutoSize = true;
			this.searchButton.Location = new System.Drawing.Point(3, 34);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(142, 25);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "Tìm kiếm";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// modifyButton
			// 
			this.modifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.modifyButton.AutoSize = true;
			this.modifyButton.Location = new System.Drawing.Point(3, 65);
			this.modifyButton.Name = "modifyButton";
			this.modifyButton.Size = new System.Drawing.Size(142, 25);
			this.modifyButton.TabIndex = 2;
			this.modifyButton.Text = "Sửa";
			this.modifyButton.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.deleteButton.AutoSize = true;
			this.deleteButton.Location = new System.Drawing.Point(3, 96);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(142, 25);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "Xóa";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// StaffManageUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "StaffManageUserControl";
			this.Size = new System.Drawing.Size(883, 486);
			this.topPanel.ResumeLayout(false);
			this.staffGroupBox.ResumeLayout(false);
			this.staffGroupBox.PerformLayout();
			this.staffTablePanel.ResumeLayout(false);
			this.staffTablePanel.PerformLayout();
			this.optionGroupBox.ResumeLayout(false);
			this.topRightTablePanel.ResumeLayout(false);
			this.topRightTablePanel.PerformLayout();
			this.bottomPanel.ResumeLayout(false);
			this.bottomTablePanel.ResumeLayout(false);
			this.staffGridViewGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffModelBindingSource)).EndInit();
			this.actionGroupBox.ResumeLayout(false);
			this.actionFlowPanel.ResumeLayout(false);
			this.actionFlowPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Panel topPanel;
		private GroupBox staffGroupBox;
		private Panel bottomPanel;
		private TableLayoutPanel staffTablePanel;
		private Label idLabel;
		private TextBox idTextBox;
		private TextBox phoneNumberTextBox;
		private Label phoneNumberLabel;
		private Label checkInLabel;
		private TextBox addressTextBox;
		private Label addressLabel;
		private TextBox nationalIdTextBox;
		private Label nationalIdLabel;
		private Label birthdayLabel;
		private Label degreeLabel;
		private Label genderLabel;
		private TextBox emailTextBox;
		private Label emailLabel;
		private TextBox nameTextBox;
		private Label nameLabel;
		private ComboBox genderComboBox;
		private ComboBox degreeComboBox;
		private DateTimePicker birthdayDateTimePicker;
		private DateTimePicker checkInDateTimePicker;
		private TableLayoutPanel topRightTablePanel;
		private Label filterLabel;
		private ComboBox filterComboBox;
		private TableLayoutPanel bottomTablePanel;
		private DataGridView staffDataGridView;
		private GroupBox actionGroupBox;
		private FlowLayoutPanel actionFlowPanel;
		private Button addButton;
		private Button searchButton;
		private Button modifyButton;
		private Button deleteButton;
		private GroupBox optionGroupBox;
		private GroupBox staffGridViewGroupBox;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nationalIdDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
		private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn degreeDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
		private BindingSource staffModelBindingSource;
		private Label helpLabel;
	}
}
