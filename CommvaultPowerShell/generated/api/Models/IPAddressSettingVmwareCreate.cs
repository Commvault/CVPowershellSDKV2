// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    /// </summary>
    public partial class IPAddressSettingVmwareCreate :
        Commvault.Powershell.Models.IIPAddressSettingVmwareCreate,
        Commvault.Powershell.Models.IIPAddressSettingVmwareCreateInternal
    {

        /// <summary>Backing field for <see cref="DestinationAlternateDns" /> property.</summary>
        private string _destinationAlternateDns;

        /// <summary>
        /// The alternate DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationAlternateDns { get => this._destinationAlternateDns; set => this._destinationAlternateDns = value; }

        /// <summary>Backing field for <see cref="DestinationAlternateWins" /> property.</summary>
        private string _destinationAlternateWins;

        /// <summary>
        /// The alternate WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationAlternateWins { get => this._destinationAlternateWins; set => this._destinationAlternateWins = value; }

        /// <summary>Backing field for <see cref="DestinationIP" /> property.</summary>
        private string _destinationIP;

        /// <summary>
        /// The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationIP { get => this._destinationIP; set => this._destinationIP = value; }

        /// <summary>Backing field for <see cref="DestinationPreferredDns" /> property.</summary>
        private string _destinationPreferredDns;

        /// <summary>
        /// The preferred DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationPreferredDns { get => this._destinationPreferredDns; set => this._destinationPreferredDns = value; }

        /// <summary>Backing field for <see cref="DestinationPreferredWins" /> property.</summary>
        private string _destinationPreferredWins;

        /// <summary>
        /// The preferred WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationPreferredWins { get => this._destinationPreferredWins; set => this._destinationPreferredWins = value; }

        /// <summary>Backing field for <see cref="DestinationSubnetMask" /> property.</summary>
        private string _destinationSubnetMask;

        /// <summary>The subnet mask for the destination VM. Provide only if DHCP is not enabled.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationSubnetMask { get => this._destinationSubnetMask; set => this._destinationSubnetMask = value; }

        /// <summary>Backing field for <see cref="DestinationdefaultGateway" /> property.</summary>
        private string _destinationdefaultGateway;

        /// <summary>
        /// The default gateway for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DestinationdefaultGateway { get => this._destinationdefaultGateway; set => this._destinationdefaultGateway = value; }

        /// <summary>Backing field for <see cref="Hostname" /> property.</summary>
        private string _hostname;

        /// <summary>The host name to be applied for the destination VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Hostname { get => this._hostname; set => this._hostname = value; }

        /// <summary>Backing field for <see cref="SourceDefaultGateway" /> property.</summary>
        private string _sourceDefaultGateway;

        /// <summary>The default gateway of the source VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceDefaultGateway { get => this._sourceDefaultGateway; set => this._sourceDefaultGateway = value; }

        /// <summary>Backing field for <see cref="SourceIP" /> property.</summary>
        private string _sourceIP;

        /// <summary>The full IP address or an IP address pattern of the source VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceIP { get => this._sourceIP; set => this._sourceIP = value; }

        /// <summary>Backing field for <see cref="SourceSubnetMask" /> property.</summary>
        private string _sourceSubnetMask;

        /// <summary>The subnet mask of the source VM.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SourceSubnetMask { get => this._sourceSubnetMask; set => this._sourceSubnetMask = value; }

        /// <summary>Backing field for <see cref="UseDhcp" /> property.</summary>
        private bool? _useDhcp;

        /// <summary>
        /// Automatically assigns available IP addresses to be used with the specified destination network.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseDhcp { get => this._useDhcp; set => this._useDhcp = value; }

        /// <summary>Creates an new <see cref="IPAddressSettingVmwareCreate" /> instance.</summary>
        public IPAddressSettingVmwareCreate()
        {

        }
    }
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    public partial interface IIPAddressSettingVmwareCreate :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The alternate DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alternate DNS server for the destination VM.  Provide only if DHCP is not enabled",
        SerializedName = @"destinationAlternateDNS",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationAlternateDns { get; set; }
        /// <summary>
        /// The alternate WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The alternate WINS server for the destination VM.  Provide only if DHCP is not enabled",
        SerializedName = @"destinationAlternateWINS",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationAlternateWins { get; set; }
        /// <summary>
        /// The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.",
        SerializedName = @"destinationIP",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationIP { get; set; }
        /// <summary>
        /// The preferred DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The preferred DNS server for the destination VM.  Provide only if DHCP is not enabled",
        SerializedName = @"destinationPreferredDNS",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationPreferredDns { get; set; }
        /// <summary>
        /// The preferred WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The preferred WINS server for the destination VM.  Provide only if DHCP is not enabled",
        SerializedName = @"destinationPreferredWINS",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationPreferredWins { get; set; }
        /// <summary>The subnet mask for the destination VM. Provide only if DHCP is not enabled.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subnet mask for the destination VM.  Provide only if DHCP is not enabled.",
        SerializedName = @"destinationSubnetMask",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationSubnetMask { get; set; }
        /// <summary>
        /// The default gateway for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default gateway for the destination VM.  Provide only if DHCP is not enabled.",
        SerializedName = @"destinationdefaultGateway",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationdefaultGateway { get; set; }
        /// <summary>The host name to be applied for the destination VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The host name to be applied for the destination VM.",
        SerializedName = @"hostname",
        PossibleTypes = new [] { typeof(string) })]
        string Hostname { get; set; }
        /// <summary>The default gateway of the source VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default gateway of the source VM.",
        SerializedName = @"sourceDefaultGateway",
        PossibleTypes = new [] { typeof(string) })]
        string SourceDefaultGateway { get; set; }
        /// <summary>The full IP address or an IP address pattern of the source VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The full IP address or an IP address pattern of the source VM.",
        SerializedName = @"sourceIP",
        PossibleTypes = new [] { typeof(string) })]
        string SourceIP { get; set; }
        /// <summary>The subnet mask of the source VM.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subnet mask of the source VM.",
        SerializedName = @"sourceSubnetMask",
        PossibleTypes = new [] { typeof(string) })]
        string SourceSubnetMask { get; set; }
        /// <summary>
        /// Automatically assigns available IP addresses to be used with the specified destination network.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Automatically assigns available IP addresses to be used with the specified destination network.",
        SerializedName = @"useDhcp",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseDhcp { get; set; }

    }
    /// A mapping of IP between the source and the destination VM with an option to configure either a dynamic or a static IP.
    internal partial interface IIPAddressSettingVmwareCreateInternal

    {
        /// <summary>
        /// The alternate DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        string DestinationAlternateDns { get; set; }
        /// <summary>
        /// The alternate WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        string DestinationAlternateWins { get; set; }
        /// <summary>
        /// The full IP address or an IP address pattern for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        string DestinationIP { get; set; }
        /// <summary>
        /// The preferred DNS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        string DestinationPreferredDns { get; set; }
        /// <summary>
        /// The preferred WINS server for the destination VM. Provide only if DHCP is not enabled
        /// </summary>
        string DestinationPreferredWins { get; set; }
        /// <summary>The subnet mask for the destination VM. Provide only if DHCP is not enabled.</summary>
        string DestinationSubnetMask { get; set; }
        /// <summary>
        /// The default gateway for the destination VM. Provide only if DHCP is not enabled.
        /// </summary>
        string DestinationdefaultGateway { get; set; }
        /// <summary>The host name to be applied for the destination VM.</summary>
        string Hostname { get; set; }
        /// <summary>The default gateway of the source VM.</summary>
        string SourceDefaultGateway { get; set; }
        /// <summary>The full IP address or an IP address pattern of the source VM.</summary>
        string SourceIP { get; set; }
        /// <summary>The subnet mask of the source VM.</summary>
        string SourceSubnetMask { get; set; }
        /// <summary>
        /// Automatically assigns available IP addresses to be used with the specified destination network.
        /// </summary>
        bool? UseDhcp { get; set; }

    }
}