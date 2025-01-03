// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>CreatevmGroupReq</summary>
    [System.ComponentModel.TypeConverter(typeof(CreatevmGroupReqTypeConverter))]
    public partial class CreatevmGroupReq
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreatevmGroupReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreatevmGroupReq(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hypervisor"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Hypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Hypervisor",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Hypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Content"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Content = (Commvault.Powershell.Models.IVMContent) content.GetValueForProperty("Content",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Content, Commvault.Powershell.Models.VMContentTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Storage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Storage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Meditech"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Meditech = (Commvault.Powershell.Models.IMeditechPropResp) content.GetValueForProperty("Meditech",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Meditech, Commvault.Powershell.Models.MeditechPropRespTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("EnableIntellisnap"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).EnableIntellisnap = (bool?) content.GetValueForProperty("EnableIntellisnap",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).EnableIntellisnap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HypervisorId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorId = (long?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("HypervisorName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorName, global::System.Convert.ToString);
            }
            if (content.Contains("ContentOverwrite"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentOverwrite = (bool?) content.GetValueForProperty("ContentOverwrite",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ContentVirtualMachines"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentVirtualMachines = (System.Collections.Generic.List<Commvault.Powershell.Models.IVirtualMachinecontent>) content.GetValueForProperty("ContentVirtualMachines",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentVirtualMachines, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IVirtualMachinecontent>(__y, Commvault.Powershell.Models.VirtualMachinecontentTypeConverter.ConvertFrom));
            }
            if (content.Contains("ContentRuleGroups"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentRuleGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IRuleGroupContent>) content.GetValueForProperty("ContentRuleGroups",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentRuleGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IRuleGroupContent>(__y, Commvault.Powershell.Models.RuleGroupContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageId = (long?) content.GetValueForProperty("StorageId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageName = (string) content.GetValueForProperty("StorageName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageName, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechUserAccount"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechUserAccount = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("MeditechUserAccount",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechUserAccount, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            }
            if (content.Contains("MeditechSystemName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechSystemName = (string) content.GetValueForProperty("MeditechSystemName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechSystemName, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechListenerIP"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerIP = (string) content.GetValueForProperty("MeditechListenerIP",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerIP, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechListenerPort"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerPort = (long?) content.GetValueForProperty("MeditechListenerPort",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MeditechMbFtimeout"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechMbFtimeout = (long?) content.GetValueForProperty("MeditechMbFtimeout",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechMbFtimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserAccountName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountName = (string) content.GetValueForProperty("UserAccountName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("UserAccountPassword"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountPassword = (string) content.GetValueForProperty("UserAccountPassword",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountPassword, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreatevmGroupReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreatevmGroupReq(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Hypervisor"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Hypervisor = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Hypervisor",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Hypervisor, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Content"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Content = (Commvault.Powershell.Models.IVMContent) content.GetValueForProperty("Content",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Content, Commvault.Powershell.Models.VMContentTypeConverter.ConvertFrom);
            }
            if (content.Contains("Plan"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Plan = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Plan",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Plan, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Storage"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Storage = (Commvault.Powershell.Models.IIdName) content.GetValueForProperty("Storage",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Storage, Commvault.Powershell.Models.IdNameTypeConverter.ConvertFrom);
            }
            if (content.Contains("Meditech"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Meditech = (Commvault.Powershell.Models.IMeditechPropResp) content.GetValueForProperty("Meditech",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Meditech, Commvault.Powershell.Models.MeditechPropRespTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("EnableIntellisnap"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).EnableIntellisnap = (bool?) content.GetValueForProperty("EnableIntellisnap",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).EnableIntellisnap, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("HypervisorId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorId = (long?) content.GetValueForProperty("HypervisorId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("HypervisorName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorName = (string) content.GetValueForProperty("HypervisorName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).HypervisorName, global::System.Convert.ToString);
            }
            if (content.Contains("ContentOverwrite"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentOverwrite = (bool?) content.GetValueForProperty("ContentOverwrite",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentOverwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ContentVirtualMachines"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentVirtualMachines = (System.Collections.Generic.List<Commvault.Powershell.Models.IVirtualMachinecontent>) content.GetValueForProperty("ContentVirtualMachines",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentVirtualMachines, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IVirtualMachinecontent>(__y, Commvault.Powershell.Models.VirtualMachinecontentTypeConverter.ConvertFrom));
            }
            if (content.Contains("ContentRuleGroups"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentRuleGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IRuleGroupContent>) content.GetValueForProperty("ContentRuleGroups",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).ContentRuleGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IRuleGroupContent>(__y, Commvault.Powershell.Models.RuleGroupContentTypeConverter.ConvertFrom));
            }
            if (content.Contains("PlanId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanId = (long?) content.GetValueForProperty("PlanId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("PlanName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).PlanName, global::System.Convert.ToString);
            }
            if (content.Contains("StorageId"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageId = (long?) content.GetValueForProperty("StorageId",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageId, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("StorageName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageName = (string) content.GetValueForProperty("StorageName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).StorageName, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechUserAccount"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechUserAccount = (Commvault.Powershell.Models.IUserNamePassword) content.GetValueForProperty("MeditechUserAccount",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechUserAccount, Commvault.Powershell.Models.UserNamePasswordTypeConverter.ConvertFrom);
            }
            if (content.Contains("MeditechSystemName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechSystemName = (string) content.GetValueForProperty("MeditechSystemName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechSystemName, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechListenerIP"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerIP = (string) content.GetValueForProperty("MeditechListenerIP",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerIP, global::System.Convert.ToString);
            }
            if (content.Contains("MeditechListenerPort"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerPort = (long?) content.GetValueForProperty("MeditechListenerPort",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechListenerPort, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("MeditechMbFtimeout"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechMbFtimeout = (long?) content.GetValueForProperty("MeditechMbFtimeout",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).MeditechMbFtimeout, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("UserAccountName"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountName = (string) content.GetValueForProperty("UserAccountName",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountName, global::System.Convert.ToString);
            }
            if (content.Contains("UserAccountPassword"))
            {
                ((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountPassword = (string) content.GetValueForProperty("UserAccountPassword",((Commvault.Powershell.Models.ICreatevmGroupReqInternal)this).UserAccountPassword, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreatevmGroupReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreatevmGroupReq" />.</returns>
        public static Commvault.Powershell.Models.ICreatevmGroupReq DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreatevmGroupReq(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreatevmGroupReq"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreatevmGroupReq" />.</returns>
        public static Commvault.Powershell.Models.ICreatevmGroupReq DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreatevmGroupReq(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreatevmGroupReq" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CreatevmGroupReq" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreatevmGroupReq FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// CreatevmGroupReq
    [System.ComponentModel.TypeConverter(typeof(CreatevmGroupReqTypeConverter))]
    public partial interface ICreatevmGroupReq

    {

    }
}