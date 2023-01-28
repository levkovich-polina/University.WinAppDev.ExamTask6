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
        List<Command> _commands;

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

            Graphics g = Panel.CreateGraphics();
            Draw(g);
        }
        public void Draw(Graphics g)
        {
            Panel.CreateGraphics().Clear(Color.White);
            int width = Panel.ClientSize.Width;
            int height = Panel.ClientSize.Height;
            for (int x = 0; x < width; x += width / 10)
            {
                g.DrawLine(new Pen(Color.Black), x, 0, x, height);
            }
            for (int y = 0; y < height; y += height / 10)
            {
                g.DrawLine(new Pen(Color.Black), 0, y, width, y);
            }
            int X = 0;
            int Y = 0;
            for (int x = 0; x < 10; x++)
            {
                X += width / 10;
                for (int y = 0; y < 10; y++)
                {
                    Y += height / 10;
                    if (_fields[x, y].Type == FieldType.Wall)
                    {
                        g.FillRectangle(Brushes.Gray, X, Y, width / 10, height / 10);
                    }
                }
                Y = 0;
            }
        }
    }
}