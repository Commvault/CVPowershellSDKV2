// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>VirtualMachineDetails</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineDetailsTypeConverter))]
    public partial class VirtualMachineDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVirtualMachineDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVirtualMachineDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IVirtualMachineDetails" />.
        /// </returns>
        public static Commvault.Powershell.Models.IVirtualMachineDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IVirtualMachineDetails FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Summary = (Commvault.Powershell.Models.IVMDetailSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Summary, Commvault.Powershell.Models.VMDetailSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResults = (Commvault.Powershell.Models.IVMApplicationValidationResults) content.GetValueForProperty("ApplicationValidationResults",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResults, Commvault.Powershell.Models.VMApplicationValidationResultsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Passkey = (Commvault.Powershell.Models.IVMPasskey) content.GetValueForProperty("Passkey",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Passkey, Commvault.Powershell.Models.VMPasskeyTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Security = (Commvault.Powershell.Models.IVMSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Security, Commvault.Powershell.Models.VMSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptionsProp[]) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ActivityControl, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IActivityControlOptionsProp>(__y, Commvault.Powershell.Models.ActivityControlOptionsPropTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryHypervisor",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryVMGroup",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryPlan",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryCompany = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryCompany",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryCompany, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHost = (string) content.GetValueForProperty("SummaryHost",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOS = (string) content.GetValueForProperty("SummaryOS",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVendor = (string) content.GetValueForProperty("SummaryVendor",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMSize = (long?) content.GetValueForProperty("SummaryVMSize",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryApplicationSize = (long?) content.GetValueForProperty("SummaryApplicationSize",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryApplicationSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryLatestRecoveryPoint = (long?) content.GetValueForProperty("SummaryLatestRecoveryPoint",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryLatestRecoveryPoint, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOldestRecoveryPoint = (long?) content.GetValueForProperty("SummaryOldestRecoveryPoint",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOldestRecoveryPoint, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryStatus = (string) content.GetValueForProperty("SummaryStatus",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBootStatus = (bool?) content.GetValueForProperty("ApplicationValidationResultBootStatus",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBootStatus, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultLastValidationJobId = (long?) content.GetValueForProperty("ApplicationValidationResultLastValidationJobId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultLastValidationJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupValidated = (long?) content.GetValueForProperty("ApplicationValidationResultBackupValidated",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupValidated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupCompletionDate = (long?) content.GetValueForProperty("ApplicationValidationResultBackupCompletionDate",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupCompletionDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultAppsDiscovered = (Commvault.Powershell.Models.IVMAppsDiscovered[]) content.GetValueForProperty("ApplicationValidationResultAppsDiscovered",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultAppsDiscovered, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMAppsDiscovered>(__y, Commvault.Powershell.Models.VMAppsDiscoveredTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyAuthType = (string) content.GetValueForProperty("PasskeyAuthType",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyAuthType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyExpirationTime = (long?) content.GetValueForProperty("PasskeyExpirationTime",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyExpirationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyPassKeyRequiredForRestore = (bool?) content.GetValueForProperty("PasskeyPassKeyRequiredForRestore",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyPassKeyRequiredForRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyEnableAuthorizeForRestore = (bool?) content.GetValueForProperty("PasskeyEnableAuthorizeForRestore",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyEnableAuthorizeForRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityAssociations = (Commvault.Powershell.Models.IVMSecurityAssoc[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMSecurityAssoc>(__y, Commvault.Powershell.Models.VMSecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityPermissions = (Commvault.Powershell.Models.IPermissionResp[]) content.GetValueForProperty("SecurityPermissions",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityPermissions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPermissionResp>(__y, Commvault.Powershell.Models.PermissionRespTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityOwners = (Commvault.Powershell.Models.ISecurityOwnersAssoc[]) content.GetValueForProperty("SecurityOwners",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityOwners, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISecurityOwnersAssoc>(__y, Commvault.Powershell.Models.SecurityOwnersAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorId = (long?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupId = (long?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VirtualMachineDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Summary = (Commvault.Powershell.Models.IVMDetailSummary) content.GetValueForProperty("Summary",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Summary, Commvault.Powershell.Models.VMDetailSummaryTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResults = (Commvault.Powershell.Models.IVMApplicationValidationResults) content.GetValueForProperty("ApplicationValidationResults",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResults, Commvault.Powershell.Models.VMApplicationValidationResultsTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Passkey = (Commvault.Powershell.Models.IVMPasskey) content.GetValueForProperty("Passkey",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Passkey, Commvault.Powershell.Models.VMPasskeyTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Security = (Commvault.Powershell.Models.IVMSecurity) content.GetValueForProperty("Security",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Security, Commvault.Powershell.Models.VMSecurityTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ActivityControl = (Commvault.Powershell.Models.IActivityControlOptionsProp[]) content.GetValueForProperty("ActivityControl",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ActivityControl, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IActivityControlOptionsProp>(__y, Commvault.Powershell.Models.ActivityControlOptionsPropTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Tags = (Commvault.Powershell.Models.IIdNameValue[]) content.GetValueForProperty("Tags",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).Tags, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IIdNameValue>(__y, Commvault.Powershell.Models.IdNameValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryHypervisor",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMGroup = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryVMGroup",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMGroup, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryPlan",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryCompany = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("SummaryCompany",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryCompany, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHost = (string) content.GetValueForProperty("SummaryHost",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryHost, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOS = (string) content.GetValueForProperty("SummaryOS",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOS, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVendor = (string) content.GetValueForProperty("SummaryVendor",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVendor, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMSize = (long?) content.GetValueForProperty("SummaryVMSize",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryVMSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryApplicationSize = (long?) content.GetValueForProperty("SummaryApplicationSize",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryApplicationSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryLatestRecoveryPoint = (long?) content.GetValueForProperty("SummaryLatestRecoveryPoint",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryLatestRecoveryPoint, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOldestRecoveryPoint = (long?) content.GetValueForProperty("SummaryOldestRecoveryPoint",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryOldestRecoveryPoint, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryStatus = (string) content.GetValueForProperty("SummaryStatus",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SummaryStatus, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBootStatus = (bool?) content.GetValueForProperty("ApplicationValidationResultBootStatus",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBootStatus, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultLastValidationJobId = (long?) content.GetValueForProperty("ApplicationValidationResultLastValidationJobId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultLastValidationJobId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupValidated = (long?) content.GetValueForProperty("ApplicationValidationResultBackupValidated",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupValidated, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupCompletionDate = (long?) content.GetValueForProperty("ApplicationValidationResultBackupCompletionDate",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultBackupCompletionDate, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultAppsDiscovered = (Commvault.Powershell.Models.IVMAppsDiscovered[]) content.GetValueForProperty("ApplicationValidationResultAppsDiscovered",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).ApplicationValidationResultAppsDiscovered, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMAppsDiscovered>(__y, Commvault.Powershell.Models.VMAppsDiscoveredTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyAuthType = (string) content.GetValueForProperty("PasskeyAuthType",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyAuthType, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyExpirationTime = (long?) content.GetValueForProperty("PasskeyExpirationTime",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyExpirationTime, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyPassKeyRequiredForRestore = (bool?) content.GetValueForProperty("PasskeyPassKeyRequiredForRestore",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyPassKeyRequiredForRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyEnableAuthorizeForRestore = (bool?) content.GetValueForProperty("PasskeyEnableAuthorizeForRestore",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PasskeyEnableAuthorizeForRestore, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityAssociations = (Commvault.Powershell.Models.IVMSecurityAssoc[]) content.GetValueForProperty("SecurityAssociations",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityAssociations, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IVMSecurityAssoc>(__y, Commvault.Powershell.Models.VMSecurityAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityPermissions = (Commvault.Powershell.Models.IPermissionResp[]) content.GetValueForProperty("SecurityPermissions",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityPermissions, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IPermissionResp>(__y, Commvault.Powershell.Models.PermissionRespTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityOwners = (Commvault.Powershell.Models.ISecurityOwnersAssoc[]) content.GetValueForProperty("SecurityOwners",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).SecurityOwners, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.ISecurityOwnersAssoc>(__y, Commvault.Powershell.Models.SecurityOwnersAssocTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorId = (long?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).HypervisorName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupId = (long?) content.GetValueForProperty("VMGroupId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupName = (string) content.GetValueForProperty("VMGroupName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).VMGroupName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).PlanName, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyId = (long?) content.GetValueForProperty("CompanyId",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyName = (string) content.GetValueForProperty("CompanyName",((Commvault.Powershell.Models.IVirtualMachineDetailsInternal)this).CompanyName, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// VirtualMachineDetails
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineDetailsTypeConverter))]
    public partial interface IVirtualMachineDetails

    {

    }
}