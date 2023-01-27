using System;

namespace Task6
{
    public partial class Form1 : Form
    {
       
        public class Field
        {
            public FieldType Type { get; set; }
            public  override string ToString()
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
        }
    }
}