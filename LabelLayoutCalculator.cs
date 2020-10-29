using BinaryKits.Utility.ZPLUtility;
using PDFtoZPL;
using SkiaSharp;
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

            var labelPages = Enumerable.Range(1, pageCount).Select(p => new LabelPage() { PageNumber = p}).ToList();

            labelPages.ForEach(p =>
            {
                p.Labels = labelBoxes.Skip((p.PageNumber - 1) * pageSize).Take(pageSize).ToList();

                var index = 0;

                p.Labels.ForEach(b =>
                {
                    index++;

                    int mod = index % _layoutTemlate.ColumnsCount;

                    int columnIndext = mod == 0 ? _layoutTemlate.ColumnsCount : mod;

                    b.Left = _layoutTemlate.LeftMargin + (columnIndext - 1) * (_layoutTemlate.ColumnSpacing + _layoutTemlate.BoxWidth);

                    int div = index / _layoutTemlate.ColumnsCount;

                    int rowIndext = mod == 0 ? div : div + 1;

                    b.Top = _layoutTemlate.TopMargin + (rowIndext - 1) * _layoutTemlate.BoxHeight;

                    b.ProductNameTop = _layoutTemlate.ProductNameTop + b.Top;

                    b.ProductNameLeft = _layoutTemlate.ProductNameLeft + b.Left;
                });

            });

            return labelPages;

        }


    }
}
