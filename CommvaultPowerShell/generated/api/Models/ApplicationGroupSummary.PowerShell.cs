// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(ApplicationGroupSummaryTypeConverter))]
    public partial class ApplicationGroupSummary
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.ApplicationGroupSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationGroupSummary(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationGroup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ApplicationGroup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Cluster"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Cluster = (Commvault.Powershell.Models.IIdNameDisplayName) content.GetValueForProperty("Cluster",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Cluster, Commvault.Powershell.Models.IdNameDisplayNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Instance"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastBackup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackupJobInfo) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupJobInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Company = (Commvault.Powershell.Models.ICompanyInfo) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Company, Commvault.Powershell.Models.CompanyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterType"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterType = (string) content.GetValueForProperty("ClusterType",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterType, global::System.Convert.ToString);
            }
            if (content.Contains("IsDefaultApplicationGroup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IsDefaultApplicationGroup = (bool?) content.GetValueForProperty("IsDefaultApplicationGroup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IsDefaultApplicationGroup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StoragePolicyRetentionExtension"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).StoragePolicyRetentionExtension = (bool?) content.GetValueForProperty("StoragePolicyRetentionExtension",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).StoragePolicyRetentionExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IndexingStatus"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IndexingStatus = (string) content.GetValueForProperty("IndexingStatus",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IndexingStatus, global::System.Convert.ToString);
            }
            if (content.Contains("SnapBackupEnabled"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).SnapBackupEnabled = (bool?) content.GetValueForProperty("SnapBackupEnabled",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).SnapBackupEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationGroupId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupId = (long?) content.GetValueForProperty("ApplicationGroupId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationGroupName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupName = (string) content.GetValueForProperty("ApplicationGroupName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterId = (long?) content.GetValueForProperty("ClusterId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ClusterName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterDisplayName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterDisplayName = (string) content.GetValueForProperty("ClusterDisplayName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceId = (long?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InstanceName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupJobId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupJobId = (long?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupTime"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupTime = (long?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupFailureReason"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyMultiCommcellId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyMultiCommcellId = (long?) content.GetValueForProperty("CompanyMultiCommcellId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyMultiCommcellId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.ApplicationGroupSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationGroupSummary(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ApplicationGroup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("ApplicationGroup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Cluster"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Cluster = (Commvault.Powershell.Models.IIdNameDisplayName) content.GetValueForProperty("Cluster",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Cluster, Commvault.Powershell.Models.IdNameDisplayNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Instance"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Instance = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Instance",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Instance, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("LastBackup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackup = (Commvault.Powershell.Models.ILastBackupJobInfo) content.GetValueForProperty("LastBackup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackup, Commvault.Powershell.Models.LastBackupJobInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Company"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Company = (Commvault.Powershell.Models.ICompanyInfo) content.GetValueForProperty("Company",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Company, Commvault.Powershell.Models.CompanyInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Status"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Status = (string) content.GetValueForProperty("Status",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).Status, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterType"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterType = (string) content.GetValueForProperty("ClusterType",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterType, global::System.Convert.ToString);
            }
            if (content.Contains("IsDefaultApplicationGroup"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IsDefaultApplicationGroup = (bool?) content.GetValueForProperty("IsDefaultApplicationGroup",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IsDefaultApplicationGroup, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("StoragePolicyRetentionExtension"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).StoragePolicyRetentionExtension = (bool?) content.GetValueForProperty("StoragePolicyRetentionExtension",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).StoragePolicyRetentionExtension, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IndexingStatus"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IndexingStatus = (string) content.GetValueForProperty("IndexingStatus",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).IndexingStatus, global::System.Convert.ToString);
            }
            if (content.Contains("SnapBackupEnabled"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).SnapBackupEnabled = (bool?) content.GetValueForProperty("SnapBackupEnabled",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).SnapBackupEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ApplicationGroupId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupId = (long?) content.GetValueForProperty("ApplicationGroupId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ApplicationGroupName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupName = (string) content.GetValueForProperty("ApplicationGroupName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ApplicationGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterId = (long?) content.GetValueForProperty("ClusterId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ClusterName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterName, global::System.Convert.ToString);
            }
            if (content.Contains("ClusterDisplayName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterDisplayName = (string) content.GetValueForProperty("ClusterDisplayName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).ClusterDisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceId = (long?) content.GetValueForProperty("InstanceId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InstanceName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceName = (string) content.GetValueForProperty("InstanceName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).InstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupJobId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupJobId = (long?) content.GetValueForProperty("LastBackupJobId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupStatus"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupStatus = (string) content.GetValueForProperty("LastBackupStatus",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupStatus, global::System.Convert.ToString);
            }
            if (content.Contains("LastBackupTime"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupTime = (long?) content.GetValueForProperty("LastBackupTime",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LastBackupFailureReason"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupFailureReason = (string) content.GetValueForProperty("LastBackupFailureReason",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).LastBackupFailureReason, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("CompanyName"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyName, global::System.Convert.ToString);
            }
            if (content.Contains("CompanyMultiCommcellId"))
            {
                ((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyMultiCommcellId = (long?) content.GetValueForProperty("CompanyMultiCommcellId",((Commvault.Powershell.Models.IApplicationGroupSummaryInternal)this).CompanyMultiCommcellId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.ApplicationGroupSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IApplicationGroupSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IApplicationGroupSummary DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationGroupSummary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.ApplicationGroupSummary"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IApplicationGroupSummary" />.
        /// </returns>
        public static Commvault.Powershell.Models.IApplicationGroupSummary DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationGroupSummary(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationGroupSummary" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ApplicationGroupSummary" /> model class.</returns>
        public static Commvault.Powershell.Models.IApplicationGroupSummary FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    [System.ComponentModel.TypeConverter(typeof(ApplicationGroupSummaryTypeConverter))]
    public partial interface IApplicationGroupSummary

    {

    }
}