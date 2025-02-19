// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class ApiResourceMetadata
    {
        internal static ApiResourceMetadata DeserializeApiResourceMetadata(JsonElement element)
        {
            Optional<string> source = default;
            Optional<string> brandColor = default;
            Optional<string> hideKey = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<ApiType> apiType = default;
            Optional<WsdlService> wsdlService = default;
            Optional<WsdlImportMethod> wsdlImportMethod = default;
            Optional<string> connectionType = default;
            Optional<WorkflowProvisioningState> provisioningState = default;
            Optional<ApiDeploymentParameterMetadataSet> deploymentParameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("brandColor"))
                {
                    brandColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hideKey"))
                {
                    hideKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("ApiType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    apiType = new ApiType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("wsdlService"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wsdlService = WsdlService.DeserializeWsdlService(property.Value);
                    continue;
                }
                if (property.NameEquals("wsdlImportMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wsdlImportMethod = new WsdlImportMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionType"))
                {
                    connectionType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new WorkflowProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deploymentParameters = ApiDeploymentParameterMetadataSet.DeserializeApiDeploymentParameterMetadataSet(property.Value);
                    continue;
                }
            }
            return new ApiResourceMetadata(source.Value, brandColor.Value, hideKey.Value, Optional.ToDictionary(tags), Optional.ToNullable(apiType), wsdlService.Value, Optional.ToNullable(wsdlImportMethod), connectionType.Value, Optional.ToNullable(provisioningState), deploymentParameters.Value);
        }
    }
}
