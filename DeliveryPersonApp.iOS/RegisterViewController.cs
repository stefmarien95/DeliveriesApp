using DeliveriesApp.Model;
using Foundation;
using System;
using UIKit;

namespace DeliveryPersonApp.iOS
{
    public partial class RegisterViewController : UIViewController
    {
        public RegisterViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            registerSaveButton.TouchUpInside += RegisterSaveButton_TouchUpInside;
        }

        private async void RegisterSaveButton_TouchUpInside(object sender, EventArgs e)
        {
            bool success = await DeliveryPerson.Register(emailTextField.Text, passwordTextField.Text, confirmPasswordTextField.Text);

            UIAlertController alert = null;
            if (success)
                alert = UIAlertController.Create("Success", "Nieuwe gebruiker is geregistreerd", UIAlertControllerStyle.Alert);
            else
                alert = UIAlertController.Create("Fout", "Er is iets fout gegaan probeer het late nog eens", UIAlertControllerStyle.Alert);

            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }
    }
}