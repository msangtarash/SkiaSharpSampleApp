using BinaryKits.Utility.ZPLUtility;
using PDFtoZPL;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;

namespace SkiaSharpSampleApp
{
    class Program
    {
        ///https://skia.org/user/api/skpaint_overview

        const int width = 300, height = 250;

        static void Main(string[] args)
        {
            {
                SKImageInfo imageInfo = new SKImageInfo(width, height);
                using SKSurface surface = SKSurface.Create(imageInfo);
                SKCanvas canvas = surface.Canvas;
                DrawOnCanvas(canvas);
                using SKImage image = surface.Snapshot();
                using SKData data = image.Encode(SKEncodedImageFormat.Png, 80);
                using FileStream stream = File.OpenWrite(Path.Combine(AppContext.BaseDirectory, "image.png"));
                data.SaveTo(stream);
            }

            {
                using SKFileWStream stream = new SKFileWStream(Path.Combine(AppContext.BaseDirectory, "doc.pdf"));
                using SKDocument document = SKDocument.CreatePdf(stream, 203);
                using SKPaint paint = new SKPaint
                {
                    TextSize = 64.0f,
                    IsAntialias = true,
                    Color = 0xFF9CAFB7,
                    IsStroke = true,
                    StrokeWidth = 3,
                    TextAlign = SKTextAlign.Center
                };

                using SKCanvas pdfCanvas = document.BeginPage(width, height);
                DrawOnCanvas(pdfCanvas);

                document.Close();
            }
        }

        static void DrawOnCanvas(SKCanvas canvas)
        {
            canvas.Clear(SKColors.White);

            //AddText(canvas);
        }

        void AddText(SKCanvas canvas)
        {
            // draw left-aligned text, solid
            using (SKPaint paint = new SKPaint())
            {
                paint.TextSize = 64.0f;
                paint.IsAntialias = true;
                paint.Color = new SKColor(0x42, 0x81, 0xA4);
                paint.IsStroke = false;

                canvas.DrawText("Skia", width / 2f, 64.0f, paint);
            }

            // draw centered text, stroked
            using (var paint = new SKPaint())
            {
                paint.TextSize = 64.0f;
                paint.IsAntialias = true;
                paint.Color = new SKColor(0x9C, 0xAF, 0xB7);
                paint.IsStroke = true;
                paint.StrokeWidth = 3;
                paint.TextAlign = SKTextAlign.Center;

                canvas.DrawText("Skia", width / 2f, 144.0f, paint);
            }

            // draw right-aligned text, scaled
            using (var paint = new SKPaint())
            {
                paint.TextSize = 64.0f;
                paint.IsAntialias = true;
                paint.Color = new SKColor(0xE6, 0xB8, 0x9C);
                paint.TextScaleX = 1.5f;
                paint.TextAlign = SKTextAlign.Right;

                canvas.DrawText("Skia", width / 2f, 224.0f, paint);
            }
        }

    }
}
