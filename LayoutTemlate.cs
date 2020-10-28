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
        public int ColumnsCount { get; set; }
        public int RowsCount { get; set; }
        public float BoxWidth { get; set; }
        public float BoxHeight { get; set; }
        public float BoxPadding { get; set; }
        public float ProductNameTop { get; set; }
        public float ProductNameLeft { get; set; }

        public int PageWidthInt => (int)Math.Ceiling(PageWidth);
        public int PageHeightInt => (int)Math.Ceiling(PageHeight);
    }


}
