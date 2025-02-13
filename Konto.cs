using konto;
var customers = new List<Customer>();
customers.Add(new Customer("1", "Andrzej", 5000));
customers.Add(new Customer("2", "Bartek",1000));
customers.Add(new Customer("3", "Kuba", 2500));

Console.WriteLine("Podaj ID klienta");
var id = Console.ReadLine();
var selectedCustomer = customers.FirstOrDefault(c => c.Id == id);

if (selectedCustomer != null)
{
    Console.WriteLine("Podaj kwotę przelewu");
    var amountText = Console.ReadLine();
    var amount = decimal.Parse(amountText);
    if (amount <= selectedCustomer.Saldo)
    {
        Console.WriteLine("Podaj odbiorcę przelewu");
        var pid = Console.ReadLine();
        var paymentCustomer = customers.FirstOrDefault(c => c.Id == pid);
        if (paymentCustomer != null)
        {
            selectedCustomer.Saldo = selectedCustomer.Saldo - amount;
            paymentCustomer.Saldo = paymentCustomer.Saldo + amount;
        }
    }
}
 Console.ReadLine();

