using System;
using NServiceBus;
using PaymentEngine.Internal.Commands.Paying;


namespace PaymentEngine.Paying
{
    public partial class PaymentNotificationHandler
    {
		
        partial void HandleImplementation(PaymentNotification message)
        {
            // TODO: PaymentNotificationHandler: Add code to handle the PaymentNotification message.
            Console.WriteLine("Paying received " + message.GetType().Name);

            var response = new PaymentEngine.Internal.Messages.Paying.PaymentNotificationResponse();
            Bus.Reply(response);
        }

    }
}
