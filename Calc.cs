using System;
using Logger;

namespace TestLogger;

public class Calc
{
    private readonly ILogger _logger;

    public Calc(ILogger logger)
    {
        _logger = logger;
    }

    public double Add(double a, double b)
    {
        var result = a + b;
        _logger.LogInfo($"{a} + {b} = {result}");
        return result;
    }

    public double Sub(double a, double b)
    {
        var result = a - b;
        _logger.LogInfo($"{a} - {b} = {result}");
        return result;
    }
    
    public double Mul(double a, double b)
    {
        var result = a * b;
        _logger.LogInfo($"{a} * {b} = {result}");
        return result;
    }
    
    public double Div(double a, double b)
    {
        if (b == 0)
        {
            _logger.LogError("Деление на ноль!");
            throw new DivideByZeroException();
        }
        
        var result = a / b;
        _logger.LogInfo($"{a} / {b} = {result}");
        return result;
    }
}