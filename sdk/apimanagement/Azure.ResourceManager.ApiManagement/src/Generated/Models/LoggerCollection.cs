// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged Logger list representation. </summary>
    internal partial class LoggerCollection
    {
        /// <summary> Initializes a new instance of LoggerCollection. </summary>
        internal LoggerCollection()
        {
            Value = new ChangeTrackingList<LoggerContractData>();
        }

        /// <summary> Initializes a new instance of LoggerCollection. </summary>
        /// <param name="value"> Logger values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal LoggerCollection(IReadOnlyList<LoggerContractData> value, long? count, string nextLink)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
        }

        /// <summary> Logger values. </summary>
        public IReadOnlyList<LoggerContractData> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
