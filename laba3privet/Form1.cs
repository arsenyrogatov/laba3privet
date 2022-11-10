using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3privet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //тут короче запускаем еще одну форму чтобы у вас оценка побольше была
            form2.FormClosing += (object se, FormClosingEventArgs fe) =>
            {
                Application.Exit(); //при закрытии второй формы все приложение закроется нахуй
            };
            form2.Show();
        }

        private void code_button_Click(object sender, EventArgs e) //кнопка кодировать
        {
            result_textBox.Text = arMethod(input_textBox.Text.ToLower());
        }

        private string arMethod(string input) //арифметическое кодирование
        {
            int inputLen = input.Length; //количество символов 
            Dictionary<char, int> charFreq = new Dictionary<char, int>(); //частота повторения символов
            table_textBox.Text = ""; //таблица с частотой символов

            for (int i = 0; i < inputLen; i++)
            {
                int tmpVal; //если такая буква уже была, в этой переменной появится ее количество
                if (charFreq.TryGetValue(input[i], out tmpVal)) //тут мы это получаем
                {
                    charFreq[input[i]] = tmpVal + 1; //и прибавляем 1
                }
                else
                {
                    charFreq.Add(input[i], 1); // а если такой буквы нет то добавляем ее 
                }
            }

            foreach (var keyValue in charFreq) //тут выводим таблицу с частотой повторов
            {
                table_textBox.Text += "'" + keyValue.Key + "'\t|\t" + keyValue.Value + Environment.NewLine;
                //"\t" - это символ табуляции чтобы красиво вывелось 
                //ну лан пох короче не интересн
            }

            Dictionary<char, ArSegment> segments = new Dictionary<char, ArSegment>(); //оо это в википедии описано про эти сегменты

            double l = 0; //левая граница отрезка

            foreach (var keyValuePair in charFreq) //для каждой частоты повторения символа
            {
                ArSegment arSegment = new ArSegment(); //создаем сегмент
                arSegment.left = l; //левая граница сегмента это предыдущая левая
                arSegment.right = l + (keyValuePair.Value / (double)inputLen); //правую считаем по такой формуле 
                l = arSegment.right; //и теперь левая граница для следующего будет равна правой для текущего сегмента
                //это так в википедии написано!!!
                //мб даже в методичке
                segments.Add(keyValuePair.Key, arSegment); //ну и добавляем сегмент короче блин
            }


            double left = 0; //лево это 0
            double right = 1; //право это 1
            //ну типо как отрезок на прямой 
            for (int i = 0; i < inputLen; i++)
            {
                var newRight = left + (right - left) * segments[input[i]].right; //както так считаем новую правую границу
                var newLeft = left + (right - left) * segments[input[i]].left; //и левую

                right = newRight; //и сохраняем это короче
                left = newLeft;
            }

            var result = (left + right) / 2; //результат это середина между левым и правым 

            return result.ToString();
        }

        struct ArSegment //сам сегмент
        {
            //бля на самом деле это скорее отрезок а не сегмент ну лан пох
            public double left; //лево 
            public double right; //право
        }
    }
}
