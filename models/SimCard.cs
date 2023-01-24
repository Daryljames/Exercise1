namespace Exercise1.Models
{
    public class SimCard
    {
        public string phoneNumber { get; private set; }
        public string network { get; private set; }

        public SimCard(string phoneNumber, string network)
        {
            this.phoneNumber = phoneNumber;
            this.network = network;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void SetNetwork(string network)
        {
            this.network = network;
        }

        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }
        public string GetNetwork()
        {
            return this.network;
        }
    }
}