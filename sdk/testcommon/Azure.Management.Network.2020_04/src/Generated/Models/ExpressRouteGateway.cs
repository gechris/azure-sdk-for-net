// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> ExpressRoute gateway resource. </summary>
    public partial class ExpressRouteGateway : Resource
    {
        /// <summary> Initializes a new instance of ExpressRouteGateway. </summary>
        public ExpressRouteGateway()
        {
            ExpressRouteConnections = new ChangeTrackingList<ExpressRouteConnection>();
        }

        /// <summary> Initializes a new instance of ExpressRouteGateway. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="autoScaleConfiguration"> Configuration for auto scaling. </param>
        /// <param name="expressRouteConnections"> List of ExpressRoute connections to the ExpressRoute gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the express route gateway resource. </param>
        /// <param name="virtualHub"> The Virtual Hub where the ExpressRoute gateway is or will be deployed. </param>
        internal ExpressRouteGateway(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, ExpressRouteGatewayPropertiesAutoScaleConfiguration autoScaleConfiguration, IReadOnlyList<ExpressRouteConnection> expressRouteConnections, ProvisioningState? provisioningState, VirtualHubId virtualHub) : base(id, name, type, location, tags)
        {
            Etag = etag;
            AutoScaleConfiguration = autoScaleConfiguration;
            ExpressRouteConnections = expressRouteConnections;
            ProvisioningState = provisioningState;
            VirtualHub = virtualHub;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Configuration for auto scaling. </summary>
        public ExpressRouteGatewayPropertiesAutoScaleConfiguration AutoScaleConfiguration { get; set; }
        /// <summary> List of ExpressRoute connections to the ExpressRoute gateway. </summary>
        public IReadOnlyList<ExpressRouteConnection> ExpressRouteConnections { get; }
        /// <summary> The provisioning state of the express route gateway resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The Virtual Hub where the ExpressRoute gateway is or will be deployed. </summary>
        public VirtualHubId VirtualHub { get; set; }
    }
}
