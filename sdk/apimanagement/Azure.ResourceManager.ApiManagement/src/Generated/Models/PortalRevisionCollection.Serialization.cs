// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PortalRevisionCollection
    {
        internal static PortalRevisionCollection DeserializePortalRevisionCollection(JsonElement element)
        {
            Optional<IReadOnlyList<PortalRevisionContractData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PortalRevisionContractData> array = new List<PortalRevisionContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PortalRevisionContractData.DeserializePortalRevisionContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PortalRevisionCollection(Optional.ToList(value), nextLink.Value);
        }
    }
}
