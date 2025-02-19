// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The disk encryption properties. </summary>
    public partial class DiskEncryptionProperties
    {
        /// <summary> Initializes a new instance of DiskEncryptionProperties. </summary>
        public DiskEncryptionProperties()
        {
        }

        /// <summary> Initializes a new instance of DiskEncryptionProperties. </summary>
        /// <param name="vaultUri"> Base key vault URI where the customers key is located eg. https://myvault.vault.azure.net. </param>
        /// <param name="keyName"> Key name that is used for enabling disk encryption. </param>
        /// <param name="keyVersion"> Specific key version that is used for enabling disk encryption. </param>
        /// <param name="encryptionAlgorithm"> Algorithm identifier for encryption, default RSA-OAEP. </param>
        /// <param name="msiResourceId"> Resource ID of Managed Identity that is used to access the key vault. </param>
        /// <param name="encryptionAtHost"> Indicates whether or not resource disk encryption is enabled. </param>
        internal DiskEncryptionProperties(Uri vaultUri, string keyName, string keyVersion, JsonWebKeyEncryptionAlgorithm? encryptionAlgorithm, string msiResourceId, bool? encryptionAtHost)
        {
            VaultUri = vaultUri;
            KeyName = keyName;
            KeyVersion = keyVersion;
            EncryptionAlgorithm = encryptionAlgorithm;
            MsiResourceId = msiResourceId;
            EncryptionAtHost = encryptionAtHost;
        }

        /// <summary> Base key vault URI where the customers key is located eg. https://myvault.vault.azure.net. </summary>
        public Uri VaultUri { get; set; }
        /// <summary> Key name that is used for enabling disk encryption. </summary>
        public string KeyName { get; set; }
        /// <summary> Specific key version that is used for enabling disk encryption. </summary>
        public string KeyVersion { get; set; }
        /// <summary> Algorithm identifier for encryption, default RSA-OAEP. </summary>
        public JsonWebKeyEncryptionAlgorithm? EncryptionAlgorithm { get; set; }
        /// <summary> Resource ID of Managed Identity that is used to access the key vault. </summary>
        public string MsiResourceId { get; set; }
        /// <summary> Indicates whether or not resource disk encryption is enabled. </summary>
        public bool? EncryptionAtHost { get; set; }
    }
}
