using System;
using System.Collections.Generic;
using UIKit;

namespace TableViewApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            List<string> fruits = new List<string>{ "Apple","Mango","Pineapple","Banana","Kiwi"};
            // Perform any additional setup after loading the view, typically from a nib.
            FruitsTableView.Source = new FruitsTableViewSource(fruits);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

        }
    }
}
