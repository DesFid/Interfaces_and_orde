using System;

namespace InterfaceOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword ("Infinity Sword");
            sword.newDamage(20);
            Order order = new Order ();
            var powers_list = order.Compare(sword.powers);
            Console.WriteLine("Powers Sword in order");
            foreach (string va in powers_list){
            Console.WriteLine("Power: " + va);
        }
        }
    }
}
