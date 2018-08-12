﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank_uwp.Utilities
{
    public static class DonateUtility
    {
        public static string GetValidurchaseName(string storeName)
        {
            switch (storeName)
            {
                case "piggy_one":
                    return "Not bad!";
                case "piggy_two":
                    return "Good!";
                case "piggy_tree":
                    return "Very good!";
                case "piggy_four":
                    return "Excellently!";
                case "piggy_five":
                    return "OMG!";
                default:
                    return "A new item";
            }
        }
    }
}
