using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;


namespace ParallelSelenium.Utils
{
    class CustomRemoteWebDriver : RemoteWebDriver
    {
        public CustomRemoteWebDriver(Uri uri, DesiredCapabilities capabilities) : base(uri, capabilities){}

        public SessionId getSessionId()
        {
            return this.SessionId;
        }
    }
}
