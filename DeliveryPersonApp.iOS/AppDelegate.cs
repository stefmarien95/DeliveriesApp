﻿using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using UIKit;

namespace DeliveryPersonApp.iOS
{
   
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
  

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            
            CurrentPlatform.Init();

            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
           
        }

        public override void DidEnterBackground(UIApplication application)
        {
        }

        public override void WillEnterForeground(UIApplication application)
        {
          
        }

        public override void OnActivated(UIApplication application)
        {
         
        }

        public override void WillTerminate(UIApplication application)
        {
        }
    }
}