// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ComputeSecrets
    {
        internal static ComputeSecrets DeserializeComputeSecrets(JsonElement element)
        {
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKS": return AksComputeSecrets.DeserializeAksComputeSecrets(element);
                    case "Databricks": return DatabricksComputeSecrets.DeserializeDatabricksComputeSecrets(element);
                    case "VirtualMachine": return VirtualMachineSecrets.DeserializeVirtualMachineSecrets(element);
                }
            }
            ComputeType computeType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeType"))
                {
                    computeType = new ComputeType(property.Value.GetString());
                    continue;
                }
            }
            return new ComputeSecrets(computeType);
        }
    }
}
