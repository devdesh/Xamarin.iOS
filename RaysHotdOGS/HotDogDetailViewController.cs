using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotdOGS
{
    public partial class HotDogDetailViewController : UIViewController
    {
		public HotDog SelectedHotDog
		{
			get;
			set;
		}	

        public HotDogDetailViewController (IntPtr handle) : base (handle)
        {
			HotDogDataService service = new HotDogDataService();
			//SelectedHotDog = service.GetHotDogByID(1);
        }


		private void BindUIData()
		{
			UIImage image = UIImage.FromFile("Images/hotDog1.jpg");
			imageViewHotDog.Image = image;
			lblName.Text = SelectedHotDog.Name;
			lblPrice.Text = "$" + SelectedHotDog.Price;
			//txtDescription.Text = SelectedHotDog.ShortDescription;

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			BindUIData();
			btnAddToCart.TouchUpInside += (object sender, EventArgs e) =>
			{
				UIAlertView message = new UIAlertView("Rays Hot Dogs", "Your Hot Dog has been added to cart!",null, "", null);
				message.Show();
			};
		}
    }
}