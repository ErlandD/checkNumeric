using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkNumeric
{
    public class isNumeric
    {
        public static Boolean check(String text)
        {
            int parsedValue;
            if (!int.TryParse(text, out parsedValue))
            {
                return false;
            } return true;
        }
    }
}
