// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class MediaAgent :
        Commvault.Powershell.Models.IMediaAgent,
        Commvault.Powershell.Models.IMediaAgentInternal
    {

        /// <summary>Internal Acessors for Control</summary>
        Commvault.Powershell.Models.IMediaAgentControl Commvault.Powershell.Models.IMediaAgentInternal.Control { get => (this._control = this._control ?? new Commvault.Powershell.Models.MediaAgentControl()); set { {_control = value;} } }

        /// <summary>Internal Acessors for General</summary>
        Commvault.Powershell.Models.IMediaAgentSummary Commvault.Powershell.Models.IMediaAgentInternal.General { get => (this._general = this._general ?? new Commvault.Powershell.Models.MediaAgentSummary()); set { {_general = value;} } }

        /// <summary>Internal Acessors for GeneralCompany</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMediaAgentInternal.GeneralCompany { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Company; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Company = value; }

        /// <summary>Internal Acessors for GeneralOperatingSystem</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IMediaAgentInternal.GeneralOperatingSystem { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystem; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystem = value; }

        /// <summary>Internal Acessors for IndexCache</summary>
        Commvault.Powershell.Models.IIndexCache Commvault.Powershell.Models.IMediaAgentInternal.IndexCache { get => (this._indexCache = this._indexCache ?? new Commvault.Powershell.Models.IndexCache()); set { {_indexCache = value;} } }

        /// <summary>Internal Acessors for IndexCacheLogsCache</summary>
        Commvault.Powershell.Models.IMediaAgentLogsCache Commvault.Powershell.Models.IMediaAgentInternal.IndexCacheLogsCache { get => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogsCache; set => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogsCache = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyId { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).CompanyId; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).CompanyId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).CompanyName; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).CompanyName = value ?? null; }

        /// <summary>Backing field for <see cref="Control" /> property.</summary>
        private Commvault.Powershell.Models.IMediaAgentControl _control;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IMediaAgentControl Control { get => (this._control = this._control ?? new Commvault.Powershell.Models.MediaAgentControl()); set => this._control = value; }

        /// <summary>Determines if the media agent is currently enabled or disabled.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ControlEnabled { get => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).Enabled; set => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).Enabled = value ?? default(bool); }

        /// <summary>
        /// Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ControlMaintenanceMode { get => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).MaintenanceMode; set => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).MaintenanceMode = value ?? default(bool); }

        /// <summary>
        /// Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will
        /// be 100. If set to false, default value of parallel data transfer operations will be set to 25.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ControlOptimizeForConcurrentLanBackups { get => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).OptimizeForConcurrentLanBackups; set => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).OptimizeForConcurrentLanBackups = value ?? default(bool); }

        /// <summary>Specifies the number of parallel data operations that can take place.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? ControlParallelDataTransferOperations { get => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).ParallelDataTransferOperations; set => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).ParallelDataTransferOperations = value ?? default(long); }

        /// <summary>
        /// If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against
        /// media agent is disabled.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ControlRansomwareProtection { get => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).RansomwareProtection; set => ((Commvault.Powershell.Models.IMediaAgentControlInternal)Control).RansomwareProtection = value ?? default(bool); }

        /// <summary>Backing field for <see cref="General" /> property.</summary>
        private Commvault.Powershell.Models.IMediaAgentSummary _general;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IMediaAgentSummary General { get => (this._general = this._general ?? new Commvault.Powershell.Models.MediaAgentSummary()); set => this._general = value; }

        /// <summary>Description of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralDescription { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Description; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Description = value ?? null; }

        /// <summary>Display name of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralDisplayName { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).DisplayName; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).DisplayName = value ?? null; }

        /// <summary>Id of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? GeneralId { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Id; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Id = value ?? default(long); }

        /// <summary>Name of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralName { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Name; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Name = value ?? null; }

        /// <summary>
        /// Provides a reason for the media agent being offline. Only given when the media agent is offline.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralOfflineReason { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OfflineReason; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OfflineReason = value ?? null; }

        /// <summary>Current status of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralStatus { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Status; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Status = value ?? null; }

        /// <summary>The service pack of the media agent.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string GeneralVersion { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Version; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).Version = value ?? null; }

        /// <summary>Backing field for <see cref="IndexCache" /> property.</summary>
        private Commvault.Powershell.Models.IIndexCache _indexCache;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIndexCache IndexCache { get => (this._indexCache = this._indexCache ?? new Commvault.Powershell.Models.IndexCache()); set => this._indexCache = value; }

        /// <summary>Path where the index cache is maintained.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string IndexCachePath { get => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).Path; set => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).Path = value ?? null; }

        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? LogCacheEnabled { get => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogCacheEnabled; set => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogCacheEnabled = value ?? default(bool); }

        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LogCachePath { get => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogCachePath; set => ((Commvault.Powershell.Models.IIndexCacheInternal)IndexCache).LogCachePath = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? OperatingSystemId { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystemId; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystemId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string OperatingSystemName { get => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystemName; set => ((Commvault.Powershell.Models.IMediaAgentSummaryInternal)General).OperatingSystemName = value ?? null; }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Commvault.Powershell.Models.ISecurityAssoc[] _security;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.ISecurityAssoc[] Security { get => this._security; set => this._security = value; }

        /// <summary>Creates an new <see cref="MediaAgent" /> instance.</summary>
        public MediaAgent()
        {

        }
    }
    public partial interface IMediaAgent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>Determines if the media agent is currently enabled or disabled.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Determines if the media agent is currently enabled or disabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ControlEnabled { get; set; }
        /// <summary>
        /// Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.",
        SerializedName = @"maintenanceMode",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ControlMaintenanceMode { get; set; }
        /// <summary>
        /// Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will
        /// be 100. If set to false, default value of parallel data transfer operations will be set to 25.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will be 100. If set to false, default value of parallel data transfer operations will be set to 25.",
        SerializedName = @"optimizeForConcurrentLANBackups",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ControlOptimizeForConcurrentLanBackups { get; set; }
        /// <summary>Specifies the number of parallel data operations that can take place.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the number of parallel data operations that can take place. ",
        SerializedName = @"parallelDataTransferOperations",
        PossibleTypes = new [] { typeof(long) })]
        long? ControlParallelDataTransferOperations { get; set; }
        /// <summary>
        /// If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against
        /// media agent is disabled.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against media agent is disabled.",
        SerializedName = @"ransomwareProtection",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ControlRansomwareProtection { get; set; }
        /// <summary>Description of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the media agent.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralDescription { get; set; }
        /// <summary>Display name of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of the media agent.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralDisplayName { get; set; }
        /// <summary>Id of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the media agent.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? GeneralId { get; set; }
        /// <summary>Name of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the media agent.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralName { get; set; }
        /// <summary>
        /// Provides a reason for the media agent being offline. Only given when the media agent is offline.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provides a reason for the media agent being offline. Only given when the media agent is offline.",
        SerializedName = @"offlineReason",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralOfflineReason { get; set; }
        /// <summary>Current status of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current status of the media agent.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralStatus { get; set; }
        /// <summary>The service pack of the media agent.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The service pack of the media agent.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string GeneralVersion { get; set; }
        /// <summary>Path where the index cache is maintained.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path where the index cache is maintained.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string IndexCachePath { get; set; }
        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This tag determines if the logs cache has been enabled or not. ",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? LogCacheEnabled { get; set; }
        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If the logs cache is enabled, this tag gives the path to store the logs cache.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string LogCachePath { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? OperatingSystemId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string OperatingSystemName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"security",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.ISecurityAssoc) })]
        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
    internal partial interface IMediaAgentInternal

    {
        long? CompanyId { get; set; }

        string CompanyName { get; set; }

        Commvault.Powershell.Models.IMediaAgentControl Control { get; set; }
        /// <summary>Determines if the media agent is currently enabled or disabled.</summary>
        bool? ControlEnabled { get; set; }
        /// <summary>
        /// Specifies whether the MediaAgent is available for data protection, data recovery and auxiliary copy operations.
        /// </summary>
        bool? ControlMaintenanceMode { get; set; }
        /// <summary>
        /// Allows optimization for concurrent LAN backups. If set to true, default value for parallel data transfer operations will
        /// be 100. If set to false, default value of parallel data transfer operations will be set to 25.
        /// </summary>
        bool? ControlOptimizeForConcurrentLanBackups { get; set; }
        /// <summary>Specifies the number of parallel data operations that can take place.</summary>
        long? ControlParallelDataTransferOperations { get; set; }
        /// <summary>
        /// If set to true, ransomware protection against the media agent is enabled. If set to false, ransomware protection against
        /// media agent is disabled.
        /// </summary>
        bool? ControlRansomwareProtection { get; set; }

        Commvault.Powershell.Models.IMediaAgentSummary General { get; set; }

        Commvault.Powershell.Models.IIdName GeneralCompany { get; set; }
        /// <summary>Description of the media agent.</summary>
        string GeneralDescription { get; set; }
        /// <summary>Display name of the media agent.</summary>
        string GeneralDisplayName { get; set; }
        /// <summary>Id of the media agent.</summary>
        long? GeneralId { get; set; }
        /// <summary>Name of the media agent.</summary>
        string GeneralName { get; set; }
        /// <summary>
        /// Provides a reason for the media agent being offline. Only given when the media agent is offline.
        /// </summary>
        string GeneralOfflineReason { get; set; }

        Commvault.Powershell.Models.IIdName GeneralOperatingSystem { get; set; }
        /// <summary>Current status of the media agent.</summary>
        string GeneralStatus { get; set; }
        /// <summary>The service pack of the media agent.</summary>
        string GeneralVersion { get; set; }

        Commvault.Powershell.Models.IIndexCache IndexCache { get; set; }

        Commvault.Powershell.Models.IMediaAgentLogsCache IndexCacheLogsCache { get; set; }
        /// <summary>Path where the index cache is maintained.</summary>
        string IndexCachePath { get; set; }
        /// <summary>This tag determines if the logs cache has been enabled or not.</summary>
        bool? LogCacheEnabled { get; set; }
        /// <summary>If the logs cache is enabled, this tag gives the path to store the logs cache.</summary>
        string LogCachePath { get; set; }

        long? OperatingSystemId { get; set; }

        string OperatingSystemName { get; set; }

        Commvault.Powershell.Models.ISecurityAssoc[] Security { get; set; }

    }
}