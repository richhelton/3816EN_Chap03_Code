using System;
using NServiceBus;
using PaymentEngine.Internal.Commands.Payments;


namespace PaymentEngine.Payments
{
    public partial class SubmitPaymentHandler
    {
		
        partial void HandleImplementation(SubmitPayment message)
        {
            // TODO: SubmitPaymentHandler: Add code to handle the SubmitPayment message.
            Console.WriteLine("Payments received " + message.GetType().Name);

            var paymentAccepted = new PaymentEngine.Contracts.Payments.PaymentAccepted();
            Bus.Publish(paymentAccepted);
        }

    }
}
