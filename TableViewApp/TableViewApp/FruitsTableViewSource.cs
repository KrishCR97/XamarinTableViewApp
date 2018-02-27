using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace TableViewApp
{
    public class FruitsTableViewSource : UITableViewSource
    {
        private List<string> fruits;

        public FruitsTableViewSource()
        {
        }

        public FruitsTableViewSource(List<string> fruits)
        {
            this.fruits = fruits;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = fruits[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return fruits.Count;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            Console.WriteLine(fruits[indexPath.Row]);
        }
    }
}
