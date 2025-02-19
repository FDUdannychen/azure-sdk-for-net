// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoints))
            {
                writer.WritePropertyName("endpoints");
                writer.WriteObjectValue(Endpoints);
            }
            if (Optional.IsCollectionDefined(Routes))
            {
                writer.WritePropertyName("routes");
                writer.WriteStartArray();
                foreach (var item in Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FallbackRoute))
            {
                writer.WritePropertyName("fallbackRoute");
                writer.WriteObjectValue(FallbackRoute);
            }
            if (Optional.IsCollectionDefined(Enrichments))
            {
                writer.WritePropertyName("enrichments");
                writer.WriteStartArray();
                foreach (var item in Enrichments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RoutingProperties DeserializeRoutingProperties(JsonElement element)
        {
            Optional<RoutingEndpoints> endpoints = default;
            Optional<IList<RouteProperties>> routes = default;
            Optional<FallbackRouteProperties> fallbackRoute = default;
            Optional<IList<EnrichmentProperties>> enrichments = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endpoints = RoutingEndpoints.DeserializeRoutingEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RouteProperties> array = new List<RouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteProperties.DeserializeRouteProperties(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("fallbackRoute"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fallbackRoute = FallbackRouteProperties.DeserializeFallbackRouteProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("enrichments"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EnrichmentProperties> array = new List<EnrichmentProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EnrichmentProperties.DeserializeEnrichmentProperties(item));
                    }
                    enrichments = array;
                    continue;
                }
            }
            return new RoutingProperties(endpoints.Value, Optional.ToList(routes), fallbackRoute.Value, Optional.ToList(enrichments));
        }
    }
}
