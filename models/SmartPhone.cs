namespace Exercise1.Models
{
    public class SmartPhone : MobilePhone
    {
        public string browser { get; set; }
        public List<App> applications { get; set; }

        public SmartPhone(string brand, string color, SimCard simCard, string model, string browser)
            : base(brand, color, simCard, model)
        {
            this.browser = browser;
            this.applications = new List<App>();
        }

        public void CallFromBrowser(string phoneNumber)
        {
            // string browser = this.browser;

            Console.WriteLine("Calling from " + browser);
            base.Call(phoneNumber);
        }

        public void CallFromBrowser(MobilePhone mobilePhone)
        {
            // string browser = this.browser;

            Console.WriteLine("Calling from " + browser);
            base.Call(mobilePhone);
        }

        public void AddApplication(App app)
        {
            applications.Add(app);
        }

        public float GetTotalSize()
        {
            int numOfApps = applications.Count();
            float total = 0;

            for (int i = 0; i < numOfApps; i++)
            {
                total += applications[i].size;
            }

            return total;
        }
    }
}