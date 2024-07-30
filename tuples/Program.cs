

static (int Sum, int Product) Calculate(int x, int y)
{
    return (x + y, x * y);
}

int x = 2;
int y = 3;
(int sum, int product) = Calculate(x, y);

Console.WriteLine($"x is : {x}, y is : {y}, sum is {sum}, product is {product}");