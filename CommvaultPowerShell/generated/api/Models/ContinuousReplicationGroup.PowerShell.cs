// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Replication group details pertaining to a continuous replication group</summary>
    [System.ComponentModel.TypeConverter(typeof(ContinuousReplicationGroupTypeConverter))]
    public partial class ContinuousReplicationGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ContinuousReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ContinuousReplicationGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Summary"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).Summary = (Commvault.Powershell.Models.IReplicationGroupSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).Summary, Commvault.Powershell.Models.ReplicationGroupSummaryTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryOptions"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptions = (Commvault.Powershell.Models.IRecoveryOptions) content.GetValueForProperty("RecoveryOptions",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptions, Commvault.Powershell.Models.RecoveryOptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplicationConfiguration"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).ReplicationConfiguration = (System.Collections.Generic.List<Commvault.Powershell.Models.IReplicationConfigurationVMware>) content.GetValueForProperty("ReplicationConfiguration",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).ReplicationConfiguration, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IReplicationConfigurationVMware>(__y, Commvault.Powershell.Models.ReplicationConfigurationVMwareTypeConverter.ConvertFrom));
            }
            if (content.Contains("SummaryDestinationVendor"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryDestinationVendor = (string) content.GetValueForProperty("SummaryDestinationVendor",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryDestinationVendor, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryReplicationType"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryReplicationType = (string) content.GetValueForProperty("SummaryReplicationType",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryReplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionRecoveryType"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryType = (string) content.GetValueForProperty("RecoveryOptionRecoveryType",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SummarySource"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummarySource = (string) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummarySource, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryRecoveryTarget"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryRecoveryTarget = (string) content.GetValueForProperty("SummaryRecoveryTarget",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryRecoveryTarget, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryState"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryState = (string) content.GetValueForProperty("SummaryState",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryState, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionRecoveryPointStore"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointStore = (string) content.GetValueForProperty("RecoveryOptionRecoveryPointStore",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointStore, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionCrashConsistentRpInterval"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionCrashConsistentRpInterval = (long?) content.GetValueForProperty("RecoveryOptionCrashConsistentRpInterval",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionCrashConsistentRpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionMergeRecoveryPointsOlderThan"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan = (long?) content.GetValueForProperty("RecoveryOptionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionRetainRecoveryPointsFor"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRetainRecoveryPointsFor = (long?) content.GetValueForProperty("RecoveryOptionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRetainRecoveryPointsFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionRecoveryPointInterval"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointInterval = (long?) content.GetValueForProperty("RecoveryOptionRecoveryPointInterval",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionPruneAndMergeRecoveryPoints"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionPruneAndMergeRecoveryPoints = (bool?) content.GetValueForProperty("RecoveryOptionPruneAndMergeRecoveryPoints",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionPruneAndMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ContinuousReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ContinuousReplicationGroup(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Summary"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).Summary = (Commvault.Powershell.Models.IReplicationGroupSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).Summary, Commvault.Powershell.Models.ReplicationGroupSummaryTypeConverter.ConvertFrom);
            }
            if (content.Contains("RecoveryOptions"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptions = (Commvault.Powershell.Models.IRecoveryOptions) content.GetValueForProperty("RecoveryOptions",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptions, Commvault.Powershell.Models.RecoveryOptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReplicationConfiguration"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).ReplicationConfiguration = (System.Collections.Generic.List<Commvault.Powershell.Models.IReplicationConfigurationVMware>) content.GetValueForProperty("ReplicationConfiguration",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).ReplicationConfiguration, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IReplicationConfigurationVMware>(__y, Commvault.Powershell.Models.ReplicationConfigurationVMwareTypeConverter.ConvertFrom));
            }
            if (content.Contains("SummaryDestinationVendor"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryDestinationVendor = (string) content.GetValueForProperty("SummaryDestinationVendor",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryDestinationVendor, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryReplicationType"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryReplicationType = (string) content.GetValueForProperty("SummaryReplicationType",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryReplicationType, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionRecoveryType"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryType = (string) content.GetValueForProperty("RecoveryOptionRecoveryType",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryType, global::System.Convert.ToString);
            }
            if (content.Contains("SummarySource"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummarySource = (string) content.GetValueForProperty("SummarySource",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummarySource, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryRecoveryTarget"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryRecoveryTarget = (string) content.GetValueForProperty("SummaryRecoveryTarget",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryRecoveryTarget, global::System.Convert.ToString);
            }
            if (content.Contains("SummaryState"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryState = (string) content.GetValueForProperty("SummaryState",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).SummaryState, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionRecoveryPointStore"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointStore = (string) content.GetValueForProperty("RecoveryOptionRecoveryPointStore",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointStore, global::System.Convert.ToString);
            }
            if (content.Contains("RecoveryOptionCrashConsistentRpInterval"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionCrashConsistentRpInterval = (long?) content.GetValueForProperty("RecoveryOptionCrashConsistentRpInterval",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionCrashConsistentRpInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionMergeRecoveryPointsOlderThan"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan = (long?) content.GetValueForProperty("RecoveryOptionMergeRecoveryPointsOlderThan",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionMergeRecoveryPointsOlderThan, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionRetainRecoveryPointsFor"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRetainRecoveryPointsFor = (long?) content.GetValueForProperty("RecoveryOptionRetainRecoveryPointsFor",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRetainRecoveryPointsFor, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionRecoveryPointInterval"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointInterval = (long?) content.GetValueForProperty("RecoveryOptionRecoveryPointInterval",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionRecoveryPointInterval, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("RecoveryOptionPruneAndMergeRecoveryPoints"))
            {
                ((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionPruneAndMergeRecoveryPoints = (bool?) content.GetValueForProperty("RecoveryOptionPruneAndMergeRecoveryPoints",((Commvault.Powershell.Models.IContinuousReplicationGroupInternal)this).RecoveryOptionPruneAndMergeRecoveryPoints, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ContinuousReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IContinuousReplicationGroup" />.
        /// </returns>
        public static Commvault.Powershell.Models.IContinuousReplicationGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ContinuousReplicationGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ContinuousReplicationGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IContinuousReplicationGroup" />.
        /// </returns>
        public static Commvault.Powershell.Models.IContinuousReplicationGroup DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ContinuousReplicationGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ContinuousReplicationGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ContinuousReplicationGroup" /> model class.</returns>
        public static Commvault.Powershell.Models.IContinuousReplicationGroup FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Replication group details pertaining to a continuous replication group
    [System.ComponentModel.TypeConverter(typeof(ContinuousReplicationGroupTypeConverter))]
    public partial interface IContinuousReplicationGroup

    {

    }
}