// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(CreatePlanBackupDestinationTypeConverter))]
    public partial class CreatePlanBackupDestination
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreatePlanBackupDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreatePlanBackupDestination(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePool = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StoragePool",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePool, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Region = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Region",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Region, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopy = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopy, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRules = (Commvault.Powershell.Models.IExtendedRetentionRules) content.GetValueForProperty("ExtendedRetentionRules",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRules, Commvault.Powershell.Models.ExtendedRetentionRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupDestinationName = (string) content.GetValueForProperty("BackupDestinationName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupDestinationName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).NetAppCloudTarget = (bool?) content.GetValueForProperty("NetAppCloudTarget",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).NetAppCloudTarget, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsSnapCopy = (bool?) content.GetValueForProperty("IsSnapCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsSnapCopy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsMirrorCopy = (bool?) content.GetValueForProperty("IsMirrorCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsMirrorCopy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupsToCopy = (string) content.GetValueForProperty("BackupsToCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupsToCopy, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupStartTime = (long?) content.GetValueForProperty("BackupStartTime",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).OptimizeForInstantClone = (bool?) content.GetValueForProperty("OptimizeForInstantClone",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).OptimizeForInstantClone, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionRuleType = (string) content.GetValueForProperty("RetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionPeriodDays = (long?) content.GetValueForProperty("RetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SnapRecoveryPoints = (long?) content.GetValueForProperty("SnapRecoveryPoints",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SnapRecoveryPoints, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).UseExtendedRetentionRules = (bool?) content.GetValueForProperty("UseExtendedRetentionRules",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).UseExtendedRetentionRules, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Mappings = (Commvault.Powershell.Models.ISnapshotCopyMapping[]) content.GetValueForProperty("Mappings",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Mappings, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISnapshotCopyMapping>(__y, Commvault.Powershell.Models.SnapshotCopyMappingTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolId = (long?) content.GetValueForProperty("StoragePoolId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolName = (string) content.GetValueForProperty("StoragePoolName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionId = (long?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionName = (string) content.GetValueForProperty("RegionName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyId = (long?) content.GetValueForProperty("SourceCopyId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyName = (string) content.GetValueForProperty("SourceCopyName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleFirstExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleFirstExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleFirstExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleSecondExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleSecondExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleSecondExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleThirdExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleThirdExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleThirdExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("FirstExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("FirstExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleType = (string) content.GetValueForProperty("FirstExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("SecondExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("SecondExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleType = (string) content.GetValueForProperty("SecondExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("ThirdExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("ThirdExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleType = (string) content.GetValueForProperty("ThirdExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreatePlanBackupDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreatePlanBackupDestination(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePool = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("StoragePool",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePool, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Region = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Region",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Region, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopy = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SourceCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopy, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRules = (Commvault.Powershell.Models.IExtendedRetentionRules) content.GetValueForProperty("ExtendedRetentionRules",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRules, Commvault.Powershell.Models.ExtendedRetentionRulesTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupDestinationName = (string) content.GetValueForProperty("BackupDestinationName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupDestinationName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).NetAppCloudTarget = (bool?) content.GetValueForProperty("NetAppCloudTarget",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).NetAppCloudTarget, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsSnapCopy = (bool?) content.GetValueForProperty("IsSnapCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsSnapCopy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsMirrorCopy = (bool?) content.GetValueForProperty("IsMirrorCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).IsMirrorCopy, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupsToCopy = (string) content.GetValueForProperty("BackupsToCopy",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupsToCopy, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupStartTime = (long?) content.GetValueForProperty("BackupStartTime",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).BackupStartTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).OptimizeForInstantClone = (bool?) content.GetValueForProperty("OptimizeForInstantClone",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).OptimizeForInstantClone, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionRuleType = (string) content.GetValueForProperty("RetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionPeriodDays = (long?) content.GetValueForProperty("RetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SnapRecoveryPoints = (long?) content.GetValueForProperty("SnapRecoveryPoints",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SnapRecoveryPoints, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).UseExtendedRetentionRules = (bool?) content.GetValueForProperty("UseExtendedRetentionRules",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).UseExtendedRetentionRules, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Mappings = (Commvault.Powershell.Models.ISnapshotCopyMapping[]) content.GetValueForProperty("Mappings",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).Mappings, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISnapshotCopyMapping>(__y, Commvault.Powershell.Models.SnapshotCopyMappingTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolId = (long?) content.GetValueForProperty("StoragePoolId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolName = (string) content.GetValueForProperty("StoragePoolName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).StoragePoolName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionId = (long?) content.GetValueForProperty("RegionId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionName = (string) content.GetValueForProperty("RegionName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).RegionName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyId = (long?) content.GetValueForProperty("SourceCopyId",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyName = (string) content.GetValueForProperty("SourceCopyName",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SourceCopyName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleFirstExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleFirstExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleFirstExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleSecondExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleSecondExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleSecondExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleThirdExtendedRetentionRule = (Commvault.Powershell.Models.IPlanRetentionRule) content.GetValueForProperty("ExtendedRetentionRuleThirdExtendedRetentionRule",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ExtendedRetentionRuleThirdExtendedRetentionRule, Commvault.Powershell.Models.PlanRetentionRuleTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("FirstExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("FirstExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleType = (string) content.GetValueForProperty("FirstExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).FirstExtendedRetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("SecondExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("SecondExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleType = (string) content.GetValueForProperty("SecondExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).SecondExtendedRetentionRuleType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleIsInfiniteRetention = (bool?) content.GetValueForProperty("ThirdExtendedRetentionRuleIsInfiniteRetention",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleIsInfiniteRetention, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleRetentionPeriodDays = (long?) content.GetValueForProperty("ThirdExtendedRetentionRuleRetentionPeriodDays",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleRetentionPeriodDays, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleType = (string) content.GetValueForProperty("ThirdExtendedRetentionRuleType",((Commvault.Powershell.Models.ICreatePlanBackupDestinationInternal)this).ThirdExtendedRetentionRuleType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreatePlanBackupDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreatePlanBackupDestination" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreatePlanBackupDestination DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreatePlanBackupDestination(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreatePlanBackupDestination"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.ICreatePlanBackupDestination" />.
        /// </returns>
        public static Commvault.Powershell.Models.ICreatePlanBackupDestination DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreatePlanBackupDestination(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreatePlanBackupDestination" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreatePlanBackupDestination FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(CreatePlanBackupDestinationTypeConverter))]
    public partial interface ICreatePlanBackupDestination

    {

    }
}