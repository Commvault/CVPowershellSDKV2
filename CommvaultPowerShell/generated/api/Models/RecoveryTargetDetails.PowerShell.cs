// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Recovery target info</summary>
    [System.ComponentModel.TypeConverter(typeof(RecoveryTargetDetailsTypeConverter))]
    public partial class RecoveryTargetDetails
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryTargetDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryTargetDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryTargetDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new RecoveryTargetDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.RecoveryTargetDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IRecoveryTargetDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IRecoveryTargetDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new RecoveryTargetDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="RecoveryTargetDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IRecoveryTargetDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryTargetDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal RecoveryTargetDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("DestinationHypervisor",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNode = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("AccessNode",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNode, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayName = (Commvault.Powershell.Models.IVMDisplayName) content.GetValueForProperty("VMDisplayName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayName, Commvault.Powershell.Models.VMDisplayNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ApplicationType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Users = (Commvault.Powershell.Models.IIdNameGuid[]) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Users, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameGuid>(__y, Commvault.Powershell.Models.IdNameGuidTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHost = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("DestinationHost",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHost, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DataStore = (string[]) content.GetValueForProperty("DataStore",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DataStore, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Region = (string) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Region, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ResourcePoolPath = (string) content.GetValueForProperty("ResourcePoolPath",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ResourcePoolPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationNetwork = (string[]) content.GetValueForProperty("DestinationNetwork",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationNetwork, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AvailabilityZones = (string[]) content.GetValueForProperty("AvailabilityZones",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AvailabilityZones, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMInstanceTypes = (string[]) content.GetValueForProperty("VMInstanceTypes",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMInstanceTypes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).EncryptionKey = (string) content.GetValueForProperty("EncryptionKey",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).EncryptionKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VolumeType = (string) content.GetValueForProperty("VolumeType",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VolumeType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumCpuCores = (long?) content.GetValueForProperty("MaximumCpuCores",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumCpuCores, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).PublicIP = (bool?) content.GetValueForProperty("PublicIP",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).PublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).NumberOfVMS = (long?) content.GetValueForProperty("NumberOfVMS",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).NumberOfVMS, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ExpirationTime = (long?) content.GetValueForProperty("ExpirationTime",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ExpirationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumMemory = (string) content.GetValueForProperty("MaximumMemory",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumMemory, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).IsoPath = (string[]) content.GetValueForProperty("IsoPath",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).IsoPath, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ConfigureIsolatedNetwork = (bool?) content.GetValueForProperty("ConfigureIsolatedNetwork",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ConfigureIsolatedNetwork, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MigrateVM = (bool?) content.GetValueForProperty("MigrateVM",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MigrateVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorId = (long?) content.GetValueForProperty("DestinationHypervisorId",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorName = (string) content.GetValueForProperty("DestinationHypervisorName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeId = (long?) content.GetValueForProperty("AccessNodeId",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeName = (string) content.GetValueForProperty("AccessNodeName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNamePrefix = (string) content.GetValueForProperty("VMDisplayNamePrefix",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNamePrefix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNameSuffix = (string) content.GetValueForProperty("VMDisplayNameSuffix",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNameSuffix, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.RecoveryTargetDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal RecoveryTargetDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("DestinationHypervisor",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNode = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("AccessNode",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNode, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayName = (Commvault.Powershell.Models.IVMDisplayName) content.GetValueForProperty("VMDisplayName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayName, Commvault.Powershell.Models.VMDisplayNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ApplicationType = (string) content.GetValueForProperty("ApplicationType",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ApplicationType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Users = (Commvault.Powershell.Models.IIdNameGuid[]) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Users, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameGuid>(__y, Commvault.Powershell.Models.IdNameGuidTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHost = (Commvault.Powershell.Models.IIdName[]) content.GetValueForProperty("DestinationHost",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHost, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DataStore = (string[]) content.GetValueForProperty("DataStore",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DataStore, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Region = (string) content.GetValueForProperty("Region",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).Region, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ResourcePoolPath = (string) content.GetValueForProperty("ResourcePoolPath",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ResourcePoolPath, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationNetwork = (string[]) content.GetValueForProperty("DestinationNetwork",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationNetwork, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AvailabilityZones = (string[]) content.GetValueForProperty("AvailabilityZones",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AvailabilityZones, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMInstanceTypes = (string[]) content.GetValueForProperty("VMInstanceTypes",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMInstanceTypes, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).EncryptionKey = (string) content.GetValueForProperty("EncryptionKey",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).EncryptionKey, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VolumeType = (string) content.GetValueForProperty("VolumeType",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VolumeType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumCpuCores = (long?) content.GetValueForProperty("MaximumCpuCores",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumCpuCores, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).PublicIP = (bool?) content.GetValueForProperty("PublicIP",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).PublicIP, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).RestoreAsManagedVM = (bool?) content.GetValueForProperty("RestoreAsManagedVM",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).RestoreAsManagedVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).NumberOfVMS = (long?) content.GetValueForProperty("NumberOfVMS",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).NumberOfVMS, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ExpirationTime = (long?) content.GetValueForProperty("ExpirationTime",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ExpirationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumMemory = (string) content.GetValueForProperty("MaximumMemory",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MaximumMemory, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).IsoPath = (string[]) content.GetValueForProperty("IsoPath",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).IsoPath, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ConfigureIsolatedNetwork = (bool?) content.GetValueForProperty("ConfigureIsolatedNetwork",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).ConfigureIsolatedNetwork, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MigrateVM = (bool?) content.GetValueForProperty("MigrateVM",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).MigrateVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorId = (long?) content.GetValueForProperty("DestinationHypervisorId",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorName = (string) content.GetValueForProperty("DestinationHypervisorName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).DestinationHypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeId = (long?) content.GetValueForProperty("AccessNodeId",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeName = (string) content.GetValueForProperty("AccessNodeName",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).AccessNodeName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNamePrefix = (string) content.GetValueForProperty("VMDisplayNamePrefix",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNamePrefix, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNameSuffix = (string) content.GetValueForProperty("VMDisplayNameSuffix",((Commvault.Powershell.Models.IRecoveryTargetDetailsInternal)this).VMDisplayNameSuffix, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Recovery target info
    [System.ComponentModel.TypeConverter(typeof(RecoveryTargetDetailsTypeConverter))]
    public partial interface IRecoveryTargetDetails

    {

    }
}