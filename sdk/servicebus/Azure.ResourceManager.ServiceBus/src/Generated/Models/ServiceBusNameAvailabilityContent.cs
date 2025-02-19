// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Description of a Check Name availability request properties. </summary>
    public partial class ServiceBusNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of ServiceBusNameAvailabilityContent. </summary>
        /// <param name="name"> The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ServiceBusNameAvailabilityContent(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The Name to check the namespace name availability and The namespace name can contain only letters, numbers, and hyphens. The namespace must start with a letter, and it must end with a letter or number. </summary>
        public string Name { get; }
    }
}
