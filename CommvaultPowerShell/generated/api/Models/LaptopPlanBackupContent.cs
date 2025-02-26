// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    public partial class LaptopPlanBackupContent :
        Commvault.Powershell.Models.ILaptopPlanBackupContent,
        Commvault.Powershell.Models.ILaptopPlanBackupContentInternal
    {

        /// <summary>Backing field for <see cref="FileSystemQuota" /> property.</summary>
        private long? _fileSystemQuota;

        /// <summary>
        /// Maximum number of gigabytes that you can store in the File System. Giving value as -1 means infinite file system quota.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FileSystemQuota { get => this._fileSystemQuota; set => this._fileSystemQuota = value; }

        /// <summary>Backing field for <see cref="MacExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _macExcludedPaths;

        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MacExcludedPaths { get => this._macExcludedPaths; set => this._macExcludedPaths = value; }

        /// <summary>Backing field for <see cref="MacIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _macIncludedPaths;

        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> MacIncludedPaths { get => this._macIncludedPaths; set => this._macIncludedPaths = value; }

        /// <summary>Backing field for <see cref="UnixExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _unixExcludedPaths;

        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UnixExcludedPaths { get => this._unixExcludedPaths; set => this._unixExcludedPaths = value; }

        /// <summary>Backing field for <see cref="UnixIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _unixIncludedPaths;

        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> UnixIncludedPaths { get => this._unixIncludedPaths; set => this._unixIncludedPaths = value; }

        /// <summary>Backing field for <see cref="WindowsExcludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _windowsExcludedPaths;

        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WindowsExcludedPaths { get => this._windowsExcludedPaths; set => this._windowsExcludedPaths = value; }

        /// <summary>Backing field for <see cref="WindowsIncludedPaths" /> property.</summary>
        private System.Collections.Generic.List<string> _windowsIncludedPaths;

        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> WindowsIncludedPaths { get => this._windowsIncludedPaths; set => this._windowsIncludedPaths = value; }

        /// <summary>Creates an new <see cref="LaptopPlanBackupContent" /> instance.</summary>
        public LaptopPlanBackupContent()
        {

        }
    }
    public partial interface ILaptopPlanBackupContent :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Maximum number of gigabytes that you can store in the File System. Giving value as -1 means infinite file system quota.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Maximum number of gigabytes that you can store in the File System. Giving value as -1 means infinite file system quota.",
        SerializedName = @"fileSystemQuota",
        PossibleTypes = new [] { typeof(long) })]
        long? FileSystemQuota { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for Mac",
        SerializedName = @"macExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for Mac",
        SerializedName = @"macIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> MacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for UNIX",
        SerializedName = @"unixExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for UNIX",
        SerializedName = @"unixIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> UnixIncludedPaths { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to exclude for Windows",
        SerializedName = @"windowsExcludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> WindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Paths to include for Windows",
        SerializedName = @"windowsIncludedPaths",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> WindowsIncludedPaths { get; set; }

    }
    internal partial interface ILaptopPlanBackupContentInternal

    {
        /// <summary>
        /// Maximum number of gigabytes that you can store in the File System. Giving value as -1 means infinite file system quota.
        /// </summary>
        long? FileSystemQuota { get; set; }
        /// <summary>Paths to exclude for Mac</summary>
        System.Collections.Generic.List<string> MacExcludedPaths { get; set; }
        /// <summary>Paths to include for Mac</summary>
        System.Collections.Generic.List<string> MacIncludedPaths { get; set; }
        /// <summary>Paths to exclude for UNIX</summary>
        System.Collections.Generic.List<string> UnixExcludedPaths { get; set; }
        /// <summary>Paths to include for UNIX</summary>
        System.Collections.Generic.List<string> UnixIncludedPaths { get; set; }
        /// <summary>Paths to exclude for Windows</summary>
        System.Collections.Generic.List<string> WindowsExcludedPaths { get; set; }
        /// <summary>Paths to include for Windows</summary>
        System.Collections.Generic.List<string> WindowsIncludedPaths { get; set; }

    }
}