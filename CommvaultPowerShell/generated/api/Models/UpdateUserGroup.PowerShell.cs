// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(UpdateUserGroupTypeConverter))]
    public partial class UpdateUserGroup
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateUserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateUserGroup" />.</returns>
        public static Commvault.Powershell.Models.IUpdateUserGroup DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateUserGroup(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.UpdateUserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IUpdateUserGroup" />.</returns>
        public static Commvault.Powershell.Models.IUpdateUserGroup DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateUserGroup(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateUserGroup" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpdateUserGroup" /> model class.</returns>
        public static Commvault.Powershell.Models.IUpdateUserGroup FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateUserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateUserGroup(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LaptopPlan"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("LaptopPlan",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestrictConsoleTypes"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleTypes = (Commvault.Powershell.Models.IRestrictConsoleTypes) content.GetValueForProperty("RestrictConsoleTypes",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleTypes, Commvault.Powershell.Models.RestrictConsoleTypesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("NewDescription"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewDescription = (string) content.GetValueForProperty("NewDescription",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PlanOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).PlanOperationType = (string) content.GetValueForProperty("PlanOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).PlanOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnforceFsQuota"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnforceFsQuota = (bool?) content.GetValueForProperty("EnforceFsQuota",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnforceFsQuota, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("QuotaLimitInGb"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).QuotaLimitInGb = (long?) content.GetValueForProperty("QuotaLimitInGb",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).QuotaLimitInGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EnableTwoFactorAuthentication"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableTwoFactorAuthentication = (string) content.GetValueForProperty("EnableTwoFactorAuthentication",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableTwoFactorAuthentication, global::System.Convert.ToString);
            }
            if (content.Contains("EnableLocalAuthentication"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableLocalAuthentication = (string) content.GetValueForProperty("EnableLocalAuthentication",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableLocalAuthentication, global::System.Convert.ToString);
            }
            if (content.Contains("AssociatedExternalGroups"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedExternalGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedExternalGroups",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedExternalGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExternalUserGroupsOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ExternalUserGroupsOperationType = (string) content.GetValueForProperty("ExternalUserGroupsOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ExternalUserGroupsOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("LaptopAdmins"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopAdmins = (bool?) content.GetValueForProperty("LaptopAdmins",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopAdmins, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AssociatedLocalGroups"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedLocalGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedLocalGroups",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedLocalGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("LocalUserGroupsOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LocalUserGroupsOperationType = (string) content.GetValueForProperty("LocalUserGroupsOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LocalUserGroupsOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Users"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Users = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Users, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).UserOperationType = (string) content.GetValueForProperty("UserOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).UserOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("AllowMultipleCompanyMembers"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AllowMultipleCompanyMembers = (bool?) content.GetValueForProperty("AllowMultipleCompanyMembers",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AllowMultipleCompanyMembers, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DoNotInheritRestrictConsoleTypes"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).DoNotInheritRestrictConsoleTypes = (bool?) content.GetValueForProperty("DoNotInheritRestrictConsoleTypes",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).DoNotInheritRestrictConsoleTypes, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConsoleTypeOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ConsoleTypeOperationType = (string) content.GetValueForProperty("ConsoleTypeOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ConsoleTypeOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureGuid"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AzureGuid = (string) content.GetValueForProperty("AzureGuid",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AzureGuid, global::System.Convert.ToString);
            }
            if (content.Contains("RestrictConsoleType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleType = (System.Collections.Generic.List<string>) content.GetValueForProperty("RestrictConsoleType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LaptopPlanId"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanId = (long?) content.GetValueForProperty("LaptopPlanId",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LaptopPlanName"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanName = (string) content.GetValueForProperty("LaptopPlanName",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.UpdateUserGroup"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateUserGroup(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LaptopPlan"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("LaptopPlan",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("RestrictConsoleTypes"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleTypes = (Commvault.Powershell.Models.IRestrictConsoleTypes) content.GetValueForProperty("RestrictConsoleTypes",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleTypes, Commvault.Powershell.Models.RestrictConsoleTypesTypeConverter.ConvertFrom);
            }
            if (content.Contains("NewName"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewName = (string) content.GetValueForProperty("NewName",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewName, global::System.Convert.ToString);
            }
            if (content.Contains("NewDescription"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewDescription = (string) content.GetValueForProperty("NewDescription",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).NewDescription, global::System.Convert.ToString);
            }
            if (content.Contains("PlanOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).PlanOperationType = (string) content.GetValueForProperty("PlanOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).PlanOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Enabled"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Enabled = (bool?) content.GetValueForProperty("Enabled",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnforceFsQuota"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnforceFsQuota = (bool?) content.GetValueForProperty("EnforceFsQuota",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnforceFsQuota, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("QuotaLimitInGb"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).QuotaLimitInGb = (long?) content.GetValueForProperty("QuotaLimitInGb",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).QuotaLimitInGb, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("EnableTwoFactorAuthentication"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableTwoFactorAuthentication = (string) content.GetValueForProperty("EnableTwoFactorAuthentication",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableTwoFactorAuthentication, global::System.Convert.ToString);
            }
            if (content.Contains("EnableLocalAuthentication"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableLocalAuthentication = (string) content.GetValueForProperty("EnableLocalAuthentication",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).EnableLocalAuthentication, global::System.Convert.ToString);
            }
            if (content.Contains("AssociatedExternalGroups"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedExternalGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedExternalGroups",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedExternalGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("ExternalUserGroupsOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ExternalUserGroupsOperationType = (string) content.GetValueForProperty("ExternalUserGroupsOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ExternalUserGroupsOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("LaptopAdmins"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopAdmins = (bool?) content.GetValueForProperty("LaptopAdmins",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopAdmins, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AssociatedLocalGroups"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedLocalGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("AssociatedLocalGroups",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AssociatedLocalGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("LocalUserGroupsOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LocalUserGroupsOperationType = (string) content.GetValueForProperty("LocalUserGroupsOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LocalUserGroupsOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("Users"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Users = (System.Collections.Generic.List<Commvault.Powershell.Models.IIdName>) content.GetValueForProperty("Users",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).Users, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IIdName>(__y, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom));
            }
            if (content.Contains("UserOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).UserOperationType = (string) content.GetValueForProperty("UserOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).UserOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("AllowMultipleCompanyMembers"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AllowMultipleCompanyMembers = (bool?) content.GetValueForProperty("AllowMultipleCompanyMembers",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AllowMultipleCompanyMembers, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DoNotInheritRestrictConsoleTypes"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).DoNotInheritRestrictConsoleTypes = (bool?) content.GetValueForProperty("DoNotInheritRestrictConsoleTypes",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).DoNotInheritRestrictConsoleTypes, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConsoleTypeOperationType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ConsoleTypeOperationType = (string) content.GetValueForProperty("ConsoleTypeOperationType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).ConsoleTypeOperationType, global::System.Convert.ToString);
            }
            if (content.Contains("AzureGuid"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AzureGuid = (string) content.GetValueForProperty("AzureGuid",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).AzureGuid, global::System.Convert.ToString);
            }
            if (content.Contains("RestrictConsoleType"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleType = (System.Collections.Generic.List<string>) content.GetValueForProperty("RestrictConsoleType",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).RestrictConsoleType, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LaptopPlanId"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanId = (long?) content.GetValueForProperty("LaptopPlanId",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("LaptopPlanName"))
            {
                ((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanName = (string) content.GetValueForProperty("LaptopPlanName",((Commvault.Powershell.Models.IUpdateUserGroupInternal)this).LaptopPlanName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    [System.ComponentModel.TypeConverter(typeof(UpdateUserGroupTypeConverter))]
    public partial interface IUpdateUserGroup

    {

    }
}