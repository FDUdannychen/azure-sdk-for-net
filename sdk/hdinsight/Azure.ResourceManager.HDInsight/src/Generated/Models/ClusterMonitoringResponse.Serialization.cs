// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class ClusterMonitoringResponse
    {
        internal static ClusterMonitoringResponse DeserializeClusterMonitoringResponse(JsonElement element)
        {
            Optional<bool> clusterMonitoringEnabled = default;
            Optional<string> workspaceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterMonitoringEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clusterMonitoringEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
            }
            return new ClusterMonitoringResponse(Optional.ToNullable(clusterMonitoringEnabled), workspaceId.Value);
        }
    }
}
