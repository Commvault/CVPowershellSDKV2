// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>Details of the new region</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateRegionTypeConverter))]
    public partial class CreateRegion
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateRegion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateRegion(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalConfigInfo"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfo = (Commvault.Powershell.Models.ICreateGlobalConfigInfo) content.GetValueForProperty("GlobalConfigInfo",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfo, Commvault.Powershell.Models.CreateGlobalConfigInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateRegionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.ICreateRegionInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Locations"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Locations = (System.Collections.Generic.List<Commvault.Powershell.Models.ILocationDetails>) content.GetValueForProperty("Locations",((Commvault.Powershell.Models.ICreateRegionInternal)this).Locations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ILocationDetails>(__y, Commvault.Powershell.Models.LocationDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoName"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoName = (string) content.GetValueForProperty("GlobalConfigInfoName",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoCommcells"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>) content.GetValueForProperty("GlobalConfigInfoCommcells",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>(__y, Commvault.Powershell.Models.GlobalConfigCommcellInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoScope"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScope = (string) content.GetValueForProperty("GlobalConfigInfoScope",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScope, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoScopeFilterQuery"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScopeFilterQuery = (string) content.GetValueForProperty("GlobalConfigInfoScopeFilterQuery",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScopeFilterQuery, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoApplyOnAllCommCells"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoApplyOnAllCommCells = (bool?) content.GetValueForProperty("GlobalConfigInfoApplyOnAllCommCells",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoApplyOnAllCommCells, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoActionOnLocalEntity"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoActionOnLocalEntity = (string) content.GetValueForProperty("GlobalConfigInfoActionOnLocalEntity",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoActionOnLocalEntity, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.CreateRegion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateRegion(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("GlobalConfigInfo"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfo = (Commvault.Powershell.Models.ICreateGlobalConfigInfo) content.GetValueForProperty("GlobalConfigInfo",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfo, Commvault.Powershell.Models.CreateGlobalConfigInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Name = (string) content.GetValueForProperty("Name",((Commvault.Powershell.Models.ICreateRegionInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Type = (string) content.GetValueForProperty("Type",((Commvault.Powershell.Models.ICreateRegionInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Locations"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).Locations = (System.Collections.Generic.List<Commvault.Powershell.Models.ILocationDetails>) content.GetValueForProperty("Locations",((Commvault.Powershell.Models.ICreateRegionInternal)this).Locations, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.ILocationDetails>(__y, Commvault.Powershell.Models.LocationDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoName"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoName = (string) content.GetValueForProperty("GlobalConfigInfoName",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoName, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoCommcells"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoCommcells = (System.Collections.Generic.List<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>) content.GetValueForProperty("GlobalConfigInfoCommcells",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoCommcells, __y => TypeConverterExtensions.SelectToList<Commvault.Powershell.Models.IGlobalConfigCommcellInfo>(__y, Commvault.Powershell.Models.GlobalConfigCommcellInfoTypeConverter.ConvertFrom));
            }
            if (content.Contains("GlobalConfigInfoScope"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScope = (string) content.GetValueForProperty("GlobalConfigInfoScope",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScope, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoScopeFilterQuery"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScopeFilterQuery = (string) content.GetValueForProperty("GlobalConfigInfoScopeFilterQuery",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoScopeFilterQuery, global::System.Convert.ToString);
            }
            if (content.Contains("GlobalConfigInfoApplyOnAllCommCells"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoApplyOnAllCommCells = (bool?) content.GetValueForProperty("GlobalConfigInfoApplyOnAllCommCells",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoApplyOnAllCommCells, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("GlobalConfigInfoActionOnLocalEntity"))
            {
                ((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoActionOnLocalEntity = (string) content.GetValueForProperty("GlobalConfigInfoActionOnLocalEntity",((Commvault.Powershell.Models.ICreateRegionInternal)this).GlobalConfigInfoActionOnLocalEntity, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.CreateRegion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateRegion" />.</returns>
        public static Commvault.Powershell.Models.ICreateRegion DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateRegion(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.CreateRegion"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>an instance of <see cref="Commvault.Powershell.Models.ICreateRegion" />.</returns>
        public static Commvault.Powershell.Models.ICreateRegion DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateRegion(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateRegion" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CreateRegion" /> model class.</returns>
        public static Commvault.Powershell.Models.ICreateRegion FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Details of the new region
    [System.ComponentModel.TypeConverter(typeof(CreateRegionTypeConverter))]
    public partial interface ICreateRegion

    {

    }
}