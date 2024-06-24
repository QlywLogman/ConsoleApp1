using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstrac
{
    internal abstract class BaseDecorator : Notifier
    {
        protected Notifier? notifier;

        protected BaseDecorator(Notifier? notifier = null)
        {
            this.notifier = notifier;
        }
    }
}
