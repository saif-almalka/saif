using System;
class calculator
{
    
    static void Main()
{
    // عمل الطالب : سيف المالكي
    Console.WriteLine("Enter the first number : ");
    double firstnum=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Enter Tte second number : ");
    double secondnum=Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine("Enter an operation ( + , - , / , * )");
    string oprtstion=Console.ReadLine();
    double result=0;

    if (oprtstion=="+")
    {
        result=firstnum+secondnum;
    }
    else if (oprtstion=="-")
    {
        result=firstnum-secondnum;
    }
    else if (oprtstion=="*")
    {
        result=firstnum*secondnum;
    }
    else if (oprtstion=="/")
    {
       result=firstnum/secondnum;
    }
    Console.WriteLine("result = "+result);
}

}