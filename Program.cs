using BinaryKits.Utility.ZPLUtility;
using PDFtoZPL;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SkiaSharpSampleApp
{
    class Program
    {
        private static int _dpi = 203;

        private static float _toPixel = _dpi / 25.4f;


        static void Main(string[] args)
        {
            var labelModels = GetListOfLayoutModelsToPrint();

            var layoutTemlate = CreateLayoutTemplate();

            LabelLayoutCalculator calculator = new LabelLayoutCalculator(layoutTemlate);

            calculator.Calculate(labelModels);

            LabelDrawer labelDrawer = new LabelDrawer(layoutTemlate, labelModels);

            labelDrawer.CreateImage(_toPixel);

            labelDrawer.CreatePdf(_toPixel , _dpi);
        }

        static List<LabelModel> GetListOfLayoutModelsToPrint()
        {
            return new List<LabelModel>
            {
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name1" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name2" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name3" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name4" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name5" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name6" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name7" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name8" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name9" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name10" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name11" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name12" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelModel{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name13" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
            };

        }

        private static LayoutTemlate CreateLayoutTemplate()
        {
            return new LayoutTemlate
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
                ProductNameLeft = 3 * _toPixel,
                ProductNameTop = 3 * _toPixel
            };
        }

    }
}
