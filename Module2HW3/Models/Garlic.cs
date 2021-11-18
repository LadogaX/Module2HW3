using System.Drawing;

namespace Module2HW3.Models
{
    public class Garlic : Onions
    {
        public Garlic(string name, int calories, Color color)
            : base(name, calories)
        {
            Color = color;
        }

        public Color Color { get; set; }
    }
}
