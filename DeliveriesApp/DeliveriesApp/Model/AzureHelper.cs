using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveriesApp.Model
{
    public class AzureHelper
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://xamarinstef2.azurewebsites.net");

        public static async Task<bool> Insert<T>(T objectToInsert)
        {
            try
            {
                await MobileService.GetTable<T>().InsertAsync(objectToInsert);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
