using System;
using NServiceBus;
using PaymentEngine.Internal.Commands.Paying;
using PaymentEngine.Contracts.Payments;
using PaymentEngine.Internal.Messages.Paying;
using NServiceBus.Saga;


namespace PaymentEngine.Paying
{
    public partial class PaymentAcceptedHandler
    {
		
        partial void HandleImplementation(PaymentAccepted message)
        {
            // TODO: PaymentAcceptedHandler: Add code to handle the PaymentAccepted message.
            Console.WriteLine("Paying received " + message.GetType().Name);

            var paymentNotification = new PaymentEngine.Internal.Commands.Paying.PaymentNotification();
            Bus.Send(paymentNotification);
        }

    }
}
