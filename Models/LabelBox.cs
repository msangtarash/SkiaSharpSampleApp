using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp.Models
{
    public class LabelBox
    {
        public float Top { get; set; }
        public float Left { get; set; }
        public string ProductName { get; set; }
        public float ProductNameTop { get; set; }
        public float ProductNameLeft { get; set; }
        public string SalePrice { get; set; }
        public string Sku { get; set; }
        public string BarcodeNumber { get; set; }


        public string BussinesName { get; set; }
        public float BusinessNameTop { get; set; }
        public float BusinessNameLeft { get; set; }
    }
}
