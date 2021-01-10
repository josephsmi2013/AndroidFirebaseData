using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase;
using Firebase.Database;

namespace AndroidFirebaseData.Helpers
{
    public static class AppDataHelper
    {
        public static FirebaseDatabase GetDatabase()
        {

            var app = FirebaseApp.InitializeApp(Application.Context);
            FirebaseDatabase database;

            if (app == null)
            {
                var option = new FirebaseOptions.Builder()
                    .SetApplicationId("androidfirebasedata-9c8cc")
                    .SetApiKey("AIzaSyAwOuTFxnhIgSpLs7As8lezNxw_5bbeWtA")
                    .SetDatabaseUrl("https://androidfirebasedata-9c8cc.firebaseio.com")
                    .SetStorageBucket("androidfirebasedata-9c8cc.appspot.com")
                    .Build();

                app = FirebaseApp.InitializeApp(Application.Context, option);
                database = FirebaseDatabase.GetInstance(app);
            }
            else
            {
                database = FirebaseDatabase.GetInstance(app);
            }

            return database;
        }
    }
}