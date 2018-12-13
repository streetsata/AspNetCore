// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Cors.Infrastructure;

namespace Microsoft.AspNetCore.Cors
{
    public class CorsPolicyMetadata : ICorsPolicyMetadata
    {
        public CorsPolicyMetadata(CorsPolicy policy)
        {
            Policy = policy;
        }

        public CorsPolicyMetadata(string policyName)
        {
            PolicyName = policyName;
        }

        public CorsPolicy Policy { get; }

        public string PolicyName { get; }
    }
}
