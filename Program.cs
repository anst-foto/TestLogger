using System;
using Logger;
using TestLogger;

var calc = new Calc(new FileLogger("calc.log"));
try
{
    calc.Add(1, 2);
    calc.Sub(1, 2);
    calc.Mul(1, 2);
    calc.Div(1, 2);
    calc.Div(1, 0);
}
catch (Exception e)
{
    // ignore
}
