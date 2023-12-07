List<string> stringNumbers = Console.ReadLine().Split().ToList();

int sum = 0;
foreach (string number in stringNumbers)
{
    try
    {
        int num = int.Parse(number);
        sum += num;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{number}' is in wrong format!");
    }
    catch(OverflowException)
    {
        Console.WriteLine($"The element '{number}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{number}' processed - current sum: {sum}");
    }
    
}
Console.WriteLine($"The total sum of all integers is: {sum}");
