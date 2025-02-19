// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The response from the List Agent Pools operation. </summary>
    internal partial class AgentPoolListResult
    {
        /// <summary> Initializes a new instance of AgentPoolListResult. </summary>
        internal AgentPoolListResult()
        {
            Value = new ChangeTrackingList<AgentPoolData>();
        }

        /// <summary> Initializes a new instance of AgentPoolListResult. </summary>
        /// <param name="value"> The list of agent pools. </param>
        /// <param name="nextLink"> The URL to get the next set of agent pool results. </param>
        internal AgentPoolListResult(IReadOnlyList<AgentPoolData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of agent pools. </summary>
        public IReadOnlyList<AgentPoolData> Value { get; }
        /// <summary> The URL to get the next set of agent pool results. </summary>
        public string NextLink { get; }
    }
}
