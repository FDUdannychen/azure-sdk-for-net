// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> Specifies how the LCM(Local Configuration Manager) actually applies the configuration to the target nodes. Possible values are ApplyOnly, ApplyAndMonitor, and ApplyAndAutoCorrect. </summary>
    public readonly partial struct ConfigurationMode : IEquatable<ConfigurationMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConfigurationMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConfigurationMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplyOnlyValue = "ApplyOnly";
        private const string ApplyAndMonitorValue = "ApplyAndMonitor";
        private const string ApplyAndAutoCorrectValue = "ApplyAndAutoCorrect";

        /// <summary> ApplyOnly. </summary>
        public static ConfigurationMode ApplyOnly { get; } = new ConfigurationMode(ApplyOnlyValue);
        /// <summary> ApplyAndMonitor. </summary>
        public static ConfigurationMode ApplyAndMonitor { get; } = new ConfigurationMode(ApplyAndMonitorValue);
        /// <summary> ApplyAndAutoCorrect. </summary>
        public static ConfigurationMode ApplyAndAutoCorrect { get; } = new ConfigurationMode(ApplyAndAutoCorrectValue);
        /// <summary> Determines if two <see cref="ConfigurationMode"/> values are the same. </summary>
        public static bool operator ==(ConfigurationMode left, ConfigurationMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConfigurationMode"/> values are not the same. </summary>
        public static bool operator !=(ConfigurationMode left, ConfigurationMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConfigurationMode"/>. </summary>
        public static implicit operator ConfigurationMode(string value) => new ConfigurationMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConfigurationMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConfigurationMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
