// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class DatasetListResponse
    {
        internal static DatasetListResponse DeserializeDatasetListResponse(JsonElement element)
        {
            IReadOnlyList<DatasetResourceData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DatasetResourceData> array = new List<DatasetResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DatasetResourceData.DeserializeDatasetResourceData(item));
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
            return new DatasetListResponse(value, nextLink.Value);
        }
    }
}
