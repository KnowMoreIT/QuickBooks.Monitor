﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace QuickBooks_Monitor
{
    public partial class IniWatcher : ServiceBase
    {
        public IniWatcher()
        {
            InitializeComponent();
            ServiceName = "Quickbooks Monitor";
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
