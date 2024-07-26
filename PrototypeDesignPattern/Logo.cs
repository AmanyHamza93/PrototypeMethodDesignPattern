using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Logo : IGraphicElement
    {
        public string _name { get; set; }
        public string _color { get; set; }
        public Shape _shape { get; set; }
        public Logo(string name, string color,Shape shape)
        {
            _name = name;
            _color = color;
            _shape = shape;
        }
        public void ShallowCopy()
        {
            var result = (Logo) MemberwiseClone();
            var newCopy = result;

            newCopy._name = "New Logo";
            newCopy._color = "White";
            newCopy._shape.Width = 200;
            newCopy._shape.Height = 100;

            Console.WriteLine("------- Shallow Copy ------------");
            Console.WriteLine($"name : {result._name}, " +
                               $"color : {result._color}, " +
                               $"shape : width {result._shape.Width}, height {result._shape.Height}");
            Console.WriteLine($"name : {newCopy._name}, " +
                              $"color : {newCopy._color}, " +
                              $"shape : width {newCopy._shape.Width}, height {newCopy._shape.Height}");
        }
        public void DeepCopy()
        {
            var result = (Logo)MemberwiseClone();
            var newCopy = new Logo("Hospital Logo", "Pink", new Shape { Width = 500, Height = 250 });
            
            Console.WriteLine("------- Deep Copy ------------");
            Console.WriteLine($"name : {result._name}, " +
                                $"color : {result._color}, " +
                                $"shape : width {result._shape.Width}, height {result._shape.Height}");
            Console.WriteLine($"name : {newCopy._name}, " +
                               $"color : {newCopy._color}, " +
                               $"shape : width {newCopy._shape.Width}, height {newCopy._shape.Height}");
        }
    }
}
