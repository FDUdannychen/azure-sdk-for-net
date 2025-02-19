// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Tells whether the cluster is Running or Stopped. </summary>
    public readonly partial struct Code : IEquatable<Code>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Code"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Code(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string StoppedValue = "Stopped";

        /// <summary> The cluster is running. </summary>
        public static Code Running { get; } = new Code(RunningValue);
        /// <summary> The cluster is stopped. </summary>
        public static Code Stopped { get; } = new Code(StoppedValue);
        /// <summary> Determines if two <see cref="Code"/> values are the same. </summary>
        public static bool operator ==(Code left, Code right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Code"/> values are not the same. </summary>
        public static bool operator !=(Code left, Code right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Code"/>. </summary>
        public static implicit operator Code(string value) => new Code(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Code other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Code other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
