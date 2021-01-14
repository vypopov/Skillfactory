namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            //

        }
    }
    abstract class Delivery
    {
        public string Addres;
    }
    class PickPointDelivery : Delivery
    {
        private string PickPointAddres;
        private int CageCode;
    }
    public class Order
    {
        public string DeliveryAdress;

    }

}
