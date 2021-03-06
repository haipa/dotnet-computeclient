// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.ComputeClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MachineNetwork
    {
        /// <summary>
        /// Initializes a new instance of the MachineNetwork class.
        /// </summary>
        public MachineNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachineNetwork class.
        /// </summary>
        public MachineNetwork(System.Guid? id = default(System.Guid?), System.Guid? machineId = default(System.Guid?), string name = default(string), IList<string> ipV4Addresses = default(IList<string>), IList<string> ipV6Addresses = default(IList<string>), string iPv4DefaultGateway = default(string), string iPv6DefaultGateway = default(string), IList<string> dnsServerAddresses = default(IList<string>), IList<string> ipV4Subnets = default(IList<string>), IList<string> ipV6Subnets = default(IList<string>))
        {
            Id = id;
            MachineId = machineId;
            Name = name;
            IpV4Addresses = ipV4Addresses;
            IpV6Addresses = ipV6Addresses;
            IPv4DefaultGateway = iPv4DefaultGateway;
            IPv6DefaultGateway = iPv6DefaultGateway;
            DnsServerAddresses = dnsServerAddresses;
            IpV4Subnets = ipV4Subnets;
            IpV6Subnets = ipV6Subnets;
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
        [JsonProperty(PropertyName = "machineId")]
        public System.Guid? MachineId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipV4Addresses")]
        public IList<string> IpV4Addresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipV6Addresses")]
        public IList<string> IpV6Addresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iPv4DefaultGateway")]
        public string IPv4DefaultGateway { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iPv6DefaultGateway")]
        public string IPv6DefaultGateway { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dnsServerAddresses")]
        public IList<string> DnsServerAddresses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipV4Subnets")]
        public IList<string> IpV4Subnets { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipV6Subnets")]
        public IList<string> IpV6Subnets { get; set; }

    }
}
