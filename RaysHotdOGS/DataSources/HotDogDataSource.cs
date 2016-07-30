using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core;
using UIKit;

namespace RaysHotdOGS
{
	public class HotDogDataSource : UITableViewSource
	{
		private List<HotDog> hotDogs;
		NSString cellIdentifier = new NSString("HotDogCell");
		UITableViewController controller;

		public HotDogDataSource(List<HotDog> hotDogs, UITableViewController controller)
		{
			this.hotDogs = hotDogs;
			this.controller = controller;

		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return	hotDogs.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			//UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;
			//if (cell == null)
			//{
			//	cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			//}
			//HotDog hotDog = this.hotDogs[indexPath.Row];
			//cell.TextLabel.Text = hotDog.Name;
			//cell.ImageView.Image = UIImage.FromFile("Images/hotDog1.jpg");
			//return cell;

			HotDog hotDog = this.hotDogs[indexPath.Row];
			HotDogListCell cell = tableView.DequeueReusableCell("HotDogCell") as HotDogListCell;
			if (cell == null)
			{

				cell = new HotDogListCell("HotDogCell");
			}
			cell.UpdateCell(hotDog.Name, hotDog.Price.ToString(), UIImage.FromFile("Images/hotDog1.jpg"));
			return cell;
		}

		public HotDog GetItem(int id)
		{
			return this.hotDogs[id];
		}


		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			controller.PerformSegue("HotDogDetailSegue", this);
		}
	}
}

