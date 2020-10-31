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

        public BoxDimentions Box { get; set; }

        public LabelCoordinations BusinessName { get; set; }

        public LabelCoordinations ProductName { get; set; }

        public LabelCoordinations SalePrice { get; set; }

        public LabelCoordinations Sku { get; set; }

        public LabelCoordinations Barcode { get; set; }

    }

    public class LabelCoordinations
    {
        public string Title { get; set; }
        public float Top { get; set; }
        public float Left { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Color { get; set; }
        public float TextSize { get; set; }
        public int WidthInt => (int)Math.Ceiling(Width);
        public int HeightInt => (int)Math.Ceiling(Height);
    }
}
