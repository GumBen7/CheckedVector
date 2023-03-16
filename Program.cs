﻿namespace V {
    class Program {
        static void Main(string[] args) {
            Check();
        }

        public class Vector {
            private double _x;
            public double X {set => _x = value; get => _x;}
            private double _y;
            public double Y {set => _y = value; get => _y;}
            public double Length;
            ///<summary>
            ///Этот конструктор инициализирует новый вектор к (<paramref name="x"/>,<paramref name="y"/>).
            ///</summary> 
            public Vector(double x, double y) {
                this.X = x;
                this.Y = y;
            }
            public override string ToString() {
                return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
            }
        }
        public static void Check() { 
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());
            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());
            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());
            Console.WriteLine(new Vector(0, 0).ToString());
        }
    }    
}