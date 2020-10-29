using SkiaSharpSampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiaSharpSampleApp.Models
{
    public class LabelPage
    {
        public int PageNumber { get; set; }
        public List<LabelBox> Labels { get; set; }
    }
}
