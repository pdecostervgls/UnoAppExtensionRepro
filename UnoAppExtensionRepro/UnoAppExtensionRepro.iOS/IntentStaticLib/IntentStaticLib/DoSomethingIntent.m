//
// DoSomethingIntent.m
//
// This file was automatically generated and should not be edited.
//

#import "DoSomethingIntent.h"

#if __has_include(<Intents/Intents.h>) && !TARGET_OS_TV

@implementation DoSomethingIntent

@end

@interface DoSomethingIntentResponse ()

@property (readwrite, NS_NONATOMIC_IOSONLY) DoSomethingIntentResponseCode code;

@end

@implementation DoSomethingIntentResponse

@synthesize code = _code;

- (instancetype)initWithCode:(DoSomethingIntentResponseCode)code userActivity:(nullable NSUserActivity *)userActivity {
    self = [super init];
    if (self) {
        _code = code;
        self.userActivity = userActivity;
    }
    return self;
}

@end

#endif
