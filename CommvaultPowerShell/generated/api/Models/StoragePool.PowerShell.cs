// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>StoragePool</summary>
    [System.ComponentModel.TypeConverter(typeof(StoragePoolTypeConverter))]
    public partial class StoragePool
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.StoragePool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IStoragePool" />.</returns>
        public static Commvault.Powershell.Models.IStoragePool DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new StoragePool(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.StoragePool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IStoragePool" />.</returns>
        public static Commvault.Powershell.Models.IStoragePool DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new StoragePool(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="StoragePool" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="StoragePool" /> model class.</returns>
        public static Commvault.Powershell.Models.IStoragePool FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.StoragePool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal StoragePool(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceType"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceType = (Commvault.Powershell.Models.IDeviceType) content.GetValueForProperty("DeviceType",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceType, Commvault.Powershell.Models.DeviceTypeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Region"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Region = (Commvault.Powershell.Models.IIdNameDisplayName) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IStoragePoolInternal)this).Region, Commvault.Powershell.Models.IdNameDisplayNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IStoragePoolInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IStoragePoolInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IStoragePoolInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPeriodDays"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RetentionPeriodDays = (long?) content.GetValueForProperty("RetentionPeriodDays",((Commvault.Powershell.Models.IStoragePoolInternal)this).RetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WormStoragePoolFlag"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).WormStoragePoolFlag = (long?) content.GetValueForProperty("WormStoragePoolFlag",((Commvault.Powershell.Models.IStoragePoolInternal)this).WormStoragePoolFlag, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageClass"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).StorageClass = (string) content.GetValueForProperty("StorageClass",((Commvault.Powershell.Models.IStoragePoolInternal)this).StorageClass, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchiveStorage"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).IsArchiveStorage = (bool?) content.GetValueForProperty("IsArchiveStorage",((Commvault.Powershell.Models.IStoragePoolInternal)this).IsArchiveStorage, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeviceTypeId"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeId = (long?) content.GetValueForProperty("DeviceTypeId",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeviceTypeName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeName = (string) content.GetValueForProperty("DeviceTypeName",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionId"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionId = (long?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RegionName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionName = (string) content.GetValueForProperty("RegionName",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionDisplayName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionDisplayName = (string) content.GetValueForProperty("RegionDisplayName",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionDisplayName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.StoragePool"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal StoragePool(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("DeviceType"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceType = (Commvault.Powershell.Models.IDeviceType) content.GetValueForProperty("DeviceType",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceType, Commvault.Powershell.Models.DeviceTypeTypeConverter.ConvertFrom);
            }
            if (content.Contains("Region"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Region = (Commvault.Powershell.Models.IIdNameDisplayName) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IStoragePoolInternal)this).Region, Commvault.Powershell.Models.IdNameDisplayNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IStoragePoolInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IStoragePoolInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IStoragePoolInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("RetentionPeriodDays"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RetentionPeriodDays = (long?) content.GetValueForProperty("RetentionPeriodDays",((Commvault.Powershell.Models.IStoragePoolInternal)this).RetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("WormStoragePoolFlag"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).WormStoragePoolFlag = (long?) content.GetValueForProperty("WormStoragePoolFlag",((Commvault.Powershell.Models.IStoragePoolInternal)this).WormStoragePoolFlag, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageClass"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).StorageClass = (string) content.GetValueForProperty("StorageClass",((Commvault.Powershell.Models.IStoragePoolInternal)this).StorageClass, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchiveStorage"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).IsArchiveStorage = (bool?) content.GetValueForProperty("IsArchiveStorage",((Commvault.Powershell.Models.IStoragePoolInternal)this).IsArchiveStorage, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DeviceTypeId"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeId = (long?) content.GetValueForProperty("DeviceTypeId",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DeviceTypeName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeName = (string) content.GetValueForProperty("DeviceTypeName",((Commvault.Powershell.Models.IStoragePoolInternal)this).DeviceTypeName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionId"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionId = (long?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RegionName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionName = (string) content.GetValueForProperty("RegionName",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionName, global::System.Convert.ToString);
            }
            if (content.Contains("RegionDisplayName"))
            {
                ((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionDisplayName = (string) content.GetValueForProperty("RegionDisplayName",((Commvault.Powershell.Models.IStoragePoolInternal)this).RegionDisplayName, global::System.Convert.ToString);
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
    /// StoragePool
    [System.ComponentModel.TypeConverter(typeof(StoragePoolTypeConverter))]
    public partial interface IStoragePool

    {

    }
}