// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The EventHub consumer group name. </summary>
    public partial class EventHubConsumerGroupName
    {
        /// <summary> Initializes a new instance of EventHubConsumerGroupName. </summary>
        /// <param name="name"> EventHub consumer group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public EventHubConsumerGroupName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> EventHub consumer group name. </summary>
        public string Name { get; }
    }
}
