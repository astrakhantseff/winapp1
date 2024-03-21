namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private List<Segment> segments;
        private RectangleF rectangle;
        private List<Segment> intersectedSegments;

        public MainForm()
        {
            InitializeComponent();
            segments = new List<Segment>();
            intersectedSegments = new List<Segment>();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Отрисовка отрезков из входных данных
            foreach (var segment in segments)
            {
                e.Graphics.DrawLine(Pens.Blue, segment.Start, segment.End);
            }

            // Отрисовка прямоугольника
            e.Graphics.DrawRectangle(Pens.Red, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);

            // Отрисовка отрезков из выходных данных
            foreach (var segment in intersectedSegments)
            {
                e.Graphics.DrawLine(Pens.Green, segment.Start, segment.End);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            // Добавление нового отрезка
            if (e.Button == MouseButtons.Left)
            {
                if (segments.Count == 0 ||
                    segments[segments.Count - 1].End != Point.Empty)
                {
                    segments.Add(new Segment(e.Location, Point.Empty));
                }
                else
                {
                    segments[segments.Count - 1].End = e.Location;
                    Invalidate();
                }
            }
            // Установка прямоугольника области
            else if (e.Button == MouseButtons.Right)
            {
                rectangle = new RectangleF(e.Location, SizeF.Empty);
                Invalidate();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Изменение размеров прямоугольника области
            if (e.Button == MouseButtons.Right)
            {
                rectangle = new RectangleF(rectangle.Location, 
                    new SizeF(e.X - rectangle.Left, e.Y - rectangle.Top));
                Invalidate();
            }
        }

        private void ProcessSegments()
        {
            intersectedSegments.Clear();

            foreach (var segment in segments)
            {
                if (segment.IntersectsWith(rectangle))
                {
                    intersectedSegments.Add(segment);
                }
            }

            segments.RemoveAll(i => intersectedSegments.Contains(i));
            
            Invalidate();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            ProcessSegments();
        }
    }
}
