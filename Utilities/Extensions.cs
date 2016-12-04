﻿using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Utilities
{
    public static class Extensions
    {
        public static void InfoFormat(this Control ctl, string format, params object[] args)
        {
            ILog log = LogManager.GetLogger(ctl.GetType().FullName);

            log.InfoFormat(format, args);
        }

        public static void ErrorFormat(this Control ctl, string format, params object[] args)
        {
            ILog log = LogManager.GetLogger(ctl.GetType().FullName);

            log.ErrorFormat(format, args);
        }

        public static void Info(this Control ctl, object ex)
        {
            ILog log = LogManager.GetLogger(ctl.GetType().FullName);

            log.Info(ex);
        }

        public static void Error(this Control ctl, object ex)
        {
            ILog log = LogManager.GetLogger(ctl.GetType().FullName);

            log.Error(ex);
        }
    }
}
