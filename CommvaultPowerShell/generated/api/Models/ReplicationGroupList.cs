// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// List of replication groups. Source contains the replication source details. Destination contains the target of the replication
    /// </summary>
    public partial class ReplicationGroupList :
        Commvault.Powershell.Models.IReplicationGroupList,
        Commvault.Powershell.Models.IReplicationGroupListInternal
    {

        /// <summary>Internal Acessors for Destination</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IReplicationGroupListInternal.Destination { get => (this._destination = this._destination ?? new Commvault.Powershell.Models.IdName()); set { {_destination = value;} } }

        /// <summary>Internal Acessors for Source</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IReplicationGroupListInternal.Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set { {_source = value;} } }

        /// <summary>Backing field for <see cref="Destination" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _destination;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Destination { get => (this._destination = this._destination ?? new Commvault.Powershell.Models.IdName()); set => this._destination = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? DestinationId { get => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string DestinationName { get => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Destination).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private long? _id;

        /// <summary>id of the replication group. Either taskId or id is available in the list</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Replication group name</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ReplicationType" /> property.</summary>
        private string _replicationType;

        /// <summary>Replication group type. Values are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ReplicationType { get => this._replicationType; set => this._replicationType = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _source;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Source { get => (this._source = this._source ?? new Commvault.Powershell.Models.IdName()); set => this._source = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? SourceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string SourceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Source).Name = value ?? null; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of replication group. Values are case sensitive</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="TaskId" /> property.</summary>
        private long? _taskId;

        /// <summary>taskid of the replication group. Either taskId or id is available in the list</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? TaskId { get => this._taskId; set => this._taskId = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Application type. Virtual Machine, Oracle</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ReplicationGroupList" /> instance.</summary>
        public ReplicationGroupList()
        {

        }
    }
    /// List of replication groups. Source contains the replication source details. Destination contains the target of the replication
    public partial interface IReplicationGroupList :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? DestinationId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationName { get; set; }
        /// <summary>id of the replication group. Either taskId or id is available in the list</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"id of the replication group. Either taskId or id is available in the list",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? Id { get; set; }
        /// <summary>Replication group name</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replication group name",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Replication group type. Values are case sensitive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replication group type. Values are case sensitive",
        SerializedName = @"replicationType",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicationType { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? SourceId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }
        /// <summary>State of replication group. Values are case sensitive</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of replication group. Values are case sensitive",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>taskid of the replication group. Either taskId or id is available in the list</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"taskid of the replication group. Either taskId or id is available in the list",
        SerializedName = @"taskId",
        PossibleTypes = new [] { typeof(long) })]
        long? TaskId { get; set; }
        /// <summary>Application type. Virtual Machine, Oracle</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application type. Virtual Machine, Oracle",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// List of replication groups. Source contains the replication source details. Destination contains the target of the replication
    internal partial interface IReplicationGroupListInternal

    {
        Commvault.Powershell.Models.IIdName Destination { get; set; }

        long? DestinationId { get; set; }

        string DestinationName { get; set; }
        /// <summary>id of the replication group. Either taskId or id is available in the list</summary>
        long? Id { get; set; }
        /// <summary>Replication group name</summary>
        string Name { get; set; }
        /// <summary>Replication group type. Values are case sensitive</summary>
        string ReplicationType { get; set; }

        Commvault.Powershell.Models.IIdName Source { get; set; }

        long? SourceId { get; set; }

        string SourceName { get; set; }
        /// <summary>State of replication group. Values are case sensitive</summary>
        string State { get; set; }
        /// <summary>taskid of the replication group. Either taskId or id is available in the list</summary>
        long? TaskId { get; set; }
        /// <summary>Application type. Virtual Machine, Oracle</summary>
        string Type { get; set; }

    }
}