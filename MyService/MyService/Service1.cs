using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MyServiceSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("MyServiceSource", "MyServiceLog");
            }

            eventLog1.Source = "MyServiceSource";
            eventLog1.Log = "MyServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My service started");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 6000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        private void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("Monitoring the system",EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My service stopped");
        }
    }
}
