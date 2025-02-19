// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The type of identity used for the resource mover service. </summary>
    public readonly partial struct ResourceIdentityType : IEquatable<ResourceIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";

        /// <summary> None. </summary>
        public static ResourceIdentityType None { get; } = new ResourceIdentityType(NoneValue);
        /// <summary> SystemAssigned. </summary>
        public static ResourceIdentityType SystemAssigned { get; } = new ResourceIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static ResourceIdentityType UserAssigned { get; } = new ResourceIdentityType(UserAssignedValue);
        /// <summary> Determines if two <see cref="ResourceIdentityType"/> values are the same. </summary>
        public static bool operator ==(ResourceIdentityType left, ResourceIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceIdentityType"/> values are not the same. </summary>
        public static bool operator !=(ResourceIdentityType left, ResourceIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceIdentityType"/>. </summary>
        public static implicit operator ResourceIdentityType(string value) => new ResourceIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
