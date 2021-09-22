using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace background.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            //Diga ao sistema operacional para executar nosso PerformFetch ocasionalmente e deixe-o decidir a frequência
            UIApplication.SharedApplication.SetMinimumBackgroundFetchInterval(10);

            return base.FinishedLaunching(app, options);
        }

     
        public override async void PerformFetch(UIApplication application, Action<UIBackgroundFetchResult> completionHandler)
        {
            Console.WriteLine("Chamei PerformFetch...");

            var generator = new Random();

            var num = generator.Next(1, 100);

            Console.WriteLine("Executando em background fetch " + num.ToString());

            completionHandler(UIBackgroundFetchResult.NewData);
        }

    }
}
