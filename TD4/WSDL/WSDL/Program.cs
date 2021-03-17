using ServiceReference1;
using System;

namespace WSDL
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorSoapClient calc = new CalculatorSoapClient(new CalculatorSoapClient.EndpointConfiguration(), "http://www.dneonline.com/calculator.asmx?wsdl");
            Console.WriteLine(calc.Add(12, 4));
        }
    }
}
