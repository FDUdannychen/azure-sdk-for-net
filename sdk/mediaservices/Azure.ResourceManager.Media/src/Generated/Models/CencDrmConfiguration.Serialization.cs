// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CencDrmConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PlayReady))
            {
                writer.WritePropertyName("playReady");
                writer.WriteObjectValue(PlayReady);
            }
            if (Optional.IsDefined(Widevine))
            {
                writer.WritePropertyName("widevine");
                writer.WriteObjectValue(Widevine);
            }
            writer.WriteEndObject();
        }

        internal static CencDrmConfiguration DeserializeCencDrmConfiguration(JsonElement element)
        {
            Optional<StreamingPolicyPlayReadyConfiguration> playReady = default;
            Optional<StreamingPolicyWidevineConfiguration> widevine = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playReady"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    playReady = StreamingPolicyPlayReadyConfiguration.DeserializeStreamingPolicyPlayReadyConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("widevine"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    widevine = StreamingPolicyWidevineConfiguration.DeserializeStreamingPolicyWidevineConfiguration(property.Value);
                    continue;
                }
            }
            return new CencDrmConfiguration(playReady.Value, widevine.Value);
        }
    }
}
