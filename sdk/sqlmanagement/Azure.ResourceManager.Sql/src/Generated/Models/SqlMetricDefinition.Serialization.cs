// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlMetricDefinition
    {
        internal static SqlMetricDefinition DeserializeSqlMetricDefinition(JsonElement element)
        {
            Optional<SqlMetricName> name = default;
            Optional<PrimaryAggregationType> primaryAggregationType = default;
            Optional<Uri> resourceUri = default;
            Optional<SqlMetricDefinitionUnitType> unit = default;
            Optional<IReadOnlyList<MetricAvailability>> metricAvailabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = SqlMetricName.DeserializeSqlMetricName(property.Value);
                    continue;
                }
                if (property.NameEquals("primaryAggregationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryAggregationType = new PrimaryAggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUri = null;
                        continue;
                    }
                    resourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unit = new SqlMetricDefinitionUnitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricAvailabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MetricAvailability> array = new List<MetricAvailability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetricAvailability.DeserializeMetricAvailability(item));
                    }
                    metricAvailabilities = array;
                    continue;
                }
            }
            return new SqlMetricDefinition(name.Value, Optional.ToNullable(primaryAggregationType), resourceUri.Value, Optional.ToNullable(unit), Optional.ToList(metricAvailabilities));
        }
    }
}
