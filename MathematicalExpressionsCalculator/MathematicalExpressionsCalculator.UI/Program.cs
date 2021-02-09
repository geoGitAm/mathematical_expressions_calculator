﻿using Autofac;
using MathematicalExpressionsCalculator.Library.Observers;
using MathematicalExpressionsCalculator.Library.Repositories;
using MathematicalExpressionsCalculator.Library.Validation;
using System;
using System.Collections.Generic;

namespace MathematicalExpressionsCalculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Logging
            // TODO - Console messages
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var application = scope.Resolve<IApplication>();
                application.Run();
            }
        }
    }
}
