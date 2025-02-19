// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Migrate;

namespace Azure.ResourceManager.Migrate.Models
{
    internal partial class MoveCollectionResultList
    {
        internal static MoveCollectionResultList DeserializeMoveCollectionResultList(JsonElement element)
        {
            Optional<IReadOnlyList<MoveCollectionData>> value = default;
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
                    List<MoveCollectionData> array = new List<MoveCollectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoveCollectionData.DeserializeMoveCollectionData(item));
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
            return new MoveCollectionResultList(Optional.ToList(value), nextLink.Value);
        }
    }
}
