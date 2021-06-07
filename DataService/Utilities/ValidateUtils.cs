using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataService.Utilities
{
    public static class ValidateUtils
    {
        public static bool IsPicture(string type)
        {
            string[] pictureType = new string[]
            {
                "image/jpg",
                "image/jpeg",
                "image/pjpeg",
                "image/gif",
                "image/x-png",
                "image/png",
            };
            if (pictureType.Contains(type.ToLower())) return true;
            return false;
        }
    }
}
