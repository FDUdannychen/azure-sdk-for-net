// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the Identifier data model. </summary>
    public partial class IdentifierData : ResourceData
    {
        /// <summary> Initializes a new instance of IdentifierData. </summary>
        public IdentifierData()
        {
        }

        /// <summary> Initializes a new instance of IdentifierData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> String representation of the identity. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal IdentifierData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string value, string kind) : base(id, name, resourceType, systemData)
        {
            Value = value;
            Kind = kind;
        }

        /// <summary> String representation of the identity. </summary>
        public string Value { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
