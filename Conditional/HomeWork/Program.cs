Console.WriteLine("Enter Your Name: ");
string name = Console.ReadLine();
if (name != "")
{
    //if (name.ToLower() == "tim")
    //{
    //    Console.WriteLine("Hello Professor Tim");
    //}
    //else
    //{
    //    Console.WriteLine("Hello Student " + name);
    //}
    switch (name.ToLower())
    {
        case "tim":
            Console.WriteLine("Hello Professor Tim");
            break;
        default:
            string capitalizedName = char.ToUpper(name[0]) + name.Substring(1);
            Console.WriteLine("Hello Student " + capitalizedName);
            break;
    }
}
else
{
    Console.WriteLine("You Should Enter Your Name");
}
