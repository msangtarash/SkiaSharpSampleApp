﻿using SkiaSharp;
using SkiaSharpSampleApp.Models;
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
            using SKFileWStream stream = new SKFileWStream(Path.Combine(AppContext.BaseDirectory, "doc.pdf"));

            using SKDocument document = SKDocument.CreatePdf(stream, dpi);

            _pages.ForEach(p => CreatePdf(toPixel, p, document));

            document.Close();
        }

        public void CreatePdf(float toPixel, LabelPage labelPage, SKDocument document)
        {
            using SKCanvas pdfCanvas = document.BeginPage(_layoutTemlate.PageWidthInt, _layoutTemlate.PageHeightInt);

            DrawOnCanvas(pdfCanvas, toPixel, labelPage);
        }

        public void DrawOnCanvas(SKCanvas canvas, float toPixel, LabelPage page)
        {
            canvas.Clear(SKColors.White);

            foreach (var label in page.Labels)
            {
                using (SKPaint framePaint = new SKPaint())
                {
                    framePaint.Style = SKPaintStyle.Stroke;
                    framePaint.StrokeWidth = _layoutTemlate.Box.StrokeWidth;
                    framePaint.Color = SKColors.Gray;

                    SKRect frameRect = new SKRect();

                    frameRect.Location = new SKPoint
                    {
                        X = label.Left,
                        Y = label.Top,
                    };

                    frameRect.Size = new SKSize
                    {
                        Width = _layoutTemlate.Box.Width,
                        Height = _layoutTemlate.Box.Height,
                    };

                    canvas.DrawRoundRect(frameRect, _layoutTemlate.Box.XReduce, _layoutTemlate.Box.YReduce, framePaint);
                }

                using (SKPaint businessNamePaint = new SKPaint())
                {
                    businessNamePaint.Color = SKColors.Black;

                    businessNamePaint.TextSize = _layoutTemlate.BusinessName.TextSize;

                    canvas.DrawText(label.BusinessName.Title, label.BusinessName.Left, label.BusinessName.Top, businessNamePaint);
                }

                using (SKPaint salePricePaint = new SKPaint())
                {
                    salePricePaint.Color = SKColors.Blue;

                    salePricePaint.TextSize = _layoutTemlate.SalePrice.TextSize;

                    canvas.DrawText(label.SalePrice.Title, label.SalePrice.Left, label.SalePrice.Top, salePricePaint);
                }

                using (SKPaint productNamePaint = new SKPaint())
                {
                    productNamePaint.Color = SKColors.Black;

                    productNamePaint.TextSize = _layoutTemlate.ProductName.TextSize;

                    canvas.DrawText(label.ProductName.Title, label.ProductName.Left, label.ProductName.Top, productNamePaint);
                }

                using (SKPaint skuPaint = new SKPaint())
                {

                    skuPaint.Color = SKColors.Black;

                    skuPaint.TextSize = _layoutTemlate.Sku.TextSize;

                    canvas.DrawText(label.Sku.Title, label.Sku.Left, label.Sku.Top, skuPaint);
                }

                using (SKPaint barCodeNumberPaint = new SKPaint())
                {

                    barCodeNumberPaint.Color = SKColors.Black;

                    barCodeNumberPaint.TextSize = _layoutTemlate.Barcode.TextSize;

                    canvas.DrawText(label.BarcodeNumber.Title, label.BarcodeNumber.Left, label.BarcodeNumber.Top, barCodeNumberPaint);
                }
            }

        }
    }
}
