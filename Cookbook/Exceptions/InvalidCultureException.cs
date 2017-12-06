using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cookbook.Exceptions
{
    public class InvalidCultureException : SystemException
    {
        public InvalidCultureException(string lang) : base($"Le code culture spécifié {lang} est invalide.")
        {

        }
    }
}