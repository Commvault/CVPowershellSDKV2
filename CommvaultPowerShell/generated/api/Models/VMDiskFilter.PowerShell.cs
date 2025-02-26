// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>vmDiskFilter</summary>
    [System.ComponentModel.TypeConverter(typeof(VMDiskFilterTypeConverter))]
    public partial class VMDiskFilter
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.VMDiskFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMDiskFilter" />.</returns>
        public static Commvault.Powershell.Models.IVMDiskFilter DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMDiskFilter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.VMDiskFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IVMDiskFilter" />.</returns>
        public static Commvault.Powershell.Models.IVMDiskFilter DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMDiskFilter(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMDiskFilter" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMDiskFilter" /> model class.</returns>
        public static Commvault.Powershell.Models.IVMDiskFilter FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.VMDiskFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMDiskFilter(global::System.Collections.IDictionary content)
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
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Overwrite = (bool?) content.GetValueForProperty("Overwrite",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FilterType"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).FilterType = (string) content.GetValueForProperty("FilterType",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).FilterType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Value"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Value = (string) content.GetValueForProperty("Value",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Condition"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Condition, global::System.Convert.ToString);
            }
            if (content.Contains("VMName"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMName = (string) content.GetValueForProperty("VMName",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMName, global::System.Convert.ToString);
            }
            if (content.Contains("VMGuid"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMGuid = (string) content.GetValueForProperty("VMGuid",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMGuid, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.VMDiskFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMDiskFilter(global::System.Management.Automation.PSObject content)
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
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Overwrite = (bool?) content.GetValueForProperty("Overwrite",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Overwrite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("FilterType"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).FilterType = (string) content.GetValueForProperty("FilterType",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).FilterType, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Value"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Value = (string) content.GetValueForProperty("Value",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Value, global::System.Convert.ToString);
            }
            if (content.Contains("Condition"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Condition = (string) content.GetValueForProperty("Condition",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).Condition, global::System.Convert.ToString);
            }
            if (content.Contains("VMName"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMName = (string) content.GetValueForProperty("VMName",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMName, global::System.Convert.ToString);
            }
            if (content.Contains("VMGuid"))
            {
                ((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMGuid = (string) content.GetValueForProperty("VMGuid",((Commvault.Powershell.Models.IVMDiskFilterInternal)this).VMGuid, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// vmDiskFilter
    [System.ComponentModel.TypeConverter(typeof(VMDiskFilterTypeConverter))]
    public partial interface IVMDiskFilter

    {

    }
}