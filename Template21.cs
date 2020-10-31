using SkiaSharpSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp
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
                    YReduce = 10,
                    XReduce = 10,
                },
                BusinessName = new LabelDimensions
                {
                    TextSize = 7 * _toPixel,
                    Top = 7 * _toPixel,
                },
                ProductName = new LabelDimensions
                {
                    TextSize = 3 * _toPixel,
                    Top = 19 * _toPixel,
                },
                SalePrice = new LabelDimensions
                {
                    TextSize = 5 * _toPixel,
                    Top = 16 * _toPixel,
                },
                Sku = new LabelDimensions
                {
                    TextSize = 3 * _toPixel,
                    Top = 24 * _toPixel,
                },
                Barcode = new LabelDimensions
                {
                    Top = 26 * _toPixel,
                    Width = 350,
                    Height = 80,
                },
            };
        }
    }
}
