// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Create a hypervisor group with Ali Baba as the destination vendor</summary>
    public partial class CreateHypervisorGroupAliCloud :
        Commvault.Powershell.Models.ICreateHypervisorGroupAliCloud,
        Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal,
        Commvault.Powershell.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Commvault.Powershell.Models.ICreateHypervisorGroupReq" />
        /// </summary>
        private Commvault.Powershell.Models.ICreateHypervisorGroupReq __createHypervisorGroupReq = new Commvault.Powershell.Models.CreateHypervisorGroupReq();

        /// <summary>Backing field for <see cref="AccessKey" /> property.</summary>
        private string _accessKey;

        /// <summary>Access key of alibaba cloud</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AccessKey { get => this._accessKey; set => this._accessKey = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Commvault.Powershell.Models.IAccessNodeModel> AccessNodes { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).AccessNodes = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for HypervisorType</summary>
        string Commvault.Powershell.Models.ICreateHypervisorGroupAliCloudInternal.HypervisorType { get => this._hypervisorType; set { {_hypervisorType = value;} } }

        /// <summary>Internal Acessors for Credentials</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal.Credentials { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials = value; }

        /// <summary>Internal Acessors for EtcdProtection</summary>
        Commvault.Powershell.Models.IEtcdProtectionItem Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal.EtcdProtection { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtection; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtection = value; }

        /// <summary>Internal Acessors for EtcdProtectionPlan</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal.EtcdProtectionPlan { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionPlan; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionPlan = value; }

        /// <summary>Internal Acessors for PlanEntity</summary>
        Commvault.Powershell.Models.IIdName Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal.PlanEntity { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntity; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntity = value; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName Credentials { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Credentials = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? CredentialsId { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string CredentialsName { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).CredentialsName = value ?? null; }

        /// <summary>Create an application group etcd (system generated) with pre-defined content</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IEtcdProtectionItem EtcdProtection { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtection; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtection = value ?? null /* model class */; }

        /// <summary>Denote if etcd protection is enabled</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? EtcdProtectionEnabled { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionEnabled; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionEnabled = value ?? default(bool); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName EtcdProtectionPlan { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionPlan; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).EtcdProtectionPlan = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="HypervisorType" /> property.</summary>
        private string _hypervisorType= @"ALIBABA_CLOUD";

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string HypervisorType { get => this._hypervisorType; }

        /// <summary>The name of the hypervisor group being created</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string Name { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).Name = value ; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        internal Commvault.Powershell.Models.IIdName PlanEntity { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntity; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntity = value ?? null /* model class */; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? PlanEntityId { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntityId; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntityId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string PlanEntityName { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntityName; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanEntityName = value ?? null; }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public long? PlanId { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanId; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanId = value ?? default(long); }

        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public string PlanName { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanName; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).PlanName = value ?? null; }

        /// <summary>Backing field for <see cref="SecretKey" /> property.</summary>
        private string _secretKey;

        /// <summary>secret key of alibaba cloud</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string SecretKey { get => this._secretKey; set => this._secretKey = value; }

        /// <summary>if credential validation has to be skipped.</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Inherited)]
        public bool? SkipCredentialValidation { get => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation; set => ((Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal)__createHypervisorGroupReq).SkipCredentialValidation = value ?? default(bool); }

        /// <summary>Creates an new <see cref="CreateHypervisorGroupAliCloud" /> instance.</summary>
        public CreateHypervisorGroupAliCloud()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Commvault.Powershell.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Commvault.Powershell.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__createHypervisorGroupReq), __createHypervisorGroupReq);
            await eventListener.AssertObjectIsValid(nameof(__createHypervisorGroupReq), __createHypervisorGroupReq);
        }
    }
    /// Create a hypervisor group with Ali Baba as the destination vendor
    public partial interface ICreateHypervisorGroupAliCloud :
        Commvault.Powershell.Runtime.IJsonSerializable,
        Commvault.Powershell.Models.ICreateHypervisorGroupReq
    {
        /// <summary>Access key of alibaba cloud</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Access key of alibaba cloud",
        SerializedName = @"accessKey",
        PossibleTypes = new [] { typeof(string) })]
        string AccessKey { get; set; }

        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"hypervisorType",
        PossibleTypes = new [] { typeof(string) })]
        string HypervisorType { get;  }
        /// <summary>secret key of alibaba cloud</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"secret key of alibaba cloud",
        SerializedName = @"secretKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecretKey { get; set; }

    }
    /// Create a hypervisor group with Ali Baba as the destination vendor
    internal partial interface ICreateHypervisorGroupAliCloudInternal :
        Commvault.Powershell.Models.ICreateHypervisorGroupReqInternal
    {
        /// <summary>Access key of alibaba cloud</summary>
        string AccessKey { get; set; }

        string HypervisorType { get; set; }
        /// <summary>secret key of alibaba cloud</summary>
        string SecretKey { get; set; }

    }
}