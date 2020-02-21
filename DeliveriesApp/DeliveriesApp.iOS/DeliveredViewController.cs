using DeliveriesApp.Model;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace DeliveriesApp.iOS
{
    public partial class DeliveredViewController : UITableViewController
    {
        List<Delivery> delivered;
        public DeliveredViewController (IntPtr handle) : base (handle)
        {
            delivered = new List<Delivery>();
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            delivered = await Delivery.GetDelivered();
            TableView.ReloadData();
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return delivered.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("deliveredCell") as DeliveredTableViewCell;

            var deliveredValue = delivered[indexPath.Row];
            cell.nameLabel.Text = deliveredValue.Naam;
            cell.coordinatesLabel.Text = $"{deliveredValue.DestinationLatitude}, {deliveredValue.DestinationLongitude}";
            switch (deliveredValue.Status)
            {
                case 0:
                    cell.statusLabel.Text = "Wachten op Leveringspersoon";
                    break;
                case 1:
                    cell.statusLabel.Text = "wordt geleverd";
                    break;
                case 2:
                    cell.statusLabel.Text = "Geleverd";
                    break;
            }

            return base.GetCell(tableView, indexPath);
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 60;
        }
    }
}