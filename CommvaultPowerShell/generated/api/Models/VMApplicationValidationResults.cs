// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>VMApplicationValidationResults</summary>
    public partial class VMApplicationValidationResults :
        Commvault.Powershell.Models.IVMApplicationValidationResults,
        Commvault.Powershell.Models.IVMApplicationValidationResultsInternal
    {

        /// <summary>Backing field for <see cref="AppsDiscovered" /> property.</summary>
        private Commvault.Powershell.Models.IVMAppsDiscovered[] _appsDiscovered;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public Commvault.Powershell.Models.IVMAppsDiscovered[] AppsDiscovered { get => this._appsDiscovered; set => this._appsDiscovered = value; }

        /// <summary>Backing field for <see cref="BackupCompletionDate" /> property.</summary>
        private long? _backupCompletionDate;

        /// <summary>timestamp(in unix) for the last backup job completed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? BackupCompletionDate { get => this._backupCompletionDate; set => this._backupCompletionDate = value; }

        /// <summary>Backing field for <see cref="BackupValidated" /> property.</summary>
        private long? _backupValidated;

        /// <summary>job id of the last backup job that was validated</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? BackupValidated { get => this._backupValidated; set => this._backupValidated = value; }

        /// <summary>Backing field for <see cref="BootStatus" /> property.</summary>
        private bool? _bootStatus;

        /// <summary>true if backup validation is set</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? BootStatus { get => this._bootStatus; set => this._bootStatus = value; }

        /// <summary>Backing field for <see cref="LastValidationJobId" /> property.</summary>
        private long? _lastValidationJobId;

        /// <summary>job id of the last backup validation job</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? LastValidationJobId { get => this._lastValidationJobId; set => this._lastValidationJobId = value; }

        /// <summary>Creates an new <see cref="VMApplicationValidationResults" /> instance.</summary>
        public VMApplicationValidationResults()
        {

        }
    }
    /// VMApplicationValidationResults
    public partial interface IVMApplicationValidationResults :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"appsDiscovered",
        PossibleTypes = new [] { typeof(Commvault.Powershell.Models.IVMAppsDiscovered) })]
        Commvault.Powershell.Models.IVMAppsDiscovered[] AppsDiscovered { get; set; }
        /// <summary>timestamp(in unix) for the last backup job completed</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"timestamp(in unix) for the last backup job completed",
        SerializedName = @"backupCompletionDate",
        PossibleTypes = new [] { typeof(long) })]
        long? BackupCompletionDate { get; set; }
        /// <summary>job id of the last backup job that was validated</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"job id of the last backup job that was validated",
        SerializedName = @"backupValidated",
        PossibleTypes = new [] { typeof(long) })]
        long? BackupValidated { get; set; }
        /// <summary>true if backup validation is set</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"true if backup validation is set",
        SerializedName = @"bootStatus",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BootStatus { get; set; }
        /// <summary>job id of the last backup validation job</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"job id of the last backup validation job",
        SerializedName = @"lastValidationJobId",
        PossibleTypes = new [] { typeof(long) })]
        long? LastValidationJobId { get; set; }

    }
    /// VMApplicationValidationResults
    internal partial interface IVMApplicationValidationResultsInternal

    {
        Commvault.Powershell.Models.IVMAppsDiscovered[] AppsDiscovered { get; set; }
        /// <summary>timestamp(in unix) for the last backup job completed</summary>
        long? BackupCompletionDate { get; set; }
        /// <summary>job id of the last backup job that was validated</summary>
        long? BackupValidated { get; set; }
        /// <summary>true if backup validation is set</summary>
        bool? BootStatus { get; set; }
        /// <summary>job id of the last backup validation job</summary>
        long? LastValidationJobId { get; set; }

    }
}