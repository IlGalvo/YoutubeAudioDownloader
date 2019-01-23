using System;

namespace YoutubeClientManager
{
    internal static class Utilities
    {
        #region GENERAL
        public static string ValidateGenericField(string genericField, string fieldName)
        {
            if (genericField == null)
            {
                throw (new ArgumentNullException(fieldName));
            }

            genericField = genericField.Trim().Normalize();

            if (genericField == string.Empty)
            {
                throw new ArgumentException(fieldName);
            }

            return genericField;
        }

        public static string ExtractValue(string fullText, string keyStart, string keyStop)
        {
            fullText = fullText.Substring((fullText.IndexOf(keyStart) + keyStart.Length));

            return (fullText.Substring(0, fullText.IndexOf(keyStop)));
        }
        #endregion
    }
}
