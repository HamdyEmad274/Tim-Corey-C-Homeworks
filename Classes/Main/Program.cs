namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = RequestData.GetName();
            UserMessages.Welcome(name);
            double x = RequestData.GetNumber("Enter First Number:");
            double y = RequestData.GetNumber("Enter Second Number:");
            char op = RequestData.GetOperator();
            double result = CalcData.opertor( x,y,op);
            UserMessages.ShowResult(result);
            UserMessages.GoodBye();
        }
    }
}
