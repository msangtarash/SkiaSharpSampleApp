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

        public void Calculate(List<LabelModel> labelModels)
        {
            var index = 0;

            labelModels.ForEach(m =>
            {
                index++;

                int mod = index % _layoutTemlate.ColumnsCount;

                int columnIndext = mod == 0 ? _layoutTemlate.ColumnsCount : mod;

                m.Left = _layoutTemlate.LeftMargin + (columnIndext - 1) * (_layoutTemlate.ColumnSpacing + _layoutTemlate.BoxWidth);

                int div = index / _layoutTemlate.ColumnsCount;

                int rowIndext = mod == 0 ? div : div + 1;

                m.Top = _layoutTemlate.TopMargin + (rowIndext - 1) * _layoutTemlate.BoxHeight;

                m.ProductNameTop = _layoutTemlate.ProductNameTop + m.Top;

                m.ProductNameLeft = _layoutTemlate.ProductNameLeft + m.Left;
            });


        }


    }
}
