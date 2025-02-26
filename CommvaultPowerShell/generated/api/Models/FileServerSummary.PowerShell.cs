// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>This returns the file server summary.</summary>
    [System.ComponentModel.TypeConverter(typeof(FileServerSummaryTypeConverter))]
    public partial class FileServerSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.FileServerSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IFileServerSummary" />.</returns>
        public static Commvault.Powershell.Models.IFileServerSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new FileServerSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.FileServerSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IFileServerSummary" />.</returns>
        public static Commvault.Powershell.Models.IFileServerSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new FileServerSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.FileServerSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal FileServerSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastBackup"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackupJobInfoWithLastSuccessfulBackup) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupJobInfoWithLastSuccessfulBackupTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sla"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Sla = (Commvault.Powershell.Models.ISlaDetailsWithReasonEntity) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Sla, Commvault.Powershell.Models.SlaDetailsWithReasonEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Guid"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Guid = (string) content.GetValueForProperty("Guid",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Guid, global::System.Convert.ToString);
            }
            if (content.Contains("Configured"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Configured = (bool?) content.GetValueForProperty("Configured",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Configured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CommcellName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CommcellName, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationSize"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).ApplicationSize = (long?) content.GetValueForProperty("ApplicationSize",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).ApplicationSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Tags"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Tags = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameValue>) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Tags, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastBackupJobId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupJobId = (long?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupTime"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupTime = (long?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupFailureReason"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupLastSuccessfulBackup"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupLastSuccessfulBackup = (long?) content.GetValueForProperty("LastBackupLastSuccessfulBackup",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupLastSuccessfulBackup, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("SlaStatus"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaStatus, global::System.Convert.ToString);
            }
            if (content.Contains("SlaReason"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReason, global::System.Convert.ToString);
            }
            if (content.Contains("SlaReasonList"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReasonList = (System.Collections.Generic.List<Commvault.Powershell.Models.IReasonDetails>) content.GetValueForProperty("SlaReasonList",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReasonList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IReasonDetails>(__y, Commvault.Powershell.Models.ReasonDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.FileServerSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal FileServerSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LastBackup"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackupJobInfoWithLastSuccessfulBackup) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupJobInfoWithLastSuccessfulBackupTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Sla"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Sla = (Commvault.Powershell.Models.ISlaDetailsWithReasonEntity) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Sla, Commvault.Powershell.Models.SlaDetailsWithReasonEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Company = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Company, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("Guid"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Guid = (string) content.GetValueForProperty("Guid",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Guid, global::System.Convert.ToString);
            }
            if (content.Contains("Configured"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Configured = (bool?) content.GetValueForProperty("Configured",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Configured, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CommcellName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CommcellName = (string) content.GetValueForProperty("CommcellName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CommcellName, global::System.Convert.ToString);
            }
            if (content.Contains("ApplicationSize"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).ApplicationSize = (long?) content.GetValueForProperty("ApplicationSize",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).ApplicationSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("Tags"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Tags = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdNameValue>) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).Tags, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            }
            if (content.Contains("LastBackupJobId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupJobId = (long?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupTime"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupTime = (long?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupFailureReason"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupLastSuccessfulBackup"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupLastSuccessfulBackup = (long?) content.GetValueForProperty("LastBackupLastSuccessfulBackup",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).LastBackupLastSuccessfulBackup, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("SlaStatus"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaStatus = (string) content.GetValueForProperty("SlaStatus",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaStatus, global::System.Convert.ToString);
            }
            if (content.Contains("SlaReason"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReason = (string) content.GetValueForProperty("SlaReason",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReason, global::System.Convert.ToString);
            }
            if (content.Contains("SlaReasonList"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReasonList = (System.Collections.Generic.List<Commvault.Powershell.Models.IReasonDetails>) content.GetValueForProperty("SlaReasonList",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).SlaReasonList, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IReasonDetails>(__y, Commvault.Powershell.Models.ReasonDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IFileServerSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="FileServerSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="FileServerSummary" /> model class.</returns>
        public static Commvault.Powershell.Models.IFileServerSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// This returns the file server summary.
    [System.ComponentModel.TypeConverter(typeof(FileServerSummaryTypeConverter))]
    public partial interface IFileServerSummary

    {

    }
}