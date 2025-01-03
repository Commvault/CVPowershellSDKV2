// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(LaptopPlanUpdateRpoTypeConverter))]
    public partial class LaptopPlanUpdateRpo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopPlanUpdateRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopPlanUpdateRpo" />.</returns>
        public static Commvault.Powershell.Models.ILaptopPlanUpdateRpo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LaptopPlanUpdateRpo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.LaptopPlanUpdateRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ILaptopPlanUpdateRpo" />.</returns>
        public static Commvault.Powershell.Models.ILaptopPlanUpdateRpo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LaptopPlanUpdateRpo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LaptopPlanUpdateRpo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="LaptopPlanUpdateRpo" /> model class.</returns>
        public static Commvault.Powershell.Models.ILaptopPlanUpdateRpo FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopPlanUpdateRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LaptopPlanUpdateRpo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).Sla = (Commvault.Powershell.Models.ISlaUpdateOptions) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).Sla, Commvault.Powershell.Models.SlaUpdateOptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("BackupFrequency"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).BackupFrequency = (long?) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).BackupFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaUseSystemDefaultSla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaPeriod"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaPeriod = (long?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaExcludeFromSla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaEnableAfterDelay"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaEnableAfterDelay = (long?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaEnableAfterDelay, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaExclusionReason"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            }
            if (content.Contains("SlaLogSlaMinutes"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaLogSlaMinutes = (long?) content.GetValueForProperty("SlaLogSlaMinutes",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaLogSlaMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.LaptopPlanUpdateRpo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LaptopPlanUpdateRpo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Sla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).Sla = (Commvault.Powershell.Models.ISlaUpdateOptions) content.GetValueForProperty("Sla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).Sla, Commvault.Powershell.Models.SlaUpdateOptionsTypeConverter.ConvertFrom);
            }
            if (content.Contains("BackupFrequency"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).BackupFrequency = (long?) content.GetValueForProperty("BackupFrequency",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).BackupFrequency, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaUseSystemDefaultSla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaUseSystemDefaultSla = (bool?) content.GetValueForProperty("SlaUseSystemDefaultSla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaUseSystemDefaultSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaPeriod"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaPeriod = (long?) content.GetValueForProperty("SlaPeriod",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaPeriod, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaExcludeFromSla"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExcludeFromSla = (bool?) content.GetValueForProperty("SlaExcludeFromSla",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExcludeFromSla, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("SlaEnableAfterDelay"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaEnableAfterDelay = (long?) content.GetValueForProperty("SlaEnableAfterDelay",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaEnableAfterDelay, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SlaExclusionReason"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExclusionReason = (string) content.GetValueForProperty("SlaExclusionReason",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaExclusionReason, global::System.Convert.ToString);
            }
            if (content.Contains("SlaLogSlaMinutes"))
            {
                ((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaLogSlaMinutes = (long?) content.GetValueForProperty("SlaLogSlaMinutes",((Commvault.Powershell.Models.ILaptopPlanUpdateRpoInternal)this).SlaLogSlaMinutes, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
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
    [System.ComponentModel.TypeConverter(typeof(LaptopPlanUpdateRpoTypeConverter))]
    public partial interface ILaptopPlanUpdateRpo

    {

    }
}