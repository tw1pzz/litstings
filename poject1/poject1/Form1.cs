using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace poject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = textBox1.Text;
            string insertText = textBox2.Text;
            string bookTitle = partBookTitle.Insert(3,insertText);
            listBox1.Items.Add(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            // Удаляем подстроку с третьей позиции
            bookTitle = bookTitle.Remove(2);
            listBox1.Items.Add(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookTitle = textBox1.Text;
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            listBox1.Items.Add(bookTitle);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text;
            string str2 = textBox1.Text;
            int i = str2.IndexOf(str1);
            // Проверяем, входит ли строка око в слово Царь-колокол
            if (i >= 0)
                { listBox1.Items.Add(str1 + " входит в строку " + str2); }
            else
                { listBox1.Items.Add(str1 + " не входит в строку " + str2); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog; // получим 41
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString(); // получим 5 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Unicode-код для торговой марки
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Создаем строку из 5 звездочек
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }

        private void button9_Click(object sender, EventArgs e)
        {            
            string AutoName;
            AutoName = "BMW";
            textBox1.Text =
            String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000);
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Red;
            // Получим имя выбранного цвета
            textBox1.Text =
                (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void SayHello(string name)
        {            
         if (string.IsNullOrEmpty(name))
         throw new ArgumentNullException("name");
         MessageBox.Show(string.Concat("Hello, ", name));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SayHello();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Взять текст из текстового поля
            // Например, А роза упала на лапу Азора
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }


    }
}
