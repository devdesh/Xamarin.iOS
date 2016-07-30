// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RaysHotdOGS
{
    [Register ("HotDogDetailViewController")]
    partial class HotDogDetailViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnAddToCart { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageViewHotDog { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNoOfHotDogs { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtViewDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnAddToCart != null) {
                btnAddToCart.Dispose ();
                btnAddToCart = null;
            }

            if (btnCancel != null) {
                btnCancel.Dispose ();
                btnCancel = null;
            }

            if (imageViewHotDog != null) {
                imageViewHotDog.Dispose ();
                imageViewHotDog = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (lblPrice != null) {
                lblPrice.Dispose ();
                lblPrice = null;
            }

            if (txtNoOfHotDogs != null) {
                txtNoOfHotDogs.Dispose ();
                txtNoOfHotDogs = null;
            }

            if (txtViewDescription != null) {
                txtViewDescription.Dispose ();
                txtViewDescription = null;
            }
        }
    }
}