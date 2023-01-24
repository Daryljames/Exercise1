using Exercise1.Models;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimCard sim = new SimCard("09171231234", "Globe");
            SimCard anotherSim = new SimCard("09231231234", "Smart");

            MobilePhone mobilePhoneA = new MobilePhone("Samsung", "black", sim, "Universe Ultra 99");
            MobilePhone mobilePhoneB = new MobilePhone("Apple", "black", anotherSim, "Iphone 00");

            SmartPhone smartPhoneA = new SmartPhone("Samsung", "black", sim, "Universe Ultra 99", "Gogoogles");

            SmartPhone smartPhoneB = new SmartPhone("Apple", "black", anotherSim, "Iphone 00", "Matapang");

            App newApp = new App("Money App", 23.50f);

            mobilePhoneA.Call(mobilePhoneB.GetPhoneNumber());



            smartPhoneA.CallFromBrowser(smartPhoneB.GetPhoneNumber());

            smartPhoneA.AddApplication(newApp);

            Console.WriteLine(smartPhoneA.GetTotalSize());
        }
    }
}