// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineNetworkProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkInterfaces))
            {
                writer.WritePropertyName("networkInterfaces");
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaces)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkApiVersion))
            {
                writer.WritePropertyName("networkApiVersion");
                writer.WriteStringValue(NetworkApiVersion.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NetworkInterfaceConfigurations))
            {
                writer.WritePropertyName("networkInterfaceConfigurations");
                writer.WriteStartArray();
                foreach (var item in NetworkInterfaceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineNetworkProfile DeserializeVirtualMachineNetworkProfile(JsonElement element)
        {
            Optional<IList<VirtualMachineNetworkInterfaceReference>> networkInterfaces = default;
            Optional<NetworkApiVersion> networkApiVersion = default;
            Optional<IList<VirtualMachineNetworkInterfaceConfiguration>> networkInterfaceConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaces"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualMachineNetworkInterfaceReference> array = new List<VirtualMachineNetworkInterfaceReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineNetworkInterfaceReference.DeserializeVirtualMachineNetworkInterfaceReference(item));
                    }
                    networkInterfaces = array;
                    continue;
                }
                if (property.NameEquals("networkApiVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkApiVersion = new NetworkApiVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkInterfaceConfigurations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualMachineNetworkInterfaceConfiguration> array = new List<VirtualMachineNetworkInterfaceConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineNetworkInterfaceConfiguration.DeserializeVirtualMachineNetworkInterfaceConfiguration(item));
                    }
                    networkInterfaceConfigurations = array;
                    continue;
                }
            }
            return new VirtualMachineNetworkProfile(Optional.ToList(networkInterfaces), Optional.ToNullable(networkApiVersion), Optional.ToList(networkInterfaceConfigurations));
        }
    }
}
