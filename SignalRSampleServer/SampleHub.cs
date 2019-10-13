using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRSampleServer
{
    [HubName("Sample")]
    public class SampleHub : Hub
    {
        public void CallSample()
        {
            System.Diagnostics.Debug.WriteLine("=====SampleHubの呼び出す=====");

        }

        public void CallSampleTwo(string sample)
        {
            System.Diagnostics.Debug.WriteLine("=====SampleHubの呼び出す=====");
            System.Diagnostics.Debug.WriteLine(sample);
        }

        public void CallSampleThree()
        {
            System.Diagnostics.Debug.WriteLine("=====あああああああああああ123=====");
            Clients.All.HelloWorld("あいうえお", "かきくけこ");
        }
    }
}
