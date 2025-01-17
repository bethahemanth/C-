using System;
using Bill;
namespace Bill
{
    public class Billing
    {
        private int id;
        private int amount;
        private string description;
        private DateTime date;
        private string name;
        private string category;
        private int GST;
        private int OtherTaxes;

        public Billing(int id, int amount, string description, DateTime date, string name, string category, int GST, int OtherTaxes)
        {
            this.id = id;
            this.amount = amount;
            this.description = description;
            this.date = date;
            this.name = name;
            this.category = category;
            this.GST = GST;
            this.OtherTaxes = OtherTaxes;
        }

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public int _amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string _description
        {
            get { return description; }
            set { description = value; }
        }

        public int _GST
        {
            get { return GST; }
            set { GST = value; }
        }

        public int _OtherTaxes
        {
            get { return OtherTaxes; }
            set { OtherTaxes = value; }
        }
        public void PrintBilling(Billing bill)
        {
            Console.WriteLine($"Total Bill: {bill._amount + bill._GST + bill._OtherTaxes}");
        }
    }
}
public class main_class
{
    public static void Main(string[] args)
    {
        Billing b = new Billing(1, 1000, "About the milk products", new DateTime(2025, 01, 01), "Curd", "Food", 100, 50);
        b.PrintBilling(b);
    }
}