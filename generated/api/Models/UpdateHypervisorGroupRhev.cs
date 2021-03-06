// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with Rhev as the destination vendor</summary>
    public partial class UpdateHypervisorGroupRhev :
        Commvault.Powershell.Models.IUpdateHypervisorGroupRhev,
        Commvault.Powershell.Models.IUpdateHypervisorGroupRhevInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.IUpdateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.IUpdateHypervisorGroupReq __updateHypervisorGroupReq = new Commvault.Powershell.Models.UpdateHypervisorGroupReq();

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] AccessNodes { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).AccessNodes; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).AccessNodes = value ?? null /* arrayOf */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IActivityControlOptions ActivityControl { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControl; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControl = value ?? null /* model class */; }

        /// <summary>true if Backup is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ActivityControlEnableBackup { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableBackup; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableBackup = value ?? default(bool); }

        /// <summary>true if Restore is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? ActivityControlEnableRestore { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableRestore; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).ActivityControlEnableRestore = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName FbrUnixMediaAgent { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgent; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgent = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public int? FbrUnixMediaAgentId { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentId; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentId = value ?? default(int); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string FbrUnixMediaAgentName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).FbrUnixMediaAgentName = value ?? null; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType;

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; set => this._hypervisorType = value; }

        /// <summary>The name of the hypervisor that has to be changed</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string NewName { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).NewName = value ?? null; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private string _password;

        /// <summary>Rhev password</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="RhevMManager" /> property.</summary>
        private string _rhevMManager;

        /// <summary>Rhev Manager</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string RhevMManager { get => this._rhevMManager; set => this._rhevMManager = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IVMHypervisorSecurityProp Security { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] SecurityAssociatedUserGroups { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups = value ?? null /* arrayOf */; }

        /// <summary>Client owners for the Hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SecurityClientOwners { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners = value ?? null; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation = value ?? default(bool); }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>Rhev userName</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="UpdateHypervisorGroupRhev" /> instance.</summary>
        public UpdateHypervisorGroupRhev()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__updateHypervisorGroupReq), __updateHypervisorGroupReq);
            await eventListener.AssertObjectIsValid(nameof(__updateHypervisorGroupReq), __updateHypervisorGroupReq);
        }
    }
    /// Update a hypervisor group with Rhev as the destination vendor
    public partial interface IUpdateHypervisorGroupRhev :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.IUpdateHypervisorGroupReq
    {
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get; set; }
        /// <summary>Rhev password</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Rhev password ",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }
        /// <summary>Rhev Manager</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Rhev Manager ",
        SerializedName = @"RhevMManager",
        PossibleTypes = new [] { typeof(string) })]
        string RhevMManager { get; set; }
        /// <summary>Rhev userName</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Rhev userName ",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Update a hypervisor group with Rhev as the destination vendor
    internal partial interface IUpdateHypervisorGroupRhevInternal :
        Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal
    {
        string HypervisorType { get; set; }
        /// <summary>Rhev password</summary>
        string Password { get; set; }
        /// <summary>Rhev Manager</summary>
        string RhevMManager { get; set; }
        /// <summary>Rhev userName</summary>
        string UserName { get; set; }

    }
}