using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    struct TRAIN
    {
        public string Punkt_nazn;
        public int Number_poezda;
        public DateTime time;
        public TRAIN(string Punkt_nazn, int Number_poezda, DateTime time)
        {
            this.Punkt_nazn = Punkt_nazn;
            this.Number_poezda = Number_poezda;
            this.time = time;

        }
        public void Write_poezd()
        {
            Console.WriteLine("Название пункта назначения: {0}, Номер поезда: {1}, Время отправления: ", Punkt_nazn, Number_poezda, time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TRAIN[] main_poezd = new TRAIN[6];

            for (int i = 0; i < main_poezd.Count(); i++)
            {
                Console.WriteLine("Введите название пункта назначения:  ");
                main_poezd[i].Punkt_nazn = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Введите номер поезда: ");
                main_poezd[i].Number_poezda = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите время отправления: ");
                main_poezd[i].time = Convert.ToDateTime(Console.ReadLine());

            }
            string str;
            bool b = true;
            int count = 0;
            while (b)
            {
                Console.WriteLine("Введите время, после которого должен прибыть поезд");
                str = Console.ReadLine();

                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]) && (Convert.ToInt32(str[i]) <= 6 || Convert.ToInt32(str[i]) >= 0)) count++;
                }

                if (count == str.Length)
                {
                    foreach (TRAIN c in main_poezd)
                    {
                        if (str == c.time.ToString()) Console.WriteLine(c.ToString());
                    }
                    b = false;
                }
                else Console.WriteLine("Повторите попытку");
            }

            Console.ReadLine();
        }
    }
}