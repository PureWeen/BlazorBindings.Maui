﻿using Emblazon;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Blaxamarin.Framework
{
    public class BlaxamarinRenderer : EmblazonRenderer
    {
        public BlaxamarinRenderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
            : base(serviceProvider, loggerFactory)
        {
        }

        public override Dispatcher Dispatcher { get; } = new XamarinDeviceDispatcher();

        protected override void HandleException(Exception exception)
        {
            Debug.Fail($"{nameof(HandleException)} called with '{exception?.GetType().Name}': '{exception?.Message}'");

            // TODO: Would be nice to dispatch this to some Xamarin.Forms-friendly error logic
            //MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override ElementManager CreateNativeControlManager()
        {
            return new BlaxamarinElementManager();
        }
    }
}
