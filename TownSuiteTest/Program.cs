// See https://aka.ms/new-console-template for more information

//Prints the numbers from 1 to 100. But for multiples of three print "Support" instead of the number and for the multiples of five print "Training".
//For numbers that are multiples of both three and five print only "SupportTraining".
for (int i=1; i <= 100; i++)
{
    if (((i % 3) == 0) && ((i % 5) == 0))
    {
        Console.WriteLine("SupportTraining");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Training");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Support");
    }
    else
    {
        Console.WriteLine(i);
    }
}
