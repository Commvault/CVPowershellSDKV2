// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.4, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>Replication options for Amazon</summary>
    public partial class OverrideReplicationOptionsAmazon
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsAmazon.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IOverrideReplicationOptionsAmazon.</returns>
        public static Commvault.Powershell.Models.IOverrideReplicationOptionsAmazon FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new OverrideReplicationOptionsAmazon(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="OverrideReplicationOptionsAmazon" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal OverrideReplicationOptionsAmazon(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_network = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("network"), out var __jsonNetwork) ? Commvault.Powershell.Models.Network.FromJson(__jsonNetwork) : Network;}
            {_instanceName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("instanceName"), out var __jsonInstanceName) ? (string)__jsonInstanceName : (string)InstanceName;}
            {_availabilityZone = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("availabilityZone"), out var __jsonAvailabilityZone) ? (string)__jsonAvailabilityZone : (string)AvailabilityZone;}
            {_volumeType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("volumeType"), out var __jsonVolumeType) ? (string)__jsonVolumeType : (string)VolumeType;}
            {_encryptionKey = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("encryptionKey"), out var __jsonEncryptionKey) ? (string)__jsonEncryptionKey : (string)EncryptionKey;}
            {_autoSelectSecurityGroup = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("autoSelectSecurityGroup"), out var __jsonAutoSelectSecurityGroup) ? If( __jsonAutoSelectSecurityGroup as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.ISecurityGroup[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.ISecurityGroup) (Commvault.Powershell.Models.SecurityGroup.FromJson(__u) )) ))() : null : AutoSelectSecurityGroup;}
            {_instanceType = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("instanceType"), out var __jsonInstanceType) ? (string)__jsonInstanceType : (string)InstanceType;}
            {_computerName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("computerName"), out var __jsonComputerName) ? (string)__jsonComputerName : (string)ComputerName;}
            {_userName = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("userName"), out var __jsonUserName) ? (string)__jsonUserName : (string)UserName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="OverrideReplicationOptionsAmazon" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="OverrideReplicationOptionsAmazon" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._network ? (Commvault.Powershell.Runtime.Json.JsonNode) this._network.ToJson(null,serializationMode) : null, "network" ,container.Add );
            AddIf( null != (((object)this._instanceName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._instanceName.ToString()) : null, "instanceName" ,container.Add );
            AddIf( null != (((object)this._availabilityZone)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._availabilityZone.ToString()) : null, "availabilityZone" ,container.Add );
            AddIf( null != (((object)this._volumeType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._volumeType.ToString()) : null, "volumeType" ,container.Add );
            AddIf( null != (((object)this._encryptionKey)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._encryptionKey.ToString()) : null, "encryptionKey" ,container.Add );
            if (null != this._autoSelectSecurityGroup)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._autoSelectSecurityGroup )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("autoSelectSecurityGroup",__w);
            }
            AddIf( null != (((object)this._instanceType)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._instanceType.ToString()) : null, "instanceType" ,container.Add );
            AddIf( null != (((object)this._computerName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._computerName.ToString()) : null, "computerName" ,container.Add );
            AddIf( null != (((object)this._userName)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._userName.ToString()) : null, "userName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}