using Write_Off_.Views.AddNewWorkItem;
using Write_Off_Business.Models;


namespace Write_Off_
{
    public partial class MainPage : ContentPage
    {
        public Dictionary<int, bool> alreadyClicked = new Dictionary<int, bool>();
        public WorkList workList;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Finished(object? sender, EventArgs e)
        {
            //int id ophalen -> WorkList.WorkItem.Id ?
            //Filteren op of al aangeklikt is
            FinishedBtn.Background = new SolidColorBrush(Colors.Green);
        }

        //Aanmaken workitem
        //Moet ook nog nieuwe form tonen
        private async void CreateWorkItem(object? sender, EventArgs e) 
        {

            await Navigation.PushAsync(new AddNewWorkItem());
            //Dit doen in de nieuwe page.xaml.cs
            //WorkItem item = new WorkItem();
        }


        //Ook nog xaml page aanmaken
        private async void CreateWorkItemPage(object? sender, EventArgs e)
        {
            //Doorverwijzen nieuwe xaml popup

            //+ een back to page (popup) erin zetten in de nieuwe xaml.cs
        }
    }
}
