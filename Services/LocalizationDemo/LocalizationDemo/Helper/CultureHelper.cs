using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;
using System.Globalization;

namespace LocalizationDemo.Helper
{
    public class CultureHelper
    {
        protected HttpSessionState session;

        public CultureHelper(HttpSessionState httpsession)
        {
            session = httpsession;
        }

        public static int CurrentCulture
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "en-GB")
                {
                    return 0;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "hi-IN")
                {
                    return 1;
                }

                else
                    return 0;
            }
            set
            {
                if (value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB");
                }

                else if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("hi-IN");

                }

                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            }   

        }
    }
}