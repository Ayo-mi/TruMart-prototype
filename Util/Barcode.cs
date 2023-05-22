using OnBarcode.Barcode;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruMart.Util
{
    class Barcode
    {        
        public Linear GenerateBarcode(string id)
        {
            Linear barcode = new Linear();
            barcode.Type = BarcodeType.CODE39;
            barcode.Data = id;
            barcode.X = 1;
            barcode.Y = 60;
            barcode.ShowText = false;
            
            return barcode;
        }
    }
}
