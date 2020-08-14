using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjCRuntime;
using UnoAppExtensionRepro.iOS.Intent;
using Newtonsoft.Json.Linq;

namespace AppKit
{
    public class DoSomethingIntentHandler : DoSomethingIntentHandling
    {
        public override void ConfirmDoSomething(DoSomethingIntent intent, Action<DoSomethingIntentResponse> completion)
        {
            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));

            JObject o = new JObject();
            o["MyArray"] = array;

            string json = o.ToString();

            completion(new DoSomethingIntentResponse(DoSomethingIntentResponseCode.Ready, null));
        }

        public override void HandleDoSomething(DoSomethingIntent intent, Action<DoSomethingIntentResponse> completion)
        {
            completion(new DoSomethingIntentResponse(DoSomethingIntentResponseCode.Success, null));
        }
    }
}
