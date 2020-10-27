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
        const int width = 300, height = 250;

        static void Main(string[] args)
        {
            // create zpl string using https://github.com/BinaryKits/ZPLUtility
            // you can have a preview at http://labelary.com/viewer.html
            // and convert zpl to pdf & png

            // create skia sharp canvas and get png & pdf from that
            // convert either pdf or png to zpl

            {
                var sampleText = "[_~^][LineBreak\n][The quick fox jumps over the lazy dog.]";
                ZPLFont font = new ZPLFont(fontWidth: 50, fontHeight: 50);
                var labelElements = new List<ZPLElementBase>();
                labelElements.Add(new ZPLTextField(sampleText, 50, 100, font));
                labelElements.Add(new ZPLGraphicBox(400, 700, 100, 100, 5));
                labelElements.Add(new ZPLGraphicBox(450, 750, 100, 100, 50, ZPLConstants.LineColor.White));
                labelElements.Add(new ZPLGraphicCircle(400, 700, 100, 5));
                labelElements.Add(new ZPLGraphicDiagonalLine(400, 700, 100, 50, 5));
                labelElements.Add(new ZPLGraphicDiagonalLine(400, 700, 50, 100, 5));
                labelElements.Add(new ZPLGraphicSymbol(ZPLGraphicSymbol.GraphicSymbolCharacter.Copyright, 600, 600, 50, 50));

                //Add raw ZPL code
                labelElements.Add(new ZPLRaw("^FO200, 200^GB300, 200, 10 ^FS"));

                var renderEngine = new ZPLEngine(labelElements);
                var output = renderEngine.ToZPLString(new ZPLRenderOptions() { AddEmptyLineBeforeElementStart = true });

                Console.WriteLine(output);
            }

            // ------------------------------------------------------------------------------------------------------------------------

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

            {
                string output = Conversion.ConvertPdfPage(File.OpenRead(Path.Combine(AppContext.BaseDirectory, "doc.pdf")));
            }

            {
                // Svg.Contrib.Render.ZPL
            }
        }

        static void DrawOnCanvas(SKCanvas canvas)
        {
            canvas.Clear(SKColors.White);

            // draw left-aligned text, solid
            using (SKPaint paint = new SKPaint())
            {
                paint.TextSize = 64.0f;
                paint.IsAntialias = true;
                paint.Color = new SKColor(0x42, 0x81, 0xA4);
                paint.IsStroke = false;

                canvas.DrawText("Skia1", width / 2f, 64.0f, paint);
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

                canvas.DrawText("Skia2", width / 2f, 144.0f, paint);
            }

            // draw right-aligned text, scaled
            using (var paint = new SKPaint())
            {
                paint.TextSize = 64.0f;
                paint.IsAntialias = true;
                paint.Color = new SKColor(0xE6, 0xB8, 0x9C);
                paint.TextScaleX = 1.5f;
                paint.TextAlign = SKTextAlign.Right;

                canvas.DrawText("Skia3", width / 2f, 224.0f, paint);
            }
        }
    }
}
