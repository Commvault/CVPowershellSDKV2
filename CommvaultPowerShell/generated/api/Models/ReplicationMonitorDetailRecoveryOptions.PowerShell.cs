// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Gives information about the recovery options for replication group</summary>
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailRecoveryOptionsTypeConverter))]
    public partial class ReplicationMonitorDetailRecoveryOptions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ReplicationMonitorDetailRecoveryOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions" />.
        /// </returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ReplicationMonitorDetailRecoveryOptions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ReplicationMonitorDetailRecoveryOptions" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptions FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ReplicationMonitorDetailRecoveryOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoverypointStore",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).CcrpInterval = (long?) content.GetValueForProperty("CcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).CcrpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan = (long?) content.GetValueForProperty("MergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RetainRecoveryPointsFor = (long?) content.GetValueForProperty("RetainRecoveryPointsFor",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RetainRecoveryPointsFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RpIntervalAfterRetention = (long?) content.GetValueForProperty("RpIntervalAfterRetention",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RpIntervalAfterRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).PruneAndMergeOffPeakOnly = (bool?) content.GetValueForProperty("PruneAndMergeOffPeakOnly",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).PruneAndMergeOffPeakOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).AcrpInterval = (long?) content.GetValueForProperty("AcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).AcrpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).SwitchToLatestIfStoreOfflineFor = (long?) content.GetValueForProperty("SwitchToLatestIfStoreOfflineFor",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).SwitchToLatestIfStoreOfflineFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreId = (long?) content.GetValueForProperty("RecoverypointStoreId",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreName = (string) content.GetValueForProperty("RecoverypointStoreName",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ReplicationMonitorDetailRecoveryOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ReplicationMonitorDetailRecoveryOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStore = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("RecoverypointStore",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStore, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).CcrpInterval = (long?) content.GetValueForProperty("CcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).CcrpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan = (long?) content.GetValueForProperty("MergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).MergeRecoveryPointsOlderThan, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RetainRecoveryPointsFor = (long?) content.GetValueForProperty("RetainRecoveryPointsFor",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RetainRecoveryPointsFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RpIntervalAfterRetention = (long?) content.GetValueForProperty("RpIntervalAfterRetention",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RpIntervalAfterRetention, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).PruneAndMergeOffPeakOnly = (bool?) content.GetValueForProperty("PruneAndMergeOffPeakOnly",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).PruneAndMergeOffPeakOnly, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).AcrpInterval = (long?) content.GetValueForProperty("AcrpInterval",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).AcrpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).SwitchToLatestIfStoreOfflineFor = (long?) content.GetValueForProperty("SwitchToLatestIfStoreOfflineFor",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).SwitchToLatestIfStoreOfflineFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreId = (long?) content.GetValueForProperty("RecoverypointStoreId",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreName = (string) content.GetValueForProperty("RecoverypointStoreName",((Commvault.Powershell.Models.IReplicationMonitorDetailRecoveryOptionsInternal)this).RecoverypointStoreName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Gives information about the recovery options for replication group
    [System.ComponentModel.TypeConverter(typeof(ReplicationMonitorDetailRecoveryOptionsTypeConverter))]
    public partial interface IReplicationMonitorDetailRecoveryOptions

    {

    }
}