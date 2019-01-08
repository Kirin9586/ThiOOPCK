using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Ho_Anh_Tuan_1706020096
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Point>> data = new Dictionary<string, List<Point>>();
        Graphics g;
        Pen pen = new Pen(Color.Black, 1);
        bool CanDraw = false;
        Point begin = new Point();
        Point end = new Point();
        Point fe = new Point();
        Line line = new Line();
        Rectangle rect = new Rectangle();
        Triangle tamgiac = new Triangle();
        Euclide thoi = new Euclide();
        bool pointer, isLine, isTriangle, isEuclide;

        private void pararaph_MouseMove(object sender, MouseEventArgs e)
        {
            if(CanDraw == true)
            {
                end = new Point(e.X, e.Y);
                fe = new Point(fe.x, fe.y);
                g.Clear(pararaph.BackColor);
                if (pointer)
                {
                    return;
                }
                else if (isLine == true)
                {
                    g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);
                }
                else if(isTriangle == true)
                {
                    Rectangle rect = new Rectangle();
                    rect.Size = new Size(end.x - begin.x, end.y - end.y);
                    rect.X = begin.x;
                    rect.Y = begin.y;
                    g.DrawLine(pen, rect.X, rect.Y + rect.Height, end.x, end.y);
                    g.DrawLine(pen, rect.X, rect.Y, end.x, end.y);
                    g.DrawLine(pen, rect.X, rect.Y, end.x - rect.Width, end.y);
                }
                else if(isEuclide == true)
                {
                    thoi.begin = new Point(e.X, e.Y);
                    thoi.Draw(pen, g);
                }
        
                    
                Update();
            }
        }

        private void pararaph_MouseUp(object sender, MouseEventArgs e)
        {
            if(pointer == false)
            {
                end.x = e.X;
                end.y = e.Y;
                CanDraw = false;
            }
            if (isLine)
            {
                line.begin = begin;
                line.end = end;
                line.Add();
            }
            if (isTriangle)
            {
                tamgiac.begin = begin;
                tamgiac.end = end;
                tamgiac.fe = fe;
                tamgiac.Add();
            }
            if (isEuclide)
            {
                thoi.begin = begin;
                thoi.end = end;
               
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            pointer = true;
            isTriangle = false;
            isLine = false;
            isEuclide = false;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", line.datasave());
            data.Add("tamgiac", tamgiac.datasave());
            data.Add("hinhthoi",thoi.datasave());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            pointer = true;
            isTriangle = false;
            isLine = false;
            isEuclide = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<Point>>>(json);
            line.Load(data, "line");
            tamgiac.Load(data, "triange");
            thoi.Load(data, "euclide");
            reader.Close();
            Update();
        }

        private void duong_thang_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = true;
            isTriangle = false;
            isEuclide = false;
        }

        private void tam_giac_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = false;
            isTriangle = true;
            isEuclide = false;
        }

        private void hinh_thoi_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = false;
            isTriangle = false;
            isEuclide = true;
        }

        private void pararaph_MouseDown(object sender, MouseEventArgs e)
        {
            if(pointer == false)
            {
                CanDraw = true;
                begin = new Point(e.X, e.Y);
                rect.X = begin.x;
                rect.Y = begin.y;
            }
        }

        public Form1()
        {
            InitializeComponent();
            g = pararaph.CreateGraphics();
            pointer = true;
            isLine = false;
            isTriangle = false;
            isEuclide = false;
        }
        void Update()
        {
            for (int i = 0; i < line.save.Count - 1; i += 2)
            {
                line.Draw(g, pen);
            }
            for (int i = 0; i < tamgiac.save.Count - 1; i += 2)
            {
                tamgiac.Draw(pen,g);
            }
            for (int i = 0; i <thoi.save.Count - 1; i += 2)
            {
                thoi.Draw(pen,g);
            }
        }

    }
}
