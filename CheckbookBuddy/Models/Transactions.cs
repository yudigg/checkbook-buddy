namespace CheckbookBuddy.Models
{
    public class Transactions
    {
        public int ID { get;set;} 

        public string Description { get; set; }

        public string Check { get; set; }

        public string Date { get; set; }

        public string Deposit { get; set; }
    }
}