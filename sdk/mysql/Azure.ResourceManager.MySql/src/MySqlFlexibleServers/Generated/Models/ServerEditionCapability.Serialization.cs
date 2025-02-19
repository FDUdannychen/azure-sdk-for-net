// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class ServerEditionCapability
    {
        internal static ServerEditionCapability DeserializeServerEditionCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<IReadOnlyList<StorageEditionCapability>> supportedStorageEditions = default;
            Optional<IReadOnlyList<ServerVersionCapability>> supportedServerVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedStorageEditions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StorageEditionCapability> array = new List<StorageEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageEditionCapability.DeserializeStorageEditionCapability(item));
                    }
                    supportedStorageEditions = array;
                    continue;
                }
                if (property.NameEquals("supportedServerVersions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServerVersionCapability> array = new List<ServerVersionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerVersionCapability.DeserializeServerVersionCapability(item));
                    }
                    supportedServerVersions = array;
                    continue;
                }
            }
            return new ServerEditionCapability(name.Value, Optional.ToList(supportedStorageEditions), Optional.ToList(supportedServerVersions));
        }
    }
}
