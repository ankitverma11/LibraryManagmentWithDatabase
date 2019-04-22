using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagmentWithDB.Healper
{
    //The app settings class contains properties defined in the appsettings.json file and is used for accessing application settings via an object that is injected into classes using the
    //ASP.NET Core built in dependency injection. For example the User Service accesses app settings via an IOptions<AppSettings> appSettings object that is injected into the constructor.
    public class AppSetting
    {
        public string Secret { get; set; }
    }
}
