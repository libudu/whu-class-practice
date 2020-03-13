using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    interface IValid
    {
        bool checkValid();
    }

    abstract class Geometry:IValid
    {
        // 几何类型的名字
        abstract public string typeName
        {
            get;
        }
        // 检测有效性的接口
        abstract public bool checkValid();

        // 根据条件，报告该几何体是否有效
        protected bool reportValid(bool condition)
        {
            if (condition)
            {
                return true;
            }
            Console.WriteLine("该形状参数有误，是无效形状！");
            return false;
        }

        // 几何体一定有面积属性
        abstract public double Area
        {
            get;
        }
    }

    class Rectangle : Geometry
    {
        override public string typeName
        {
            get { return "长方形"; }
        }
        override public double Area
        {
            get
            {
                return width * height;
            }
        }
        // 长方形宽度
        private double width;
        public double Width
        {
            get { return width; }
            set
            {
                width = value;
                checkValid();
            }
        }

        // 长方形高度
        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
                checkValid();
            }
        }

        // 检测长方形是否有效
        override public bool checkValid()
        {
            return reportValid(Height > 0 && Width > 0);
        }

        // 指定长宽构造参数
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            checkValid();
        }

        // 无参构造参数
        public Rectangle():this(1,1) { }
    }

    class Square : Rectangle
    {
        override public string typeName
        {
            get { return "正方形"; }
        }
        // 正方形的边长
        public double Side
        {
            get { return Side; }
            set { Width = Side; Height = Side; }
        }

        // 传参构造函数
        public Square(double side) : base(side, side) { }

        // 默认构造函数
        public Square() : base() { }
    }

    class Circle : Geometry
    {
        override public string typeName
        {
            get { return "圆形"; }
        }

        // 面积
        override public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        // 圆的半径
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                checkValid();
            }
        }

        // 检测该圆形是否有效
        override public bool checkValid()
        {
            return reportValid(Radius >= 0);
        }

        // 圆形传参构造参数
        public Circle(double radius)
        {
            Radius = radius;
            checkValid();
        }

        // 圆形无参构造参数
        public Circle():this(1){ }
    }

    class Triangle : Geometry
    {
        override public string typeName
        {
            get { return "三角形"; }
        }
        public override double Area
        {
            get
            {
                double p = (side1 + side2 + side3) / 2;
                return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            }
        }

        private double side1;
        public double Side1
        {
            get { return side1; }
            set
            {
                side1 = value;
                checkValid();
            }
        }

        private double side2;
        public double Side2
        {
            get { return side2; }
            set
            {
                side2 = value;
                checkValid();
            }
        }

        private double side3;
        public double Side3
        {
            get { return side3; }
            set
            {
                side3 = value;
                checkValid();
            }
        }

        // 检测有效性
        override public bool checkValid()
        {
            bool valid = (side1 + side2 > side3) && (side3 + side2 > side1) &&(side1 + side3 > side2);
            return reportValid(valid);
        }

        // 传参构造
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // 无参构造
        public Triangle():this(1,1,1) { }
    }

    class GeometryGenerator
    {
        static Random rd = new Random();
        static Type[] GeometryList = { typeof(Rectangle), typeof(Square), typeof(Circle), typeof(Triangle)};
        public static Geometry GetGeometry()
        {
            int index = rd.Next(0, GeometryList.Length);
            Geometry geo = (Geometry)Activator.CreateInstance(GeometryList[index]);
            return geo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
                reportGeometry(GeometryGenerator.GetGeometry());
            Console.ReadKey();
        }
        static void reportGeometry(Geometry geo)
        {
            Console.WriteLine(geo.typeName);
            Console.WriteLine(geo.Area);
        }
    }
}
