using LAB05_1;

try
{
    QuadraticEquation eq1 = new 
        QuadraticEquation(1, -5, 6);
    eq1.Print();
    eq1.GetRoots();
    Console.WriteLine();

    QuadraticEquation eq2 = new 
        QuadraticEquation(1, -4, 4);
    eq2.Print();
    eq2.GetRoots();
    Console.WriteLine();

    QuadraticEquation eq3 = new
        QuadraticEquation(1, 2, 5);
    eq3.Print();
    eq3.GetRoots();
    Console.WriteLine();

    QuadraticEquation eq4 = new 
        QuadraticEquation(0, 5, 6);
    eq4.Print();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}