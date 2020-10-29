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

        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxPadding { get; set; }

        public float BoxStrokeWidth { get; set; }

        public float BoxXReduce { get; set; }
        public float BoxYReduce { get; set; }

        public float BussinesNameTop { get; set; }
        public float BussinesNameLeft { get; set; }
        public float BussinesNameTextSize { get; set; }

        public float ProductNameTop { get; set; }
        public float ProductNameLeft { get; set; }
        public float ProductNameTextSize { get; set; }

        public float SalePriceTop { get; set; }
        public float SalePriceLeft { get; set; }
        public float SalePriceTextSize { get; set; }

        public float SkuTop { get; set; }
        public float SkuLeft { get; set; }
        public float SkuTextSize { get; set; }

        public float BarcodeTop { get; set; }
        public float BarcodeLeft { get; set; }
        public float BarcodeTextSize { get; set; }

        public float BarcodeNumberTop { get; set; }
        public float BarcodeNumberLeft { get; set; }
        public float BarcodeNumberTextSize { get; set; }

        public int PageWidthInt => (int)Math.Ceiling(PageWidth);
        public int PageHeightInt => (int)Math.Ceiling(PageHeight);

        public static int _dpi = 203;

        public static float _toPixel = _dpi / 25.4f;

        public static LayoutTemlate Template21 => new LayoutTemlate
        {

            BoxHeight = 38.1f * _toPixel,
            BoxWidth = 63.5f * _toPixel,
            PageHeight = 297f * _toPixel,
            PageWidth = 210f * _toPixel,
            BoxPadding = 1.2f * _toPixel,
            ColumnsCount = 3,
            ColumnSpacing = 2.5f * _toPixel,
            LeftMargin = 8.6f * _toPixel,
            TopMargin = 15.1f * _toPixel,
            RowsCount = 7,
            BoxStrokeWidth = 1,
            BoxYReduce = 5,
            BoxXReduce = 5,
            BussinesNameTextSize = 7 * _toPixel,
            BussinesNameTop = 6 * _toPixel,
            SalePriceTextSize = 5 * _toPixel,
            SalePriceTop = 17 * _toPixel,
            ProductNameTextSize = 3 * _toPixel,
            ProductNameTop = 20 * _toPixel,
            SkuTextSize = 3 * _toPixel,
            SkuTop = 26 * _toPixel,
            BarcodeTextSize = 2 * _toPixel,
            BarcodeTop = 32 * _toPixel,

        };

    }

}
