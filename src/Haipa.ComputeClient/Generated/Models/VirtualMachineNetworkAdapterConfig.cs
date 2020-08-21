// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.ComputeClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class VirtualMachineNetworkAdapterConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineNetworkAdapterConfig class.
        /// </summary>
        public VirtualMachineNetworkAdapterConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineNetworkAdapterConfig class.
        /// </summary>
        public VirtualMachineNetworkAdapterConfig(string name = default(string), string switchName = default(string), string macAddress = default(string))
        {
            Name = name;
            SwitchName = switchName;
            MacAddress = macAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "switchName")]
        public string SwitchName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }

    }
}
