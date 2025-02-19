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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppConfiguration
{
    /// <summary>
    /// A class representing a collection of <see cref="DeletedConfigurationStoreResource" /> and their operations.
    /// Each <see cref="DeletedConfigurationStoreResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="DeletedConfigurationStoreCollection" /> instance call the GetDeletedConfigurationStores method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class DeletedConfigurationStoreCollection : ArmCollection, IEnumerable<DeletedConfigurationStoreResource>, IAsyncEnumerable<DeletedConfigurationStoreResource>
    {
        private readonly ClientDiagnostics _deletedConfigurationStoreConfigurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _deletedConfigurationStoreConfigurationStoresRestClient;
        private readonly ClientDiagnostics _configurationStoresClientDiagnostics;
        private readonly ConfigurationStoresRestOperations _configurationStoresRestClient;

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreCollection"/> class for mocking. </summary>
        protected DeletedConfigurationStoreCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeletedConfigurationStoreCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DeletedConfigurationStoreCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _deletedConfigurationStoreConfigurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", DeletedConfigurationStoreResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DeletedConfigurationStoreResource.ResourceType, out string deletedConfigurationStoreConfigurationStoresApiVersion);
            _deletedConfigurationStoreConfigurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, deletedConfigurationStoreConfigurationStoresApiVersion);
            _configurationStoresClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppConfiguration", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _configurationStoresRestClient = new ConfigurationStoresRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<DeletedConfigurationStoreResource>> GetAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a deleted Azure app configuration store.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<DeletedConfigurationStoreResource> Get(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Get");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeletedConfigurationStoreResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the deleted configuration stores in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores
        /// Operation Id: ConfigurationStores_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedConfigurationStoreResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedConfigurationStoreResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoresRestClient.ListDeletedAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeletedConfigurationStoreResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _configurationStoresRestClient.ListDeletedNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets information about the deleted configuration stores in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/deletedConfigurationStores
        /// Operation Id: ConfigurationStores_ListDeleted
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedConfigurationStoreResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedConfigurationStoreResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DeletedConfigurationStoreResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _configurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoresRestClient.ListDeleted(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeletedConfigurationStoreResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _configurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _configurationStoresRestClient.ListDeletedNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeletedConfigurationStoreResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = await _deletedConfigurationStoreConfigurationStoresRestClient.GetDeletedAsync(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.AppConfiguration/locations/{location}/deletedConfigurationStores/{configStoreName}
        /// Operation Id: ConfigurationStores_GetDeleted
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configStoreName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var scope = _deletedConfigurationStoreConfigurationStoresClientDiagnostics.CreateScope("DeletedConfigurationStoreCollection.Exists");
            scope.Start();
            try
            {
                var response = _deletedConfigurationStoreConfigurationStoresRestClient.GetDeleted(Id.SubscriptionId, location, configStoreName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DeletedConfigurationStoreResource> IEnumerable<DeletedConfigurationStoreResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DeletedConfigurationStoreResource> IAsyncEnumerable<DeletedConfigurationStoreResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
