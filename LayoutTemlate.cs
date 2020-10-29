using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp
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
        public float BussinesNameSize { get; set; }

        public float ProductNameTop { get; set; }
        public float ProductNameLeft { get; set; }
        public float ProductNameSize { get; set; }

        public float SalePriceTop { get; set; }
        public float SalePriceLeft { get; set; }
        public float SalePriceSize { get; set; }

        public float SkuTop { get; set; }
        public float SkuLeft { get; set; }
        public float SkuSize { get; set; }

        public float BarcodeTop { get; set; }
        public float BarcodeLeft { get; set; }
        public float BarcodeSize { get; set; }

        public float BarcodeNumberTop { get; set; }
        public float BarcodeNumberLeft { get; set; }
        public float BarcodeNumberSize { get; set; }

        public int PageWidthInt => (int)Math.Ceiling(PageWidth);
        public int PageHeightInt => (int)Math.Ceiling(PageHeight);
    }

    public class Coordinat
    {
        public float Top { get; set; }
        public float Left { get; set; }
    }

}
