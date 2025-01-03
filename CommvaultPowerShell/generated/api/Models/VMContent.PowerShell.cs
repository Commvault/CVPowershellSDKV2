// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>RuleContent</summary>
    [System.ComponentModel.TypeConverter(typeof(VMContentTypeConverter))]
    public partial class VMContent
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VMContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMContent" />.</returns>
        public static Commvault.Powershell.Models.IVMContent DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMContent(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VMContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMContent" />.</returns>
        public static Commvault.Powershell.Models.IVMContent DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMContent(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMContent" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMContent" /> model class.</returns>
        public static Commvault.Powershell.Models.IVMContent FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VMContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMContent(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Overwrite"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).Overwrite = (bool?) content.GetValueForProperty("Overwrite",((Commvault.Powershell.Models.IVMContentInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachines"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).VirtualMachines = (System.Collections.Generic.List<Commvault.Powershell.Models.IVirtualMachinecontent>) content.GetValueForProperty("VirtualMachines",((Commvault.Powershell.Models.IVMContentInternal)this).VirtualMachines, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IVirtualMachinecontent>(__y, Commvault.Powershell.Models.VirtualMachinecontentTypeConverter.ConvertFrom));
            }
            if (content.Contains("RuleGroups"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).RuleGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IRuleGroupContent>) content.GetValueForProperty("RuleGroups",((Commvault.Powershell.Models.IVMContentInternal)this).RuleGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IRuleGroupContent>(__y, Commvault.Powershell.Models.RuleGroupContentTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VMContent"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMContent(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Overwrite"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).Overwrite = (bool?) content.GetValueForProperty("Overwrite",((Commvault.Powershell.Models.IVMContentInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VirtualMachines"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).VirtualMachines = (System.Collections.Generic.List<Commvault.Powershell.Models.IVirtualMachinecontent>) content.GetValueForProperty("VirtualMachines",((Commvault.Powershell.Models.IVMContentInternal)this).VirtualMachines, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IVirtualMachinecontent>(__y, Commvault.Powershell.Models.VirtualMachinecontentTypeConverter.ConvertFrom));
            }
            if (content.Contains("RuleGroups"))
            {
                ((Commvault.Powershell.Models.IVMContentInternal)this).RuleGroups = (System.Collections.Generic.List<Commvault.Powershell.Models.IRuleGroupContent>) content.GetValueForProperty("RuleGroups",((Commvault.Powershell.Models.IVMContentInternal)this).RuleGroups, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IRuleGroupContent>(__y, Commvault.Powershell.Models.RuleGroupContentTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// RuleContent
    [System.ComponentModel.TypeConverter(typeof(VMContentTypeConverter))]
    public partial interface IVMContent

    {

    }
}