using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp.Models
{
    public class LayoutTemlate
    {
        public float PageHeight { get; set; }
        public float PageWidth { get; set; }
        public float TopMargin { get; set; }
        public float LeftMargin { get; set; }
        public float ColumnSpacing { get; set; }
        public float RowSpacing { get; set; }
        public int ColumnsCount { get; set; }
        public int RowsCount { get; set; }
        public BoxDimentions Box { get; set; }
        public LabelDimensions BusinessName { get; set; }
        public LabelDimensions ProductName { get; set; }
        public LabelDimensions SalePrice { get; set; }
        public LabelDimensions Sku { get; set; }
        public LabelDimensions Barcode { get; set; }
        public int PageWidthInt => (int)Math.Ceiling(PageWidth);
        public int PageHeightInt => (int)Math.Ceiling(PageHeight);       
    }

    public class LabelDimensions
    {
        public float Top { get; set; }
        public float Left { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Color { get; set; } = "000000";
        public float TextSize { get; set; }
    }

    public class BoxDimentions
    {
        public float StrokeWidth { get; set; }
        public float XReduce { get; set; }
        public float YReduce { get; set; }
        public float Padding { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Color { get; set; } = "000000";

    }
}
