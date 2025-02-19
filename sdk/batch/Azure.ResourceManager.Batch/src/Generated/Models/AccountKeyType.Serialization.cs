// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class AccountKeyTypeExtensions
    {
        public static string ToSerialString(this AccountKeyType value) => value switch
        {
            AccountKeyType.Primary => "Primary",
            AccountKeyType.Secondary => "Secondary",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccountKeyType value.")
        };

        public static AccountKeyType ToAccountKeyType(this string value)
        {
            if (string.Equals(value, "Primary", StringComparison.InvariantCultureIgnoreCase)) return AccountKeyType.Primary;
            if (string.Equals(value, "Secondary", StringComparison.InvariantCultureIgnoreCase)) return AccountKeyType.Secondary;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AccountKeyType value.");
        }
    }
}
