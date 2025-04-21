using System;
class Program{

    static void Main(){
        Console.WriteLine("아마도 우리가 제일 잘나가");
        Money mainBank = new Money("신한은행", 80000000);
        Console.WriteLine(String.Format("{0:N0}",mainBank.Amount));

    }
    public struct Money {
        public string Bank { get; private set;}
        public decimal Amount { get; private set;}

        public Money(string bank, decimal amount)
        {
            this.Bank = bank;
            this.Amount = amount;
        }

    }
}