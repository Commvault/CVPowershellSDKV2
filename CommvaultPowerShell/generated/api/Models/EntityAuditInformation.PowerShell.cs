// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>EntityAuditInformation</summary>
    [System.ComponentModel.TypeConverter(typeof(EntityAuditInformationTypeConverter))]
    public partial class EntityAuditInformation
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.EntityAuditInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IEntityAuditInformation" />.
        /// </returns>
        public static Commvault.Powershell.Models.IEntityAuditInformation DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EntityAuditInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.EntityAuditInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IEntityAuditInformation" />.
        /// </returns>
        public static Commvault.Powershell.Models.IEntityAuditInformation DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EntityAuditInformation(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.EntityAuditInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EntityAuditInformation(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Severity"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Time"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Time = (long?) content.GetValueForProperty("Time",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Time, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("User"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).User = (string) content.GetValueForProperty("User",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).User, global::System.Convert.ToString);
            }
            if (content.Contains("Operation"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Operation, global::System.Convert.ToString);
            }
            if (content.Contains("Messages"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Messages = (System.Collections.Generic.List<string>) content.GetValueForProperty("Messages",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Messages, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.EntityAuditInformation"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EntityAuditInformation(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Severity"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Time"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Time = (long?) content.GetValueForProperty("Time",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Time, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("User"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).User = (string) content.GetValueForProperty("User",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).User, global::System.Convert.ToString);
            }
            if (content.Contains("Operation"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Operation = (string) content.GetValueForProperty("Operation",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Operation, global::System.Convert.ToString);
            }
            if (content.Contains("Messages"))
            {
                ((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Messages = (System.Collections.Generic.List<string>) content.GetValueForProperty("Messages",((Commvault.Powershell.Models.IEntityAuditInformationInternal)this).Messages, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EntityAuditInformation" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EntityAuditInformation" /> model class.</returns>
        public static Commvault.Powershell.Models.IEntityAuditInformation FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// EntityAuditInformation
    [System.ComponentModel.TypeConverter(typeof(EntityAuditInformationTypeConverter))]
    public partial interface IEntityAuditInformation

    {

    }
}