using System.Reflection;

namespace CAReflectionBankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount bankAccount = new BankAccount("A123", "Rami S.", 1000m);
            //bankAccount.OnNegativeBalance += BankAccount_OnNegativeBalance;

            //bankAccount.Withdraw(500m);
            //Console.WriteLine(bankAccount);
            //Console.WriteLine("----------------");

            //bankAccount.Withdraw(700m);
            //Console.WriteLine(bankAccount);




            //------------------------- [MemberInfo] ----------------------------
            Console.WriteLine("MemberInfo");
            Console.WriteLine("==============");
            //TO discover members of class BankAccount without private members
            MemberInfo[] members = typeof(BankAccount).GetMembers();
            foreach (MemberInfo member in members)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n----------------------");
            //TO discover members of class BankAccount  private members
            MemberInfo[] members1 = typeof(BankAccount).GetMembers(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MemberInfo member in members1)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n----------------------");
            //TO discover members of class BankAccount with public members
            MemberInfo[] members2 = typeof(BankAccount).GetMembers(BindingFlags.Public | BindingFlags.Instance);
            foreach (MemberInfo member in members2)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n---------------------------------------------");

            //------------------------- [FieldInfo] ----------------------------
            Console.WriteLine("FieldInfo");
            Console.WriteLine("==============");

            //TO discover members of class BankAccount without private members
            FieldInfo[] membersf = typeof(BankAccount).GetFields();
            foreach (MemberInfo member in membersf)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n----------------------");
            //TO discover members of class BankAccount  private members
            FieldInfo[] membersf1 = typeof(BankAccount).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MemberInfo member in membersf1)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n----------------------");
            //TO discover members of class BankAccount with public members
            FieldInfo[] membersf2 = typeof(BankAccount).GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (MemberInfo member in membersf2)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("\n---------------------------------------------");

            //------------------------- [PropertyInfo] ----------------------------
            Console.WriteLine("PropertyInfo");
            Console.WriteLine("==============");

            //TO discover members of class BankAccount without private members
            PropertyInfo[] membersp = typeof(BankAccount).GetProperties();
            foreach (MemberInfo member in membersp)
            {
                Console.WriteLine(member);
            }
            
            Console.WriteLine("\n---------------------------------------------");
            Console.ReadKey();
        }

        private static void BankAccount_OnNegativeBalance(object? sender, EventArgs e)
        {
            var bankAccount = (BankAccount)sender;
            Console.WriteLine("NEGATIVE BALANCE!!!!!!");
        }
    }
}