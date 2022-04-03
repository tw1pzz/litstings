using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog2
{
    public partial class Form1 : Form
    {const string strTextForButton = "Тестовая строкаааааааааааааа";
        public Form1()
        {
            InitializeComponent();
            button1.Text = strTextForButton;
            using (Graphics graphics = button1.CreateGraphics())          
            {
                button1.Width = (int)graphics.MeasureString(strTextForButton,Font).Width;
                this.Text = button1.Width.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Шаг 1
            TextBox tb = new TextBox();
            // Шаг 2
            tb.Location = new Point(10, 10);
            tb.Size = new Size(300, 20);
            tb.Text = "Я был создан во время выполнения программы";
            // Шаг 3
            this.Controls.Add(tb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                foreach (Control ctrl in this.Controls)
                {
                    // Работаем только с текстовыми полями
                    if (ctrl.GetType() == typeof(TextBox))
                        ctrl.Text = "Народные советы";
                }
          
        }

        private void IterateControls(Control ctrl)
        {
            // Работаем только с текстовыми полями
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "Народные советы";
            }
            // Проходим через элементы рекурсивно,
            // чтобы не пропустить элементы, которые находятся в контейнерах
            foreach (Control ctrlChild in ctrl.Controls)
            {
                IterateControls(ctrlChild);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                IterateControls(this);
            }
        }

        public class MyButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                int borderWidth = 1;
                Color borderColor = Color.Green;
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyButton btn = new MyButton();
            btn.Width = 90;
            btn.Height = 50;
            btn.Left = 100;
            btn.Top = 10;
            btn.Text = "Я новая кнопка";
            btn.Visible = true;
            this.Controls.Add(btn);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
                Graphics g = e.Graphics;
                Pen p = new Pen(Color.Red, 3);

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.GetType() == typeof(CheckBox))
                    {
                        g.DrawRectangle(p, new Rectangle(ctrl.Location, ctrl.Size));
                    }
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            {
                const int MAX_LENGTH = 5;
                if (textBox1.Text.Length == MAX_LENGTH)
                // переводим фокус на следующий элемент управления
                SelectNextControl(textBox1, true, true, false, false);
            }
        }

        private void button7_Click(object sender, EventArgs e)        
        {
                // Выводим кнопку button2 на передний край
                this.Controls.SetChildIndex(button2, 0);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }
    }
}
