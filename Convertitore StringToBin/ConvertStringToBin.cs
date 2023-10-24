using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertitore_StringToBin
{
    internal class ConvertStringToBin
    {
        public string InputText { get; set; }
        public string ExportText { get; set; }
        public ConvertStringToBin(string iT)
        {
            InputText = iT;
        }

        internal string Converts()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(InputText);

            foreach (byte b in bytes)
            {
                ExportText += Convert.ToString(b, 2).PadLeft(8, '0');
                ExportText += " ";
            }

            return ExportText;
        }
    }
}
