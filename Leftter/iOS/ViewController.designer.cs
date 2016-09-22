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

namespace Leftter.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton getButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView logTextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton sendButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField sendText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (getButton != null) {
                getButton.Dispose ();
                getButton = null;
            }

            if (logTextView != null) {
                logTextView.Dispose ();
                logTextView = null;
            }

            if (sendButton != null) {
                sendButton.Dispose ();
                sendButton = null;
            }

            if (sendText != null) {
                sendText.Dispose ();
                sendText = null;
            }
        }
    }
}