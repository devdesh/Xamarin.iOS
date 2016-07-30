using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace RaysHotdOGS
{
	public class HotDogListCell : UITableViewCell
	{
		UIImageView imageView;
		UILabel lableName;
		UILabel labelPrice;


		public HotDogListCell(string cellIdentifier) : base(UITableViewCellStyle.Default, cellIdentifier)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
			ContentView.BackgroundColor = UIColor.FromRGB(254, 199, 101);
			imageView = new UIImageView();
			lableName = new UILabel()
			{
				Font = UIFont.FromName("Cochin-BoldItalic", 18f),
				TextColor = UIColor.FromRGB(255, 255, 255),
				BackgroundColor = UIColor.Clear
			};
			labelPrice = new UILabel()
			{
				Font = UIFont.FromName("AmericanTypewriter", 12f),
				TextColor = UIColor.FromRGB(228, 79, 61),
				BackgroundColor = UIColor.Clear,
				TextAlignment = UITextAlignment.Center
			};

			ContentView.Add(imageView);
			ContentView.Add(lableName);
			ContentView.Add(labelPrice);

		}

		public override void LayoutSubviews()
		{
			base.LayoutSubviews();

			imageView.Frame = new Rectangle ((int)((nint)ContentView.Bounds.Width - 63), 5, 33, 33);
			lableName.Frame = new RectangleF(5, 4, (int)ContentView.Bounds.Width - 63, 25);
			labelPrice.Frame = new RectangleF(200, 10, 100, 20);
		}

		public void UpdateCell(string name,string price,UIImage image)
		{
			imageView.Image = image;
			lableName.Text = name;
			labelPrice.Text = price;
		}
	}
}

