using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp
{
    public class LabelDrawer
    {
        private LayoutTemlate _layoutTemlate;

        private List<LabelPage> _pages;

        public LabelDrawer(LayoutTemlate layoutTemlate, List<LabelPage> pages)
        {
            _layoutTemlate = layoutTemlate;

            _pages = pages;
        }

        public void CreateImages(float toPixel)
        {
            _pages.ForEach(p => CreateImage(toPixel, p));
        }

        private void CreateImage(float toPixel, LabelPage labelPage)
        {
            SKImageInfo imageInfo = new SKImageInfo(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);
            using SKSurface surface = SKSurface.Create(imageInfo);
            SKCanvas canvas = surface.Canvas;
            DrawOnCanvas(canvas, toPixel, labelPage);
            using SKImage image = surface.Snapshot();
            using SKData data = image.Encode(SKEncodedImageFormat.Png, 80);
            using FileStream stream = File.OpenWrite(Path.Combine(AppContext.BaseDirectory, $"image{labelPage.PageNumber}.png"));
            data.SaveTo(stream);
        }

        public void CreatePdfs(float toPixel, int dpi)
        {
            _pages.ForEach(p => CreatePdf(toPixel, dpi, p));
        }

        public void CreatePdf(float toPixel, int dpi, LabelPage labelPage)
        {
            using SKFileWStream stream = new SKFileWStream(Path.Combine(AppContext.BaseDirectory, "doc.pdf"));

            using SKDocument document = SKDocument.CreatePdf(stream, dpi);

            using SKCanvas pdfCanvas = document.BeginPage(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);

            DrawOnCanvas(pdfCanvas, toPixel, labelPage);

            document.Close();
        }

        public void DrawOnCanvas(SKCanvas canvas, float toPixel, LabelPage page)
        {
            canvas.Clear(SKColors.White);

            foreach (var label in page.Labels)
            {
                using (SKPaint framePaint = new SKPaint())
                {
                    framePaint.Style = SKPaintStyle.Stroke;
                    framePaint.StrokeWidth = _layoutTemlate.BoxStrokeWidth;
                    framePaint.Color = SKColors.Gray;

                    SKRect frameRect = new SKRect();

                    frameRect.Location = new SKPoint
                    {
                        X = label.Left,
                        Y = label.Top,
                    };

                    frameRect.Size = new SKSize
                    {
                        Width = _layoutTemlate.BoxWidth,
                        Height = _layoutTemlate.BoxHeight,
                    };

                    canvas.DrawRoundRect(frameRect, _layoutTemlate.BoxXReduce, _layoutTemlate.BoxYReduce, framePaint);
                }

                using (SKPaint bussinesNamePaint = new SKPaint())
                {
                    bussinesNamePaint.Color = SKColors.Black;

                    bussinesNamePaint.TextSize = _layoutTemlate.BussinesNameSize;

                    float xText = CalculateXToCenterTextOnFram(bussinesNamePaint, label.BussinesName, label.Left);

                    float yText = label.Top + _layoutTemlate.BussinesNameTop;

                    canvas.DrawText(label.BussinesName, xText, yText, bussinesNamePaint);
                }

                using (SKPaint salePricePaint = new SKPaint())
                {
                    salePricePaint.Color = SKColors.Blue;

                    salePricePaint.TextSize = _layoutTemlate.SalePriceSize;

                    float xText = CalculateXToCenterTextOnFram(salePricePaint, label.SalePrice, label.Left);

                    float yText = label.Top + _layoutTemlate.SalePriceTop;

                    canvas.DrawText(label.SalePrice, xText, yText, salePricePaint);
                }

                using (SKPaint productNamePaint = new SKPaint())
                {
                    productNamePaint.Color = SKColors.Black;

                    productNamePaint.TextSize = _layoutTemlate.ProductNameSize;

                    float xText = CalculateXToCenterTextOnFram(productNamePaint, label.ProductName, label.Left);

                    float yText = label.Top + _layoutTemlate.ProductNameTop;

                    canvas.DrawText(label.ProductName, xText, yText, productNamePaint);
                }

                using (SKPaint skuPaint = new SKPaint())
                {

                    skuPaint.Color = SKColors.Black;

                    skuPaint.TextSize = _layoutTemlate.SkuSize;

                    float xText = CalculateXToCenterTextOnFram(skuPaint, label.Sku, label.Left);

                    float yText = label.Top + _layoutTemlate.SkuTop;

                    canvas.DrawText(label.Sku, xText, yText, skuPaint);
                }

                using (SKPaint barCodeNumberPaint = new SKPaint())
                {

                    barCodeNumberPaint.Color = SKColors.Black;

                    barCodeNumberPaint.TextSize = _layoutTemlate.BarcodeSize;

                    float xText = CalculateXToCenterTextOnFram(barCodeNumberPaint, label.BarcodeNumber, label.Left);

                    float yText = label.Top + _layoutTemlate.BarcodeTop;

                    canvas.DrawText(label.BarcodeNumber, xText, yText, barCodeNumberPaint);
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
