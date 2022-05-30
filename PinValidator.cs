using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpHub
{
    public class PinValidator
    {
        public static bool ValidatePin(string pin) => Regex.IsMatch(pin, @"^\d{6}$|^\d{4}$");
    }
}
