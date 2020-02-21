using Foundation;
using Plugin.InAppBilling;
using Plugin.InAppBilling.Abstractions;
using System;
using UIKit;

namespace DeliveriesApp.iOS
{
    public partial class MainTabBarController : UITabBarController
    {
        public MainTabBarController (IntPtr handle) : base (handle)
        {
            subscriptionBarButtonItem.Clicked += SubscriptionBarButtonItem_Clicked;
        }

        private async void SubscriptionBarButtonItem_Clicked(object sender, EventArgs e)
        {
            try
            {
                var productId = "com.lalorosas.deliveriesapp.premiumdeliveries";

                var connection = await CrossInAppBilling.Current.ConnectAsync();

                if(!connection)
                {
                    return;
                }

                var purchase = await CrossInAppBilling.Current.PurchaseAsync(productId, Plugin.InAppBilling.Abstractions.ItemType.Subscription, "apppayload");

                if(purchase == null)
                {
                    //! No purchase
                }
                else
                {
                    var id = purchase.Id;
                    var token = purchase.PurchaseToken;
                    var state = purchase.State;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                await CrossInAppBilling.Current.DisconnectAsync();
            }
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            NavigationItem.SetHidesBackButton(true, false);
        }
    }
}