
using ConsoleApp1.Abstrac;
namespace ConsoleApp1.Contanies
{
    Notifier notifier = new SmsDecorator();
    notifier = new FacebookDecorator(notifier);
    notifier = new SlackDecorator(notifier);

    notifier.Send("Hello My Name Is Logman");
}
