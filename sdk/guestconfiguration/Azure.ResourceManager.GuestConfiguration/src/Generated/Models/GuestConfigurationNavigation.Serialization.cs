// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationNavigation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ContentUri))
            {
                writer.WritePropertyName("contentUri");
                writer.WriteStringValue(ContentUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ContentHash))
            {
                writer.WritePropertyName("contentHash");
                writer.WriteStringValue(ContentHash);
            }
            if (Optional.IsDefined(AssignmentType))
            {
                writer.WritePropertyName("assignmentType");
                writer.WriteStringValue(AssignmentType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ConfigurationParameter))
            {
                writer.WritePropertyName("configurationParameter");
                writer.WriteStartArray();
                foreach (var item in ConfigurationParameter)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedParameter))
            {
                writer.WritePropertyName("configurationProtectedParameter");
                writer.WriteStartArray();
                foreach (var item in ConfigurationProtectedParameter)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationNavigation DeserializeGuestConfigurationNavigation(JsonElement element)
        {
            Optional<GuestConfigurationKind> kind = default;
            Optional<string> name = default;
            Optional<string> version = default;
            Optional<Uri> contentUri = default;
            Optional<string> contentHash = default;
            Optional<AssignmentType> assignmentType = default;
            Optional<string> assignmentSource = default;
            Optional<string> contentType = default;
            Optional<IList<ConfigurationParameter>> configurationParameter = default;
            Optional<IList<ConfigurationParameter>> configurationProtectedParameter = default;
            Optional<ConfigurationSetting> configurationSetting = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new GuestConfigurationKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contentUri = null;
                        continue;
                    }
                    contentUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentHash"))
                {
                    contentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    assignmentType = new AssignmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assignmentSource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentSource = null;
                        continue;
                    }
                    assignmentSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        contentType = null;
                        continue;
                    }
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationParameter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConfigurationParameter> array = new List<ConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ConfigurationParameter.DeserializeConfigurationParameter(item));
                    }
                    configurationParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationProtectedParameter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConfigurationParameter> array = new List<ConfigurationParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ConfigurationParameter.DeserializeConfigurationParameter(item));
                    }
                    configurationProtectedParameter = array;
                    continue;
                }
                if (property.NameEquals("configurationSetting"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    configurationSetting = ConfigurationSetting.DeserializeConfigurationSetting(property.Value);
                    continue;
                }
            }
            return new GuestConfigurationNavigation(Optional.ToNullable(kind), name.Value, version.Value, contentUri.Value, contentHash.Value, Optional.ToNullable(assignmentType), assignmentSource.Value, contentType.Value, Optional.ToList(configurationParameter), Optional.ToList(configurationProtectedParameter), configurationSetting.Value);
        }
    }
}
