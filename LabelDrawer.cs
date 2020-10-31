using SkiaSharp;
using SkiaSharpSampleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;

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

        public void CreateImages()
        {
            _pages.ForEach(p => CreateImage(p));
        }

        private void CreateImage(LabelPage labelPage)
        {
            SKImageInfo imageInfo = new SKImageInfo(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);
            using SKSurface surface = SKSurface.Create(imageInfo);
            SKCanvas canvas = surface.Canvas;
            DrawOnCanvas(canvas, labelPage);
            using SKImage image = surface.Snapshot();
            using SKData data = image.Encode(SKEncodedImageFormat.Png, 80);
            using FileStream stream = File.OpenWrite(Path.Combine(AppContext.BaseDirectory, $"image{labelPage.PageNumber}.png"));
            data.SaveTo(stream);
        }

        public void CreatePdfs(int dpi)
        {
            using SKFileWStream stream = new SKFileWStream(Path.Combine(AppContext.BaseDirectory, "doc.pdf"));

            using SKDocument document = SKDocument.CreatePdf(stream, dpi);

            _pages.ForEach(p => CreatePdf(p, document));

            document.Close();
        }

        public void CreatePdf(LabelPage labelPage, SKDocument document)
        {
            using SKCanvas pdfCanvas = document.BeginPage(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);

            DrawOnCanvas(pdfCanvas, labelPage);
        }

        public void DrawOnCanvas(SKCanvas canvas, LabelPage page)
        {
            canvas.Clear(SKColors.White);

            foreach (var label in page.Labels)
            {
                using (SKPaint framePaint = new SKPaint())
                {
                    framePaint.Style = SKPaintStyle.Stroke;
                    framePaint.StrokeWidth = label.Box.StrokeWidth;
                    SKColor.TryParse(label.Box.Color, out SKColor color);
                    framePaint.Color = color;

                    SKRect frameRect = new SKRect();

                    frameRect.Location = new SKPoint
                    {
                        X = label.Left,
                        Y = label.Top,
                    };

                    frameRect.Size = new SKSize
                    {
                        Width = label.Box.Width,
                        Height = label.Box.Height,
                    };

                    canvas.DrawRoundRect(frameRect, label.Box.XReduce, label.Box.YReduce, framePaint);
                }

                using (SKPaint businessNamePaint = new SKPaint())
                {
                    SKColor.TryParse(label.BusinessName.Color, out SKColor color);

                    businessNamePaint.Color = color;

                    businessNamePaint.TextSize = label.BusinessName.TextSize;

                    canvas.DrawText(label.BusinessName.Title, label.BusinessName.Left, label.BusinessName.Top, businessNamePaint);
                }

                using (SKPaint salePricePaint = new SKPaint())
                {
                    SKColor.TryParse(label.SalePrice.Color, out SKColor color);

                    salePricePaint.Color = color;

                    salePricePaint.TextSize = label.SalePrice.TextSize;

                    canvas.DrawText(label.SalePrice.Title, label.SalePrice.Left, label.SalePrice.Top, salePricePaint);
                }

                using (SKPaint productNamePaint = new SKPaint())
                {
                    SKColor.TryParse(label.ProductName.Color, out SKColor color);

                    productNamePaint.Color = color;

                    productNamePaint.TextSize = label.ProductName.TextSize;

                    canvas.DrawText(label.ProductName.Title, label.ProductName.Left, label.ProductName.Top, productNamePaint);
                }

                using (SKPaint skuPaint = new SKPaint())
                {
                    SKColor.TryParse(label.Sku.Color, out SKColor color);

                    skuPaint.Color = color;

                    skuPaint.TextSize = label.Sku.TextSize;

                    canvas.DrawText(label.Sku.Title, label.Sku.Left, label.Sku.Top, skuPaint);
                }

                var barcodeWriter = new ZXing.SkiaSharp.BarcodeWriter()
                {
                    Format = BarcodeFormat.CODE_128,

                    Options = new ZXing.Common.EncodingOptions
                    {
                        Height = label.Barcode.HeightInt,
                        Width = label.Barcode.WidthInt,
                    },
                };

                SKBitmap bitmap = barcodeWriter.Write(label.Barcode.Title);

                canvas.DrawBitmap(bitmap, new SKPoint { X = label.Barcode.Left, Y = label.Barcode.Top });

            }

        }
    }
}
