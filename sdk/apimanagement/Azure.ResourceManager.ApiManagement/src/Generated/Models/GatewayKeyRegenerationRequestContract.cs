// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Gateway key regeneration request contract properties. </summary>
    public partial class GatewayKeyRegenerationRequestContract
    {
        /// <summary> Initializes a new instance of GatewayKeyRegenerationRequestContract. </summary>
        /// <param name="keyType"> The Key being regenerated. </param>
        public GatewayKeyRegenerationRequestContract(KeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> The Key being regenerated. </summary>
        public KeyType KeyType { get; }
    }
}
