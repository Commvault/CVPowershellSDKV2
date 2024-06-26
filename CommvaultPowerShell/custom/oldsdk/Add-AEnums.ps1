function Add-AEnums{

Add-Type -TypeDefinition @"
public enum CVMatchingPattern {
    Contains = 0,
    Equals,
    StartsWith,
    EndsWith
}
"@

Add-Type -TypeDefinition @"
public enum CVOperationWindowRuleLevel {
    CommServ = 0,
    ClientGroup,
    Client,
    iDataAgent,
    Instance,
    Backupset,
    Subclient,
    SchedulePolicy,
    Schedule
}
"@

Add-Type -TypeDefinition @"
public enum CVSchedulePolicyType {
    All = -1,
    DataProtection = 0,
    AuxiliaryCopy = 1,
    BackupCopy = 3,
    OfflineContentIndexing = 6,
    DDBVerification = 11,
    ContentIndexing = 12,
    Workflow = 13
}
"@

Add-Type -TypeDefinition @"
public enum CVBackupType {
    Full = 1,
    Incremental = 2,
    Differential = 3,
    Synthetic_Full = 4
}
"@

Add-Type -TypeDefinition @"
public enum CVSQLBackupType {
    full = 1,
    incremental = 2,
    differential = 3
}
"@

Add-Type -TypeDefinition @"
public enum CVSQLDatabaseSortColumn {
    bkpTime,
    bkpSize,
    insName,
    dbName,
    cName,
    planName
}
"@

Add-Type -TypeDefinition @"
public enum CVSQLInstanceSortColumn {
    insId,
    insName,
    version,
    cName,
    noDBs,
    planName
}
"@

Add-Type -TypeDefinition @"
public enum CVVSAVMStatus {
    ALL = 0,
    PROTECTED = 1,
    NOT_PROTECTED = 2,
    PENDING = 3,
    BACKED_UP_WITH_ERROR = 4
}
"@

Add-Type -TypeDefinition @"
public enum CVVSABackupType {
    full = 1,
    incremental = 2,
    synthfull = 3
}
"@

Add-Type -TypeDefinition @"
public enum CVVSARestoreType {
    VirtualMachineFiles = 2,
    FullVirtualMachine = 3
}
"@

Add-Type -TypeDefinition @"
public enum CVVSAHyperVisorType {
    vmware    = 101,
    hyperv    = 102
}
"@

Add-Type -TypeDefinition @"
public enum CVVSAContentOperationType {
    ADD,
    DELETE,
    OVERWRITE
}
"@

<#
Object	             Numeric Value	Text Value
Server Host Name or IP Address	 1	 SERVER
Resource Pool	                 2   RES_POOL
vApp                             3   VAPP
Datacenter                       4   DATACENTER
Folder                           5   FOLDER
Cluster                          6   CLUSTER
Datastore Name                   7   DATASTORE
Datastore Cluster                8   DATASTORE_CLUSTER
Virtual Machine GUID             9   VM
Virtual Machine Name or Pattern	 10  VMName
Virtual Machine Guest OS         11  VMGuestOS
Virtual Machine Guest Host Name  12  VMGuestHostName
Cluster Shared Volumes	         13  ClusterSharedVolumes
Local Disk                       14  LocalDisk
Cluster Disk                     15  ClusterDisk
Unprotected VMs                  16  UnprotectedVMs
All	                             17  ROOT
File Server                      18  FileServer
Share                            19  SMBShare
Types                            20  TypesFolder
VMs                              21  VMFolder
Servers                          22  ServerFolder
Custom Templates                 23  TemplateFolder
Datastore List                   24  StorageRepositoryFolder
vApp List                        25  VAppFolder
Datacenters                      26  DatacenterFolder
Clusters                         27  ClusterFolder
Virtual Machine Power State      28  VMPowerState
Virtual Machine Notes            29  VMNotes
Virtual Machine Custom Attribute 30  VMCustomAttribute
Network Adapter                  31  Network
User                             32  User
Virtual Machine Template         33  VMTemplate
Tag                              34  Tag
Tag Category                     35  TagCategory
Subclient                        36  Subclient
Client Group                     37  ClientGroup
Protection Domain                38  ProtectionDomain
Consistency Group                39  ConsistencyGroup
Instance Size                    40  InstanceSize
Organization                     41  Organization
#>
Add-Type -TypeDefinition @"
public enum CVVSAContentEntityType {
    SERVER	                = 1,
    RES_POOL                = 2,
    VAPP	                = 3,
    DATACENTER	            = 4,
    FOLDER	                = 5,
    CLUSTER	                = 6,
    DATASTORE	            = 7,
    DATASTORE_CLUSTER       = 8,
    VM	                    = 9,
    VMName	                = 10,
    VMGuestOS	            = 11,
    VMGuestHostName	        = 12,
    ClusterSharedVolumes    = 13,
    LocalDisk               = 14,
    ClusterDisk	            = 15,
    UnprotectedVMs          = 16,
    ROOT	                = 17,
    FileServer	            = 18,
    SMBShare	            = 19,
    TypesFolder	            = 20,
    VMFolder	            = 21,
    ServerFolder            = 22,
    TemplateFolder          = 23,
    StorageRepositoryFolder	= 24,
    VAppFolder	            = 25,
    DatacenterFolder        = 26,
    ClusterFolder           = 27,
    VMPowerState            = 28,
    VMNotes	                = 29,
    VMCustomAttribute       = 30,
    Network	                = 31,
    User	                = 32,
    VMTemplate	            = 33,
    Tag	                    = 34,
    TagCategory	            = 35,
    Subclient	            = 36,
    ClientGroup	            = 37,
    ProtectionDomain        = 38,
    ConsistencyGroup        = 39,
    InstanceSize            = 40,
    Organization            = 41
}
"@

Add-Type -TypeDefinition @"
public enum CVVMGroupContentEntityType {
    Host                    = 1,
    Datastore               = 7,
    VMName                  = 9,
    VMNamePattern           = 10,
    GuestOS                 = 11,
    GuestDNSHostname        = 12,
    PoweredState            = 28,
    Notes                   = 29,
    TemplateState           = 33,
    Tag                     = 34,
    TagCategory             = 35
}
"@

Add-Type -TypeDefinition @"
public enum CVVSAPowerState {
    Off                     = 0,
    On                      = 1,
    Other                   = 2
}
"@

}