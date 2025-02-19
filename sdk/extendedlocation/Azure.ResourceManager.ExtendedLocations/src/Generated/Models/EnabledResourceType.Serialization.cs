// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class EnabledResourceType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterExtensionId))
            {
                writer.WritePropertyName("clusterExtensionId");
                writer.WriteStringValue(ClusterExtensionId);
            }
            if (Optional.IsDefined(ExtensionType))
            {
                writer.WritePropertyName("extensionType");
                writer.WriteStringValue(ExtensionType);
            }
            if (Optional.IsCollectionDefined(TypesMetadata))
            {
                writer.WritePropertyName("typesMetadata");
                writer.WriteStartArray();
                foreach (var item in TypesMetadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EnabledResourceType DeserializeEnabledResourceType(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> clusterExtensionId = default;
            Optional<string> extensionType = default;
            Optional<IList<EnabledResourceTypePropertiesTypesMetadataItem>> typesMetadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterExtensionId"))
                        {
                            clusterExtensionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensionType"))
                        {
                            extensionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typesMetadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<EnabledResourceTypePropertiesTypesMetadataItem> array = new List<EnabledResourceTypePropertiesTypesMetadataItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EnabledResourceTypePropertiesTypesMetadataItem.DeserializeEnabledResourceTypePropertiesTypesMetadataItem(item));
                            }
                            typesMetadata = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EnabledResourceType(id, name, type, systemData.Value, clusterExtensionId.Value, extensionType.Value, Optional.ToList(typesMetadata));
        }
    }
}
