﻿using GovITHub.Auth.Common.Infrastructure.Attributes;
using GovITHub.Auth.Common.Services.Audit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GovITHub.Auth.Common.Infrastructure.Configuration
{
    public static class AuditConfiguration
    {
        public static IServiceCollection ConfigureAudit(this IServiceCollection services)
        {
            return services.AddTransient<IAuditService, AuditService>()
                .AddTransient(typeof(AuditTrailAttribute));
        }

        public static void ConfigureAudit(this MvcOptions options)
        {
            options.Filters.Add(typeof(AuditTrailAttribute));
        }
    }
}
