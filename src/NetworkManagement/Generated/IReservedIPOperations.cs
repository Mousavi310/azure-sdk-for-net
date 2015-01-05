// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Network Management API includes operations for managing the
    /// reserved IPs for your subscription.
    /// </summary>
    public partial interface IReservedIPOperations
    {
        /// <summary>
        /// The Begin Creating Reserved IP operation creates a reserved IP from
        /// your the subscription.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Begin Creating Reserved IP operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginCreatingAsync(NetworkReservedIPCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Deleting Reserved IP operation removes a reserved IP from
        /// your the subscription.
        /// </summary>
        /// <param name='ipName'>
        /// The name of the reserved IP.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> BeginDeletingAsync(string ipName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Create Reserved IP operation creates a reserved IP from your
        /// the subscription.
        /// </summary>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Reserved IP operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> CreateAsync(NetworkReservedIPCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Delete Reserved IP operation removes a reserved IP from your
        /// the subscription.
        /// </summary>
        /// <param name='ipName'>
        /// The name of the reserved IP.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> DeleteAsync(string ipName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Reserved IP operation retrieves the details for the virtual
        /// IP reserved for the subscription.
        /// </summary>
        /// <param name='ipName'>
        /// The name of the reserved IP to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A reserved IP associated with your subscription.
        /// </returns>
        Task<NetworkReservedIPGetResponse> GetAsync(string ipName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The List Reserved IP operation retrieves all of the virtual IPs
        /// reserved for the subscription.
        /// </summary>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response structure for the Server List operation.
        /// </returns>
        Task<NetworkReservedIPListResponse> ListAsync(CancellationToken cancellationToken);
    }
}
