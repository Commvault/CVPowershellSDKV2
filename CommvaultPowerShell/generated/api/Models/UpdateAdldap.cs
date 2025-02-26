// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update the properties of an AD/LDAP</summary>
    public partial class UpdateAdldap :
        Commvault.Powershell.Models.IUpdateAdldap,
        Commvault.Powershell.Models.IUpdateAdldapInternal
    {

        /// <summary>Backing field for <see cref="AccessViaClient" /> property.</summary>
        private bool? _accessViaClient;

        /// <summary>Denotes if the domain is to be accessed via a proxy</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? AccessViaClient { get => this._accessViaClient; set => this._accessViaClient = value; }

        /// <summary>Backing field for <see cref="AttributeMap" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> _attributeMap;

        /// <summary>
        /// List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> AttributeMap { get => this._attributeMap; set => this._attributeMap = value; }

        /// <summary>Backing field for <see cref="BaseDnForCardUsers" /> property.</summary>
        private string _baseDnForCardUsers;

        /// <summary>Base DN for card users</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string BaseDnForCardUsers { get => this._baseDnForCardUsers; set => this._baseDnForCardUsers = value; }

        /// <summary>Backing field for <see cref="DirectoryType" /> property.</summary>
        private string _directoryType;

        /// <summary>Directory type of an AD/LDAP domain</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DirectoryType { get => this._directoryType; set => this._directoryType = value; }

        /// <summary>Backing field for <see cref="EnableSso" /> property.</summary>
        private bool? _enableSso;

        /// <summary>
        /// Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? EnableSso { get => this._enableSso; set => this._enableSso = value; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="LdapQueryParameters" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> _ldapQueryParameters;

        /// <summary>
        /// List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> LdapQueryParameters { get => this._ldapQueryParameters; set => this._ldapQueryParameters = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The fully qualified domain name, for example, my.domain.example.com</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NetbiosName" /> property.</summary>
        private string _netbiosName;

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY,
        /// OPEN_LDAP or ORACLE_DIRECTORY
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string NetbiosName { get => this._netbiosName; set => this._netbiosName = value; }

        /// <summary>Backing field for <see cref="OsxServerName" /> property.</summary>
        private string _osxServerName;

        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string OsxServerName { get => this._osxServerName; set => this._osxServerName = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Password for the domain user. Should be in Base64 encoded format.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="Proxies" /> property.</summary>
        private System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> _proxies;

        /// <summary>
        /// List of proxies used to connect to the domain. Available only if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get => this._proxies; set => this._proxies = value; }

        /// <summary>Backing field for <see cref="UseSecureLdap" /> property.</summary>
        private bool? _useSecureLdap;

        /// <summary>
        /// Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and
        /// LDAP_SERVER.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseSecureLdap { get => this._useSecureLdap; set => this._useSecureLdap = value; }

        /// <summary>Backing field for <see cref="Username" /> property.</summary>
        private string _username;

        /// <summary>The username for a user who has at least read permission for the domain</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Username { get => this._username; set => this._username = value; }

        /// <summary>Creates an new <see cref="UpdateAdldap" /> instance.</summary>
        public UpdateAdldap()
        {

        }
    }
    /// Update the properties of an AD/LDAP
    public partial interface IUpdateAdldap :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Denotes if the domain is to be accessed via a proxy</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Denotes if the domain is to be accessed via a proxy",
        SerializedName = @"accessViaClient",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AccessViaClient { get; set; }
        /// <summary>
        /// List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.",
        SerializedName = @"attributeMap",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ILdapAttribute) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> AttributeMap { get; set; }
        /// <summary>Base DN for card users</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Base DN for card users",
        SerializedName = @"baseDNForCardUsers",
        PossibleTypes = new [] { typeof(string) })]
        string BaseDnForCardUsers { get; set; }
        /// <summary>Directory type of an AD/LDAP domain</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Directory type of an AD/LDAP domain",
        SerializedName = @"directoryType",
        PossibleTypes = new [] { typeof(string) })]
        string DirectoryType { get; set; }
        /// <summary>
        /// Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.",
        SerializedName = @"enableSSO",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableSso { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>
        /// List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER",
        SerializedName = @"LDAPQueryParameters",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ILdapAttribute) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> LdapQueryParameters { get; set; }
        /// <summary>The fully qualified domain name, for example, my.domain.example.com</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified domain name, for example, my.domain.example.com",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY,
        /// OPEN_LDAP or ORACLE_DIRECTORY
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY, OPEN_LDAP or ORACLE_DIRECTORY ",
        SerializedName = @"NETBIOSName",
        PossibleTypes = new [] { typeof(string) })]
        string NetbiosName { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE",
        SerializedName = @"OSXServerName",
        PossibleTypes = new [] { typeof(string) })]
        string OsxServerName { get; set; }
        /// <summary>Password for the domain user. Should be in Base64 encoded format.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Password for the domain user. Should be in Base64 encoded format.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>
        /// List of proxies used to connect to the domain. Available only if accessViaClient is true.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of proxies used to connect to the domain. Available only if accessViaClient is true.",
        SerializedName = @"proxies",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IIdName) })]
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get; set; }
        /// <summary>
        /// Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and
        /// LDAP_SERVER.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and LDAP_SERVER.",
        SerializedName = @"useSecureLDAP",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseSecureLdap { get; set; }
        /// <summary>The username for a user who has at least read permission for the domain</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The username for a user who has at least read permission for the domain",
        SerializedName = @"username",
        PossibleTypes = new [] { typeof(string) })]
        string Username { get; set; }

    }
    /// Update the properties of an AD/LDAP
    internal partial interface IUpdateAdldapInternal

    {
        /// <summary>Denotes if the domain is to be accessed via a proxy</summary>
        bool? AccessViaClient { get; set; }
        /// <summary>
        /// List of overridden attribute mappings for the LDAP domain. Valid only if the directoryType is LDAP_SERVER.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> AttributeMap { get; set; }
        /// <summary>Base DN for card users</summary>
        string BaseDnForCardUsers { get; set; }
        /// <summary>Directory type of an AD/LDAP domain</summary>
        string DirectoryType { get; set; }
        /// <summary>
        /// Denotes if SSO should be enabled for the domain. Valid only for ACTIVE_DIRECTORY.
        /// </summary>
        bool? EnableSso { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is LDAP_SERVER
        /// </summary>
        string Host { get; set; }
        /// <summary>
        /// List of overridden query parameters for the LDAP domain. Valid only if the directory type is LDAP_SERVER
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.ILdapAttribute> LdapQueryParameters { get; set; }
        /// <summary>The fully qualified domain name, for example, my.domain.example.com</summary>
        string Name { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is ACTIVE_DIRECTORY,
        /// OPEN_LDAP or ORACLE_DIRECTORY
        /// </summary>
        string NetbiosName { get; set; }
        /// <summary>
        /// The fully qualified domain name that you use to identify this network resource. Required only if directoryType is APPLE_DIRECTORY_SERVICE
        /// </summary>
        string OsxServerName { get; set; }
        /// <summary>Password for the domain user. Should be in Base64 encoded format.</summary>
        string Password { get; set; }
        /// <summary>
        /// List of proxies used to connect to the domain. Available only if accessViaClient is true.
        /// </summary>
        System.Collections.Generic.List<Commvault.Powershell.Models.IIdName> Proxies { get; set; }
        /// <summary>
        /// Boolean to indicate if the app use secure LDAP. Valid only for directory types - ACTIVE_DIRECTORY, ORACLE_DIRECTORY and
        /// LDAP_SERVER.
        /// </summary>
        bool? UseSecureLdap { get; set; }
        /// <summary>The username for a user who has at least read permission for the domain</summary>
        string Username { get; set; }

    }
}