// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.ComputeClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Subnet
    {
        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Subnet class.
        /// </summary>
        public Subnet(System.Guid? id = default(System.Guid?), System.Guid? networkId = default(System.Guid?), bool? isPublic = default(bool?), bool? dhcpEnabled = default(bool?), int? ipVersion = default(int?), string gatewayAddress = default(string), string address = default(string), IList<string> dnsServerAddresses = default(IList<string>), Network network = default(Network))
        {
            Id = id;
            NetworkId = networkId;
            IsPublic = isPublic;
            DhcpEnabled = dhcpEnabled;
            IpVersion = ipVersion;
            GatewayAddress = gatewayAddress;
            Address = address;
            DnsServerAddresses = dnsServerAddresses;
            Network = network;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "networkId")]
        public System.Guid? NetworkId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dhcpEnabled")]
        public bool? DhcpEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipVersion")]
        public int? IpVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gatewayAddress")]
        public string GatewayAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dnsServerAddresses")]
        public IList<string> DnsServerAddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public Network Network { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Network != null)
            {
                Network.Validate();
            }
        }
    }
}
