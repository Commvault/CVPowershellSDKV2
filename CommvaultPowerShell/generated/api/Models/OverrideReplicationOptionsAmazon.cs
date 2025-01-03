// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for Amazon</summary>
    public partial class OverrideReplicationOptionsAmazon :
        Commvault.Powershell.Models.IOverrideReplicationOptionsAmazon,
        Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal
    {

        /// <summary>Backing field for <see cref="AutoSelectSecurityGroup" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityGroup> _autoSelectSecurityGroup;

        /// <summary>Select a security group for the destination instances</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityGroup> AutoSelectSecurityGroup { get => this._autoSelectSecurityGroup; set => this._autoSelectSecurityGroup = value; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private string _availabilityZone;

        /// <summary>Destination zone</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

        /// <summary>Internal Acessors for GuestCreds</summary>
        Commvault.Powershell.Models.IGuestCredentialsCreate Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal.GuestCreds { get => (this._guestCreds = this._guestCreds ?? new Commvault.Powershell.Models.GuestCredentialsCreate()); set { {_guestCreds = value;} } }

        /// <summary>Internal Acessors for Network</summary>
        Commvault.Powershell.Models.IAmazonNetwork Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal.Network { get => (this._network = this._network ?? new Commvault.Powershell.Models.AmazonNetwork()); set { {_network = value;} } }

        /// <summary>Internal Acessors for TestFailoverNetwork</summary>
        Commvault.Powershell.Models.IAmazonNetwork Commvault.Powershell.Models.IOverrideReplicationOptionsAmazonInternal.TestFailoverNetwork { get => (this._testFailoverNetwork = this._testFailoverNetwork ?? new Commvault.Powershell.Models.AmazonNetwork()); set { {_testFailoverNetwork = value;} } }

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Backing field for <see cref="EncryptionKey" /> property.</summary>
        private string _encryptionKey;

        /// <summary>Encryption key if used</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string EncryptionKey { get => this._encryptionKey; set => this._encryptionKey = value; }

        /// <summary>The name of the computer</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GuestCredComputerName { get => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).ComputerName; set => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).ComputerName = value ?? null; }

        /// <summary>The password of the user in Base64 format</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GuestCredPassword { get => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).Password; set => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).Password = value ?? null; }

        /// <summary>The user to be used to access the computer</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GuestCredUserName { get => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).UserName; set => ((Commvault.Powershell.Models.IGuestCredentialsCreateInternal)GuestCreds).UserName = value ?? null; }

        /// <summary>Backing field for <see cref="GuestCreds" /> property.</summary>
        private Commvault.Powershell.Models.IGuestCredentialsCreate _guestCreds;

        /// <summary>
        /// Faster performance can be achieved during replication by using the VSA access node running on the Amazon instance. Applicable
        /// only if the source VM is Windows and the source hypervisor is not Amazon vendor.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IGuestCredentialsCreate GuestCreds { get => (this._guestCreds = this._guestCreds ?? new Commvault.Powershell.Models.GuestCredentialsCreate()); set => this._guestCreds = value; }

        /// <summary>Backing field for <see cref="InstanceName" /> property.</summary>
        private string _instanceName;

        /// <summary>Display name for the destination instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstanceName { get => this._instanceName; set => this._instanceName = value; }

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Commvault.Powershell.Models.IAmazonNetwork _network;

        /// <summary>Network interface for the destination instances</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAmazonNetwork Network { get => (this._network = this._network ?? new Commvault.Powershell.Models.AmazonNetwork()); set => this._network = value; }

        /// <summary>Network display name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkDisplayName { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).DisplayName; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).DisplayName = value ?? null; }

        /// <summary>VPC Id of the network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkId { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).NetworkId; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).NetworkId = value ?? null; }

        /// <summary>Name of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkName { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).Name; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).Name = value ?? null; }

        /// <summary>Private IP address of the network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkPrivateIPaddress { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).PrivateIPaddress; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).PrivateIPaddress = value ?? null; }

        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string NetworkSubnetId { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).SubnetId; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)Network).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="TestFailoverNetwork" /> property.</summary>
        private Commvault.Powershell.Models.IAmazonNetwork _testFailoverNetwork;

        /// <summary>Network interface for the destination instances</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IAmazonNetwork TestFailoverNetwork { get => (this._testFailoverNetwork = this._testFailoverNetwork ?? new Commvault.Powershell.Models.AmazonNetwork()); set => this._testFailoverNetwork = value; }

        /// <summary>Network display name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TestFailoverNetworkDisplayName { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).DisplayName; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).DisplayName = value ?? null; }

        /// <summary>VPC Id of the network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TestFailoverNetworkId { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).NetworkId; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).NetworkId = value ?? null; }

        /// <summary>Name of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TestFailoverNetworkName { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).Name; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).Name = value ?? null; }

        /// <summary>Private IP address of the network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TestFailoverNetworkPrivateIPaddress { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).PrivateIPaddress; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).PrivateIPaddress = value ?? null; }

        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TestFailoverNetworkSubnetId { get => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).SubnetId; set => ((Commvault.Powershell.Models.IAmazonNetworkInternal)TestFailoverNetwork).SubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Backing field for <see cref="VolumeType" /> property.</summary>
        private string _volumeType;

        /// <summary>Type of volume used for replication</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string VolumeType { get => this._volumeType; set => this._volumeType = value; }

        /// <summary>Creates an new <see cref="OverrideReplicationOptionsAmazon" /> instance.</summary>
        public OverrideReplicationOptionsAmazon()
        {

        }
    }
    /// Replication options for Amazon
    public partial interface IOverrideReplicationOptionsAmazon :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Select a security group for the destination instances</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Select a security group for the destination instances",
        SerializedName = @"autoSelectSecurityGroup",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISecurityGroup) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityGroup> AutoSelectSecurityGroup { get; set; }
        /// <summary>Destination zone</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Destination zone",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable required drivers to be installed on the Amazon guest instance",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }
        /// <summary>Encryption key if used</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Encryption key if used",
        SerializedName = @"encryptionKey",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionKey { get; set; }
        /// <summary>The name of the computer</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the computer",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string GuestCredComputerName { get; set; }
        /// <summary>The password of the user in Base64 format</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The password of the user in Base64 format",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string GuestCredPassword { get; set; }
        /// <summary>The user to be used to access the computer</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The user to be used to access the computer",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string GuestCredUserName { get; set; }
        /// <summary>Display name for the destination instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Display name for the destination instance",
        SerializedName = @"instanceName",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceName { get; set; }
        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Provides the available CPU cores and memory for the instance.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }
        /// <summary>Network display name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkDisplayName { get; set; }
        /// <summary>VPC Id of the network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VPC Id of the network",
        SerializedName = @"networkId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkId { get; set; }
        /// <summary>Name of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of network",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkName { get; set; }
        /// <summary>Private IP address of the network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private IP address of the network",
        SerializedName = @"privateIPaddress",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkPrivateIPaddress { get; set; }
        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subnet id of network",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSubnetId { get; set; }
        /// <summary>Network display name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Network display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverNetworkDisplayName { get; set; }
        /// <summary>VPC Id of the network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VPC Id of the network",
        SerializedName = @"networkId",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverNetworkId { get; set; }
        /// <summary>Name of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of network",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverNetworkName { get; set; }
        /// <summary>Private IP address of the network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Private IP address of the network",
        SerializedName = @"privateIPaddress",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverNetworkPrivateIPaddress { get; set; }
        /// <summary>subnet id of network</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"subnet id of network",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string TestFailoverNetworkSubnetId { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable required drivers to be installed on the Amazon guest instance",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }
        /// <summary>Type of volume used for replication</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of volume used for replication",
        SerializedName = @"volumeType",
        PossibleTypes = new [] { typeof(string) })]
        string VolumeType { get; set; }

    }
    /// Replication options for Amazon
    internal partial interface IOverrideReplicationOptionsAmazonInternal

    {
        /// <summary>Select a security group for the destination instances</summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.ISecurityGroup> AutoSelectSecurityGroup { get; set; }
        /// <summary>Destination zone</summary>
        string AvailabilityZone { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        string ComputerName { get; set; }
        /// <summary>Encryption key if used</summary>
        string EncryptionKey { get; set; }
        /// <summary>The name of the computer</summary>
        string GuestCredComputerName { get; set; }
        /// <summary>The password of the user in Base64 format</summary>
        string GuestCredPassword { get; set; }
        /// <summary>The user to be used to access the computer</summary>
        string GuestCredUserName { get; set; }
        /// <summary>
        /// Faster performance can be achieved during replication by using the VSA access node running on the Amazon instance. Applicable
        /// only if the source VM is Windows and the source hypervisor is not Amazon vendor.
        /// </summary>
        Commvault.Powershell.Models.IGuestCredentialsCreate GuestCreds { get; set; }
        /// <summary>Display name for the destination instance</summary>
        string InstanceName { get; set; }
        /// <summary>Provides the available CPU cores and memory for the instance.</summary>
        string InstanceType { get; set; }
        /// <summary>Network interface for the destination instances</summary>
        Commvault.Powershell.Models.IAmazonNetwork Network { get; set; }
        /// <summary>Network display name</summary>
        string NetworkDisplayName { get; set; }
        /// <summary>VPC Id of the network</summary>
        string NetworkId { get; set; }
        /// <summary>Name of network</summary>
        string NetworkName { get; set; }
        /// <summary>Private IP address of the network</summary>
        string NetworkPrivateIPaddress { get; set; }
        /// <summary>subnet id of network</summary>
        string NetworkSubnetId { get; set; }
        /// <summary>Network interface for the destination instances</summary>
        Commvault.Powershell.Models.IAmazonNetwork TestFailoverNetwork { get; set; }
        /// <summary>Network display name</summary>
        string TestFailoverNetworkDisplayName { get; set; }
        /// <summary>VPC Id of the network</summary>
        string TestFailoverNetworkId { get; set; }
        /// <summary>Name of network</summary>
        string TestFailoverNetworkName { get; set; }
        /// <summary>Private IP address of the network</summary>
        string TestFailoverNetworkPrivateIPaddress { get; set; }
        /// <summary>subnet id of network</summary>
        string TestFailoverNetworkSubnetId { get; set; }
        /// <summary>Enable required drivers to be installed on the Amazon guest instance</summary>
        string UserName { get; set; }
        /// <summary>Type of volume used for replication</summary>
        string VolumeType { get; set; }

    }
}