using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRANameGeneratorUI.Services
{
    /// <summary>
    /// This service manage the creation of FmHome
    /// </summary>
    public class FrameService : BackgroundService
    {
        private readonly FmHome _form;
        private readonly IHostApplicationLifetime _applicationLifetime;

        public FrameService(FmHome form, IHostApplicationLifetime applicationLifetime)
        {
            _form = form;
            _applicationLifetime = applicationLifetime;
        }

        /// <summary>
        /// Call when launching the service.
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _form.Init();
            Application.Run(_form);
            _applicationLifetime.StopApplication();

            return Task.CompletedTask;
        }
    }
}
