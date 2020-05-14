using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App238.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(myNaviRenderer))]
namespace App238.iOS
{
    class myNaviRenderer : NavigationRenderer
    {

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            //this.EdgesForExtendedLayout = UIRectEdge.None;
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            this.NavigationBar.BackgroundColor = UIColor.Red;
            this.NavigationBar.Frame = new CoreGraphics.CGRect(0, 0, View.Frame.Size.Width, 100);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

           
        }
    }
}