// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using Commvault.Powershell.Runtime.PowerShell;

    /// <summary>
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(IPAddressSettingVmwareCreateTypeConverter))]
    public partial class IPAddressSettingVmwareCreate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Commvault.Powershell.Models.IPAddressSettingVmwareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IIPAddressSettingVmwareCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IIPAddressSettingVmwareCreate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new IPAddressSettingVmwareCreate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Commvault.Powershell.Models.IPAddressSettingVmwareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Commvault.Powershell.Models.IIPAddressSettingVmwareCreate" />.
        /// </returns>
        public static Commvault.Powershell.Models.IIPAddressSettingVmwareCreate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new IPAddressSettingVmwareCreate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="IPAddressSettingVmwareCreate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="IPAddressSettingVmwareCreate" /> model class.</returns>
        public static Commvault.Powershell.Models.IIPAddressSettingVmwareCreate FromJsonString(string jsonText) => FromJson(Commvault.Powershell.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Commvault.Powershell.Models.IPAddressSettingVmwareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal IPAddressSettingVmwareCreate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceIP"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceIP, global::System.Convert.ToString);
            }
            if (content.Contains("SourceSubnetMask"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceSubnetMask = (string) content.GetValueForProperty("SourceSubnetMask",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceSubnetMask, global::System.Convert.ToString);
            }
            if (content.Contains("SourceDefaultGateway"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceDefaultGateway = (string) content.GetValueForProperty("SourceDefaultGateway",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceDefaultGateway, global::System.Convert.ToString);
            }
            if (content.Contains("UseDhcp"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).UseDhcp = (bool?) content.GetValueForProperty("UseDhcp",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).UseDhcp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DestinationIP"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationIP = (string) content.GetValueForProperty("DestinationIP",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationIP, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationSubnetMask"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationSubnetMask = (string) content.GetValueForProperty("DestinationSubnetMask",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationSubnetMask, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationDefaultGateway"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationDefaultGateway = (string) content.GetValueForProperty("DestinationDefaultGateway",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationDefaultGateway, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPreferredDns"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredDns = (string) content.GetValueForProperty("DestinationPreferredDns",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredDns, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAlternateDns"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateDns = (string) content.GetValueForProperty("DestinationAlternateDns",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateDns, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPreferredWins"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredWins = (string) content.GetValueForProperty("DestinationPreferredWins",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredWins, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAlternateWins"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateWins = (string) content.GetValueForProperty("DestinationAlternateWins",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateWins, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Commvault.Powershell.Models.IPAddressSettingVmwareCreate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal IPAddressSettingVmwareCreate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceIP"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceIP = (string) content.GetValueForProperty("SourceIP",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceIP, global::System.Convert.ToString);
            }
            if (content.Contains("SourceSubnetMask"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceSubnetMask = (string) content.GetValueForProperty("SourceSubnetMask",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceSubnetMask, global::System.Convert.ToString);
            }
            if (content.Contains("SourceDefaultGateway"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceDefaultGateway = (string) content.GetValueForProperty("SourceDefaultGateway",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).SourceDefaultGateway, global::System.Convert.ToString);
            }
            if (content.Contains("UseDhcp"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).UseDhcp = (bool?) content.GetValueForProperty("UseDhcp",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).UseDhcp, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DestinationIP"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationIP = (string) content.GetValueForProperty("DestinationIP",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationIP, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationSubnetMask"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationSubnetMask = (string) content.GetValueForProperty("DestinationSubnetMask",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationSubnetMask, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationDefaultGateway"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationDefaultGateway = (string) content.GetValueForProperty("DestinationDefaultGateway",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationDefaultGateway, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPreferredDns"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredDns = (string) content.GetValueForProperty("DestinationPreferredDns",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredDns, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAlternateDns"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateDns = (string) content.GetValueForProperty("DestinationAlternateDns",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateDns, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationPreferredWins"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredWins = (string) content.GetValueForProperty("DestinationPreferredWins",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationPreferredWins, global::System.Convert.ToString);
            }
            if (content.Contains("DestinationAlternateWins"))
            {
                ((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateWins = (string) content.GetValueForProperty("DestinationAlternateWins",((Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal)this).DestinationAlternateWins, global::System.Convert.ToString);
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
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    [System.ComponentModel.TypeConverter(typeof(IPAddressSettingVmwareCreateTypeConverter))]
    public partial interface IIPAddressSettingVmwareCreate

    {

    }
}