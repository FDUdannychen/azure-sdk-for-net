// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> public network access is enabled or not. </summary>
    public readonly partial struct ServerPublicNetworkAccessState : IEquatable<ServerPublicNetworkAccessState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServerPublicNetworkAccessState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServerPublicNetworkAccessState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static ServerPublicNetworkAccessState Enabled { get; } = new ServerPublicNetworkAccessState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static ServerPublicNetworkAccessState Disabled { get; } = new ServerPublicNetworkAccessState(DisabledValue);
        /// <summary> Determines if two <see cref="ServerPublicNetworkAccessState"/> values are the same. </summary>
        public static bool operator ==(ServerPublicNetworkAccessState left, ServerPublicNetworkAccessState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServerPublicNetworkAccessState"/> values are not the same. </summary>
        public static bool operator !=(ServerPublicNetworkAccessState left, ServerPublicNetworkAccessState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServerPublicNetworkAccessState"/>. </summary>
        public static implicit operator ServerPublicNetworkAccessState(string value) => new ServerPublicNetworkAccessState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServerPublicNetworkAccessState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServerPublicNetworkAccessState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
