using System;
using ObjCRuntime;

namespace UnoAppExtensionRepro.iOS.Intent
{
	[Watch (5,0), NoTV, Mac (10,16), iOS (12,0)]
	[Native]
	public enum DoSomethingIntentResponseCode : nint
	{
		Unspecified = 0,
		Ready,
		ContinueInApp,
		InProgress,
		Success,
		Failure,
		FailureRequiringAppLaunch
	}
}
