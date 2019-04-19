using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PainApplication
{
    enum Tool
    {
        Pencil,
        Fill,
        Rectangle,
        Ellipse,
        Triangle
    }

    enum BitmapMode
    {
        New,
        File
    }

    public partial class Form1 : Form
    {
        Point startPoint = default(Point);
        Point finishPoint = default(Point);
        Graphics gfx;
        Bitmap bitmap;
        BitmapMode bitmapMode = default(BitmapMode);
        Pen pen;
        Tool activeTool = default(Tool);
        Color activeColor = Color.Black;
        float toolWidth = default(float);
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            toolWidth = float.Parse(widthUpDown.Value.ToString());
            pen = new Pen(activeColor, toolWidth);
            bitmapMode = BitmapMode.New;
            SetupPictureBox();
        }

        private void SetupPictureBox()
        {
            if (bitmapMode == BitmapMode.New)
            {
                bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            }
            else if (bitmapMode == BitmapMode.File)
            {
                bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
            }

            gfx = Graphics.FromImage(bitmap);

            pictureBox.Image = bitmap;
            pictureBox.Refresh();
            activeTool = Tool.Pencil;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Fill:
                    // our implementation
                    //FloodFill floodFill = new FloodFill(ref bitmap, e.Location);
                    //floodFill.Fill(activeColor);

                    // using DLL
                    MapFill mf = new MapFill();
                    mf.Fill(gfx, e.Location, activeColor, ref bitmap);
                    break;
                case Tool.Rectangle:
                    break;
                case Tool.Ellipse:
                    break;
                case Tool.Triangle:
                    break;
                default:
                    break;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                finishPoint = e.Location;

                switch (activeTool)
                {
                    case Tool.Pencil:
                        break;
                    case Tool.Fill:
                        break;
                    case Tool.Rectangle:
                        break;
                    case Tool.Ellipse:
                        break;
                    case Tool.Triangle:
                        break;
                    default:
                        break;
                }

                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            finishPoint = e.Location;

            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Fill:
                    break;
                case Tool.Rectangle:
                    gfx.DrawRectangle(pen, GetRectangle());
                    break;
                case Tool.Ellipse:
                    gfx.DrawEllipse(pen, GetRectangle());
                    break;
                case Tool.Triangle:
                    break;
                default:
                    break;
            }

            pictureBox.Refresh();
        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Pencil;
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Fill;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Ellipse;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Rectangle;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activeTool = Tool.Triangle;
        }

        private Rectangle GetRectangle()
        {
            Rectangle rect = new Rectangle(
                        Math.Min(startPoint.X, finishPoint.X), Math.Min(startPoint.Y, finishPoint.Y),
                        Math.Abs(startPoint.X - finishPoint.X), Math.Abs(startPoint.Y - finishPoint.Y)
                        );
            return rect;
        }

        // is called in pictureBox.Refresh()
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = count++.ToString();

            switch (activeTool)
            {
                case Tool.Pencil:
                    break;
                case Tool.Fill:
                    break;
                case Tool.Rectangle:
                    Graphics componentGraphics = e.Graphics;
                    componentGraphics.DrawRectangle(pen, GetRectangle());
                    break;
                case Tool.Ellipse:
                    e.Graphics.DrawEllipse(pen, GetRectangle());
                    break;
                case Tool.Triangle:
                    break;
                default:
                    break;
            }
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            // "3.14" -> 3.14
            toolWidth = float.Parse(widthUpDown.Value.ToString());
            pen.Width = toolWidth;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeColor = colorDialog1.Color;
                pen.Color = activeColor;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmapMode = BitmapMode.File;
                SetupPictureBox();
            }
        }
    }
}