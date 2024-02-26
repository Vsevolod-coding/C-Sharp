double CalculateFormula(int a, int b, int c, int d)
{
    double numerator = a * b;
    int denominator = c + d;
    double result = numerator / denominator;
    return result;
}

double result = CalculateFormula(8, 10, 5, 6);
Console.WriteLine(result);