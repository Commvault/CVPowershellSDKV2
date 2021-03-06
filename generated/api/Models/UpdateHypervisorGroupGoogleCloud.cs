// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Update a hypervisor group with Google Cloud as the destination vendor</summary>
    public partial class UpdateHypervisorGroupGoogleCloud :
        Commvault.Powershell.Models.IUpdateHypervisorGroupGoogleCloud,
        Commvault.Powershell.Models.IUpdateHypervisorGroupGoogleCloudInternal,
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

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IVMHypervisorSecurityProp Security { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).Security = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public Commvault.Powershell.Models.IIdName[] SecurityAssociatedUserGroups { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityAssociatedUserGroups = value ?? null /* arrayOf */; }

        /// <summary>Client owners for the Hypervisor</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string SecurityClientOwners { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SecurityClientOwners = value ?? null; }

        /// <summary>Backing field for <see cref="ServiceAccountId" /> property.</summary>
        private string _serviceAccountId;

        /// <summary>service account id of google cloud</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string ServiceAccountId { get => this._serviceAccountId; set => this._serviceAccountId = value; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal)__updateHypervisorGroupReq).SkipCredentialValidation = value ?? default(bool); }

        /// <summary>Backing field for <see cref="UserName" /> property.</summary>
        private string _userName;

        /// <summary>username of GCP login Application</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string UserName { get => this._userName; set => this._userName = value; }

        /// <summary>Creates an new <see cref="UpdateHypervisorGroupGoogleCloud" /> instance.</summary>
        public UpdateHypervisorGroupGoogleCloud()
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
    /// Update a hypervisor group with Google Cloud as the destination vendor
    public partial interface IUpdateHypervisorGroupGoogleCloud :
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
        /// <summary>service account id of google cloud</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"service account id of google cloud",
        SerializedName = @"serviceAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceAccountId { get; set; }
        /// <summary>username of GCP login Application</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"username of GCP login Application",
        SerializedName = @"userName",
        PossibleTypes = new [] { typeof(string) })]
        string UserName { get; set; }

    }
    /// Update a hypervisor group with Google Cloud as the destination vendor
    internal partial interface IUpdateHypervisorGroupGoogleCloudInternal :
        Commvault.Powershell.Models.IUpdateHypervisorGroupReqInternal
    {
        string HypervisorType { get; set; }
        /// <summary>service account id of google cloud</summary>
        string ServiceAccountId { get; set; }
        /// <summary>username of GCP login Application</summary>
        string UserName { get; set; }

    }
}