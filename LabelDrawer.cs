using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp
{
    public class LabelDrawer
    {

        private LayoutTemlate _layoutTemlate;

        private List<LabelModel> _labelModels;

        public LabelDrawer(LayoutTemlate layoutTemlate , List<LabelModel> labelModels)
        {
            _layoutTemlate = layoutTemlate;

            _labelModels = labelModels;
        }

        public void CreateImage(float toPixel)
        {
            SKImageInfo imageInfo = new SKImageInfo(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);
            using SKSurface surface = SKSurface.Create(imageInfo);
            SKCanvas canvas = surface.Canvas;
            DrawOnCanvas(canvas , toPixel);
            using SKImage image = surface.Snapshot();
            using SKData data = image.Encode(SKEncodedImageFormat.Png, 80);
            using FileStream stream = File.OpenWrite(Path.Combine(AppContext.BaseDirectory, "image.png"));
            data.SaveTo(stream);
        }

        public void CreatePdf(float toPixel , int dpi)
        {
            using SKFileWStream stream = new SKFileWStream(Path.Combine(AppContext.BaseDirectory, "doc.pdf"));

            using SKDocument document = SKDocument.CreatePdf(stream, dpi);

            using SKCanvas pdfCanvas = document.BeginPage(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);

            DrawOnCanvas(pdfCanvas , toPixel);

            document.Close();
        }

        public void DrawOnCanvas(SKCanvas canvas , float toPixel)
        {
            canvas.Clear(SKColors.White);

            foreach (var model in _labelModels)
            {
                using (SKPaint framePaint = new SKPaint())
                {
                    framePaint.Style = SKPaintStyle.Stroke;
                    framePaint.StrokeWidth = 1;
                    framePaint.Color = SKColors.Gray;

                    SKRect frameRect = new SKRect();

                    frameRect.Location = new SKPoint
                    {
                        X = model.Left,
                        Y = model.Top,
                    };

                    frameRect.Size = new SKSize
                    {
                        Width = _layoutTemlate.BoxWidth,
                        Height = _layoutTemlate.BoxHeight,
                    };

                    canvas.DrawRoundRect(frameRect, 5, 5, framePaint);
                }

                using (SKPaint bussinesNamePaint = new SKPaint())
                {
                    bussinesNamePaint.Color = SKColors.Black;

                    bussinesNamePaint.TextSize = ((int)(7 * toPixel));

                    float xText = CalculateXToCenterTextOnFram(bussinesNamePaint, model.BussinesName, model.Left);

                    float yText = model.Top + ((int)(6 * toPixel));

                    canvas.DrawText(model.BussinesName, xText, yText, bussinesNamePaint);
                }

                using (SKPaint salePricePaint = new SKPaint())
                {
                    salePricePaint.Color = SKColors.Blue;

                    salePricePaint.TextSize = ((int)(5 * toPixel));

                    float xText = CalculateXToCenterTextOnFram(salePricePaint, model.SalePrice, model.Left);

                    float yText = model.Top + ((int)(17 * toPixel));

                    canvas.DrawText(model.SalePrice, xText, yText, salePricePaint);
                }

                using (SKPaint productNamePaint = new SKPaint())
                {
                    productNamePaint.Color = SKColors.Black;

                    productNamePaint.TextSize = ((int)(3 * toPixel));

                    float xText = CalculateXToCenterTextOnFram(productNamePaint, model.ProductName, model.Left);

                    float yText = model.Top + ((int)(20 * toPixel));

                    canvas.DrawText(model.ProductName, xText, yText, productNamePaint);
                }

                using (SKPaint skuPaint = new SKPaint())
                {

                    skuPaint.Color = SKColors.Black;

                    skuPaint.TextSize = ((int)(3 * toPixel));

                    float xText = CalculateXToCenterTextOnFram(skuPaint, model.Sku, model.Left);

                    float yText = model.Top + ((int)(26 * toPixel));

                    canvas.DrawText(model.Sku, xText, yText, skuPaint);
                }

                using (SKPaint barCodeNumberPaint = new SKPaint())
                {

                    barCodeNumberPaint.Color = SKColors.Black;

                    barCodeNumberPaint.TextSize = ((int)(2 * toPixel));

                    float xText = CalculateXToCenterTextOnFram(barCodeNumberPaint, model.BarcodeNumber, model.Left);

                    float yText = model.Top + ((int)(32 * toPixel));

                    canvas.DrawText(model.BarcodeNumber, xText, yText, barCodeNumberPaint);
                }
            }

        }

         float CalculateXToCenterTextOnFram(SKPaint textPaint, string str, float x)
        {
            float textWidth = textPaint.MeasureText(str);

            // Calculate offsets to center the text horizontaly on the fram
            float xText = x + _layoutTemlate.BoxWidth / 2 - textWidth / 2;

            return xText;
        }
    }
}
