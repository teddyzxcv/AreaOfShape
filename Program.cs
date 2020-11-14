using System;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
namespace AreaOfShape
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ShapesClass> ShapeList = new List<ShapesClass>();
            Random rn = new Random();
            Console.Write("Rectangle: ");
            int NRec = int.Parse(Console.ReadLine());
            for (int i = 0; i < NRec; i++)
            {
                Rectangle Rec = new Rectangle();
                Rec.x = rn.Next(3, 20);
                Rec.y = rn.Next(3, 20);
                ShapeList.Add(Rec);
            }
            Console.Write("Circle: ");
            int NCir = int.Parse(Console.ReadLine());
            for (int i = 0; i < NCir; i++)
            {
                Circle Cir = new Circle();
                Cir.r = rn.Next(3, 20);
                ShapeList.Add(Cir);
            }
            Console.Write("Triangle: ");
            int NTri = int.Parse(Console.ReadLine());
            for (int i = 0; i < NTri; i++)
            {
                Triangle Tri = new Triangle();
                Tri.a = rn.Next(3, 20);
                Tri.b = rn.Next(3, 20);
                Tri.c = rn.Next(3, 20);
                ShapeList.Add(Tri);
            }
            Console.Write("Square: ");
            int NSq = int.Parse(Console.ReadLine());
            for (int i = 0; i < NSq; i++)
            {
                Square Cir = new Square();
                Cir.r = rn.Next(3, 20);
                ShapeList.Add(Cir);
            }
            Console.WriteLine(JsonConvert.SerializeObject(ShapeList));

            for (int i = 0; i < ShapeList.Count; i++)
            {
                Console.WriteLine(JsonConvert.SerializeObject(ShapeList[i]));
            }





        }
    }
}
