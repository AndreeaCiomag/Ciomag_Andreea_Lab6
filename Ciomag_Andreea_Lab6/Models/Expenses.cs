using System;
namespace Ciomag_Andreea_Lab6.Models
{
    public class Expenses
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
    }
}

