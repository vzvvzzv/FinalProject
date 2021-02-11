using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //degisken olmasina ragmen buyuk harfli yazdik cunku public, private olsaydi productAdded olurdu.
        public static string ProductAdded = "Urun eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakimda.";
        public static string ProductsListed = "Urunler listelendi.";
    }
}
