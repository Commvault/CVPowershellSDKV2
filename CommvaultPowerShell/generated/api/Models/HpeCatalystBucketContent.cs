// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>HPE Catalyst Storage</summary>
    public partial class HpeCatalystBucketContent :
        Commvault.Powershell.Models.IHpeCatalystBucketContent,
        Commvault.Powershell.Models.IHpeCatalystBucketContentInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageAdvanced" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageAdvanced __cloudStorageAdvanced = new Commvault.Powershell.Models.CloudStorageAdvanced();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IModifyCloudBucketConfiguration" />
        /// </summary>
        private Commvault.Powershell.Models.IModifyCloudBucketConfiguration __modifyCloudBucketConfiguration = new Commvault.Powershell.Models.ModifyCloudBucketConfiguration();

        /// <summary>
        /// The access type for the access path can be either read (writing to path not allowed) or read and write (writing to path
        /// allowed).
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Access { get => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Access; set => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Access = value ?? null; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"HPE Catalyst Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IHpeCatalystBucketContentInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for MediaAgent</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IHpeCatalystBucketContentInternal.MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set { {_mediaAgent = value;} } }

        /// <summary>Internal Acessors for Configuration</summary>
        Commvault.Powershell.Models.ICloudBucketConfiguration Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal.Configuration { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration = value; }

        /// <summary>Internal Acessors for ConfigurationStorageAcceleratorCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal.ConfigurationStorageAcceleratorCredentials { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials = value; }

        /// <summary>CloudBucketConfiguration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.ICloudBucketConfiguration Configuration { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration = value ?? null /* model class */; }

        /// <summary>
        /// When true, prevents new data writes to backup location by changing number of writers to zero
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ConfigurationDisableBackupLocationForFutureBackups { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationDisableBackupLocationForFutureBackups; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationDisableBackupLocationForFutureBackups = value ?? default(bool); }

        /// <summary>When true, means mount path is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ConfigurationEnable { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationEnable; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationEnable = value ?? default(bool); }

        /// <summary>
        /// When true, the deduplicated blocks in the mount path will not be referenced when there are multiple mount paths in the
        /// library.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ConfigurationPrepareForRetirement { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationPrepareForRetirement; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationPrepareForRetirement = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName ConfigurationStorageAcceleratorCredentials { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials = value ?? null /* model class */; }

        /// <summary>Enable/Disable access of bucket to a media Agent</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? Enable { get => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Enable; set => ((Commvault.Powershell.Models.ICloudStorageAdvancedInternal)__cloudStorageAdvanced).Enable = value ?? default(bool); }

        /// <summary>Backing field for <see cref="MediaAgent" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _mediaAgent;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set => this._mediaAgent = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? MediaAgentId { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string MediaAgentName { get => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)MediaAgent).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private System.Security.SecureString _password;

        /// <summary>
        /// Password used to access StoreOnce management console (Should be in Base64 format)
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Security.SecureString Password { get => this._password; set => this._password = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? StorageAcceleratorCredentialsId { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsId; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string StorageAcceleratorCredentialsName { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsName; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsName = value ?? null; }

        /// <summary>Backing field for <see cref="Store" /> property.</summary>
        private string _store;

        /// <summary>Name of the store that is created on the StoreOnce management console</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Store { get => this._store; set => this._store = value; }

        /// <summary>Backing field for <see cref="StoreOnceHost" /> property.</summary>
        private string _storeOnceHost;

        /// <summary>
        /// IP address or COFC identifier in case of Fibre Channel associated with the HPE StoreOnce device
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string StoreOnceHost { get => this._storeOnceHost; set => this._storeOnceHost = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>Username used to access StoreOnce management console</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="HpeCatalystBucketContent" /> instance.</summary>
        public HpeCatalystBucketContent()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
            await eventListener.AssertNotNull(nameof(__modifyCloudBucketConfiguration), __modifyCloudBucketConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__modifyCloudBucketConfiguration), __modifyCloudBucketConfiguration);
        }
    }
    /// HPE Catalyst Storage
    public partial interface IHpeCatalystBucketContent :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorageAdvanced,
        Commvault.Powershell.Models.IModifyCloudBucketConfiguration
    {
        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of cloud vendor",
        SerializedName = @"cloudType",
        PossibleTypes = new [] { typeof(string) })]
        string CloudType { get;  }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? MediaAgentId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string MediaAgentName { get; set; }
        /// <summary>
        /// Password used to access StoreOnce management console (Should be in Base64 format)
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Password used to access StoreOnce management console (Should be in Base64 format)",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Password { get; set; }
        /// <summary>Name of the store that is created on the StoreOnce management console</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the store that is created on the StoreOnce management console",
        SerializedName = @"store",
        PossibleTypes = new [] { typeof(string) })]
        string Store { get; set; }
        /// <summary>
        /// IP address or COFC identifier in case of Fibre Channel associated with the HPE StoreOnce device
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP address or COFC identifier in case of Fibre Channel associated with the HPE StoreOnce device",
        SerializedName = @"storeOnceHost",
        PossibleTypes = new [] { typeof(string) })]
        string StoreOnceHost { get; set; }
        /// <summary>Username used to access StoreOnce management console</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Username used to access StoreOnce management console",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// HPE Catalyst Storage
    internal partial interface IHpeCatalystBucketContentInternal :
        Commvault.Powershell.Models.ICloudStorageAdvancedInternal,
        Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal
    {
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }

        Commvault.Powershell.Models.IIdName MediaAgent { get; set; }

        long? MediaAgentId { get; set; }

        string MediaAgentName { get; set; }
        /// <summary>
        /// Password used to access StoreOnce management console (Should be in Base64 format)
        /// </summary>
        System.Security.SecureString Password { get; set; }
        /// <summary>Name of the store that is created on the StoreOnce management console</summary>
        string Store { get; set; }
        /// <summary>
        /// IP address or COFC identifier in case of Fibre Channel associated with the HPE StoreOnce device
        /// </summary>
        string StoreOnceHost { get; set; }
        /// <summary>Username used to access StoreOnce management console</summary>
        string Username { get; set; }

    }
}