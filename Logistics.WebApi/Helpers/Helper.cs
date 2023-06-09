﻿using System;
using System.Text.RegularExpressions;

namespace Logistics.WebApi.Helpers
{
    public class Helper
    {
        public static bool IsValidPhoneNumer(string? phoneNumber)
        {
            string pattern = @"^1[3456789]\d{9}$";
            if (string.IsNullOrEmpty(phoneNumber))
                return true;
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}

