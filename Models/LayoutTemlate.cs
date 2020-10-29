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

        public static int _dpi = 203;
        public static float _toPixel = _dpi / 25.4f;
        public static LayoutTemlate Template21 => new LayoutTemlate
        {
            PageHeight = 297f * _toPixel,
            PageWidth = 210f * _toPixel,
            ColumnsCount = 3,
            ColumnSpacing = 2.5f * _toPixel,
            LeftMargin = 8.6f * _toPixel,
            TopMargin = 15.1f * _toPixel,
            RowsCount = 7,
            Box = new BoxDimentions
            {
                Height = 38.1f * _toPixel,
                Width = 63.5f * _toPixel,

                Padding = 1.2f * _toPixel,

                StrokeWidth = 1,
                YReduce = 5,
                XReduce = 5,
            },
            BusinessName = new LabelDimensions
            {
                TextSize = 7 * _toPixel,
                Top = 6 * _toPixel,
            },
            ProductName = new LabelDimensions
            {
                TextSize = 3 * _toPixel,
                Top = 20 * _toPixel,
            },
            SalePrice = new LabelDimensions
            {
                TextSize = 5 * _toPixel,
                Top = 17 * _toPixel,
            },
            Sku = new LabelDimensions
            {
                TextSize = 3 * _toPixel,
                Top = 26 * _toPixel,
            },
            Barcode = new LabelDimensions
            {
                Top = 28 * _toPixel,
            },
        };
    }

    public class LabelDimensions
    {
        public float Top { get; set; }
        public float Left { get; set; }
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
    }
}
