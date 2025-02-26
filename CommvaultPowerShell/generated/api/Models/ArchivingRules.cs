// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.2, generator: @autorest/powershell@4.0.708)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>These rules are enforced only when archiving is set to true</summary>
    public partial class ArchivingRules :
        Commvault.Powershell.Models.IArchivingRules,
        Commvault.Powershell.Models.IArchivingRulesInternal
    {

        /// <summary>Backing field for <see cref="AfterArchiving" /> property.</summary>
        private string _afterArchiving;

        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public string AfterArchiving { get => this._afterArchiving; set => this._afterArchiving = value; }

        /// <summary>Backing field for <see cref="ArchiveReadOnlyFiles" /> property.</summary>
        private bool? _archiveReadOnlyFiles;

        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public bool? ArchiveReadOnlyFiles { get => this._archiveReadOnlyFiles; set => this._archiveReadOnlyFiles = value; }

        /// <summary>Backing field for <see cref="FileAccessTimeOlderThan" /> property.</summary>
        private long? _fileAccessTimeOlderThan;

        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FileAccessTimeOlderThan { get => this._fileAccessTimeOlderThan; set => this._fileAccessTimeOlderThan = value; }

        /// <summary>Backing field for <see cref="FileCreatedTimeOlderThan" /> property.</summary>
        private long? _fileCreatedTimeOlderThan;

        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FileCreatedTimeOlderThan { get => this._fileCreatedTimeOlderThan; set => this._fileCreatedTimeOlderThan = value; }

        /// <summary>Backing field for <see cref="FileModifiedTimeOlderThan" /> property.</summary>
        private long? _fileModifiedTimeOlderThan;

        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FileModifiedTimeOlderThan { get => this._fileModifiedTimeOlderThan; set => this._fileModifiedTimeOlderThan = value; }

        /// <summary>Backing field for <see cref="FileSizeGreaterThan" /> property.</summary>
        private long? _fileSizeGreaterThan;

        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? FileSizeGreaterThan { get => this._fileSizeGreaterThan; set => this._fileSizeGreaterThan = value; }

        /// <summary>Backing field for <see cref="MaximumFileSize" /> property.</summary>
        private long? _maximumFileSize;

        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? MaximumFileSize { get => this._maximumFileSize; set => this._maximumFileSize = value; }

        /// <summary>Backing field for <see cref="StartCleaningIfLessThan" /> property.</summary>
        private long? _startCleaningIfLessThan;

        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? StartCleaningIfLessThan { get => this._startCleaningIfLessThan; set => this._startCleaningIfLessThan = value; }

        /// <summary>Backing field for <see cref="StopCleaningIfupto" /> property.</summary>
        private long? _stopCleaningIfupto;

        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Origin(Commvault.Powershell.PropertyOrigin.Owned)]
        public long? StopCleaningIfupto { get => this._stopCleaningIfupto; set => this._stopCleaningIfupto = value; }

        /// <summary>Creates an new <see cref="ArchivingRules" /> instance.</summary>
        public ArchivingRules()
        {

        }
    }
    /// These rules are enforced only when archiving is set to true
    public partial interface IArchivingRules :
        Commvault.Powershell.Runtime.IJsonSerializable
    {
        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving rules",
        SerializedName = @"afterArchiving",
        PossibleTypes = new [] { typeof(string) })]
        string AfterArchiving { get; set; }
        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the Read-Only attribute, set to TRUE",
        SerializedName = @"archiveReadOnlyFiles",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ArchiveReadOnlyFiles { get; set; }
        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the last accessed date of each file within the folder, specify the number of days",
        SerializedName = @"fileAccessTimeOlderThan",
        PossibleTypes = new [] { typeof(long) })]
        long? FileAccessTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the time the files were created within the folder, specify the number of days",
        SerializedName = @"fileCreatedTimeOlderThan",
        PossibleTypes = new [] { typeof(long) })]
        long? FileCreatedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the last modified date of each file within the folder, specify the number of days",
        SerializedName = @"fileModifiedTimeOlderThan",
        PossibleTypes = new [] { typeof(long) })]
        long? FileModifiedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between the minimum and maximum values are archived.",
        SerializedName = @"fileSizeGreaterThan",
        PossibleTypes = new [] { typeof(long) })]
        long? FileSizeGreaterThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between the minimum and maximum values are archived.",
        SerializedName = @"maximumFileSize",
        PossibleTypes = new [] { typeof(long) })]
        long? MaximumFileSize { get; set; }
        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When free disk space falls below specified amount (in percentage), start cleaning up the disk",
        SerializedName = @"startCleaningIfLessThan",
        PossibleTypes = new [] { typeof(long) })]
        long? StartCleaningIfLessThan { get; set; }
        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        [Commvault.Powershell.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When free disk space more than specified amount (in percentage), stop cleaning up the disk",
        SerializedName = @"stopCleaningIfupto",
        PossibleTypes = new [] { typeof(long) })]
        long? StopCleaningIfupto { get; set; }

    }
    /// These rules are enforced only when archiving is set to true
    internal partial interface IArchivingRulesInternal

    {
        /// <summary>
        /// After an archive job, replace the file that meets the archiving rules with a stub or delete the file that meets the archiving
        /// rules
        /// </summary>
        string AfterArchiving { get; set; }
        /// <summary>To archive files based on the Read-Only attribute, set to TRUE</summary>
        bool? ArchiveReadOnlyFiles { get; set; }
        /// <summary>
        /// To archive files based on the last accessed date of each file within the folder, specify the number of days
        /// </summary>
        long? FileAccessTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the time the files were created within the folder, specify the number of days
        /// </summary>
        long? FileCreatedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the last modified date of each file within the folder, specify the number of days
        /// </summary>
        long? FileModifiedTimeOlderThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the minimum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        long? FileSizeGreaterThan { get; set; }
        /// <summary>
        /// To archive files based on the size of the file, specify the maximum file size in KB. All files whose size ranges between
        /// the minimum and maximum values are archived.
        /// </summary>
        long? MaximumFileSize { get; set; }
        /// <summary>
        /// When free disk space falls below specified amount (in percentage), start cleaning up the disk
        /// </summary>
        long? StartCleaningIfLessThan { get; set; }
        /// <summary>
        /// When free disk space more than specified amount (in percentage), stop cleaning up the disk
        /// </summary>
        long? StopCleaningIfupto { get; set; }

    }
}