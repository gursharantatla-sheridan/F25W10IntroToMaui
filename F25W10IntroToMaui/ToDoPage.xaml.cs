using System.Collections.ObjectModel;

namespace F25W10IntroToMaui;

public partial class ToDoPage : ContentPage
{
	private ObservableCollection<string> tasks = new ObservableCollection<string>();

	public ToDoPage()
	{
		InitializeComponent();
		lvTasks.ItemsSource = tasks;
	}

    private void btnAddTask_Clicked(object sender, EventArgs e)
    {
		if (!string.IsNullOrWhiteSpace(txtTask.Text))
		{
			tasks.Add(txtTask.Text);
			txtTask.Text = "";
			txtTask.Focus();
		}
    }
}