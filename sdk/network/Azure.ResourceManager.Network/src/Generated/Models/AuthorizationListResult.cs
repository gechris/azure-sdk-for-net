// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListAuthorizations API service call retrieves all authorizations that belongs to an ExpressRouteCircuit. </summary>
    public partial class AuthorizationListResult
    {
        /// <summary> Initializes a new instance of AuthorizationListResult. </summary>
        internal AuthorizationListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteCircuitAuthorization>();
        }

        /// <summary> Initializes a new instance of AuthorizationListResult. </summary>
        /// <param name="value"> The authorizations in an ExpressRoute Circuit. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal AuthorizationListResult(IReadOnlyList<ExpressRouteCircuitAuthorization> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The authorizations in an ExpressRoute Circuit. </summary>
        public IReadOnlyList<ExpressRouteCircuitAuthorization> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
