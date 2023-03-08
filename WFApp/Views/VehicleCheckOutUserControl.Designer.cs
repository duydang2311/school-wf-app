
namespace WFApp.Views;

partial class VehicleCheckOutUserControl
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

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.gvveout = new System.Windows.Forms.DataGridView();
		this.comboBox1 = new System.Windows.Forms.ComboBox();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
		this.label3 = new System.Windows.Forms.Label();
		this.textBox2 = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.button3 = new System.Windows.Forms.Button();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		((System.ComponentModel.ISupportInitialize)(this.gvveout)).BeginInit();
		this.groupBox1.SuspendLayout();
		this.SuspendLayout();
		// 
		// linkLabel1
		// 
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Location = new System.Drawing.Point(771, 262);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(77, 20);
		this.linkLabel1.TabIndex = 12;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "VehicleIN";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		// 
		// gvveout
		// 
		this.gvveout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.gvveout.Location = new System.Drawing.Point(36, 285);
		this.gvveout.Name = "gvveout";
		this.gvveout.RowHeadersWidth = 62;
		this.gvveout.RowTemplate.Height = 28;
		this.gvveout.Size = new System.Drawing.Size(812, 356);
		this.gvveout.TabIndex = 11;
		// 
		// comboBox1
		// 
		this.comboBox1.FormattingEnabled = true;
		this.comboBox1.Items.AddRange(new object[] {
			"VehicleID",
			"Time out",
			"Cost",
			"Status",
			"CardID",
			"Color"});
		this.comboBox1.Location = new System.Drawing.Point(153, 47);
		this.comboBox1.Name = "comboBox1";
		this.comboBox1.Size = new System.Drawing.Size(223, 28);
		this.comboBox1.TabIndex = 8;
		// 
		// button2
		// 
		this.button2.Location = new System.Drawing.Point(454, 125);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(122, 44);
		this.button2.TabIndex = 7;
		this.button2.Text = "RESET";
		this.button2.UseVisualStyleBackColor = true;
		// 
		// button1
		// 
		this.button1.Location = new System.Drawing.Point(454, 47);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(122, 44);
		this.button1.TabIndex = 6;
		this.button1.Text = "SEARCH";
		this.button1.UseVisualStyleBackColor = true;
		// 
		// dateTimePicker1
		// 
		this.dateTimePicker1.Location = new System.Drawing.Point(153, 142);
		this.dateTimePicker1.Name = "dateTimePicker1";
		this.dateTimePicker1.Size = new System.Drawing.Size(223, 26);
		this.dateTimePicker1.TabIndex = 5;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(24, 148);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(44, 20);
		this.label3.TabIndex = 4;
		this.label3.Text = "Date";
		// 
		// textBox2
		// 
		this.textBox2.Location = new System.Drawing.Point(153, 91);
		this.textBox2.Name = "textBox2";
		this.textBox2.Size = new System.Drawing.Size(223, 26);
		this.textBox2.TabIndex = 3;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(24, 97);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(35, 20);
		this.label2.TabIndex = 2;
		this.label2.Text = "Key";
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(24, 55);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(71, 20);
		this.label1.TabIndex = 0;
		this.label1.Text = "InfoType";
		// 
		// button3
		// 
		this.button3.Location = new System.Drawing.Point(726, 120);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(122, 44);
		this.button3.TabIndex = 13;
		this.button3.Text = "UPDATE";
		this.button3.UseVisualStyleBackColor = true;
		// 
		// groupBox1
		// 
		this.groupBox1.Controls.Add(this.comboBox1);
		this.groupBox1.Controls.Add(this.button2);
		this.groupBox1.Controls.Add(this.button1);
		this.groupBox1.Controls.Add(this.dateTimePicker1);
		this.groupBox1.Controls.Add(this.label3);
		this.groupBox1.Controls.Add(this.textBox2);
		this.groupBox1.Controls.Add(this.label2);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Location = new System.Drawing.Point(36, 35);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(657, 207);
		this.groupBox1.TabIndex = 10;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "SEARCH";
		// 
		// VehicleOUT
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(886, 681);
		this.Controls.Add(this.linkLabel1);
		this.Controls.Add(this.gvveout);
		this.Controls.Add(this.button3);
		this.Controls.Add(this.groupBox1);
		this.Name = "VehicleOUT";
		this.Text = "VehicleOUT";
		this.Load += new System.EventHandler(this.VehicleOUT_Load);
		((System.ComponentModel.ISupportInitialize)(this.gvveout)).EndInit();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.LinkLabel linkLabel1;
	private System.Windows.Forms.DataGridView gvveout;
	private System.Windows.Forms.ComboBox comboBox1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.DateTimePicker dateTimePicker1;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.GroupBox groupBox1;
}
