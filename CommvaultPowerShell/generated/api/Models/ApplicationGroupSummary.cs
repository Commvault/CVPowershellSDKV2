// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ApplicationGroupSummary :
        Commvault.Powershell.Models.IApplicationGroupSummary,
        Commvault.Powershell.Models.IApplicationGroupSummaryInternal
    {

        /// <summary>Backing field for <see cref="ApplicationGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _applicationGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set => this._applicationGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? ApplicationGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ApplicationGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)ApplicationGroup).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Cluster" /> property.</summary>
        private Commvault.Powershell.Models.IIdNameDisplayName _cluster;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdNameDisplayName Cluster { get => (this._cluster = this._cluster ?? new Commvault.Powershell.Models.IdNameDisplayName()); set => this._cluster = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClusterDisplayName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).DisplayName; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).DisplayName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? ClusterId { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).Id; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClusterName { get => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).Name; set => ((Commvault.Powershell.Models.IIdNameDisplayNameInternal)Cluster).Name = value ?? null; }

        /// <summary>Backing field for <see cref="ClusterType" /> property.</summary>
        private string _clusterType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ClusterType { get => this._clusterType; set => this._clusterType = value; }

        /// <summary>Internal Acessors for ApplicationGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationGroupSummaryInternal.ApplicationGroup { get => (this._applicationGroup = this._applicationGroup ?? new Commvault.Powershell.Models.IdName()); set { {_applicationGroup = value;} } }

        /// <summary>Internal Acessors for Cluster</summary>
        Commvault.Powershell.Models.IIdNameDisplayName Commvault.Powershell.Models.IApplicationGroupSummaryInternal.Cluster { get => (this._cluster = this._cluster ?? new Commvault.Powershell.Models.IdNameDisplayName()); set { {_cluster = value;} } }

        /// <summary>Internal Acessors for Company</summary>
        Commvault.Powershell.Models.ICompanyInfo Commvault.Powershell.Models.IApplicationGroupSummaryInternal.Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.CompanyInfo()); set { {_company = value;} } }

        /// <summary>Internal Acessors for Instance</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationGroupSummaryInternal.Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set { {_instance = value;} } }

        /// <summary>Internal Acessors for LastBackup</summary>
        Commvault.Powershell.Models.ILastBackupJobInfo Commvault.Powershell.Models.IApplicationGroupSummaryInternal.LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set { {_lastBackup = value;} } }

        /// <summary>Internal Acessors for Plan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IApplicationGroupSummaryInternal.Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set { {_plan = value;} } }

        /// <summary>Backing field for <see cref="Company" /> property.</summary>
        private Commvault.Powershell.Models.ICompanyInfo _company;

        /// <summary>companyInfo</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ICompanyInfo Company { get => (this._company = this._company ?? new Commvault.Powershell.Models.CompanyInfo()); set => this._company = value; }

        /// <summary>Id of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyId { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Id; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Id = value ?? default(long); }

        /// <summary>Multi Commcell Id of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? CompanyMultiCommcellId { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).MultiCommcellId; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).MultiCommcellId = value ?? default(long); }

        /// <summary>Name of company</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string CompanyName { get => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Name; set => ((Commvault.Powershell.Models.ICompanyInfoInternal)Company).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IndexingStatus" /> property.</summary>
        private string _indexingStatus;

        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string IndexingStatus { get => this._indexingStatus; set => this._indexingStatus = value; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _instance;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set => this._instance = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? InstanceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string InstanceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name = value ?? null; }

        /// <summary>Backing field for <see cref="IsDefaultApplicationGroup" /> property.</summary>
        private bool? _isDefaultApplicationGroup;

        /// <summary>True if subclient is default subclient</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? IsDefaultApplicationGroup { get => this._isDefaultApplicationGroup; set => this._isDefaultApplicationGroup = value; }

        /// <summary>Backing field for <see cref="LastBackup" /> property.</summary>
        private Commvault.Powershell.Models.ILastBackupJobInfo _lastBackup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.ILastBackupJobInfo LastBackup { get => (this._lastBackup = this._lastBackup ?? new Commvault.Powershell.Models.LastBackupJobInfo()); set => this._lastBackup = value; }

        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupFailureReason { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).FailureReason; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).FailureReason = value ?? null; }

        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? LastBackupJobId { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).JobId; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).JobId = value ?? default(long); }

        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string LastBackupStatus { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Status; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Status = value ?? null; }

        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? LastBackupTime { get => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Time; set => ((Commvault.Powershell.Models.ILastBackupJobInfoInternal)LastBackup).Time = value ?? default(long); }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Plan" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _plan;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Plan { get => (this._plan = this._plan ?? new Commvault.Powershell.Models.IdName()); set => this._plan = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? PlanId { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string PlanName { get => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Plan).Name = value ?? null; }

        /// <summary>Backing field for <see cref="SnapBackupEnabled" /> property.</summary>
        private bool? _snapBackupEnabled;

        /// <summary>true if snap backup enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? SnapBackupEnabled { get => this._snapBackupEnabled; set => this._snapBackupEnabled = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="StoragePolicyRetentionExtension" /> property.</summary>
        private bool? _storagePolicyRetentionExtension;

        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? StoragePolicyRetentionExtension { get => this._storagePolicyRetentionExtension; set => this._storagePolicyRetentionExtension = value; }

        /// <summary>Creates an new <see cref="ApplicationGroupSummary" /> instance.</summary>
        public ApplicationGroupSummary()
        {

        }
    }
    public partial interface IApplicationGroupSummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? ApplicationGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ApplicationGroupName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterDisplayName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? ClusterId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clusterType",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterType { get; set; }
        /// <summary>Id of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of company",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyId { get; set; }
        /// <summary>Multi Commcell Id of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Multi Commcell Id of company",
        SerializedName = @"multiCommcellId",
        PossibleTypes = new [] { typeof(long) })]
        long? CompanyMultiCommcellId { get; set; }
        /// <summary>Name of company</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of company",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>Type of indexing status.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of indexing status.",
        SerializedName = @"indexingStatus",
        PossibleTypes = new [] { typeof(string) })]
        string IndexingStatus { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? InstanceId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceName { get; set; }
        /// <summary>True if subclient is default subclient</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if subclient is default subclient",
        SerializedName = @"isDefaultApplicationGroup",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefaultApplicationGroup { get; set; }
        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gives the reason for the last backup job failing, if the last backup job fails.",
        SerializedName = @"failureReason",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Returns the job id of the last backup job performed.",
        SerializedName = @"jobId",
        PossibleTypes = new [] { typeof(long) })]
        long? LastBackupJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the last backup job performed.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string LastBackupStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Shows the time when the last back up job was carried out. The time is provided in unix time format.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(long) })]
        long? LastBackupTime { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? PlanId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }
        /// <summary>true if snap backup enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @" true if snap backup enabled",
        SerializedName = @"snapBackupEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapBackupEnabled { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if extend storage policy Retention was set in VMGroup for deleted files",
        SerializedName = @"storagePolicyRetentionExtension",
        PossibleTypes = new [] { typeof(bool) })]
        bool? StoragePolicyRetentionExtension { get; set; }

    }
    internal partial interface IApplicationGroupSummaryInternal

    {
        Commvault.Powershell.Models.IIdName ApplicationGroup { get; set; }

        long? ApplicationGroupId { get; set; }

        string ApplicationGroupName { get; set; }

        Commvault.Powershell.Models.IIdNameDisplayName Cluster { get; set; }

        string ClusterDisplayName { get; set; }

        long? ClusterId { get; set; }

        string ClusterName { get; set; }

        string ClusterType { get; set; }
        /// <summary>companyInfo</summary>
        Commvault.Powershell.Models.ICompanyInfo Company { get; set; }
        /// <summary>Id of company</summary>
        long? CompanyId { get; set; }
        /// <summary>Multi Commcell Id of company</summary>
        long? CompanyMultiCommcellId { get; set; }
        /// <summary>Name of company</summary>
        string CompanyName { get; set; }

        long? Id { get; set; }
        /// <summary>Type of indexing status.</summary>
        string IndexingStatus { get; set; }

        Commvault.Powershell.Models.IIdName Instance { get; set; }

        long? InstanceId { get; set; }

        string InstanceName { get; set; }
        /// <summary>True if subclient is default subclient</summary>
        bool? IsDefaultApplicationGroup { get; set; }

        Commvault.Powershell.Models.ILastBackupJobInfo LastBackup { get; set; }
        /// <summary>Gives the reason for the last backup job failing, if the last backup job fails.</summary>
        string LastBackupFailureReason { get; set; }
        /// <summary>Returns the job id of the last backup job performed.</summary>
        long? LastBackupJobId { get; set; }
        /// <summary>Status of the last backup job performed.</summary>
        string LastBackupStatus { get; set; }
        /// <summary>
        /// Shows the time when the last back up job was carried out. The time is provided in unix time format.
        /// </summary>
        long? LastBackupTime { get; set; }

        string Name { get; set; }

        Commvault.Powershell.Models.IIdName Plan { get; set; }

        long? PlanId { get; set; }

        string PlanName { get; set; }
        /// <summary>true if snap backup enabled</summary>
        bool? SnapBackupEnabled { get; set; }

        string Status { get; set; }
        /// <summary>True if extend storage policy Retention was set in VMGroup for deleted files</summary>
        bool? StoragePolicyRetentionExtension { get; set; }

    }
}