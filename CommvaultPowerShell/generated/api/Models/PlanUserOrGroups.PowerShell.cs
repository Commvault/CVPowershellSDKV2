// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Users or User Groups associated with the plan</summary>
    [System.ComponentModel.TypeConverter(typeof(PlanUserOrGroupsTypeConverter))]
    public partial class PlanUserOrGroups
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.PlanUserOrGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IPlanUserOrGroups" />.</returns>
        public static Commvault.Powershell.Models.IPlanUserOrGroups DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PlanUserOrGroups(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.PlanUserOrGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.IPlanUserOrGroups" />.</returns>
        public static Commvault.Powershell.Models.IPlanUserOrGroups DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PlanUserOrGroups(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PlanUserOrGroups" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IPlanUserOrGroups FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.PlanUserOrGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PlanUserOrGroups(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Type, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).SendInvite = (bool?) content.GetValueForProperty("SendInvite",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).SendInvite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.PlanUserOrGroups"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PlanUserOrGroups(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Id = (long?) content.GetValueForProperty("Id",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Id, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).Type, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).SendInvite = (bool?) content.GetValueForProperty("SendInvite",((Commvault.Powershell.Models.IPlanUserOrGroupsInternal)this).SendInvite, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Users or User Groups associated with the plan
    [System.ComponentModel.TypeConverter(typeof(PlanUserOrGroupsTypeConverter))]
    public partial interface IPlanUserOrGroups

    {

    }
}