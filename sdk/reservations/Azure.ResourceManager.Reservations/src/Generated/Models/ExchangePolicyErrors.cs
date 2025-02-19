// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Exchange policy errors. </summary>
    internal partial class ExchangePolicyErrors
    {
        /// <summary> Initializes a new instance of ExchangePolicyErrors. </summary>
        internal ExchangePolicyErrors()
        {
            PolicyErrors = new ChangeTrackingList<ExchangePolicyError>();
        }

        /// <summary> Initializes a new instance of ExchangePolicyErrors. </summary>
        /// <param name="policyErrors"> Exchange Policy errors. </param>
        internal ExchangePolicyErrors(IReadOnlyList<ExchangePolicyError> policyErrors)
        {
            PolicyErrors = policyErrors;
        }

        /// <summary> Exchange Policy errors. </summary>
        public IReadOnlyList<ExchangePolicyError> PolicyErrors { get; }
    }
}
