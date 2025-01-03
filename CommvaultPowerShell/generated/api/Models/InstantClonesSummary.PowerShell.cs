// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// Source Client - The server where the database was backed up from. Source instance - The backed up database instance. Mounted
    /// host - The server where the DB snapshot has been mounted to bring up the clone. Target instance - The DB instance name
    /// which was clone target.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(InstantClonesSummaryTypeConverter))]
    public partial class InstantClonesSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.InstantClonesSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IInstantClonesSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IInstantClonesSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InstantClonesSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.InstantClonesSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IInstantClonesSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IInstantClonesSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InstantClonesSummary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InstantClonesSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InstantClonesSummary" /> model class.</returns>
        public static Commvault.Powershell.Models.IInstantClonesSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.InstantClonesSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InstantClonesSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceClient"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClient = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceClient",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClient, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceInstance"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceInstance",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("MountedHost"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHost = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MountedHost",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHost, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetInstance"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TargetInstance",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Commcell"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloneJobId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CloneJobId = (long?) content.GetValueForProperty("CloneJobId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CloneJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SqlRecoveryId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SqlRecoveryId = (long?) content.GetValueForProperty("SqlRecoveryId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SqlRecoveryId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DatabaseAsOfTime"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).DatabaseAsOfTime = (long?) content.GetValueForProperty("DatabaseAsOfTime",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).DatabaseAsOfTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreationTime"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CreationTime = (long?) content.GetValueForProperty("CreationTime",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CreationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExpirationDate"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).ExpirationDate = (long?) content.GetValueForProperty("ExpirationDate",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).ExpirationDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("SourceClientId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientId = (long?) content.GetValueForProperty("SourceClientId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceClientName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientName = (string) content.GetValueForProperty("SourceClientName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceInstanceId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceId = (long?) content.GetValueForProperty("SourceInstanceId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceInstanceName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceName = (string) content.GetValueForProperty("SourceInstanceName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("MountedHostId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostId = (long?) content.GetValueForProperty("MountedHostId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MountedHostName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostName = (string) content.GetValueForProperty("MountedHostName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInstanceId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceId = (long?) content.GetValueForProperty("TargetInstanceId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TargetInstanceName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceName = (string) content.GetValueForProperty("TargetInstanceName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("CommcellName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CommcellName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.InstantClonesSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InstantClonesSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceClient"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClient = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceClient",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClient, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceInstance"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceInstance",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("MountedHost"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHost = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("MountedHost",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHost, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetInstance"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("TargetInstance",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Commcell"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Commcell = (Commvault.Powershell.Models.ICommcellInfo) content.GetValueForProperty("Commcell",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Commcell, Commvault.Powershell.Models.CommcellInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("CloneJobId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CloneJobId = (long?) content.GetValueForProperty("CloneJobId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CloneJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SqlRecoveryId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SqlRecoveryId = (long?) content.GetValueForProperty("SqlRecoveryId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SqlRecoveryId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("DatabaseAsOfTime"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).DatabaseAsOfTime = (long?) content.GetValueForProperty("DatabaseAsOfTime",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).DatabaseAsOfTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CreationTime"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CreationTime = (long?) content.GetValueForProperty("CreationTime",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CreationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExpirationDate"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).ExpirationDate = (long?) content.GetValueForProperty("ExpirationDate",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).ExpirationDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("SourceClientId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientId = (long?) content.GetValueForProperty("SourceClientId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceClientName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientName = (string) content.GetValueForProperty("SourceClientName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceClientName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceInstanceId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceId = (long?) content.GetValueForProperty("SourceInstanceId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceInstanceName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceName = (string) content.GetValueForProperty("SourceInstanceName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).SourceInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("MountedHostId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostId = (long?) content.GetValueForProperty("MountedHostId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MountedHostName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostName = (string) content.GetValueForProperty("MountedHostName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).MountedHostName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetInstanceId"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceId = (long?) content.GetValueForProperty("TargetInstanceId",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("TargetInstanceName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceName = (string) content.GetValueForProperty("TargetInstanceName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).TargetInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("CommcellName"))
            {
                ((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IInstantClonesSummaryInternal)this).CommcellName, global::System.Convert.ToString);
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
    /// Source Client - The server where the database was backed up from. Source instance - The backed up database instance. Mounted
    /// host - The server where the DB snapshot has been mounted to bring up the clone. Target instance - The DB instance name
    /// which was clone target.
    [System.ComponentModel.TypeConverter(typeof(InstantClonesSummaryTypeConverter))]
    public partial interface IInstantClonesSummary

    {

    }
}