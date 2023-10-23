namespace MyFleetManager.Models
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public int VehicleID { get; set; }
        public double Spent {get; set; }
        public double Poured {get; set; }
        public int OdometerReading {get; set; }
        public string Merchant {get; set; }



    }
}
