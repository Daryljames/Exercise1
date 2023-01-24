namespace Exercise1.Models
{
    public class MobilePhone
    {
        public string brand { get; set; }
        public string color { get; set; }
        public SimCard simCard { get; set; }
        public string model { get; set; }

        public MobilePhone(string brand, string color, SimCard simCard, string model)
        {
            this.brand = brand;
            this.color = color;
            this.simCard = simCard;
            this.model = model;
        }

        public SimCard GetSimCard()
        {
            return simCard;
        }

        public string GetPhoneNumber()
        {
            string phoneNumber = GetSimCard().GetPhoneNumber();

            return phoneNumber;
        }

        public void SwapSimCard(SimCard simCard)
        {
            this.simCard = simCard;
        }

        public void Call(string phoneNumber)
        {
            string ownPhoneNumber = GetPhoneNumber();
            Console.WriteLine("Calling " + phoneNumber + " from number " + ownPhoneNumber);
        }

        public string Call(MobilePhone mobilePhone)
        {
            string message = "Calling " + mobilePhone.GetPhoneNumber() + " from number " + GetPhoneNumber();

            return message;
        }
    }
}