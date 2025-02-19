// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The list of workflow versions. </summary>
    internal partial class WorkflowVersionListResult
    {
        /// <summary> Initializes a new instance of WorkflowVersionListResult. </summary>
        internal WorkflowVersionListResult()
        {
            Value = new ChangeTrackingList<WorkflowVersionData>();
        }

        /// <summary> Initializes a new instance of WorkflowVersionListResult. </summary>
        /// <param name="value"> A list of workflow versions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal WorkflowVersionListResult(IReadOnlyList<WorkflowVersionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of workflow versions. </summary>
        public IReadOnlyList<WorkflowVersionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
