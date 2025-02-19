﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer.Models
{
    /// <summary>
    /// <see cref="ContentTransferOptions"/> is used to provide options for parallel transfers.
    /// </summary>
    public struct ContentTransferOptions : IEquatable<ContentTransferOptions>
    {
        private long? _maximumTransferSize;
        private int? _maximumConcurrency;
        private long? _initialTransferSize;

        /// <summary>
        /// The maximum length of a transfer in bytes.
        /// </summary>
        public long MaximumTransferSize
        {
            get { return _maximumTransferSize ?? Constants.ContentDownloader.Partition.MaxDownloadBytes; }
            set { _maximumTransferSize = value; }
        }

        /// <summary>
        /// The maximum number of workers that may be used in a parallel transfer.
        /// </summary>
        public int MaximumConcurrency
        {
            get { return _maximumConcurrency ?? Constants.ContentDownloader.Partition.DefaultConcurrentTransfersCount; }
            set { _maximumConcurrency = value; }
        }

        /// <summary>
        /// The size of the first range request in bytes. Blobs smaller than this limit will
        /// be downloaded in a single request. Blobs larger than this limit will continue being
        /// downloaded in chunks of size <see cref="MaximumTransferSize"/>.
        /// </summary>
        public long InitialTransferSize
        {
            get { return _initialTransferSize ?? Constants.ContentDownloader.Partition.DefaultInitalDownloadRangeSize; }
            set { _initialTransferSize = value; }
        }

        /// <summary>
        /// Check if two ContentTransferOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
            => obj is ContentTransferOptions other
            && Equals(other);

        /// <summary>
        /// Get a hash code for the ParallelTransferOptions.
        /// </summary>
        /// <returns>Hash code for the ParallelTransferOptions.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
            => MaximumTransferSize.GetHashCode()
            ^ MaximumConcurrency.GetHashCode()
            ^ InitialTransferSize.GetHashCode();

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator ==(ContentTransferOptions left, ContentTransferOptions right) => left.Equals(right);

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're not equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool operator !=(ContentTransferOptions left, ContentTransferOptions right) => !(left == right);

        /// <summary>
        /// Check if two ParallelTransferOptions instances are equal.
        /// </summary>
        /// <param name="obj">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool Equals(ContentTransferOptions obj)
            => MaximumTransferSize == obj.MaximumTransferSize
            && MaximumConcurrency == obj.MaximumConcurrency
            && InitialTransferSize == obj.InitialTransferSize;
    }
}
