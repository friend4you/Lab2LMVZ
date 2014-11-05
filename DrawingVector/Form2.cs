using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Single;

namespace DrawingVector
{
    public partial class Form2 : Form
    {
        SparseVector[] vectors;
        bool[,] intersaction;
        float bgsize;
        float zCamAlpha = 0.5f;
        float xCamAlpha = 1.4f;
        float xObjAlpha;
        float yObjAlpha;
        float zObjAlpha;
        Graphics graph;        
        Matrix cameraMatrix, objectMatrix;

        public Form2()
        {
            vectors = new SparseVector[2];

            vectors[0] = new SparseVector(new float[] { 0, 0, 0 });
            vectors[1] = new SparseVector(new float[] { 0, 0, 0 });


            intersaction = new bool[2, 2];
            intersaction[0, 0] = true;
            intersaction[0, 1] = true;


            InitializeComponent();
            graph = DrawPanel.CreateGraphics();
            UpdateCameraMatrix();
            UpdateObjectMatrix();

            numericUpDown1.Maximum = Convert.ToInt32(textBox1.Text);
            numericUpDown2.Maximum = Convert.ToInt32(textBox1.Text);
            numericUpDown3.Maximum = Convert.ToInt32(textBox1.Text);
            numericUpDown4.Maximum = Convert.ToInt32(textBox1.Text);
            numericUpDown5.Maximum = Convert.ToInt32(textBox1.Text);
            numericUpDown6.Maximum = Convert.ToInt32(textBox1.Text);

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            ReDraw();
        }

        public void ReDraw()
        {
            PointF xrow = GetCameraPoint(new SparseVector(new float[] { bgsize, 0, 0 }));
            PointF yrow = GetCameraPoint(new SparseVector(new float[] { 0, bgsize, 0 }));
            PointF zrow = GetCameraPoint(new SparseVector(new float[] { 0, 0, bgsize }));
            PointF zero = GetCameraPoint(new SparseVector(new float[] { 0, 0, 0 }));
            PointF proectionX1 = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown1.Value, (float)numericUpDown2.Value, 0 }));
            PointF proectionY1 = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown1.Value, 0, (float)numericUpDown3.Value }));
            PointF proectionZ1 = GetCameraPoint(new SparseVector(new float[] { 0, (float)numericUpDown2.Value, (float)numericUpDown3.Value }));
            PointF proectionX2 = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown4.Value, (float)numericUpDown5.Value, 0 }));
            PointF proectionY2 = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown4.Value, 0, (float)numericUpDown6.Value }));
            PointF proectionZ2 = GetCameraPoint(new SparseVector(new float[] { 0, (float)numericUpDown6.Value, (float)numericUpDown6.Value }));
            PointF proectionX = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value }));
            PointF proectionY = GetCameraPoint(new SparseVector(new float[] { (float)numericUpDown4.Value, (float)numericUpDown5.Value, (float)numericUpDown6.Value }));

            PointF point0 = GetCameraPoint(new SparseVector(new float[] { 0, 0, 0 }));
            PointF point1 = GetCameraPoint(new SparseVector(new float[] { bgsize, 0, 0 }));
            PointF point2 = GetCameraPoint(new SparseVector(new float[] { 0, bgsize, 0 }));
            PointF point3 = GetCameraPoint(new SparseVector(new float[] { 0, 0, bgsize }));
            PointF point4 = GetCameraPoint(new SparseVector(new float[] { bgsize, bgsize, 0 }));
            PointF point5 = GetCameraPoint(new SparseVector(new float[] { 0, bgsize, bgsize }));
            PointF point6 = GetCameraPoint(new SparseVector(new float[] { bgsize, 0, bgsize }));

            PointF[] points1 = new PointF[] { point0, point2, point4, point1 };
            PointF[] points2 = new PointF[] { point0, point1, point6, point3 };
            PointF[] points3 = new PointF[] { point0, point3, point5, point2 };

            Bitmap bm = new Bitmap(DrawPanel.Width, DrawPanel.Height);
            Graphics gr = Graphics.FromImage(bm);

                

            gr.Clear(Color.White);

            gr.FillPolygon(Brushes.DarkGray, points1);
            gr.FillPolygon(Brushes.Gray, points2);
            gr.FillPolygon(Brushes.LightGray, points3);

            PointF[] points = new PointF[vectors.Length];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = GetObjectPoint(vectors[i]);
            }

            for (int i = 0; i < intersaction.GetLength(0); i++)
            {
                for (int j = i + 1; j < intersaction.GetLength(1); j++)
                {
                    if (intersaction[i, j])
                    {
                        gr.DrawLine(Pens.WhiteSmoke, points[i], points[j]);
                    }
                }
            }

            gr.DrawLine(Pens.Red, zero, xrow);
            gr.DrawLine(Pens.Green, zero, yrow);
            gr.DrawLine(Pens.Blue, zero, zrow);
            gr.DrawLine(Pens.Red, proectionX, proectionX1);
            gr.DrawLine(Pens.Red, proectionX, proectionY1);
            gr.DrawLine(Pens.Red, proectionX, proectionZ1);
            gr.DrawLine(Pens.Red, proectionY, proectionX2);
            gr.DrawLine(Pens.Red, proectionY, proectionY2);
            gr.DrawLine(Pens.Red, proectionY, proectionZ2);


            graph.DrawImage(bm, 0, 0);
        }
        void UpdateCameraMatrix()
        {
            float dx = 400;
            float dy = 300;
            Matrix tmpMatrix;

            //Вращение
            tmpMatrix = Matrix.RotZMatrix(zCamAlpha);
            tmpMatrix *= Matrix.RotXMatrix(xCamAlpha);
            //Матрица масштабирования.
            tmpMatrix *= Matrix.ScaleMatrix((float)trackSizeBar.Value);
            //Матрица проецирования.
            tmpMatrix *= Matrix.ProjectionMatrix();
            //Сдвигаем в центр
            tmpMatrix *= new Matrix(new float[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { dx, dy, 0, 1 } });

            cameraMatrix = tmpMatrix;
        }

        void UpdateObjectMatrix()
        {
            float dx = 400;
            float dy = 300;
            Matrix tmpMatrix;

            // Вращение обьекта
            tmpMatrix = Matrix.RotZMatrix(zObjAlpha);
            tmpMatrix *= Matrix.RotXMatrix(xObjAlpha);
            tmpMatrix *= Matrix.RotYMatrix(yObjAlpha);

            // Матрицы камеры
            tmpMatrix *= Matrix.RotZMatrix(zCamAlpha);
            tmpMatrix *= Matrix.RotXMatrix(xCamAlpha);
            tmpMatrix *= Matrix.ScaleMatrix((float)trackSizeBar.Value);
            //Матрица масштабирования.
            tmpMatrix *= Matrix.ProjectionMatrix();
            //Сдвигаем в центр
            tmpMatrix *= new Matrix(new float[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { dx, dy, 0, 1 } });

            objectMatrix = tmpMatrix;
        }

        PointF GetCameraPoint(SparseVector vector)
        {
            Matrix baseMatrix = new Matrix(new float[,] { { vector[0], vector[1], vector[2], 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
            Matrix resMatrix = baseMatrix * cameraMatrix;
            return new PointF(resMatrix[0, 0], resMatrix[0, 1]);
        }

        PointF GetObjectPoint(SparseVector vector)
        {
            //Matrix moveMatrix = new Matrix(new float[,] { { (float)TxBar.Value/10, (float)TyBar.Value/10, (float)TzBar.Value/10, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
            Matrix baseMatrix = new Matrix(new float[,] { { vector[0], vector[1], vector[2], 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } });
            Matrix resMatrix = (baseMatrix) * objectMatrix;
            return new PointF(resMatrix[0, 0], resMatrix[0, 1]);
        }

        private void XBar_Scroll(object sender, EventArgs e)
        {
            zCamAlpha = (float)XBar.Value / 10;
            UpdateCameraMatrix();
            UpdateObjectMatrix();
            ReDraw();
        }

        private void ScaleBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateCameraMatrix();
            UpdateObjectMatrix();
            ReDraw();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            ReDraw();
        }

        private void YBar_Scroll(object sender, EventArgs e)
        {
            xCamAlpha = (float)YBar.Value / 10;
            UpdateCameraMatrix();
            UpdateObjectMatrix();
            ReDraw();
        }

        private void TxBar_ValueChanged(object sender, EventArgs e)
        {
            ReDraw();
        }

        private void Rx_ValueChanged(object sender, EventArgs e)
        {
            xObjAlpha = (float)RxBar.Value / 10;
            yObjAlpha = (float)RyBar.Value / 10;
            zObjAlpha = (float)RzBar.Value / 10;
            UpdateObjectMatrix();
            ReDraw();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void CreateLineBtn_Click(object sender, EventArgs e)
        {
            vectors = new SparseVector[2];

            vectors[0] = new SparseVector(new float[] { (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value });
            vectors[1] = new SparseVector(new float[] { (float)numericUpDown4.Value, (float)numericUpDown5.Value, (float)numericUpDown6.Value });

            intersaction = new bool[2, 2];
            intersaction[0, 0] = true;
            intersaction[0, 1] = true;
            bgsize = (float)Convert.ToInt32(textBox1.Text);
            ReDraw();
        }

        private void trackSizeBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateCameraMatrix();
            UpdateObjectMatrix();
            ReDraw();
        }

    }
}
