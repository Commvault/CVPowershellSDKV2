// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Get list of global windows and unix execptions</summary>
    public partial class GetGlobalExceptions :
        Commvault.Powershell.Models.IGetGlobalExceptions,
        Commvault.Powershell.Models.IGetGlobalExceptionsInternal
    {

        /// <summary>Backing field for <see cref="UnixGlobalExceptions" /> property.</summary>
        private string[] _unixGlobalExceptions;

        /// <summary>List of global unix execptions</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] UnixGlobalExceptions { get => this._unixGlobalExceptions; set => this._unixGlobalExceptions = value; }

        /// <summary>Backing field for <see cref="UseGlobalExceptionsOnAllSubclients" /> property.</summary>
        private bool? _useGlobalExceptionsOnAllSubclients;

        /// <summary>Boolean which signifies application of global execption on all subclients</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? UseGlobalExceptionsOnAllSubclients { get => this._useGlobalExceptionsOnAllSubclients; set => this._useGlobalExceptionsOnAllSubclients = value; }

        /// <summary>Backing field for <see cref="WindowsGlobalExceptions" /> property.</summary>
        private string[] _windowsGlobalExceptions;

        /// <summary>gives list of all the windowsglobal execptions</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string[] WindowsGlobalExceptions { get => this._windowsGlobalExceptions; set => this._windowsGlobalExceptions = value; }

        /// <summary>Creates an new <see cref="GetGlobalExceptions" /> instance.</summary>
        public GetGlobalExceptions()
        {

        }
    }
    /// Get list of global windows and unix execptions
    public partial interface IGetGlobalExceptions :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>List of global unix execptions</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of global unix execptions",
        SerializedName = @"unixGlobalExceptions",
        PossibleTypes = new [] { typeof(string) })]
        string[] UnixGlobalExceptions { get; set; }
        /// <summary>Boolean which signifies application of global execption on all subclients</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Boolean which signifies application of global execption on all subclients",
        SerializedName = @"useGlobalExceptionsOnAllSubclients",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseGlobalExceptionsOnAllSubclients { get; set; }
        /// <summary>gives list of all the windowsglobal execptions</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"gives list of all the windowsglobal execptions",
        SerializedName = @"windowsGlobalExceptions",
        PossibleTypes = new [] { typeof(string) })]
        string[] WindowsGlobalExceptions { get; set; }

    }
    /// Get list of global windows and unix execptions
    internal partial interface IGetGlobalExceptionsInternal

    {
        /// <summary>List of global unix execptions</summary>
        string[] UnixGlobalExceptions { get; set; }
        /// <summary>Boolean which signifies application of global execption on all subclients</summary>
        bool? UseGlobalExceptionsOnAllSubclients { get; set; }
        /// <summary>gives list of all the windowsglobal execptions</summary>
        string[] WindowsGlobalExceptions { get; set; }

    }
}