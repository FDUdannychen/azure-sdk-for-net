// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The settings that will be leveraged for SAP table source partitioning. </summary>
    public partial class SapTablePartitionSettings
    {
        /// <summary> Initializes a new instance of SapTablePartitionSettings. </summary>
        public SapTablePartitionSettings()
        {
        }

        /// <summary> Initializes a new instance of SapTablePartitionSettings. </summary>
        /// <param name="partitionColumnName"> The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionUpperBound"> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="partitionLowerBound"> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </param>
        /// <param name="maxPartitionsNumber"> The maximum value of partitions the table will be split into. Type: integer (or Expression with resultType string). </param>
        internal SapTablePartitionSettings(BinaryData partitionColumnName, BinaryData partitionUpperBound, BinaryData partitionLowerBound, BinaryData maxPartitionsNumber)
        {
            PartitionColumnName = partitionColumnName;
            PartitionUpperBound = partitionUpperBound;
            PartitionLowerBound = partitionLowerBound;
            MaxPartitionsNumber = maxPartitionsNumber;
        }

        /// <summary> The name of the column that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionColumnName { get; set; }
        /// <summary> The maximum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionUpperBound { get; set; }
        /// <summary> The minimum value of column specified in partitionColumnName that will be used for proceeding range partitioning. Type: string (or Expression with resultType string). </summary>
        public BinaryData PartitionLowerBound { get; set; }
        /// <summary> The maximum value of partitions the table will be split into. Type: integer (or Expression with resultType string). </summary>
        public BinaryData MaxPartitionsNumber { get; set; }
    }
}
