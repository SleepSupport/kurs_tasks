using System;

namespace kurs_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double creditSumm, procent, monthPayment, paymentCreditForMonth, yearSumPayment = 0;
            byte choose;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Введите сумму кредита:");
            creditSumm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите проценты кредита:");
            procent = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.WriteLine("Выберите тип платежа:\n 1-дифференцированные\n 2-аннуитетные");
            choose = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Выплаты по месяцам:");
            monthPayment = creditSumm / 12;
            if (choose == 1)
            {
                for (int i = 1; i <= 12; i++)
                {

                    paymentCreditForMonth = monthPayment + (creditSumm - (monthPayment * i)) * procent / 12;
                    yearSumPayment += paymentCreditForMonth;
                    Console.WriteLine($"Выплата за {i} месяц равна: " + paymentCreditForMonth);
                }

            }
            if (choose == 2)
            {
                for (int i = 1; i <= 12; i++)
                {
                    paymentCreditForMonth = creditSumm * (procent / 12 + (procent / 12) / (Math.Pow((1 + procent / 12), 12) - 1));
                    yearSumPayment += paymentCreditForMonth;
                    Console.WriteLine($"Выплата за {i} месяц равна: " + paymentCreditForMonth);
                }
            }
            Console.WriteLine($"Общая сумма выплат составит: {yearSumPayment}");
            Console.WriteLine("-------------------------------------");

        }
    }
}
