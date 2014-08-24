using System;
using System.IO;
using ServiceControl.Plugin.CustomChecks;
using ServiceControl.Plugin.CustomChecks.Messages;
using ServiceControl.Plugin.CustomChecks.Internal;
namespace MyPublisher
{
    public class MyCustomCheck : CustomCheck
    {
        public MyCustomCheck()
            : base("MyPublisher availability check", "MyPublisher Server")
        {
            ReportFailed("Testing");
        }
    }
}
