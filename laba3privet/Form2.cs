using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3privet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bwtCode_button_Click(object sender, EventArgs e) //действия при нажатии на кнопку кодировать БВТ
        {
            bwtResult_textBox.Text = BWT(bwtInput_textBox.Text.ToLower()); //получаем результат
            mtfInput_textBox.Text = bwtResult_textBox.Text; //записать результат в форму ввода для МТФ
        }

        private string BWT(string input) //функция кодирования в БВТ
        {
            //там в википедии классно описан этот алгорим мне тут лень объяснять принцип кодирования :-)

            int inputLen = input.Length; //получаем количество символов
            List<string> rotations = new List<string>(); //список с ротациями
            rotations.Add(input); //добавляем первую ротацию
            for (int i = 0; i < inputLen - 1; i++)
            {
                int cutIndex = inputLen - i - 1; //индекс по которому режем строку
                rotations.Add(input.Substring(cutIndex) + input.Substring(0, cutIndex)); //ставим конец строки в начало и добавляем в список ротаций
            }
            rotations.Sort(); //сортируем по алфавиту

            string result = "";
            for (int i = 0; i < inputLen; i++)
            {
                result += rotations[i][inputLen - 1]; //последние буквы каждой ротации это результат
            }
            return result;
        }

        private void mtfCode_button_Click(object sender, EventArgs e) //кодировать в МТФ
        {
            mtfResult_textBox.Text = MTF(mtfInput_textBox.Text);
        }

        private string MTF(string input) // МТФ
        {
            int inputLen = input.Length; //количество символов
            List<char> alphabet = new List<char>(); //уникальные буквы строки
            for (int i = 0; i < inputLen; i++)
            {
                if (!alphabet.Contains(input[i])) //если такой буквы нет
                {
                    alphabet.Add(input[i]); //добавляем в алфавит
                }
            } 
            alphabet.Sort(); //сортируем по возрастанию

            string result = ""; 
            for (int i = 0; i < inputLen; i++)
            {
                int index = alphabet.IndexOf(input[i]); //получаем позицию текущей буквы в алфавите
                result += index.ToString(); //добавляем этот индекс в результат
                alphabet.RemoveAt(index); //удаляем текущую букву из алфавита
                alphabet.Insert(0, input[i]); //и добавляем ее в начало алфавита
            }
            return result;
        }
    }
}
