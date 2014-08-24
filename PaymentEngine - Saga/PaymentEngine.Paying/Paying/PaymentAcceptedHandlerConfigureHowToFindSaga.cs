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
        public override void ConfigureHowToFindSaga()
        {
            
            // ConfigureMapping<PaymentNotificationResponse>(m => /* specify message property */).ToSaga(s =>  /* specify saga property */ );

            
            // If you add new messages to be handled by your saga, you will need to manually add a call to ConfigureMapping for them.
        }
    }
}
