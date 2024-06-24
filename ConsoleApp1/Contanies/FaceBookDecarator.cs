using ConsoleApp1.Abstrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Contanies
{
    internal class FacebookDecorator(Notifier? notifier = null) : BaseDecorator(notifier)
    {
        public override void Send(string message)
        {
            notifier?.Send(message);
            Console.WriteLine($"Facebook: {message}");
        }
    }
}
