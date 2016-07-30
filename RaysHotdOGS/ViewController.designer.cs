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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnOrderNow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageViewRaysHotDogs { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelShortDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtFullDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtNoOfHotDogs { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCancel != null) {
                btnCancel.Dispose ();
                btnCancel = null;
            }

            if (btnOrderNow != null) {
                btnOrderNow.Dispose ();
                btnOrderNow = null;
            }

            if (imageViewRaysHotDogs != null) {
                imageViewRaysHotDogs.Dispose ();
                imageViewRaysHotDogs = null;
            }

            if (labelShortDescription != null) {
                labelShortDescription.Dispose ();
                labelShortDescription = null;
            }

            if (txtFullDescription != null) {
                txtFullDescription.Dispose ();
                txtFullDescription = null;
            }

            if (txtNoOfHotDogs != null) {
                txtNoOfHotDogs.Dispose ();
                txtNoOfHotDogs = null;
            }
        }
    }
}