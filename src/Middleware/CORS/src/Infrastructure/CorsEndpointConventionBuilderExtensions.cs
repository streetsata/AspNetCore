// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// CORS extension methods for <see cref="IEndpointConventionBuilder"/>.
    /// </summary>
    public static class CorsEndpointConventionBuilderExtensions
    {
        /// <summary>
        /// Adds a CORS policy with the specified name to the endpoint(s).
        /// </summary>
        /// <param name="builder">The endpoint convention builder.</param>
        /// <param name="policyName">The CORS policy name.</param>
        /// <returns>The original convention builder parameter.</returns>
        public static IEndpointConventionBuilder WithCorsPolicy(this IEndpointConventionBuilder builder, string policyName)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Apply(endpointBuilder =>
            {
                endpointBuilder.Metadata.Add(new EnableCorsAttribute(policyName));
            });
            return builder;
        }
    }
}
