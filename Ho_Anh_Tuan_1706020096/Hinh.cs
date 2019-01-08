using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ho_Anh_Tuan_1706020096
{
    class Hinh
    {
        public List<Point> save = new List<Point>();
        public virtual void Draw(Pen pen,Graphics g) { }
        public Hinh()
        {
        }
        public void Load(Dictionary<string,List<Point>> ink,string ink_name)
        {
            foreach(var item in ink)
            {
                if(item.Key == ink_name)
                {
                    save = item.Value;
                }
            }
        }
        public List<Point> datasave()
        {
            List<Point> temp = new List<Point>();
            temp = save;
            return temp;
        }
    }
    class Line : Hinh
    {
        public Point begin = new Point();
        public Point end = new Point();
        public Line()
        {
            begin = new Point(0, 0);
            end = new Point(0, 0);
        }
        public Line(Point A,Point B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            foreach(var item in save)
            {
                for(int i = 0; i< save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }
        public void Add()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch { }
        }
    }
    class Triangle : Hinh
    {
        public Point begin = new Point();
        public Point end = new Point();
        public Point fe = new Point();
        public Triangle()
        {
            begin = new Point(0, 0);
            end = new Point(0, 0);
            fe = new Point(0, 0);
        }
        public Triangle(Point A, Point B, Point C)
        {
            begin = A;
            end = B;
        }

        public override void Draw(Pen pen,Graphics g)
        {
            base.Draw(pen,g);
            Rectangle rect = new Rectangle();
            rect.Size = new Size(end.x - begin.x, end.y - end.y);
            rect.X = begin.x;
            rect.Y = begin.y;
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x - rect.Width, end.y);
        }
        public void Draw_tamGiac(Pen pen, Graphics g)
        {
            Rectangle rect = new Rectangle();
            rect.Size = new Size(end.x - begin.x, end.y - end.y);
            rect.X = begin.x;
            rect.Y = end.y;
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, end.x, end.x);
            g.DrawLine(pen, rect.X, rect.Y, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x - rect.Width, end.y);
        }
        public void Add()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch
            {

            }
        }
    }
    class Euclide : Hinh
    {
        public Point begin = new Point();
        public Point end = new Point();
        public Euclide()
        {
            begin = new Point(0, 0);
            end = new Point(0, 0);
        }
        public Euclide(Point A, Point B)
        {
            begin = A;
            end = B;
        }
        public override void Draw(Pen pen, Graphics g)
        {
            base.Draw(pen, g);
            for (int i = 0; i < save.Count - 1; i += 2)
            {
                Rectangle rect = new Rectangle();
                rect.Size = new Size(save[i + 1].x - save[i].x, save[i + 1].y - save[i].y);
                rect.X = save[i].x;
                rect.Y = save[i].y;
                float width = rect.Width / 2;
                float height = rect.Height / 2;
                g.DrawLine(pen, rect.X + width, rect.Y, save[i + 1].x, save[i + 1].y - height);
                g.DrawLine(pen, rect.X + width, rect.Y, rect.X, rect.Y + height);
                g.DrawLine(pen, rect.X, rect.Y + height, save[i + 1].x - width, save[i + 1].y);
                g.DrawLine(pen, save[i + 1].x - width, save[i + 1].y, save[i + 1].x, save[i + 1].y - height);
            }
        }
    }
}