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
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name01" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name02" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name03" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name04" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name05" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name06" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name07" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name08" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name09" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name10" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name11" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name12" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name13" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name14" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name15" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name16" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name17" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name18" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name19" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name20" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name21" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name22" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
                new LabelBox{ BarcodeNumber = "2544585454558" , ProductName = "T-shirt" , BussinesName = "Bussines Name23" , SalePrice = "200 $" , Sku = "T-4545-r-l" },
            };

        }
    }
}
