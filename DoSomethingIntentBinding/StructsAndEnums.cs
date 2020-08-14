using System;
using ObjCRuntime;

namespace UnoAppExtensionRepro.iOS.Intent
{
	[Native]
	public enum DoSomethingIntentResponseCode : long
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
