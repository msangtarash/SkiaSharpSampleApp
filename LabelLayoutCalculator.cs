using SkiaSharp;
using SkiaSharpSampleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SkiaSharpSampleApp
{
    public class LabelLayoutCalculator
    {
        readonly LayoutTemlate _layoutTemlate;
        public LabelLayoutCalculator(LayoutTemlate layoutTemlate)
        {
            _layoutTemlate = layoutTemlate;
        }

        public List<LabelPage> Calculate(List<LabelBox> labelBoxes)
        {
            var pageSize = _layoutTemlate.ColumnsCount * _layoutTemlate.RowsCount;

            var div = labelBoxes.Count / pageSize;

            var mod = labelBoxes.Count % pageSize;

            var pageCount = mod == 0 ? div : div + 1;

            var labelPages = Enumerable.Range(1, pageCount).Select(p => new LabelPage() { PageNumber = p }).ToList();

            labelPages.ForEach(p =>
            {
                p.Width = _layoutTemlate.PageWidthInt;
                p.Height = _layoutTemplate.PageHeightInt;
                p.Labels = labelBoxes.Skip((p.PageNumber - 1) * pageSize).Take(pageSize).ToList();

                var index = 0;

                p.Labels.ForEach(l =>
                {
                    index++;

                    int mod = index % _layoutTemlate.ColumnsCount;

                    int columnIndext = mod == 0 ? _layoutTemlate.ColumnsCount : mod;

                    l.Left = _layoutTemlate.LeftMargin + (columnIndext - 1) * (_layoutTemlate.ColumnSpacing + _layoutTemlate.Box.Width);

                    int div = index / _layoutTemlate.ColumnsCount;

                    int rowIndext = mod == 0 ? div : div + 1;

                    l.Top = _layoutTemlate.TopMargin + (rowIndext - 1) * _layoutTemlate.Box.Height;

                    l.Box.Color = _layoutTemlate.Box.Color;
                    l.Box.Width = _layoutTemlate.Box.Width;
                    l.Box.Height = _layoutTemlate.Box.Height;
                    l.Box.StrokeWidth = _layoutTemlate.Box.StrokeWidth;
                    l.Box.XReduce = _layoutTemlate.Box.XReduce;
                    l.Box.YReduce = _layoutTemlate.Box.YReduce;
                    l.Box.Padding = _layoutTemlate.Box.Padding;

                    l.BusinessName.Top = l.Top + _layoutTemlate.BusinessName.Top;
                    l.BusinessName.Left = CalculateCenteredTextX(_layoutTemlate.BusinessName.TextSize, l.BusinessName.Title, l.Left);
                    l.BusinessName.TextSize = _layoutTemlate.BusinessName.TextSize;
                    l.BusinessName.Color = _layoutTemlate.BusinessName.Color;                   

                    l.ProductName.Top = l.Top + _layoutTemlate.ProductName.Top;
                    l.ProductName.Left = CalculateCenteredTextX(_layoutTemlate.ProductName.TextSize, l.ProductName.Title, l.Left);
                    l.ProductName.TextSize = _layoutTemlate.ProductName.TextSize;
                    l.ProductName.Color = _layoutTemlate.ProductName.Color;

                    l.SalePrice.Top = l.Top + _layoutTemlate.SalePrice.Top;
                    l.SalePrice.Left = CalculateCenteredTextX(_layoutTemlate.SalePrice.TextSize, l.SalePrice.Title, l.Left);
                    l.SalePrice.TextSize = _layoutTemlate.SalePrice.TextSize;
                    l.SalePrice.Color = _layoutTemlate.SalePrice.Color;

                    l.Sku.Top = l.Top + _layoutTemlate.Sku.Top;
                    l.Sku.Left = CalculateCenteredTextX(_layoutTemlate.Sku.TextSize, l.Sku.Title, l.Left);
                    l.Sku.TextSize = _layoutTemlate.Sku.TextSize;
                    l.Sku.Color = _layoutTemlate.Sku.Color;

                    l.Barcode.Top = l.Top + _layoutTemlate.Barcode.Top;
                    l.Barcode.Left = l.Left + _layoutTemlate.Box.Padding;
                    l.Barcode.TextSize = _layoutTemlate.Barcode.TextSize;
                    l.Barcode.Color = _layoutTemlate.Barcode.Color;
                    l.Barcode.Width = _layoutTemlate.Box.Width - (2 * _layoutTemlate.Box.Padding);
                    l.Barcode.Height = _layoutTemlate.Barcode.Height;
                });

            });

            return labelPages;

        }


        private float CalculateCenteredTextX(float textSize, string str, float boxLeft)
        {
            using (SKPaint textPaint = new SKPaint())
            {
                textPaint.TextSize = textSize;

                float textWidth = textPaint.MeasureText(str);

                float xText = boxLeft + _layoutTemlate.Box.Width / 2 - textWidth / 2;

                return xText;
            }
        }
    }
}
