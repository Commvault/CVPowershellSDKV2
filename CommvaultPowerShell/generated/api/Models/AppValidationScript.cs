// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Custom validation script to be used during VM backup validation</summary>
    public partial class AppValidationScript :
        Commvault.Powershell.Models.IAppValidationScript,
        Commvault.Powershell.Models.IAppValidationScriptInternal
    {

        /// <summary>Internal Acessors for Unix</summary>
        Commvault.Powershell.Models.IValidationScript Commvault.Powershell.Models.IAppValidationScriptInternal.Unix { get => (this._unix = this._unix ?? new Commvault.Powershell.Models.ValidationScript()); set { {_unix = value;} } }

        /// <summary>Internal Acessors for UnixUncCredentials</summary>
        Commvault.Powershell.Models.IUserNamePassword Commvault.Powershell.Models.IAppValidationScriptInternal.UnixUncCredentials { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentials; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentials = value; }

        /// <summary>Internal Acessors for UnixUncSavedCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAppValidationScriptInternal.UnixUncSavedCredentials { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentials; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentials = value; }

        /// <summary>Internal Acessors for WindowUncCredentials</summary>
        Commvault.Powershell.Models.IUserNamePassword Commvault.Powershell.Models.IAppValidationScriptInternal.WindowUncCredentials { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentials; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentials = value; }

        /// <summary>Internal Acessors for WindowUncSavedCredentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IAppValidationScriptInternal.WindowUncSavedCredentials { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentials; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentials = value; }

        /// <summary>Internal Acessors for Windows</summary>
        Commvault.Powershell.Models.IValidationScript Commvault.Powershell.Models.IAppValidationScriptInternal.Windows { get => (this._windows = this._windows ?? new Commvault.Powershell.Models.ValidationScript()); set { {_windows = value;} } }

        /// <summary>Backing field for <see cref="Unix" /> property.</summary>
        private Commvault.Powershell.Models.IValidationScript _unix;

        /// <summary>ValidationScript</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IValidationScript Unix { get => (this._unix = this._unix ?? new Commvault.Powershell.Models.ValidationScript()); set => this._unix = value; }

        /// <summary>Arguments for the script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UnixArguments { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).Arguments; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).Arguments = value ?? null; }

        /// <summary>Is the script disabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? UnixIsDisabled { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).IsDisabled; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).IsDisabled = value ?? default(bool); }

        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? UnixIsUnc { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).IsUnc; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).IsUnc = value ?? default(bool); }

        /// <summary>Path for the validation script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UnixPath { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).Path; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).Path = value ?? null; }

        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UnixUNCCredentialsName { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentialsName; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentialsName = value ?? null; }

        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UnixUNCCredentialsPassword { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentialsPassword; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncCredentialsPassword = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UnixUNCSavedCredentialsId { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentialsId; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentialsId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string UnixUNCSavedCredentialsName { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentialsName; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Unix).UncSavedCredentialsName = value ?? null; }

        /// <summary>Arguments for the script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string WindowArguments { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).Arguments; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).Arguments = value ?? null; }

        /// <summary>Is the script disabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? WindowIsDisabled { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).IsDisabled; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).IsDisabled = value ?? default(bool); }

        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? WindowIsUnc { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).IsUnc; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).IsUnc = value ?? default(bool); }

        /// <summary>Path for the validation script</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string WindowPath { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).Path; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).Path = value ?? null; }

        /// <summary>Backing field for <see cref="Windows" /> property.</summary>
        private Commvault.Powershell.Models.IValidationScript _windows;

        /// <summary>ValidationScript</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IValidationScript Windows { get => (this._windows = this._windows ?? new Commvault.Powershell.Models.ValidationScript()); set => this._windows = value; }

        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string WindowsUNCCredentialsName { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentialsName; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentialsName = value ?? null; }

        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string WindowsUNCCredentialsPassword { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentialsPassword; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncCredentialsPassword = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? WindowsUNCSavedCredentialsId { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentialsId; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentialsId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string WindowsUNCSavedCredentialsName { get => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentialsName; set => ((Commvault.Powershell.Models.IValidationScriptInternal)Windows).UncSavedCredentialsName = value ?? null; }

        /// <summary>Creates an new <see cref="AppValidationScript" /> instance.</summary>
        public AppValidationScript()
        {

        }
    }
    /// Custom validation script to be used during VM backup validation
    public partial interface IAppValidationScript :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Arguments for the script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arguments for the script",
        SerializedName = @"arguments",
        PossibleTypes = new [] { typeof(string) })]
        string UnixArguments { get; set; }
        /// <summary>Is the script disabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the script disabled",
        SerializedName = @"isDisabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnixIsDisabled { get; set; }
        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the script is a UNC script, False if it is a local script",
        SerializedName = @"isUNC",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnixIsUnc { get; set; }
        /// <summary>Path for the validation script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path for the validation script",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string UnixPath { get; set; }
        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"username to access the network path",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UnixUNCCredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password to access the network path",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string UnixUNCCredentialsPassword { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? UnixUNCSavedCredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string UnixUNCSavedCredentialsName { get; set; }
        /// <summary>Arguments for the script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Arguments for the script",
        SerializedName = @"arguments",
        PossibleTypes = new [] { typeof(string) })]
        string WindowArguments { get; set; }
        /// <summary>Is the script disabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the script disabled",
        SerializedName = @"isDisabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowIsDisabled { get; set; }
        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the script is a UNC script, False if it is a local script",
        SerializedName = @"isUNC",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowIsUnc { get; set; }
        /// <summary>Path for the validation script</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path for the validation script",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string WindowPath { get; set; }
        /// <summary>username to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"username to access the network path",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string WindowsUNCCredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"password to access the network path",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string WindowsUNCCredentialsPassword { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? WindowsUNCSavedCredentialsId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string WindowsUNCSavedCredentialsName { get; set; }

    }
    /// Custom validation script to be used during VM backup validation
    internal partial interface IAppValidationScriptInternal

    {
        /// <summary>ValidationScript</summary>
        Commvault.Powershell.Models.IValidationScript Unix { get; set; }
        /// <summary>Arguments for the script</summary>
        string UnixArguments { get; set; }
        /// <summary>Is the script disabled</summary>
        bool? UnixIsDisabled { get; set; }
        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        bool? UnixIsUnc { get; set; }
        /// <summary>Path for the validation script</summary>
        string UnixPath { get; set; }
        /// <summary>username to access the network path</summary>
        string UnixUNCCredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        string UnixUNCCredentialsPassword { get; set; }

        long? UnixUNCSavedCredentialsId { get; set; }

        string UnixUNCSavedCredentialsName { get; set; }

        Commvault.Powershell.Models.IUserNamePassword UnixUncCredentials { get; set; }

        Commvault.Powershell.Models.IIdName UnixUncSavedCredentials { get; set; }
        /// <summary>Arguments for the script</summary>
        string WindowArguments { get; set; }
        /// <summary>Is the script disabled</summary>
        bool? WindowIsDisabled { get; set; }
        /// <summary>True if the script is a UNC script, False if it is a local script</summary>
        bool? WindowIsUnc { get; set; }
        /// <summary>Path for the validation script</summary>
        string WindowPath { get; set; }

        Commvault.Powershell.Models.IUserNamePassword WindowUncCredentials { get; set; }

        Commvault.Powershell.Models.IIdName WindowUncSavedCredentials { get; set; }
        /// <summary>ValidationScript</summary>
        Commvault.Powershell.Models.IValidationScript Windows { get; set; }
        /// <summary>username to access the network path</summary>
        string WindowsUNCCredentialsName { get; set; }
        /// <summary>password to access the network path</summary>
        string WindowsUNCCredentialsPassword { get; set; }

        long? WindowsUNCSavedCredentialsId { get; set; }

        string WindowsUNCSavedCredentialsName { get; set; }

    }
}