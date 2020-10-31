using SkiaSharpSampleApp.Models;
using System.Collections.Generic;


namespace SkiaSharpSampleApp
{
    class Program
    {
        private static int _dpi = 203;
        private static float _toPixel = _dpi / 25.4f;
        static void Main(string[] args)
        {
            var labelModels = GetListOfLayoutModelsToPrint();

            var template = new Template21();

            var layoutTemlate = template.GetTemplate21(_toPixel);

            LabelLayoutCalculator calculator = new LabelLayoutCalculator(layoutTemlate);

            var pages = calculator.Calculate(labelModels);

            LabelDrawer labelDrawer = new LabelDrawer(layoutTemlate, pages);

            labelDrawer.CreateImages();

            labelDrawer.CreatePdfs(_dpi);
        }

        static List<LabelBox> GetListOfLayoutModelsToPrint()
        {
            return new List<LabelBox>
            {
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName01" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName02" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName03" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName04" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName05" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName06" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName07" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName08" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName09" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName10" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName11" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName12" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName13" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName14" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName15" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName16" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName17" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName18" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName19" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName20" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName21" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName22" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCoordinations{ Title = "BusinessName23" } , Box = new BoxDimentions() , ProductName = new LabelCoordinations{ Title = "T-shirt"} , Barcode = new LabelCoordinations{Title = "124578525588" } , SalePrice = new LabelCoordinations{Title = "200 $" } , Sku = new LabelCoordinations{ Title = "T-ee-r-27"} },
            };

        }
    }
}
