using Microsoft.Owin.Hosting;
using System;
using System.Configuration;
using Topshelf;

namespace WFKS.Check.Search
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType);

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                var rc = HostFactory.Run(x =>
                {
                    x.Service<Program>(s =>
                    {
                        s.ConstructUsing(name => new Program());
                        s.WhenStarted(p => p.Start());
                        s.WhenStopped(p => p.Stop());
                    });
                    x.RunAsLocalSystem();

                    x.SetServiceName("UserManagerDemo");
                    x.SetDisplayName("UserManagerDemo服务");
                });

                var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
                Environment.ExitCode = exitCode;
            }
            catch (Exception ex)
            {
                log.Error("服务启动出错", ex);
            }

        }

        /// <summary>
        /// 服务启动
        /// </summary>
        void Start()
        {
            log.Info("服务正在启动");

            string baseAddress = ConfigurationManager.AppSettings["baseAddress"];
            WebApp.Start<Startup>(url: baseAddress);

            log.Info("服务已经启动,访问地址:" + baseAddress);
        }

        /// <summary>
        /// 服务停止
        /// </summary>
        void Stop()
        {
            log.Info("服务正在停止");
            log.Info("服务已经停止");
        }
    }
}
