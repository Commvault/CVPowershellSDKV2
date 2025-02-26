// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Wasabi Hot Cloud Storage</summary>
    public partial class WasabiHotBucketContent :
        Commvault.Powershell.Models.IWasabiHotBucketContent,
        Commvault.Powershell.Models.IWasabiHotBucketContentInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageAdvanced" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageAdvanced __cloudStorageAdvanced = new Commvault.Powershell.Models.CloudStorageAdvanced();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICloudStorageProxy" />
        /// </summary>
        private Commvault.Powershell.Models.ICloudStorageProxy __cloudStorageProxy = new Commvault.Powershell.Models.CloudStorageProxy();

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

        /// <summary>Backing field for <see cref="Bucket" /> property.</summary>
        private string _bucket;

        /// <summary>Name of bucket</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Bucket { get => this._bucket; set => this._bucket = value; }

        /// <summary>Backing field for <see cref="CloudType" /> property.</summary>
        private string _cloudType= @"Wasabi Hot Cloud Storage";

        /// <summary>Name of cloud vendor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string CloudType { get => this._cloudType; }

        /// <summary>Internal Acessors for Configuration</summary>
        Commvault.Powershell.Models.ICloudBucketConfiguration Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal.Configuration { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).Configuration = value; }

        /// <summary>Internal Acessors for ConfigurationStorageAcceleratorCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal.ConfigurationStorageAcceleratorCredentials { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).ConfigurationStorageAcceleratorCredentials = value; }

        /// <summary>Internal Acessors for CloudType</summary>
        string Commvault.Powershell.Models.IWasabiHotBucketContentInternal.CloudType { get => this._cloudType; set { {_cloudType = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IWasabiHotBucketContentInternal.Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set { {_credentials = value;} } }

        /// <summary>Internal Acessors for MediaAgent</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IWasabiHotBucketContentInternal.MediaAgent { get => (this._mediaAgent = this._mediaAgent ?? new Commvault.Powershell.Models.IdName()); set { {_mediaAgent = value;} } }

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

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _credentials;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Credentials { get => (this._credentials = this._credentials ?? new Commvault.Powershell.Models.IdName()); set => this._credentials = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CredentialsId { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Credentials).Name = value ?? null; }

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

        /// <summary>Password for proxy configuration (Should be in Base64 format)</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public System.Security.SecureString Password { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Password = value ?? null; }

        /// <summary>Port for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? Port { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Port = value ?? default(long); }

        /// <summary>
        /// If the MediaAgent accesses the mount path using a proxy then proxy server address needs to be provided. If you want to
        /// remove proxy information, pass empty string in proxyAddress.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string ProxyAddress { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).ProxyAddress; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).ProxyAddress = value ?? null; }

        /// <summary>Backing field for <see cref="ServiceHost" /> property.</summary>
        private string _serviceHost;

        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceHost { get => this._serviceHost; set => this._serviceHost = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? StorageAcceleratorCredentialsId { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsId; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string StorageAcceleratorCredentialsName { get => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsName; set => ((Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal)__modifyCloudBucketConfiguration).StorageAcceleratorCredentialsName = value ?? null; }

        /// <summary>Username for proxy configuration</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Username { get => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username; set => ((Commvault.Powershell.Models.ICloudStorageProxyInternal)__cloudStorageProxy).Username = value ?? null; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__cloudStorageProxy), __cloudStorageProxy);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorageProxy), __cloudStorageProxy);
            await eventListener.AssertNotNull(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
            await eventListener.AssertObjectIsValid(nameof(__cloudStorageAdvanced), __cloudStorageAdvanced);
            await eventListener.AssertNotNull(nameof(__modifyCloudBucketConfiguration), __modifyCloudBucketConfiguration);
            await eventListener.AssertObjectIsValid(nameof(__modifyCloudBucketConfiguration), __modifyCloudBucketConfiguration);
        }

        /// <summary>Creates an new <see cref="WasabiHotBucketContent" /> instance.</summary>
        public WasabiHotBucketContent()
        {

        }
    }
    /// Wasabi Hot Cloud Storage
    public partial interface IWasabiHotBucketContent :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICloudStorageProxy,
        Commvault.Powershell.Models.ICloudStorageAdvanced,
        Commvault.Powershell.Models.IModifyCloudBucketConfiguration
    {
        /// <summary>Name of bucket</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of bucket",
        SerializedName = @"bucket",
        PossibleTypes = new [] { typeof(string) })]
        string Bucket { get; set; }
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
        long? CredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsName { get; set; }

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
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP address or fully qualified domain name or URL for the cloud library based on cloud vendor",
        SerializedName = @"serviceHost",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceHost { get; set; }

    }
    /// Wasabi Hot Cloud Storage
    internal partial interface IWasabiHotBucketContentInternal :
        Commvault.Powershell.Models.ICloudStorageProxyInternal,
        Commvault.Powershell.Models.ICloudStorageAdvancedInternal,
        Commvault.Powershell.Models.IModifyCloudBucketConfigurationInternal
    {
        /// <summary>Name of bucket</summary>
        string Bucket { get; set; }
        /// <summary>Name of cloud vendor</summary>
        string CloudType { get; set; }

        Commvault.Powershell.Models.IIdName Credentials { get; set; }

        long? CredentialsId { get; set; }

        string CredentialsName { get; set; }

        Commvault.Powershell.Models.IIdName MediaAgent { get; set; }

        long? MediaAgentId { get; set; }

        string MediaAgentName { get; set; }
        /// <summary>
        /// IP address or fully qualified domain name or URL for the cloud library based on cloud vendor
        /// </summary>
        string ServiceHost { get; set; }

    }
}