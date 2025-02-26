// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>This feature applies only to file system agents</summary>
    public partial class PlanContent :
        Commvault.Powershell.Models.IPlanContent,
        Commvault.Powershell.Models.IPlanContentInternal
    {

        /// <summary>Backing field for <see cref="BackupSystemState" /> property.</summary>
        private bool? _backupSystemState;

        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? BackupSystemState { get => this._backupSystemState; set => this._backupSystemState = value; }

        /// <summary>Backing field for <see cref="BackupSystemStateOnlyWithFullBackup" /> property.</summary>
        private bool? _backupSystemStateOnlyWithFullBackup;

        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? BackupSystemStateOnlyWithFullBackup { get => this._backupSystemStateOnlyWithFullBackup; set => this._backupSystemStateOnlyWithFullBackup = value; }

        /// <summary>Internal Acessors for MacNumberOfDataReaders</summary>
        Commvault.Powershell.Models.IPlanContentDataReaders Commvault.Powershell.Models.IPlanContentInternal.MacNumberOfDataReaders { get => (this._macNumberOfDataReaders = this._macNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set { {_macNumberOfDataReaders = value;} } }

        /// <summary>Internal Acessors for UnixNumberOfDataReaders</summary>
        Commvault.Powershell.Models.IPlanContentDataReaders Commvault.Powershell.Models.IPlanContentInternal.UnixNumberOfDataReaders { get => (this._unixNumberOfDataReaders = this._unixNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set { {_unixNumberOfDataReaders = value;} } }

        /// <summary>Internal Acessors for WindowsNumberOfDataReaders</summary>
        Commvault.Powershell.Models.IPlanContentDataReaders Commvault.Powershell.Models.IPlanContentInternal.WindowsNumberOfDataReaders { get => (this._windowsNumberOfDataReaders = this._windowsNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set { {_windowsNumberOfDataReaders = value;} } }

        /// <summary>Backing field for <see cref="ForceUpdateProperties" /> property.</summary>
        private bool? _forceUpdateProperties;

        /// <summary>
        /// Do you want to sync properties on associated subclients even if properties are overriden at subclient level?
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ForceUpdateProperties { get => this._forceUpdateProperties; set => this._forceUpdateProperties = value; }

        /// <summary>Backing field for <see cref="MacExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _macExcludedPaths;

        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MacExcludedPaths { get => this._macExcludedPaths; set => this._macExcludedPaths = value; }

        /// <summary>Backing field for <see cref="MacFilterToExcludePaths" /> property.</summary>
        private System.Collections.Generic.List<string> _macFilterToExcludePaths;

        /// <summary>Paths that are exception to excluded paths for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MacFilterToExcludePaths { get => this._macFilterToExcludePaths; set => this._macFilterToExcludePaths = value; }

        /// <summary>Backing field for <see cref="MacIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _macIncludedPaths;

        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MacIncludedPaths { get => this._macIncludedPaths; set => this._macIncludedPaths = value; }

        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? MacNumberOfDataReaderCount { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)MacNumberOfDataReaders).Count; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)MacNumberOfDataReaders).Count = value ?? default(long); }

        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? MacNumberOfDataReaderUseOptimal { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)MacNumberOfDataReaders).UseOptimal; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)MacNumberOfDataReaders).UseOptimal = value ?? default(bool); }

        /// <summary>Backing field for <see cref="MacNumberOfDataReaders" /> property.</summary>
        private Commvault.Powershell.Models.IPlanContentDataReaders _macNumberOfDataReaders;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanContentDataReaders MacNumberOfDataReaders { get => (this._macNumberOfDataReaders = this._macNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set => this._macNumberOfDataReaders = value; }

        /// <summary>Backing field for <see cref="UnixExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _unixExcludedPaths;

        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UnixExcludedPaths { get => this._unixExcludedPaths; set => this._unixExcludedPaths = value; }

        /// <summary>Backing field for <see cref="UnixFilterToExcludePaths" /> property.</summary>
        private System.Collections.Generic.List<string> _unixFilterToExcludePaths;

        /// <summary>Paths that are exception to excluded paths for Unix</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UnixFilterToExcludePaths { get => this._unixFilterToExcludePaths; set => this._unixFilterToExcludePaths = value; }

        /// <summary>Backing field for <see cref="UnixIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _unixIncludedPaths;

        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UnixIncludedPaths { get => this._unixIncludedPaths; set => this._unixIncludedPaths = value; }

        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? UnixNumberOfDataReaderCount { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)UnixNumberOfDataReaders).Count; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)UnixNumberOfDataReaders).Count = value ?? default(long); }

        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? UnixNumberOfDataReaderUseOptimal { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)UnixNumberOfDataReaders).UseOptimal; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)UnixNumberOfDataReaders).UseOptimal = value ?? default(bool); }

        /// <summary>Backing field for <see cref="UnixNumberOfDataReaders" /> property.</summary>
        private Commvault.Powershell.Models.IPlanContentDataReaders _unixNumberOfDataReaders;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanContentDataReaders UnixNumberOfDataReaders { get => (this._unixNumberOfDataReaders = this._unixNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set => this._unixNumberOfDataReaders = value; }

        /// <summary>Backing field for <see cref="UseVssForSystemState" /> property.</summary>
        private bool? _useVssForSystemState;

        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseVssForSystemState { get => this._useVssForSystemState; set => this._useVssForSystemState = value; }

        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? WindowNumberOfDataReaderCount { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)WindowsNumberOfDataReaders).Count; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)WindowsNumberOfDataReaders).Count = value ?? default(long); }

        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? WindowNumberOfDataReaderUseOptimal { get => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)WindowsNumberOfDataReaders).UseOptimal; set => ((Commvault.Powershell.Models.IPlanContentDataReadersInternal)WindowsNumberOfDataReaders).UseOptimal = value ?? default(bool); }

        /// <summary>Backing field for <see cref="WindowsExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _windowsExcludedPaths;

        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WindowsExcludedPaths { get => this._windowsExcludedPaths; set => this._windowsExcludedPaths = value; }

        /// <summary>Backing field for <see cref="WindowsFilterToExcludePaths" /> property.</summary>
        private System.Collections.Generic.List<string> _windowsFilterToExcludePaths;

        /// <summary>Paths that are exception to excluded paths for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WindowsFilterToExcludePaths { get => this._windowsFilterToExcludePaths; set => this._windowsFilterToExcludePaths = value; }

        /// <summary>Backing field for <see cref="WindowsIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _windowsIncludedPaths;

        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WindowsIncludedPaths { get => this._windowsIncludedPaths; set => this._windowsIncludedPaths = value; }

        /// <summary>Backing field for <see cref="WindowsNumberOfDataReaders" /> property.</summary>
        private Commvault.Powershell.Models.IPlanContentDataReaders _windowsNumberOfDataReaders;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IPlanContentDataReaders WindowsNumberOfDataReaders { get => (this._windowsNumberOfDataReaders = this._windowsNumberOfDataReaders ?? new Commvault.Powershell.Models.PlanContentDataReaders()); set => this._windowsNumberOfDataReaders = value; }

        /// <summary>Creates an new <see cref="PlanContent" /> instance.</summary>
        public PlanContent()
        {

        }
    }
    /// This feature applies only to file system agents
    public partial interface IPlanContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Do you want to back up the system state? Applicable only for Windows",
        SerializedName = @"backupSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true",
        SerializedName = @"backupSystemStateOnlyWithFullBackup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>
        /// Do you want to sync properties on associated subclients even if properties are overriden at subclient level?
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Do you want to sync properties on associated subclients even if properties are overriden at subclient level?",
        SerializedName = @"forceUpdateProperties",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ForceUpdateProperties { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for Mac",
        SerializedName = @"macExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MacExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths that are exception to excluded paths for Mac",
        SerializedName = @"macFilterToExcludePaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MacFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for Mac",
        SerializedName = @"macIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MacIncludedPaths { get; set; }
        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of data readers.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? MacNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set optimal number of data readers. if it is set to true, count will be ignored.",
        SerializedName = @"useOptimal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MacNumberOfDataReaderUseOptimal { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for UNIX",
        SerializedName = @"unixExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UnixExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Unix</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths that are exception to excluded paths for Unix",
        SerializedName = @"unixFilterToExcludePaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UnixFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for UNIX",
        SerializedName = @"unixIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UnixIncludedPaths { get; set; }
        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of data readers.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? UnixNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set optimal number of data readers. if it is set to true, count will be ignored.",
        SerializedName = @"useOptimal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnixNumberOfDataReaderUseOptimal { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true",
        SerializedName = @"useVSSForSystemState",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseVssForSystemState { get; set; }
        /// <summary>Number of data readers.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of data readers.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(long) })]
        long? WindowNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set optimal number of data readers. if it is set to true, count will be ignored.",
        SerializedName = @"useOptimal",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WindowNumberOfDataReaderUseOptimal { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for Windows",
        SerializedName = @"windowsExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> WindowsExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths that are exception to excluded paths for Windows",
        SerializedName = @"windowsFilterToExcludePaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> WindowsFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for Windows",
        SerializedName = @"windowsIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> WindowsIncludedPaths { get; set; }

    }
    /// This feature applies only to file system agents
    internal partial interface IPlanContentInternal

    {
        /// <summary>Do you want to back up the system state? Applicable only for Windows</summary>
        bool? BackupSystemState { get; set; }
        /// <summary>
        /// Do you want to back up system state only with full backup? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? BackupSystemStateOnlyWithFullBackup { get; set; }
        /// <summary>
        /// Do you want to sync properties on associated subclients even if properties are overriden at subclient level?
        /// </summary>
        bool? ForceUpdateProperties { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        System.Collections.Generic.List<string> MacExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Mac</summary>
        System.Collections.Generic.List<string> MacFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        System.Collections.Generic.List<string> MacIncludedPaths { get; set; }
        /// <summary>Number of data readers.</summary>
        long? MacNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        bool? MacNumberOfDataReaderUseOptimal { get; set; }

        Commvault.Powershell.Models.IPlanContentDataReaders MacNumberOfDataReaders { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        System.Collections.Generic.List<string> UnixExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Unix</summary>
        System.Collections.Generic.List<string> UnixFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        System.Collections.Generic.List<string> UnixIncludedPaths { get; set; }
        /// <summary>Number of data readers.</summary>
        long? UnixNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        bool? UnixNumberOfDataReaderUseOptimal { get; set; }

        Commvault.Powershell.Models.IPlanContentDataReaders UnixNumberOfDataReaders { get; set; }
        /// <summary>
        /// Do you want to back up system state with VSS? Applicable only if the value of backupSystemState is true
        /// </summary>
        bool? UseVssForSystemState { get; set; }
        /// <summary>Number of data readers.</summary>
        long? WindowNumberOfDataReaderCount { get; set; }
        /// <summary>
        /// Set optimal number of data readers. if it is set to true, count will be ignored.
        /// </summary>
        bool? WindowNumberOfDataReaderUseOptimal { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        System.Collections.Generic.List<string> WindowsExcludedPaths { get; set; }
        /// <summary>Paths that are exception to excluded paths for Windows</summary>
        System.Collections.Generic.List<string> WindowsFilterToExcludePaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        System.Collections.Generic.List<string> WindowsIncludedPaths { get; set; }

        Commvault.Powershell.Models.IPlanContentDataReaders WindowsNumberOfDataReaders { get; set; }

    }
}