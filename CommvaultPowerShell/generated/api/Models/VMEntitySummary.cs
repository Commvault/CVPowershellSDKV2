// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Summary of VMEntity in Virtual Machine summary</summary>
    public partial class VMEntitySummary :
        Commvault.Powershell.Models.IVMEntitySummary,
        Commvault.Powershell.Models.IVMEntitySummaryInternal
    {

        /// <summary>Backing field for <see cref="Backupset" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _backupset;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Backupset { get => (this._backupset = this._backupset ?? new Commvault.Powershell.Models.IdName()); set => this._backupset = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? BackupsetId { get => ((Commvault.Powershell.Models.IIdNameInternal)Backupset).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Backupset).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string BackupsetName { get => ((Commvault.Powershell.Models.IIdNameInternal)Backupset).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Backupset).Name = value ?? null; }

        /// <summary>Internal Acessors for Backupset</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMEntitySummaryInternal.Backupset { get => (this._backupset = this._backupset ?? new Commvault.Powershell.Models.IdName()); set { {_backupset = value;} } }

        /// <summary>Internal Acessors for Instance</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMEntitySummaryInternal.Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set { {_instance = value;} } }

        /// <summary>Internal Acessors for VMGroup</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.IVMEntitySummaryInternal.VMGroup { get => (this._vMGroup = this._vMGroup ?? new Commvault.Powershell.Models.IdName()); set { {_vMGroup = value;} } }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _instance;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName Instance { get => (this._instance = this._instance ?? new Commvault.Powershell.Models.IdName()); set => this._instance = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? InstanceId { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string InstanceName { get => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)Instance).Name = value ?? null; }

        /// <summary>Backing field for <see cref="VMGroup" /> property.</summary>
        private Commvault.Powershell.Models.IIdName _vMGroup;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        internal Commvault.Powershell.Models.IIdName VMGroup { get => (this._vMGroup = this._vMGroup ?? new Commvault.Powershell.Models.IdName()); set => this._vMGroup = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public long? VMGroupId { get => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Id; set => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Id = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inlined)]
        public string VMGroupName { get => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Name; set => ((Commvault.Powershell.Models.IIdNameInternal)VMGroup).Name = value ?? null; }

        /// <summary>Creates an new <see cref="VMEntitySummary" /> instance.</summary>
        public VMEntitySummary()
        {

        }
    }
    /// Summary of VMEntity in Virtual Machine summary
    public partial interface IVMEntitySummary :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? BackupsetId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string BackupsetName { get; set; }

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

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(long) })]
        long? VMGroupId { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string VMGroupName { get; set; }

    }
    /// Summary of VMEntity in Virtual Machine summary
    internal partial interface IVMEntitySummaryInternal

    {
        Commvault.Powershell.Models.IIdName Backupset { get; set; }

        long? BackupsetId { get; set; }

        string BackupsetName { get; set; }

        Commvault.Powershell.Models.IIdName Instance { get; set; }

        long? InstanceId { get; set; }

        string InstanceName { get; set; }

        Commvault.Powershell.Models.IIdName VMGroup { get; set; }

        long? VMGroupId { get; set; }

        string VMGroupName { get; set; }

    }
}