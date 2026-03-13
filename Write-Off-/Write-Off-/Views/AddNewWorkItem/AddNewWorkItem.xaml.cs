using Write_Off_Business.Models;
using Write_Off_.ViewModels;
using Write_Off_.ViewModels.AddNewWorkItem;


namespace Write_Off_.Views.AddNewWorkItem;

public partial class AddNewWorkItem : ContentPage
{	public AddNewWorkItemViewModel ViewModel { get; set; }
	public AddNewWorkItem()
	{
		InitializeComponent();
        BindingContext = new AddNewWorkItemViewModel();
        ViewModel = new AddNewWorkItemViewModel();

    }

    public async void GoBack(object? sender, EventArgs e)
	{
		await Navigation.PopAsync();

    }

	public async void CreateNewTask(object? sender, EventArgs e)
	{
		ViewModel.CreateTask();
		await Navigation.PopAsync();
	}


}