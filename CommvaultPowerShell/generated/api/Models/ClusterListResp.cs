// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class ClusterListResp :
        Commvault.Powershell.Models.IClusterListResp,
        Commvault.Powershell.Models.IClusterListRespInternal
    {

        /// <summary>Backing field for <see cref="ClientActivityControl" /> property.</summary>
        private Commvault.Powershell.Models.IActivityControlOptionsProp _clientActivityControl;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IActivityControlOptionsProp ClientActivityControl { get => (this._clientActivityControl = this._clientActivityControl ?? new Commvault.Powershell.Models.ActivityControlOptionsProp()); set => this._clientActivityControl = value; }

        /// <summary>denotes the activity type being considered</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string ClientActivityControlActivityType { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).ActivityType; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).ActivityType = value ?? null; }

        /// <summary>True if the activity type is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ClientActivityControlEnableActivityType { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).EnableActivityType; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).EnableActivityType = value ?? default(bool); }

        /// <summary>True if the activity will be enabled after a delay time interval</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public bool? ClientActivityControlEnableAfterADelay { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).EnableAfterADelay; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).EnableAfterADelay = value ?? default(bool); }

        /// <summary>Backing field for <see cref="ClusterType" /> property.</summary>
        private string _clusterType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ClusterType { get => this._clusterType; set => this._clusterType = value; }

        /// <summary>Internal Acessors for ClientActivityControl</summary>
        Commvault.Powershell.Models.IActivityControlOptionsProp Commvault.Powershell.Models.IClusterListRespInternal.ClientActivityControl { get => (this._clientActivityControl = this._clientActivityControl ?? new Commvault.Powershell.Models.ActivityControlOptionsProp()); set { {_clientActivityControl = value;} } }

        /// <summary>Internal Acessors for ClientActivityControlDelayTime</summary>
        Commvault.Powershell.Models.IActivityControlTileDelayTime Commvault.Powershell.Models.IClusterListRespInternal.ClientActivityControlDelayTime { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTime; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTime = value; }

        /// <summary>Internal Acessors for DelayTimeZone</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IClusterListRespInternal.DelayTimeZone { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeZone; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeZone = value; }

        /// <summary>Internal Acessors for Instance</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IClusterListRespInternal.Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set { {_instance = value;} } }

        /// <summary>delay time in unix timestamp</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? DelayTime { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeTime; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeTime = value ?? default(long); }

        /// <summary>actual delay time value in string format according to the timezone</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string DelayTimeValue { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeValue; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).DelayTimeValue = value ?? null; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>This gives the name of the cluster as it shown on the admin console or GUI.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>This give the host name of the cluster.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; set => this._hostName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>This gives the id of the cluster.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _instance;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set => this._instance = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? InstanceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string InstanceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>This give the name of the cluster.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>status of the cluster</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? TimeZoneId { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).TimeZoneId; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).TimeZoneId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string TimeZoneName { get => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).TimeZoneName; set => ((Commvault.Powershell.Models.IActivityControlOptionsPropInternal)ClientActivityControl).TimeZoneName = value ?? null; }

        /// <summary>Creates an new <see cref="ClusterListResp" /> instance.</summary>
        public ClusterListResp()
        {

        }
    }
    public partial interface IClusterListResp :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>denotes the activity type being considered</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"denotes the activity type being considered",
        SerializedName = @"activityType",
        PossibleTypes = new [] { typeof(string) })]
        string ClientActivityControlActivityType { get; set; }
        /// <summary>True if the activity type is enabled</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the activity type is enabled",
        SerializedName = @"enableActivityType",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ClientActivityControlEnableActivityType { get; set; }
        /// <summary>True if the activity will be enabled after a delay time interval</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True if the activity will be enabled after a delay time interval",
        SerializedName = @"enableAfterADelay",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ClientActivityControlEnableAfterADelay { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"clusterType",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterType { get; set; }
        /// <summary>delay time in unix timestamp</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delay time in unix timestamp",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(long) })]
        long? DelayTime { get; set; }
        /// <summary>actual delay time value in string format according to the timezone</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"actual delay time value in string format according to the timezone",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string DelayTimeValue { get; set; }
        /// <summary>This gives the name of the cluster as it shown on the admin console or GUI.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This gives the name of the cluster as it shown on the admin console or GUI.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>This give the host name of the cluster.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This give the host name of the cluster.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>This gives the id of the cluster.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This gives the id of the cluster.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }

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
        /// <summary>This give the name of the cluster.</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This give the name of the cluster.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>status of the cluster</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"status of the cluster",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? TimeZoneId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string TimeZoneName { get; set; }

    }
    internal partial interface IClusterListRespInternal

    {
        Commvault.Powershell.Models.IActivityControlOptionsProp ClientActivityControl { get; set; }
        /// <summary>denotes the activity type being considered</summary>
        string ClientActivityControlActivityType { get; set; }
        /// <summary>ActivityControlTileDelayTime</summary>
        Commvault.Powershell.Models.IActivityControlTileDelayTime ClientActivityControlDelayTime { get; set; }
        /// <summary>True if the activity type is enabled</summary>
        bool? ClientActivityControlEnableActivityType { get; set; }
        /// <summary>True if the activity will be enabled after a delay time interval</summary>
        bool? ClientActivityControlEnableAfterADelay { get; set; }

        string ClusterType { get; set; }
        /// <summary>delay time in unix timestamp</summary>
        long? DelayTime { get; set; }
        /// <summary>actual delay time value in string format according to the timezone</summary>
        string DelayTimeValue { get; set; }

        Commvault.Powershell.Models.IIdName DelayTimeZone { get; set; }
        /// <summary>This gives the name of the cluster as it shown on the admin console or GUI.</summary>
        string DisplayName { get; set; }
        /// <summary>This give the host name of the cluster.</summary>
        string HostName { get; set; }
        /// <summary>This gives the id of the cluster.</summary>
        long? Id { get; set; }

        Commvault.Powershell.Models.IIdName Instance { get; set; }

        long? InstanceId { get; set; }

        string InstanceName { get; set; }
        /// <summary>This give the name of the cluster.</summary>
        string Name { get; set; }
        /// <summary>status of the cluster</summary>
        string Status { get; set; }

        long? TimeZoneId { get; set; }

        string TimeZoneName { get; set; }

    }
}