// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipCalc.iOS
{
    [Register ("InformationView")]
    partial class InformationView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton BuGidelim { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider GenerositySlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SubTotalTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BuGidelim != null) {
                BuGidelim.Dispose ();
                BuGidelim = null;
            }

            if (GenerositySlider != null) {
                GenerositySlider.Dispose ();
                GenerositySlider = null;
            }

            if (GoBack != null) {
                GoBack.Dispose ();
                GoBack = null;
            }

            if (SubTotalTextField != null) {
                SubTotalTextField.Dispose ();
                SubTotalTextField = null;
            }

            if (TipLabel != null) {
                TipLabel.Dispose ();
                TipLabel = null;
            }
        }
    }
}