// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
    /// number of days specified at the CommCell, Server Group or plan level.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(SlaUpdateOptionsTypeConverter))]
    public partial class SlaUpdateOptions
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.SlaUpdateOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISlaUpdateOptions" />.</returns>
        public static Commvault.Powershell.Models.ISlaUpdateOptions DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SlaUpdateOptions(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.SlaUpdateOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ISlaUpdateOptions" />.</returns>
        public static Commvault.Powershell.Models.ISlaUpdateOptions DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SlaUpdateOptions(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SlaUpdateOptions" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SlaUpdateOptions" /> model class.</returns>
        public static Commvault.Powershell.Models.ISlaUpdateOptions FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.SlaUpdateOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SlaUpdateOptions(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UseSystemDefaultSla"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).UseSystemDefaultSla = (bool?) content.GetValueForProperty("UseSystemDefaultSla",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).UseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaPeriod"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).SlaPeriod = (long?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).SlaPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExcludeFromSla"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExcludeFromSla = (bool?) content.GetValueForProperty("ExcludeFromSla",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAfterDelay"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).EnableAfterDelay = (long?) content.GetValueForProperty("EnableAfterDelay",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).EnableAfterDelay, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExclusionReason"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExclusionReason = (string) content.GetValueForProperty("ExclusionReason",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExclusionReason, global::System.Convert.ToString);
            }
            if (content.Contains("LogSlaMinutes"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).LogSlaMinutes = (long?) content.GetValueForProperty("LogSlaMinutes",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).LogSlaMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.SlaUpdateOptions"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SlaUpdateOptions(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("UseSystemDefaultSla"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).UseSystemDefaultSla = (bool?) content.GetValueForProperty("UseSystemDefaultSla",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).UseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaPeriod"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).SlaPeriod = (long?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).SlaPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExcludeFromSla"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExcludeFromSla = (bool?) content.GetValueForProperty("ExcludeFromSla",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("EnableAfterDelay"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).EnableAfterDelay = (long?) content.GetValueForProperty("EnableAfterDelay",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).EnableAfterDelay, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ExclusionReason"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExclusionReason = (string) content.GetValueForProperty("ExclusionReason",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).ExclusionReason, global::System.Convert.ToString);
            }
            if (content.Contains("LogSlaMinutes"))
            {
                ((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).LogSlaMinutes = (long?) content.GetValueForProperty("LogSlaMinutes",((Commvault.Powershell.Models.ISlaUpdateOptionsInternal)this).LogSlaMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
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
    /// A server meets SLA (Service Level Agreement) when all of its subclients have at least one successful backup during the
    /// number of days specified at the CommCell, Server Group or plan level.
    [System.ComponentModel.TypeConverter(typeof(SlaUpdateOptionsTypeConverter))]
    public partial interface ISlaUpdateOptions

    {

    }
}