// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class DiskStorage :
        Commvault.Powershell.Models.IDiskStorage,
        Commvault.Powershell.Models.IDiskStorageInternal
    {

        /// <summary>Backing field for <see cref="AssociatedPlanList" /> property.</summary>
        private Commvault.Powershell.Models.IIdName[] _associatedPlanList;

        /// <summary>Provides the list of plans associated with the storage pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdName[] AssociatedPlanList { get => this._associatedPlanList; set => this._associatedPlanList = value; }

        /// <summary>Backing field for <see cref="BackupLocations" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameStatus[] _backupLocations;

        /// <summary>Gives backup location/mount path details for the storage pool.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IIdNameStatus[] BackupLocations { get => this._backupLocations; set => this._backupLocations = value; }

        /// <summary>Internal Acessors for Encryption</summary>
        Commvault.Powershell.Models.IEncryption Commvault.Powershell.Models.IDiskStorageInternal.Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set { {_encryption = value;} } }

        /// <summary>Internal Acessors for EncryptionKeyProvider</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDiskStorageInternal.EncryptionKeyProvider { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProvider = value; }

        /// <summary>Internal Acessors for General</summary>
        Commvault.Powershell.Models.IDiskStorageGeneralInfo Commvault.Powershell.Models.IDiskStorageInternal.General { get => (this._general = this._general ?? new Commvault.Powershell.Models.DiskStorageGeneralInfo()); set { {_general = value;} } }

        /// <summary>Internal Acessors for Security</summary>
        Commvault.Powershell.Models.ISecurityAssoc Commvault.Powershell.Models.IDiskStorageInternal.Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.SecurityAssoc()); set { {_security = value;} } }

        /// <summary>Internal Acessors for SecurityExternalUserGroup</summary>
        Commvault.Powershell.Models.IExternalUserGroup Commvault.Powershell.Models.IDiskStorageInternal.SecurityExternalUserGroup { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroup; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroup = value; }

        /// <summary>Internal Acessors for SecurityRole</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDiskStorageInternal.SecurityRole { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).Role; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).Role = value; }

        /// <summary>Internal Acessors for SecurityUser</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDiskStorageInternal.SecurityUser { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).User; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).User = value; }

        /// <summary>Internal Acessors for SecurityUserGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IDiskStorageInternal.SecurityUserGroup { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroup; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroup = value; }

        /// <summary>Backing field for <see cref="Encryption" /> property.</summary>
        private Commvault.Powershell.Models.IEncryption _encryption;

        /// <summary>Different ways in which data can be encrypted.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IEncryption Encryption { get => (this._encryption = this._encryption ?? new Commvault.Powershell.Models.Encryption()); set => this._encryption = value; }

        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string EncryptionCipher { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Cipher; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Cipher = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? EncryptionEncrypt { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Encrypt; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).Encrypt = value ?? default(bool); }

        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? EncryptionKeyLength { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyLength; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyLength = value ?? default(long); }

        /// <summary>User Group Id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? ExternalUserGroupId { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupId; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupId = value ?? default(long); }

        /// <summary>External Group Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ExternalUserGroupName { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupName; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupName = value ?? null; }

        /// <summary>Provider id</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? ExternalUserGroupProviderId { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupProviderId; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupProviderId = value ?? default(long); }

        /// <summary>Provider Name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ExternalUserGroupProviderName { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupProviderName; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).ExternalUserGroupProviderName = value ?? null; }

        /// <summary>Backing field for <see cref="General" /> property.</summary>
        private Commvault.Powershell.Models.IDiskStorageGeneralInfo _general;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IDiskStorageGeneralInfo General { get => (this._general = this._general ?? new Commvault.Powershell.Models.DiskStorageGeneralInfo()); set => this._general = value; }

        /// <summary>specifies the capacity of the storage pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? GeneralCapacity { get => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).Capacity; set => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).Capacity = value ?? default(long); }

        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? GeneralDedupeSavingsPercent { get => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).DedupeSavingsPercent; set => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).DedupeSavingsPercent = value ?? default(long); }

        /// <summary>specifies the available space on the storage pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? GeneralFreeSpace { get => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).FreeSpace; set => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).FreeSpace = value ?? default(long); }

        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? GeneralSizeOnDisk { get => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).SizeOnDisk; set => ((Commvault.Powershell.Models.IDiskStorageGeneralInfoInternal)General).SizeOnDisk = value ?? default(long); }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>Id of the Disk Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? KeyProviderId { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string KeyProviderName { get => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName; set => ((Commvault.Powershell.Models.IEncryptionInternal)Encryption).KeyProviderName = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the Disk Storage Pool</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? RoleId { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).RoleId; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).RoleId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string RoleName { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).RoleName; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).RoleName = value ?? null; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ISecurityAssoc _security;

        /// <summary>
        /// A list of users or user groups each having a specific set of roles that determine the kind of operations they can perform
        /// on the entity.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ISecurityAssoc Security { get => (this._security = this._security ?? new Commvault.Powershell.Models.SecurityAssoc()); set => this._security = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? SecurityIsCreatorAssociation { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).IsCreatorAssociation; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).IsCreatorAssociation = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public Commvault.Powershell.Models.IPermissionResp[] SecurityPermissionList { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).PermissionList; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).PermissionList = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UserGroupId { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroupId; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroupId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserGroupName { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroupName; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserGroupName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UserId { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserId; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UserName { get => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserName; set => ((Commvault.Powershell.Models.ISecurityAssocInternal)Security).UserName = value ?? null; }

        /// <summary>Creates an new <see cref="DiskStorage" /> instance.</summary>
        public DiskStorage()
        {

        }
    }
    public partial interface IDiskStorage :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Provides the list of plans associated with the storage pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides the list of plans associated with the storage pool.",
        SerializedName = @"associatedPlanList",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        Commvault.Powershell.Models.IIdName[] AssociatedPlanList { get; set; }
        /// <summary>Gives backup location/mount path details for the storage pool.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives backup location/mount path details for the storage pool.",
        SerializedName = @"backupLocations",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdNameStatus) })]
        Commvault.Powershell.Models.IIdNameStatus[] BackupLocations { get; set; }
        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The different types of encryption keys that can be used for encrypting the data. The values are case sensitive",
        SerializedName = @"cipher",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptionCipher { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"encrypt",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EncryptionEncrypt { get; set; }
        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128 and 256. DES3 accepts only 192. GOST accepts only 256. ",
        SerializedName = @"keyLength",
        PossibleTypes = new [] { typeof(long) })]
        long? EncryptionKeyLength { get; set; }
        /// <summary>User Group Id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User Group Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? ExternalUserGroupId { get; set; }
        /// <summary>External Group Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External Group Name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalUserGroupName { get; set; }
        /// <summary>Provider id</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider id",
        SerializedName = @"providerId",
        PossibleTypes = new [] { typeof(long) })]
        long? ExternalUserGroupProviderId { get; set; }
        /// <summary>Provider Name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider Name",
        SerializedName = @"providerName",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalUserGroupProviderName { get; set; }
        /// <summary>specifies the capacity of the storage pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the capacity of the storage pool",
        SerializedName = @"capacity",
        PossibleTypes = new [] { typeof(long) })]
        long? GeneralCapacity { get; set; }
        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.",
        SerializedName = @"dedupeSavingsPercent",
        PossibleTypes = new [] { typeof(long) })]
        long? GeneralDedupeSavingsPercent { get; set; }
        /// <summary>specifies the available space on the storage pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"specifies the available space on the storage pool",
        SerializedName = @"freeSpace",
        PossibleTypes = new [] { typeof(long) })]
        long? GeneralFreeSpace { get; set; }
        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size on disk refers to the actual amount of space being taken by the storage pool on the disk.",
        SerializedName = @"sizeOnDisk",
        PossibleTypes = new [] { typeof(long) })]
        long? GeneralSizeOnDisk { get; set; }
        /// <summary>Id of the Disk Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the Disk Storage Pool",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? KeyProviderId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string KeyProviderName { get; set; }
        /// <summary>Name of the Disk Storage Pool</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the Disk Storage Pool",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? RoleId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string RoleName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isCreatorAssociation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityIsCreatorAssociation { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"permissionList",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IPermissionResp) })]
        Commvault.Powershell.Models.IPermissionResp[] SecurityPermissionList { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? UserGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? UserId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    internal partial interface IDiskStorageInternal

    {
        /// <summary>Provides the list of plans associated with the storage pool.</summary>
        Commvault.Powershell.Models.IIdName[] AssociatedPlanList { get; set; }
        /// <summary>Gives backup location/mount path details for the storage pool.</summary>
        Commvault.Powershell.Models.IIdNameStatus[] BackupLocations { get; set; }
        /// <summary>Different ways in which data can be encrypted.</summary>
        Commvault.Powershell.Models.IEncryption Encryption { get; set; }
        /// <summary>
        /// The different types of encryption keys that can be used for encrypting the data. The values are case sensitive
        /// </summary>
        string EncryptionCipher { get; set; }

        bool? EncryptionEncrypt { get; set; }
        /// <summary>
        /// Different keylengths are present for different kinds of ciphers. Blowfish,Twofish,AES and Serpent all accept both 128
        /// and 256. DES3 accepts only 192. GOST accepts only 256.
        /// </summary>
        long? EncryptionKeyLength { get; set; }

        Commvault.Powershell.Models.IIdName EncryptionKeyProvider { get; set; }
        /// <summary>User Group Id</summary>
        long? ExternalUserGroupId { get; set; }
        /// <summary>External Group Name</summary>
        string ExternalUserGroupName { get; set; }
        /// <summary>Provider id</summary>
        long? ExternalUserGroupProviderId { get; set; }
        /// <summary>Provider Name</summary>
        string ExternalUserGroupProviderName { get; set; }

        Commvault.Powershell.Models.IDiskStorageGeneralInfo General { get; set; }
        /// <summary>specifies the capacity of the storage pool</summary>
        long? GeneralCapacity { get; set; }
        /// <summary>
        /// specifies the savings that occurred due to deduplication. Only available for dedupe storage pools.
        /// </summary>
        long? GeneralDedupeSavingsPercent { get; set; }
        /// <summary>specifies the available space on the storage pool</summary>
        long? GeneralFreeSpace { get; set; }
        /// <summary>
        /// Size on disk refers to the actual amount of space being taken by the storage pool on the disk.
        /// </summary>
        long? GeneralSizeOnDisk { get; set; }
        /// <summary>Id of the Disk Storage Pool</summary>
        long? Id { get; set; }

        long? KeyProviderId { get; set; }

        string KeyProviderName { get; set; }
        /// <summary>Name of the Disk Storage Pool</summary>
        string Name { get; set; }

        long? RoleId { get; set; }

        string RoleName { get; set; }
        /// <summary>
        /// A list of users or user groups each having a specific set of roles that determine the kind of operations they can perform
        /// on the entity.
        /// </summary>
        Commvault.Powershell.Models.ISecurityAssoc Security { get; set; }
        /// <summary>External User Group Entity</summary>
        Commvault.Powershell.Models.IExternalUserGroup SecurityExternalUserGroup { get; set; }

        bool? SecurityIsCreatorAssociation { get; set; }

        Commvault.Powershell.Models.IPermissionResp[] SecurityPermissionList { get; set; }

        Commvault.Powershell.Models.IIdName SecurityRole { get; set; }

        Commvault.Powershell.Models.IIdName SecurityUser { get; set; }

        Commvault.Powershell.Models.IIdName SecurityUserGroup { get; set; }

        long? UserGroupId { get; set; }

        string UserGroupName { get; set; }

        long? UserId { get; set; }

        string UserName { get; set; }

    }
}