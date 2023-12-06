﻿namespace AkarCommerce.MusicStore.Core.Utilites.Security.TypeConversation.StringConversation
{
    public static class StringConversation
    {
        public static string NormalizeUpperCase(string value)
        {
            value = value.ToUpper();
            value = value.Trim();
            value = value.Replace("İ", "I");
            value = value.Replace("Ö", "O");
            value = value.Replace("Ü", "U");
            return value;
        }
    }
}
