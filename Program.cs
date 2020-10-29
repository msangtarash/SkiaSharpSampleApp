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

            var pages = calculator.Calculate(labelModels);

            LabelDrawer labelDrawer = new LabelDrawer(layoutTemlate, pages);

            labelDrawer.CreateImages(_toPixel);

            //labelDrawer.CreatePdfs(_toPixel , _dpi);
        }

        static List<LabelBox> GetListOfLayoutModelsToPrint()
        {
            return new List<LabelBox>
            {
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name1" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name2" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name3" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name4" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name5" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name6" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name7" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name8" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name9" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name10" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name11" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name12" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name13" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name14" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name15" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name16" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name17" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name18" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber="2544585454558" , ProductName = "T-shirt" , BussinesName ="Bussines Name19" , SalePrice = "200 $" , Sku = "T-4545-r-l"},
                new LabelBox{ BarcodeNumber = "2544585454558", ProductName = "T-shirt", BussinesName = "Bussines Name20", SalePrice = "200 $", Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558", ProductName = "T-shirt", BussinesName = "Bussines Name21", SalePrice = "200 $", Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558", ProductName = "T-shirt", BussinesName = "Bussines Name22", SalePrice = "200 $", Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558", ProductName = "T-shirt", BussinesName = "Bussines Name23", SalePrice = "200 $", Sku = "T-4545-r-l" },
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
                BoxStrokeWidth = 1,
                BoxYReduce = 5,
                BoxXReduce = 5,
                BussinesNameSize = 7 * _toPixel,
                BussinesNameTop = 6 * _toPixel,
                SalePriceSize = 5 * _toPixel,
                SalePriceTop =17 * _toPixel,
                ProductNameSize = 3 * _toPixel,
                ProductNameTop = 20 * _toPixel,
                SkuSize = 3 * _toPixel,
                SkuTop = 26 * _toPixel,
                BarcodeSize = 2 * _toPixel,
                BarcodeTop = 32 * _toPixel,

            };
        }

    }
}
