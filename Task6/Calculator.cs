using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task6;

internal class Calculator<T> where T : INumber<T>
{
    public Calculator(T number1, T number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public T Number1 { get; set; }
    public T Number2 { get; set; }
   
    public T Addition ()
    {
        return Number1 + Number2;
    }

    public T Substraction ()
    {
        return Number1 - Number2;
    }
    public T Multiplication()
    {
        return Number1 * Number2;
    }
    public T Division()
    {
        dynamic number2= Number2;
        if (number2 == 0)
        {
            throw new DivideByZeroException("0-a bolme yoxdu");
        }
        return Number1 / Number2;
    }
    }




