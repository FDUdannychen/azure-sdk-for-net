// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class TextTrack : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(PlayerVisibility))
            {
                writer.WritePropertyName("playerVisibility");
                writer.WriteStringValue(PlayerVisibility.Value.ToString());
            }
            if (Optional.IsDefined(HlsSettings))
            {
                writer.WritePropertyName("hlsSettings");
                writer.WriteObjectValue(HlsSettings);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static TextTrack DeserializeTextTrack(JsonElement element)
        {
            Optional<string> fileName = default;
            Optional<string> displayName = default;
            Optional<string> languageCode = default;
            Optional<Visibility> playerVisibility = default;
            Optional<HlsSettings> hlsSettings = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileName"))
                {
                    fileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("languageCode"))
                {
                    languageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("playerVisibility"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    playerVisibility = new Visibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hlsSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hlsSettings = HlsSettings.DeserializeHlsSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new TextTrack(odataType, fileName.Value, displayName.Value, languageCode.Value, Optional.ToNullable(playerVisibility), hlsSettings.Value);
        }
    }
}
