// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create LDAP request</summary>
    public partial class LdapRequest :
        Commvault.Powershell.Models.ILdapRequest,
        Commvault.Powershell.Models.ILdapRequestInternal
    {

        /// <summary>Backing field for <see cref="AccessViaClient" /> property.</summary>
        private bool? _accessViaClient;

        /// <summary>Denotes if the domain is accessed via a proxy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AccessViaClient { get => this._accessViaClient; set => this._accessViaClient = value; }

        /// <summary>Backing field for <see cref="DoNotValidateNetBiosName" /> property.</summary>
        private bool? _doNotValidateNetBiosName;

        /// <summary>
        /// If true, the NetBIOS name will not be validated. Providing a custom name without validation may cause problems during
        /// Single Sign-On.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? DoNotValidateNetBiosName { get => this._doNotValidateNetBiosName; set => this._doNotValidateNetBiosName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>Required when configuring an existing dummy domain as LDAP/AD</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Password to create LDAP app, it should be base64 encoded</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Proxies" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> _proxies;

        /// <summary>
        /// List of proxies used to connect to the domain. Required if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get => this._proxies; set => this._proxies = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>Username to create LDAP/AD app</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="LdapRequest" /> instance.</summary>
        public LdapRequest()
        {

        }
    }
    /// Create LDAP request
    public partial interface ILdapRequest :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Denotes if the domain is accessed via a proxy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Denotes if the domain is accessed via a proxy",
        SerializedName = @"accessViaClient",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AccessViaClient { get; set; }
        /// <summary>
        /// If true, the NetBIOS name will not be validated. Providing a custom name without validation may cause problems during
        /// Single Sign-On.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If true, the NetBIOS name will not be validated. Providing a custom name without validation may cause problems during Single Sign-On.",
        SerializedName = @"doNotValidateNetBIOSName",
        PossibleTypes = new [] { typeof(bool) })]
        bool? DoNotValidateNetBiosName { get; set; }
        /// <summary>Required when configuring an existing dummy domain as LDAP/AD</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Required when configuring an existing dummy domain as LDAP/AD",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>Password to create LDAP app, it should be base64 encoded</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Password to create LDAP app, it should be base64 encoded",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>
        /// List of proxies used to connect to the domain. Required if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of proxies used to connect to the domain. Required if accessViaClient is true.",
        SerializedName = @"proxies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get; set; }
        /// <summary>Username to create LDAP/AD app</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Username to create LDAP/AD app",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Create LDAP request
    internal partial interface ILdapRequestInternal

    {
        /// <summary>Denotes if the domain is accessed via a proxy</summary>
        bool? AccessViaClient { get; set; }
        /// <summary>
        /// If true, the NetBIOS name will not be validated. Providing a custom name without validation may cause problems during
        /// Single Sign-On.
        /// </summary>
        bool? DoNotValidateNetBiosName { get; set; }
        /// <summary>Required when configuring an existing dummy domain as LDAP/AD</summary>
        long? Id { get; set; }
        /// <summary>Password to create LDAP app, it should be base64 encoded</summary>
        string Password { get; set; }
        /// <summary>
        /// List of proxies used to connect to the domain. Required if accessViaClient is true.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get; set; }
        /// <summary>Username to create LDAP/AD app</summary>
        string Username { get; set; }

    }
}