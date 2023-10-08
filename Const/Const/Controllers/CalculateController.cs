using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Const.Controllers;
using Const.Service;
using Const.Helper.Const;
namespace Const.Controllers
{
    internal class CalculateController
    {
        private readonly CalculateService _service;
        public CalculateController()
        {
            _service = new CalculateService();
        }
        public void Calculate()
        {
            Console.WriteLine("Add first number");
        num1: string num1 = Console.ReadLine();
            double number1;
            bool IsTrueNum1 = double.TryParse(num1, out number1);

            if (!IsTrueNum1)
            {
                Console.WriteLine(CalculateNotification.CorrectInputNumber);
                goto num1;
            }

            Console.WriteLine("Add operation");
            string operation = Console.ReadLine();

            Console.WriteLine("Add second number");
        num2: string num2 = Console.ReadLine();
            double number2;
            bool IsTrueNum2 = double.TryParse(num2, out number2);

            if (!IsTrueNum2)
            {
                Console.WriteLine(CalculateNotification.CorrectInputNumber);
                goto num2;
            }

            if (operation == "/" && number2 == 0)
            {
                Console.WriteLine("Can't be divide by zero,Please start again");
                goto num1;
            }
            string result = _service.Calculate(number2, number1, operation);
            Console.WriteLine(result);
        }
    }
}
