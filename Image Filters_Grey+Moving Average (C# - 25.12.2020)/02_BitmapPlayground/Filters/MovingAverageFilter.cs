using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground.Filters
{
    ///SIMPLE MOVING AVERAGE FILTER
    public class MovingAverageFilter : IFilter
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
                    int a = p.A;
                    int r = p.R;
                    int avg1 = (a + r) / 2;
                    int g = p.G;
                    int avg2 = (a + r + g) / 3;
                    int b = p.B;
                    int avg3 = (a + r + g + b) / 4;
                    result[x, y] = Color.FromArgb(p.A, avg1, avg2, avg3);
                }
            }

            return result;
        }

        public string Name => "MOVING AVERAGE FILTER";

        public override string ToString()
            => Name;
    }
}
