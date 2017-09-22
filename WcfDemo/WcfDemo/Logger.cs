using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfDemo
{
    public enum loginfo
    {
    debug,
     error,
     information
    }

    public class Logger
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void log(loginfo l,string msg)
        {
            switch(l)
            {
                case loginfo.debug:
                    _log.Debug(msg);
                    break;

                case loginfo.error:
                    _log.Error(msg);
                    break;

                case loginfo.information:
                    _log.Info(msg);
                    break;       

            }
        } 
    }
}