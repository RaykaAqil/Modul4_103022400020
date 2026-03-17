using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400020
{
    public class KodePaket
    {
        public enum NamaPaket { Basic, Standar, Premium, 
                Unlimited, Gaming, Streming, Family, Business, Stuident,
                Traveler}

        public static string getKodePaket(NamaPaket namaPaket)
        {
            string[] kodePaket = { "P201", "P202", "P203", "P204",
                "P205", "P206", "P207", "P208", "P209", "P210" };

            return kodePaket[(int) namaPaket];
        }
    }
}
