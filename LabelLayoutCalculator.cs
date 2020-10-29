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
                p.Labels = labelBoxes.Skip((p.PageNumber - 1) * pageSize).Take(pageSize).ToList();

                var index = 0;

                p.Labels.ForEach(b =>
                {
                    index++;

                    int mod = index % _layoutTemlate.ColumnsCount;

                    int columnIndext = mod == 0 ? _layoutTemlate.ColumnsCount : mod;

                    b.Left = _layoutTemlate.LeftMargin + (columnIndext - 1) * (_layoutTemlate.ColumnSpacing + _layoutTemlate.Box.Width);

                    int div = index / _layoutTemlate.ColumnsCount;

                    int rowIndext = mod == 0 ? div : div + 1;

                    b.Top = _layoutTemlate.TopMargin + (rowIndext - 1) * _layoutTemlate.Box.Height;

                    b.BusinessName.Top = b.Top + _layoutTemlate.BusinessName.Top;
                    b.BusinessName.Left = CalculateCenteredTextX(_layoutTemlate.BusinessName.TextSize, b.BusinessName.Title, b.Left);

                    b.ProductName.Top = _layoutTemlate.ProductName.Top + b.Top;
                    b.ProductName.Left = CalculateCenteredTextX(_layoutTemlate.ProductName.TextSize, b.ProductName.Title, b.Left);

                    b.SalePrice.Top = b.Top + _layoutTemlate.SalePrice.Top;
                    b.SalePrice.Left = CalculateCenteredTextX(_layoutTemlate.SalePrice.TextSize, b.SalePrice.Title, b.Left);

                    b.Sku.Top = b.Top + _layoutTemlate.Sku.Top;
                    b.BusinessName.Left = CalculateCenteredTextX(_layoutTemlate.Sku.TextSize, b.Sku.Title, b.Left);

                    b.Barcode.Top = b.Top + _layoutTemlate.Barcode.Top;
                    b.Barcode.Left = b.Left + _layoutTemlate.Barcode.Left;

                    b.BarcodeNumber.Top = b.Top + _layoutTemlate.BarcodeNumber.Top;
                    b.BarcodeNumber.Left = CalculateCenteredTextX(_layoutTemlate.BarcodeNumber.TextSize, b.BarcodeNumber.Title, b.Left);

                });

            });

            return labelPages;

        }


        private float CalculateCenteredTextX(float textSize, string str, float boxLeft)
        {
            using (SKPaint textPaint = new SKPaint())
            {
                textPaint.TextSize = _layoutTemlate.BusinessName.TextSize;
                float textWidth = textPaint.MeasureText(str);
                float xText = boxLeft + _layoutTemlate.Box.Width / 2 - textWidth / 2;
                return xText;
            }
        }
    }
}
