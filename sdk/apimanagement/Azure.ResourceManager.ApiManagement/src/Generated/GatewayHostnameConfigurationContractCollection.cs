// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="GatewayHostnameConfigurationContractResource" /> and their operations.
    /// Each <see cref="GatewayHostnameConfigurationContractResource" /> in the collection will belong to the same instance of <see cref="GatewayContractResource" />.
    /// To get a <see cref="GatewayHostnameConfigurationContractCollection" /> instance call the GetGatewayHostnameConfigurationContracts method from an instance of <see cref="GatewayContractResource" />.
    /// </summary>
    public partial class GatewayHostnameConfigurationContractCollection : ArmCollection, IEnumerable<GatewayHostnameConfigurationContractResource>, IAsyncEnumerable<GatewayHostnameConfigurationContractResource>
    {
        private readonly ClientDiagnostics _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics;
        private readonly GatewayHostnameConfigurationRestOperations _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient;

        /// <summary> Initializes a new instance of the <see cref="GatewayHostnameConfigurationContractCollection"/> class for mocking. </summary>
        protected GatewayHostnameConfigurationContractCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GatewayHostnameConfigurationContractCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal GatewayHostnameConfigurationContractCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", GatewayHostnameConfigurationContractResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(GatewayHostnameConfigurationContractResource.ResourceType, out string gatewayHostnameConfigurationContractGatewayHostnameConfigurationApiVersion);
            _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient = new GatewayHostnameConfigurationRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, gatewayHostnameConfigurationContractGatewayHostnameConfigurationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != GatewayContractResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, GatewayContractResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="data"> The GatewayHostnameConfigurationContract to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<GatewayHostnameConfigurationContractResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hcId, GatewayHostnameConfigurationContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<GatewayHostnameConfigurationContractResource>(Response.FromValue(new GatewayHostnameConfigurationContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates of updates hostname configuration for a Gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="data"> The GatewayHostnameConfigurationContract to use. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<GatewayHostnameConfigurationContractResource> CreateOrUpdate(WaitUntil waitUntil, string hcId, GatewayHostnameConfigurationContractData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<GatewayHostnameConfigurationContractResource>(Response.FromValue(new GatewayHostnameConfigurationContractResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a hostname configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_Get
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual async Task<Response<GatewayHostnameConfigurationContractResource>> GetAsync(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.Get");
            scope.Start();
            try
            {
                var response = await _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GatewayHostnameConfigurationContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of a hostname configuration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_Get
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual Response<GatewayHostnameConfigurationContractResource> Get(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.Get");
            scope.Start();
            try
            {
                var response = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GatewayHostnameConfigurationContractResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the collection of hostname configurations for the specified gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations
        /// Operation Id: GatewayHostnameConfiguration_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| hostname | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GatewayHostnameConfigurationContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GatewayHostnameConfigurationContractResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<GatewayHostnameConfigurationContractResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.ListByServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayHostnameConfigurationContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GatewayHostnameConfigurationContractResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.ListByServiceNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayHostnameConfigurationContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the collection of hostname configurations for the specified gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations
        /// Operation Id: GatewayHostnameConfiguration_ListByService
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| hostname | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GatewayHostnameConfigurationContractResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GatewayHostnameConfigurationContractResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            Page<GatewayHostnameConfigurationContractResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.ListByService(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayHostnameConfigurationContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GatewayHostnameConfigurationContractResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.ListByServiceNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, filter, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GatewayHostnameConfigurationContractResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_Get
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.Exists");
            scope.Start();
            try
            {
                var response = await _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/gateways/{gatewayId}/hostnameConfigurations/{hcId}
        /// Operation Id: GatewayHostnameConfiguration_Get
        /// </summary>
        /// <param name="hcId"> Gateway hostname configuration identifier. Must be unique in the scope of parent Gateway entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hcId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hcId"/> is null. </exception>
        public virtual Response<bool> Exists(string hcId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hcId, nameof(hcId));

            using var scope = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationClientDiagnostics.CreateScope("GatewayHostnameConfigurationContractCollection.Exists");
            scope.Start();
            try
            {
                var response = _gatewayHostnameConfigurationContractGatewayHostnameConfigurationRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, hcId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<GatewayHostnameConfigurationContractResource> IEnumerable<GatewayHostnameConfigurationContractResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GatewayHostnameConfigurationContractResource> IAsyncEnumerable<GatewayHostnameConfigurationContractResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
