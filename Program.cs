using SkiaSharpSampleApp.Models;
using System.Collections.Generic;


namespace SkiaSharpSampleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var labelModels = GetListOfLayoutModelsToPrint();

            var layoutTemlate = LayoutTemlate.Template21;

            LabelLayoutCalculator calculator = new LabelLayoutCalculator(layoutTemlate);

            var pages = calculator.Calculate(labelModels);

            LabelDrawer labelDrawer = new LabelDrawer(layoutTemlate, pages);

            labelDrawer.CreateImages(LayoutTemlate._toPixel);

            labelDrawer.CreatePdfs(LayoutTemlate._toPixel, LayoutTemlate._dpi);
        }

        static List<LabelBox> GetListOfLayoutModelsToPrint()
        {
            return new List<LabelBox>
            {
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName01" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName02" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName03" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName04" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName05" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName06" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName07" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName08" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName09" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName10" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName11" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName12" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName13" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName14" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName15" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName16" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName17" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName18" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName19" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName20" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName21" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName22" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
                new LabelBox{ BusinessName = new LabelCordinations{ Title = "BusinessName23" } , ProductName = new LabelCordinations{ Title = "T-shirt"} , Barcode = new LabelCordinations{Title = "124578525588" } , SalePrice = new LabelCordinations{Title = "200 $" } , Sku = new LabelCordinations{ Title = "T-ee-r-27"} },
            };

        }
    }
}
