using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground.Filters
{
    ///GRAYSCALE FILTER APPLIED OWING TO MINOR CHANGES (ARITHMETIC AVERAGE?)
    public class GreyScaleFilter : IFilter
    {
        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var p = input[x, y];
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;
                    result[x, y] = Color.FromArgb(p.A, avg, avg, avg);
                    
                }
            }

            return result;
        }

        public string Name => "GREYSCALE FILTER";

        public override string ToString()
            => Name;
    }
}
