using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vizhiner
{
    
    public partial class Morse : Form
    {
        //создание массивов с алфавитами
        char[] alphabet = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и','й', 'к', 'л', 'м', 'н', 
            'о', 'п', 'р', 'с','т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ','ы', 'ь','э', 'ю', 'я' };

        string[] MorseAlphabet = new string[] { ".–", "–...", ".––", "––.", "–..", ".", "...–", "––..","..", ".–––", 
            "–.–", ".–..","––", "–.", "–––", ".––.",".–.", "...", "–", "..–", "..–.", "....", "–.–.","–––.", "––––", 
            "−−.−", ".--.-.","−.−−", "−..−", "..−..","..−−", ".−.−"};
        public Morse()
        {
            InitializeComponent();
        }

        //шифратор
        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.ToLower();
            string result = "";
            int index;
            //замена русского на морзе
            foreach (char element in text)
            {
                if (element != ' ')
                {
                    index = Array.IndexOf(alphabet, element);
                    result += MorseAlphabet[index] + " ";
                }
            }
            //убираем лишний пробел в конце 
            result = result.Remove(result.Length - 1);
            textBox3.Text = result;
        }

        //дешифратор
        private void button2_Click(object sender, EventArgs e)
        {
            string input = textBox4.Text;
            string[] split = input.Split(' ');
            string result = "";
            int index;
            //замена морзе на русский
            foreach (string elementString in split)
            {
                index = Array.IndexOf(MorseAlphabet, elementString);
                result += alphabet[index] + " ";
            }
            //убираем лишний пробел
            result = result.Remove(result.Length - 1);
            textBox2.Text = result;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
