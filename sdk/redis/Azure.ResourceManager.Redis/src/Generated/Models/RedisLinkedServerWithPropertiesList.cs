// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> List of linked servers (with properties) of a Redis cache. </summary>
    internal partial class RedisLinkedServerWithPropertiesList
    {
        /// <summary> Initializes a new instance of RedisLinkedServerWithPropertiesList. </summary>
        internal RedisLinkedServerWithPropertiesList()
        {
            Value = new ChangeTrackingList<RedisLinkedServerWithPropertiesData>();
        }

        /// <summary> Initializes a new instance of RedisLinkedServerWithPropertiesList. </summary>
        /// <param name="value"> List of linked servers (with properties) of a Redis cache. </param>
        /// <param name="nextLink"> Link for next set. </param>
        internal RedisLinkedServerWithPropertiesList(IReadOnlyList<RedisLinkedServerWithPropertiesData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of linked servers (with properties) of a Redis cache. </summary>
        public IReadOnlyList<RedisLinkedServerWithPropertiesData> Value { get; }
        /// <summary> Link for next set. </summary>
        public string NextLink { get; }
    }
}
