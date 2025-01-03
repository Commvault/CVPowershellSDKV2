// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(DiskStorageTypeConverter))]
    public partial class DiskStorage
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.DiskStorage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IDiskStorage" />.</returns>
        public static Commvault.Powershell.Models.IDiskStorage DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiskStorage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.DiskStorage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IDiskStorage" />.</returns>
        public static Commvault.Powershell.Models.IDiskStorage DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiskStorage(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.DiskStorage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiskStorage(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("General"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).General = (Commvault.Powershell.Models.IDiskStorageGeneralInfo) content.GetValueForProperty("General",((Commvault.Powershell.Models.IDiskStorageInternal)this).General, Commvault.Powershell.Models.DiskStorageGeneralInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Encryption = (Commvault.Powershell.Models.IEncryption) content.GetValueForProperty("Encryption",((Commvault.Powershell.Models.IDiskStorageInternal)this).Encryption, Commvault.Powershell.Models.EncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IDiskStorageInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IDiskStorageInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BackupLocations"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).BackupLocations = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameStatus>) content.GetValueForProperty("BackupLocations",((Commvault.Powershell.Models.IDiskStorageInternal)this).BackupLocations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdNameStatus>(__y, Commvault.Powershell.Models.IdNameStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IDiskStorageInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssociatedPlanList"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).AssociatedPlanList = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedPlanList",((Commvault.Powershell.Models.IDiskStorageInternal)this).AssociatedPlanList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("EncryptionKeyLength"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyLength = (long?) content.GetValueForProperty("EncryptionKeyLength",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralCapacity"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralCapacity = (long?) content.GetValueForProperty("GeneralCapacity",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralFreeSpace"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralFreeSpace = (long?) content.GetValueForProperty("GeneralFreeSpace",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralFreeSpace, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralSizeOnDisk"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralSizeOnDisk = (long?) content.GetValueForProperty("GeneralSizeOnDisk",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralSizeOnDisk, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralDedupeSavingsPercent"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralDedupeSavingsPercent = (long?) content.GetValueForProperty("GeneralDedupeSavingsPercent",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralDedupeSavingsPercent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EncryptionKeyProvider"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyProvider = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EncryptionKeyProvider",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyProvider, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionEncrypt"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionEncrypt = (bool?) content.GetValueForProperty("EncryptionEncrypt",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionEncrypt, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionCipher"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionCipher = (string) content.GetValueForProperty("EncryptionCipher",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionCipher, global::System.Convert.ToString);
            }
            if (content.Contains("KeyProviderId"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderId = (long?) content.GetValueForProperty("KeyProviderId",((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("KeyProviderName"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderName = (string) content.GetValueForProperty("KeyProviderName",((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.DiskStorage"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiskStorage(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("General"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).General = (Commvault.Powershell.Models.IDiskStorageGeneralInfo) content.GetValueForProperty("General",((Commvault.Powershell.Models.IDiskStorageInternal)this).General, Commvault.Powershell.Models.DiskStorageGeneralInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Encryption"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Encryption = (Commvault.Powershell.Models.IEncryption) content.GetValueForProperty("Encryption",((Commvault.Powershell.Models.IDiskStorageInternal)this).Encryption, Commvault.Powershell.Models.EncryptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IDiskStorageInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IDiskStorageInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("BackupLocations"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).BackupLocations = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameStatus>) content.GetValueForProperty("BackupLocations",((Commvault.Powershell.Models.IDiskStorageInternal)this).BackupLocations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdNameStatus>(__y, Commvault.Powershell.Models.IdNameStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("Security"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).Security = (System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityAssoc>) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IDiskStorageInternal)this).Security, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ISecurityAssoc>(__y, Commvault.Powershell.Models.SecurityAssocTypeConverter.ConvertFrom));
            }
            if (content.Contains("AssociatedPlanList"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).AssociatedPlanList = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedPlanList",((Commvault.Powershell.Models.IDiskStorageInternal)this).AssociatedPlanList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("EncryptionKeyLength"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyLength = (long?) content.GetValueForProperty("EncryptionKeyLength",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyLength, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralCapacity"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralCapacity = (long?) content.GetValueForProperty("GeneralCapacity",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralCapacity, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralFreeSpace"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralFreeSpace = (long?) content.GetValueForProperty("GeneralFreeSpace",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralFreeSpace, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralSizeOnDisk"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralSizeOnDisk = (long?) content.GetValueForProperty("GeneralSizeOnDisk",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralSizeOnDisk, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("GeneralDedupeSavingsPercent"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralDedupeSavingsPercent = (long?) content.GetValueForProperty("GeneralDedupeSavingsPercent",((Commvault.Powershell.Models.IDiskStorageInternal)this).GeneralDedupeSavingsPercent, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EncryptionKeyProvider"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyProvider = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("EncryptionKeyProvider",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionKeyProvider, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("EncryptionEncrypt"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionEncrypt = (bool?) content.GetValueForProperty("EncryptionEncrypt",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionEncrypt, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EncryptionCipher"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionCipher = (string) content.GetValueForProperty("EncryptionCipher",((Commvault.Powershell.Models.IDiskStorageInternal)this).EncryptionCipher, global::System.Convert.ToString);
            }
            if (content.Contains("KeyProviderId"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderId = (long?) content.GetValueForProperty("KeyProviderId",((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("KeyProviderName"))
            {
                ((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderName = (string) content.GetValueForProperty("KeyProviderName",((Commvault.Powershell.Models.IDiskStorageInternal)this).KeyProviderName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiskStorage" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiskStorage" /> model class.</returns>
        public static Commvault.Powershell.Models.IDiskStorage FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(DiskStorageTypeConverter))]
    public partial interface IDiskStorage

    {

    }
}