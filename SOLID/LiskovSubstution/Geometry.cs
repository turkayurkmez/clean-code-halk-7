using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    internal class Geometry
    {
        public IArea CreateRectangle(int unit1, int? unit2 = null)
        {
            //factory: ihtiyaç duyulan nesneyi üretip döndüren metod.
            //varsayın ki...
            return unit2.HasValue ? new Rectangle { Width = unit1, Height = unit2.Value } :
                                    new Square { EdgeLength = unit1 };


        }
    }

    public interface IArea
    {
        int GetArea();
    }

    public class Rectangle : IArea
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea() => Width * Height;
    }

    public class Square : IArea
    //: Rectangle
    {
        public int EdgeLength { get; set; }

        public int GetArea()
        {
            return EdgeLength * EdgeLength;
        }
    }


}
