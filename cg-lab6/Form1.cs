using cg_lab6.Primitives;
using cg_lab6.Figures;
using System.Diagnostics;
using cg_lab6.MathUtils;
using static cg_lab6.Constants;

namespace cg_lab6
{
    public partial class Form1 : Form
    {
        Graphics gr;
        ProjectionType projection;
        Constants.Axis axis;
        Tetrahedron t = new Tetrahedron();
        Polyhedron p;
        Hexahedron h = new Hexahedron();
        Octahedron o = new Octahedron();
        public Form1()
        {
            InitializeComponent();
            gr = graphicPanel.CreateGraphics();
            comboFigures.Items.Add("Тетраэдр");
            comboFigures.Items.Add("Гексаэдр");
            comboFigures.Items.Add("Октаэдр");
            comboFigures.Items.Add("Икосаэдр");
            comboFigures.Items.Add("Додекаэдр");

            comboAxes.Items.Add("X");
            comboAxes.Items.Add("Y");
            comboAxes.Items.Add("Z");
            comboAxes2.Items.Add("X");
            comboAxes2.Items.Add("Y");
            comboAxes2.Items.Add("Z");

            comboAxes.SelectedIndex = 0;
            comboAxes2.SelectedIndex = 0;
            comboFigures.SelectedIndex = 0;
            axis = Constants.Axis.X;
            radioPerspectiveCentral.Checked = true;
            Constants.WORLD_X = graphicPanel.Width / 2;
            Constants.WORLD_Y = graphicPanel.Height / 2 + 25;
            groupRotate.Enabled = false;
            groupShift.Enabled = false;
            groupScale.Enabled = false;

            inputAngle.Text = "0";
            inputAngleCenter.Text = "0";
            inputShiftX.Text = "0";
            inputShiftY.Text = "0";
            inputShiftZ.Text = "0";
            inputScaleX.Text = "0";
            inputScaleY.Text = "0";
            inputScaleZ.Text = "0";



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void drawAxis()
        {
            Dot zero = new Dot(0, 0, 0);
            Dot x = new Dot(500, 0, 0);
            Dot y = new Dot(0, 300, 0);
            Dot z = new Dot(0, 0, 500);
            gr.DrawLine(new Pen(Color.Red), zero.getProjection(projection), x.getProjection(projection));
            gr.DrawLine(new Pen(Color.Green), zero.getProjection(projection), y.getProjection(projection));
            gr.DrawLine(new Pen(Color.Blue), zero.getProjection(projection), z.getProjection(projection));
            gr.DrawString($" X", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Red), x.getProjection(projection).X, x.getProjection(projection).Y);
            gr.DrawString($" Y", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Green), y.getProjection(projection).X, y.getProjection(projection).Y);
            gr.DrawString($" Z", new Font("Arial", 10, FontStyle.Regular), new SolidBrush(Color.Blue), z.getProjection(projection).X, z.getProjection(projection).Y);


        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            groupRotate.Enabled = true;
            groupShift.Enabled = true;
            groupScale.Enabled = true;
            gr.Clear(Color.White);
            drawAxis();

            switch (comboFigures.SelectedIndex)
            {
                case 0:
                    p = t.shape;
                    break;
                case 1:
                    p = h.shape;
                    break;
                case 2:
                    p = o.shape;
                    break;
                default:
                    p = t.shape;
                    break;
            }
            foreach (Polygon poly in p.polys)
            {
                foreach (Edge edge in poly.edges)
                {
                    gr.DrawLine(new Pen(Color.Red), edge.start.getProjection(projection), edge.end.getProjection(projection));
                }
            }

            gr.DrawRectangle(new Pen(Color.Black), p.getCenter().getProjection(projection).X, p.getCenter().getProjection(projection).Y, 2, 2); // Центр

        }

        private void radioPerspectiveCentral_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerspectiveCentral.Checked)
            {
                projection = ProjectionType.Central;
            }
            else
            {
                projection = ProjectionType.Isometric;
            }
        }

        private void comboAxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboAxes.SelectedIndex)
            {
                case 0:
                    axis = Constants.Axis.X;
                    break;
                case 1:
                    axis = Constants.Axis.Y;
                    break;
                case 2:
                    axis = Constants.Axis.Z;
                    break;
                default:
                    axis = Constants.Axis.X;
                    break;
            }
        }


        private void buttonRotateAxes_Click(object sender, EventArgs e)
        {
            p.dots = AffineTransformations.rotate(p.dots, double.Parse(inputAngle.Text), axis);
            p.transform();
            gr.Clear(Color.White);
            drawAxis();
            foreach (Polygon poly in p.polys)
            {
                foreach (Edge edge in poly.edges)
                {
                    gr.DrawLine(new Pen(Color.Red), edge.start.getProjection(projection), edge.end.getProjection(projection));
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonShiftCoords_Click(object sender, EventArgs e)
        {
            p.dots = AffineTransformations.shift(p.dots, double.Parse(inputShiftX.Text), double.Parse(inputShiftY.Text), double.Parse(inputShiftZ.Text));
            p.transform();
            gr.Clear(Color.White);
            drawAxis();
            foreach (Polygon poly in p.polys)
            {
                foreach (Edge edge in poly.edges)
                {
                    gr.DrawLine(new Pen(Color.Red), edge.start.getProjection(projection), edge.end.getProjection(projection));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonScaleCoords_Click(object sender, EventArgs e)
        {
            p.dots = AffineTransformations.scale(p.dots, double.Parse(inputScaleX.Text), double.Parse(inputScaleY.Text), double.Parse(inputScaleZ.Text));
            p.transform();
            gr.Clear(Color.White);
            drawAxis();
            foreach (Polygon poly in p.polys)
            {
                foreach (Edge edge in poly.edges)
                {
                    gr.DrawLine(new Pen(Color.Red), edge.start.getProjection(projection), edge.end.getProjection(projection));
                }
            }
        }

        private void buttonRotateCenter_Click(object sender, EventArgs e)
        {
            p.dots = AffineTransformations.rotate_around_center(p.dots, p.getCenter(), axis, double.Parse(inputAngle.Text));
            p.transform();
            gr.Clear(Color.White);
            drawAxis();
            foreach (Polygon poly in p.polys)
            {
                foreach (Edge edge in poly.edges)
                {
                    gr.DrawLine(new Pen(Color.Red), edge.start.getProjection(projection), edge.end.getProjection(projection));
                }
            }
        }

        private void comboAxes2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void inputAngleCenter_TextChanged(object sender, EventArgs e)
        {
        }
    }
}