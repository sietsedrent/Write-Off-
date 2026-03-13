using Write_Off_.ViewModels.Components;
using Write_Off_Business.Models;
using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace Write_Off_.ViewModels.AddNewWorkItem;

public class AddNewWorkItemViewModel : ViewModel
{
	private readonly WorkItem work;
	private double _newPoints;
	private string _newName;
	private bool _newFinished;
	
	public double NewPoints
	{
		get { return _newPoints; }
		set { SetField(ref _newPoints, value); }
	}

	public string NewName
	{
		get { return _newName; }
		set { SetField(ref _newName, value); }
	}

	public bool NewFinished
	{
		get { return _newFinished; }
		set { SetField(ref _newFinished, value); }
	}

	public AddNewWorkItemViewModel() {
	}

    

    public void CreateTask()
    {
        //Ophalen info om mee te geven

        //Het aanmaken object met de ingevulde informatie -> ook nog textfields en labels plaatsen
        WorkItem _work = new WorkItem(Guid.NewGuid(), NewName, NewPoints, NewFinished);
        //Object meegeven aan WorkList zodat deze aan array van info in xaml getoond kan worden

    }
}