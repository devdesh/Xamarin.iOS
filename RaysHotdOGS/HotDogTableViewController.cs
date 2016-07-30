using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotdOGS
{
    public partial class HotDogTableViewController : UITableViewController
    {
		HotDogDataService dataService = new HotDogDataService();

        public HotDogTableViewController (IntPtr handle) : base (handle)
        {
			
        }


		public override void ViewDidLoad()
		{
			var hotDogs = dataService.GetAllHotDogs();
			HotDogDataSource dataSource = new HotDogDataSource(hotDogs, this);
			TableView.Source = dataSource;
			TableView.AllowsSelection = true;
			this.NavigationItem.Title = "Hot Dog Menu";
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			if (segue.Identifier == "HotDogDetailSegue")
			{
				var hotDogDetailViewController = segue.DestinationViewController as HotDogDetailViewController;
				if (hotDogDetailViewController != null)
				{
					HotDogDataSource hotDogDataSource = TableView.Source as HotDogDataSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var hotDog = hotDogDataSource.GetItem(rowPath.Row);
					hotDogDetailViewController.SelectedHotDog = hotDog;
				}

			}

		}


		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			this.PerformSegue("HotDogDetailSegue", this);
		}

    }
}