// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>EntitySettingsListItem</summary>
    [System.ComponentModel.TypeConverter(typeof(EntitySettingsListItemTypeConverter))]
    public partial class EntitySettingsListItem
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.EntitySettingsListItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IEntitySettingsListItem" />.
        /// </returns>
        public static Commvault.Powershell.Models.IEntitySettingsListItem DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EntitySettingsListItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.EntitySettingsListItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IEntitySettingsListItem" />.
        /// </returns>
        public static Commvault.Powershell.Models.IEntitySettingsListItem DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EntitySettingsListItem(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.EntitySettingsListItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EntitySettingsListItem(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).AcceptableValues = (string[]) content.GetValueForProperty("AcceptableValues",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).AcceptableValues, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).DefaultValue, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Values = (Commvault.Powershell.Models.IEntitySettingsValue[]) content.GetValueForProperty("Values",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Values, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IEntitySettingsValue>(__y, Commvault.Powershell.Models.EntitySettingsValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsModified = (bool?) content.GetValueForProperty("IsModified",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsModified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Type, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsRestartRequired = (bool?) content.GetValueForProperty("IsRestartRequired",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsRestartRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MinValue = (long?) content.GetValueForProperty("MinValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MinValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MaxValue = (long?) content.GetValueForProperty("MaxValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MaxValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Category = (string) content.GetValueForProperty("Category",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Category, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.EntitySettingsListItem"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EntitySettingsListItem(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Name, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Description = (string) content.GetValueForProperty("Description",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Description, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).AcceptableValues = (string[]) content.GetValueForProperty("AcceptableValues",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).AcceptableValues, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).DefaultValue = (string) content.GetValueForProperty("DefaultValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).DefaultValue, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Values = (Commvault.Powershell.Models.IEntitySettingsValue[]) content.GetValueForProperty("Values",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Values, __y => TypeConverterExtensions.SelectToArray<Commvault.Powershell.Models.IEntitySettingsValue>(__y, Commvault.Powershell.Models.EntitySettingsValueTypeConverter.ConvertFrom));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsModified = (bool?) content.GetValueForProperty("IsModified",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsModified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Type, global::System.Convert.ToString);
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsRestartRequired = (bool?) content.GetValueForProperty("IsRestartRequired",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).IsRestartRequired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MinValue = (long?) content.GetValueForProperty("MinValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MinValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MaxValue = (long?) content.GetValueForProperty("MaxValue",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).MaxValue, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Category = (string) content.GetValueForProperty("Category",((Commvault.Powershell.Models.IEntitySettingsListItemInternal)this).Category, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EntitySettingsListItem" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Commvault.Powershell.Models.IEntitySettingsListItem FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Commvault.Powershell.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// EntitySettingsListItem
    [System.ComponentModel.TypeConverter(typeof(EntitySettingsListItemTypeConverter))]
    public partial interface IEntitySettingsListItem

    {

    }
}