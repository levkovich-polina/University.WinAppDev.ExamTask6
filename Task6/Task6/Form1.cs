using Timer = System.Threading.Timer;

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
        private Timer _timer;
        Random _random = new Random();
        int _playerPositionX;
        int _playerPositionY;
        int _stepIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateLevelButton_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
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
            _playerPositionX = _random.Next(0, 10);
            _playerPositionY = _random.Next(0, 10);
            _fields[_playerPositionX, _playerPositionY].Type = FieldType.Empty;
            Draw();
        }
        private void Draw()
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
            var x = _playerPositionX * (width / 10);
            var y = _playerPositionY * (height / 10);
            g.FillEllipse(Brushes.Red, x, y, width / 10, height / 10);
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoUp);
            ListBox.Items.Add("Вверх");
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoRight);
            ListBox.Items.Add("Вправо");
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoLeft);
            ListBox.Items.Add("Влево");
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            _commands.Add(Command.GoDown);
            ListBox.Items.Add("Вниз");
        }

        private void RunProgramButton_Click(object sender, EventArgs e)
        {
            TimerCallback tm = new TimerCallback(OnTimerTicked);
            _timer = new Timer(tm, 0, 0, 100);
        }
        public void OnTimerTicked(object obj)
        {
            if (_commands[_stepIndex] == Command.GoDown)
            {
                _playerPositionY += 1;
            }
            else if (_commands[_stepIndex] == Command.GoUp)
            {
                _playerPositionY -= 1;
            }
            else if (_commands[_stepIndex] == Command.GoRight)
            {
                _playerPositionX += 1;
            }
            else
            {
                _playerPositionX -= 1;
            }
            if (_playerPositionX < 0 || _playerPositionY < 0 || _playerPositionX > 9 || _playerPositionY > 9)
            {
                _timer.Dispose();
                MessageBox.Show("Действие не может быть совершенно! Вы вышли за пределы игрового поля.");
            }           
            else if (_fields[_playerPositionX, _playerPositionY].Type == FieldType.Wall )
            {
                _timer.Dispose();
                MessageBox.Show("Действие не может быть совершенно! Впереди препятствие.");

            }
            else if (_fields[_playerPositionX, _playerPositionY].Type == FieldType.Empty)
            {
                Draw();
            }
            _stepIndex++;
            if (_stepIndex == _commands.Count)
            {
                _timer.Dispose();
            }
        }
    }
}