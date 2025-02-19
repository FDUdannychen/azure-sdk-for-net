// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class CertificateResourceList
    {
        internal static CertificateResourceList DeserializeCertificateResourceList(JsonElement element)
        {
            Optional<IReadOnlyList<CertificateResourceData>> value = default;
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
                    List<CertificateResourceData> array = new List<CertificateResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CertificateResourceData.DeserializeCertificateResourceData(item));
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
            return new CertificateResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
