using System;
using Foundation;
using Intents;

namespace UnoAppExtensionRepro.iOS.Intent
{
	// @interface DoSomethingIntent : INIntent
	[BaseType (typeof(INIntent))]
	interface DoSomethingIntent
	{
	}

	// @protocol DoSomethingIntentHandling <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DoSomethingIntentHandling
	{
		// @required -(void)handleDoSomething:(DoSomethingIntent * _Nonnull)intent completion:(void (^ _Nonnull)(DoSomethingIntentResponse * _Nonnull))completion;
		[Abstract]
		[Export ("handleDoSomething:completion:")]
		void HandleDoSomething (DoSomethingIntent intent, Action<DoSomethingIntentResponse> completion);

		// @optional -(void)confirmDoSomething:(DoSomethingIntent * _Nonnull)intent completion:(void (^ _Nonnull)(DoSomethingIntentResponse * _Nonnull))completion;
		[Export ("confirmDoSomething:completion:")]
		void ConfirmDoSomething (DoSomethingIntent intent, Action<DoSomethingIntentResponse> completion);
	}

	// @interface DoSomethingIntentResponse : INIntentResponse
	[BaseType (typeof(INIntentResponse))]
	[DisableDefaultCtor]
	interface DoSomethingIntentResponse
	{
		// -(instancetype _Nonnull)initWithCode:(DoSomethingIntentResponseCode)code userActivity:(NSUserActivity * _Nullable)userActivity __attribute__((objc_designated_initializer));
		[Export ("initWithCode:userActivity:")]
		[DesignatedInitializer]
		IntPtr Constructor (DoSomethingIntentResponseCode code, [NullAllowed] NSUserActivity userActivity);

		// @property (readonly, nonatomic) DoSomethingIntentResponseCode code;
		[Export ("code")]
		DoSomethingIntentResponseCode Code { get; }
	}
}
