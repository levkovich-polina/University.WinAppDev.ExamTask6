namespace Task6
{
    public partial class Form1 : Form
    {

        public class Field
        {
            public FieldType Type { get; set; }
            public override string ToString()
            {
                return $"{Type}";
            }
        }

        public enum FieldType
        {
            Empty,
            Wall,
        }


        public enum Command
        {
            GoLeft,
            GoRight,
            GoUp,
            GoDown,
        }

        Field[,] _fields = new Field[10, 10];
        List<Command> _commands = new List<Command>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        Random _random = new Random();
        int _playerStartPositionX;
        int _playerStartPositionY;
        private void GenerateLevelButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int chance = _random.Next(1, 11);
                    _fields[i, j] = new Field();
                    if (chance <= 2)
                    {
                        _fields[i, j].Type = FieldType.Wall;
                    }
                    else
                    {
                        _fields[i, j].Type = FieldType.Empty;
                    }
                }
            }
            _playerStartPositionX = _random.Next(0, 10);
            _playerStartPositionY = _random.Next(0, 10);
            _fields[_playerStartPositionX, _playerStartPositionY].Type = FieldType.Empty;
            Draw();
        }
        public void Draw()
        {
            Panel.CreateGraphics().Clear(Color.White);
            Graphics g = Panel.CreateGraphics();
            int width = Panel.ClientSize.Width;
            int height = Panel.ClientSize.Height;
            for (int i = 0; i < width; i += width / 10)
            {
                g.DrawLine(new Pen(Color.Black), i, 0, i, height);
            }
            for (int j = 0; j < height; j += height / 10)
            {
                g.DrawLine(new Pen(Color.Black), 0, j, width, j);
            }
            int X = 0;
            int Y = 0;
            for (int i = 0; i < 10; i++)
            {
                X += width / 10;
                for (int j = 0; j < 10; j++)
                {
                    Y += height / 10;
                    if (_fields[i, j].Type == FieldType.Wall)
                    {
                        g.FillRectangle(Brushes.Gray, X, Y, width / 10, height / 10);
                    }
                }
                Y = 0;
            }
            var x = _playerStartPositionX * (width / 10);
            var y = _playerStartPositionY * (height / 10);
            g.FillEllipse(Brushes.Red, x, y, width / 10, height / 10);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoUp);
            ListBox.Items.Add("¬верх");
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoRight);
            ListBox.Items.Add("¬право");
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoLeft);
            ListBox.Items.Add("¬лево");
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoDown);
            ListBox.Items.Add("¬низ");
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {

        }
    }
}