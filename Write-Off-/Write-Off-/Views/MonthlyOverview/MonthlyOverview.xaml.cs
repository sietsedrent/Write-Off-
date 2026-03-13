using Write_Off_.ViewModels.MonthlyOverview;

namespace Write_Off_.Views.MonthlyOverview;

public partial class MonthlyOverview : ContentPage
{
    public MonthlyOverviewViewModel ViewModel { get; set; }

    public MonthlyOverview()
	{
		InitializeComponent();
	}

}