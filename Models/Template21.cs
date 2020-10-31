using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp.Models
{
    public class Template21
    {
        public LayoutTemlate GetTemplate21(float _toPixel)
        {
            return new LayoutTemlate
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
                    Width = 350,
                    Height = 50,
                },
            };
        }
    }
}
