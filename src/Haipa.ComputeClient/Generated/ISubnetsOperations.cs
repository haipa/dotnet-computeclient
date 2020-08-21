// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.ComputeClient
{
    using Haipa.ClientRuntime;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SubnetsOperations operations.
    /// </summary>
    public partial interface ISubnetsOperations
    {
        /// <param name='select'>
        /// Limits the properties returned in the result.
        /// </param>
        /// <param name='expand'>
        /// Indicates the related entities to be represented inline. The
        /// maximum depth is 2.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Haipa.ClientRuntime.HaipaServiceException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<Haipa.ClientRuntime.HaipaOperationResponse> ListWithHttpMessagesAsync(string select = default(string), string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
