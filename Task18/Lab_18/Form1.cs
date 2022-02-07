using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_18
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Вычисление площади равностороннего треугольника
            
            double a, s;
            a = double.Parse(TextLenght.Text); // Преобразуем строку символов
                                               // из окна ввода в значение a
            s = (Math.Pow(a,2) * Math.Sqrt(3))/4 ;// Вычисляем площадь
            s = Math.Round (s,2 ); //Округляем до 2х знаков после запятой
            textBoxS.Text = s.ToString(); // Преобразуем площадь в строку
                                          // и отображаем ее в окне вывода 

            //Вычисляем радиус вписанной окружности
            double r;
            r = a /(2 * Math.Sqrt(3));// Вычисляем радиус вписанной окружности
            r = Math.Round(r, 2); //Округляем до 2х знаков после запятой
            textBoxVpis.Text = r.ToString(); // Преобразуем радиус в строку
                                             // и отображаем ее в окне вывода 

            //Вычисляем радиус опписанной окружности
            double r2;
            r2 = a /  Math.Sqrt(3);// Вычисляем радиус вписанной окружности
            r2 = Math.Round(r2, 2); //Округляем до 2х знаков после запятой
            textBoxOpis.Text = r2.ToString(); // Преобразуем радиус в строку
                                             // и отображаем ее в окне вывода 
        }

        private void LabelLenght_Click(object sender, EventArgs e)
        {

        }

        private void LabelRadVpis_Click(object sender, EventArgs e)
        {

        }

        private void LabelS_Click(object sender, EventArgs e)
        {

        }

        private void LabelRadOpis_Click(object sender, EventArgs e)
        {

        }

        private void TextLenght_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVpis_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOpis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
