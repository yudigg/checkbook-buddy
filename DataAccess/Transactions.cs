namespace DataAccess
{
    public class Transaction
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public string Check { get; set; }

        public string Date { get; set; }

        public string Deposit { get; set; }

        public int OrderID { get; set; }

        public virtual Order Order { get; set; }
    }
}