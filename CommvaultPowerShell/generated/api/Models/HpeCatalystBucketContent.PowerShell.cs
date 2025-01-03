// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>HPE Catalyst Storage</summary>
    [System.ComponentModel.TypeConverter(typeof(HpeCatalystBucketContentTypeConverter))]
    public partial class HpeCatalystBucketContent
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.HpeCatalystBucketContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHpeCatalystBucketContent" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHpeCatalystBucketContent DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HpeCatalystBucketContent(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.HpeCatalystBucketContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IHpeCatalystBucketContent" />.
        /// </returns>
        public static Commvault.Powershell.Models.IHpeCatalystBucketContent DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HpeCatalystBucketContent(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HpeCatalystBucketContent" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="HpeCatalystBucketContent" /> model class.</returns>
        public static Commvault.Powershell.Models.IHpeCatalystBucketContent FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.HpeCatalystBucketContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HpeCatalystBucketContent(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MediaAgent"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloudType"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).CloudType = (string) content.GetValueForProperty("CloudType",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).CloudType, global::System.Convert.ToString);
            }
            if (content.Contains("StoreOnceHost"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).StoreOnceHost = (string) content.GetValueForProperty("StoreOnceHost",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).StoreOnceHost, global::System.Convert.ToString);
            }
            if (content.Contains("Store"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Store = (string) content.GetValueForProperty("Store",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Store, global::System.Convert.ToString);
            }
            if (content.Contains("Username"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Username = (string) content.GetValueForProperty("Username",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Username, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("Access"))
            {
                ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Access = (string) content.GetValueForProperty("Access",((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Access, global::System.Convert.ToString);
            }
            if (content.Contains("Enable"))
            {
                ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Enable = (bool?) content.GetValueForProperty("Enable",((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Enable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationStorageAcceleratorCredentials"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationStorageAcceleratorCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ConfigurationStorageAcceleratorCredentials",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationStorageAcceleratorCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationEnable"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationEnable = (bool?) content.GetValueForProperty("ConfigurationEnable",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationDisableBackupLocationForFutureBackups"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationDisableBackupLocationForFutureBackups = (bool?) content.GetValueForProperty("ConfigurationDisableBackupLocationForFutureBackups",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationDisableBackupLocationForFutureBackups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationPrepareForRetirement"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationPrepareForRetirement = (bool?) content.GetValueForProperty("ConfigurationPrepareForRetirement",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationPrepareForRetirement, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StorageAcceleratorCredentialsId"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsId = (long?) content.GetValueForProperty("StorageAcceleratorCredentialsId",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageAcceleratorCredentialsName"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsName = (string) content.GetValueForProperty("StorageAcceleratorCredentialsName",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).Configuration = (Commvault.Powershell.Models.ICloudBucketConfiguration) content.GetValueForProperty("Configuration",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).Configuration, Commvault.Powershell.Models.CloudBucketConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MediaAgentId"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentId = (long?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MediaAgentName"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.HpeCatalystBucketContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HpeCatalystBucketContent(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MediaAgent"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgent = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MediaAgent",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgent, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloudType"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).CloudType = (string) content.GetValueForProperty("CloudType",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).CloudType, global::System.Convert.ToString);
            }
            if (content.Contains("StoreOnceHost"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).StoreOnceHost = (string) content.GetValueForProperty("StoreOnceHost",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).StoreOnceHost, global::System.Convert.ToString);
            }
            if (content.Contains("Store"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Store = (string) content.GetValueForProperty("Store",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Store, global::System.Convert.ToString);
            }
            if (content.Contains("Username"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Username = (string) content.GetValueForProperty("Username",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Username, global::System.Convert.ToString);
            }
            if (content.Contains("Password"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Password = (System.Security.SecureString) content.GetValueForProperty("Password",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).Password, (object ss) => (System.Security.SecureString)ss);
            }
            if (content.Contains("Access"))
            {
                ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Access = (string) content.GetValueForProperty("Access",((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Access, global::System.Convert.ToString);
            }
            if (content.Contains("Enable"))
            {
                ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Enable = (bool?) content.GetValueForProperty("Enable",((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)this).Enable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationStorageAcceleratorCredentials"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationStorageAcceleratorCredentials = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ConfigurationStorageAcceleratorCredentials",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationStorageAcceleratorCredentials, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationEnable"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationEnable = (bool?) content.GetValueForProperty("ConfigurationEnable",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationDisableBackupLocationForFutureBackups"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationDisableBackupLocationForFutureBackups = (bool?) content.GetValueForProperty("ConfigurationDisableBackupLocationForFutureBackups",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationDisableBackupLocationForFutureBackups, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConfigurationPrepareForRetirement"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationPrepareForRetirement = (bool?) content.GetValueForProperty("ConfigurationPrepareForRetirement",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).ConfigurationPrepareForRetirement, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StorageAcceleratorCredentialsId"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsId = (long?) content.GetValueForProperty("StorageAcceleratorCredentialsId",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageAcceleratorCredentialsName"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsName = (string) content.GetValueForProperty("StorageAcceleratorCredentialsName",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).StorageAcceleratorCredentialsName, global::System.Convert.ToString);
            }
            if (content.Contains("Configuration"))
            {
                ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).Configuration = (Commvault.Powershell.Models.ICloudBucketConfiguration) content.GetValueForProperty("Configuration",((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)this).Configuration, Commvault.Powershell.Models.CloudBucketConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("MediaAgentId"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentId = (long?) content.GetValueForProperty("MediaAgentId",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MediaAgentName"))
            {
                ((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentName = (string) content.GetValueForProperty("MediaAgentName",((Commvault.Powershell.Models.IHpeCatalystBucketContentInternal)this).MediaAgentName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

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
    /// HPE Catalyst Storage
    [System.ComponentModel.TypeConverter(typeof(HpeCatalystBucketContentTypeConverter))]
    public partial interface IHpeCatalystBucketContent

    {

    }
}