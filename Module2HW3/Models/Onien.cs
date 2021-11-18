using System.Drawing;

namespace Module2HW3.Models
{
    public class Onien : Onions
    {
        public Onien(string name, int calories, Color color)
            : base(name, calories)
        {
            Color = color;
        }

        public Color Color { get; set; }
    }
}