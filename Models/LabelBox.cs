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

        public LabelCordinations BusinessName { get; set; }

        public LabelCordinations ProductName { get; set; }

        public LabelCordinations SalePrice { get; set; }

        public LabelCordinations Sku { get; set; }

        public LabelCordinations Barcode { get; set; }

        public LabelCordinations BarcodeNumber { get; set; }
    }

    public class LabelCordinations
    {
        public float Top { get; set; }
        public float Left { get; set; }
        public string Title { get; set; }
    }
}
