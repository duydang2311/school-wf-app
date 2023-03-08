using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WFApp.ViewModels;

public class MainFormViewModel : INotifyPropertyChanged
{
	private ToolStripItem activeItem;
	private readonly Control pagePanel;

	public ToolStripItem ActiveItem
	{
		get => activeItem;
		set
		{
			activeItem = value;
			if (activeItem.Tag is Control control)
			{
				pagePanel.SuspendLayout();
				pagePanel.Controls.Clear();
				control.Dock = DockStyle.Fill;
				pagePanel.Controls.Add(control);
				pagePanel.ResumeLayout(false);
				pagePanel.PerformLayout();
			}
			OnPropertyChanged();
		}
	}

	public MainFormViewModel(Control pagePanel, ToolStripItem activeItem)
	{
		this.pagePanel = pagePanel;
		this.activeItem = activeItem;
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	private void OnPropertyChanged([CallerMemberName] string name = "")
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
