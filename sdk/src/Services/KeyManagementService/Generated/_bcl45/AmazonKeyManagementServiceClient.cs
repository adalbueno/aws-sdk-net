/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/">AWS
    /// Key Management Service Developer Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to AWS KMS and other AWS services. For
    /// example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account (root) access key ID and secret
    /// key for everyday work with AWS KMS. Instead, use the access key ID and secret access
    /// key for an IAM user, or you can use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the types
    /// of credentials used for accessing AWS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the APIs discussed in this guide, the following will prove the most useful for
    /// most applications. You will likely perform actions other than these, such as creating
    /// keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CancelKeyDeletion


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public CancelKeyDeletionResponse CancelKeyDeletion(string keyId)
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletion(request);
        }


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var marshaller = new CancelKeyDeletionRequestMarshaller();
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelKeyDeletionRequestMarshaller();
            var unmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelKeyDeletionRequest,CancelKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS).
        /// 
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        ///  
        /// <para>
        /// To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">An identifier of the key for which you are creating the alias. This value cannot be another alias but can be a globally unique identifier or a fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public CreateAliasResponse CreateAlias(string aliasName, string targetKeyId)
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAlias(request);
        }


        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS).
        /// 
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        ///  
        /// <para>
        /// To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS).
        /// 
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        ///  
        /// <para>
        /// To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">An identifier of the key for which you are creating the alias. This value cannot be another alias but can be a globally unique identifier or a fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAliasAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Adds a grant to a key to specify who can use the key and under what conditions. Grants
        /// are alternate permission mechanisms to key policies.
        /// 
        ///  
        /// <para>
        /// For more information about grants, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var marshaller = new CreateGrantRequestMarshaller();
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantRequest,CreateGrantResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateGrantRequestMarshaller();
            var unmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantRequest,CreateGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateKey


        /// <summary>
        /// Creates a customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// You can use a CMK to encrypt small amounts of data (4 KiB or less) directly, but CMKs
        /// are more commonly used to encrypt data encryption keys (DEKs), which are used to encrypt
        /// raw data. For more information about DEKs and the difference between CMKs and DEKs,
        /// see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <a>GenerateDataKey</a> operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">AWS
        /// Key Management Service Concepts</a> in the <i>AWS Key Management Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var marshaller = new CreateKeyRequestMarshaller();
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyRequest,CreateKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyRequestMarshaller();
            var unmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyRequest,CreateKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Decrypt


        /// <summary>
        /// Decrypts ciphertext. Ciphertext is plaintext that has been previously encrypted by
        /// using any of the following functions:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that if a caller has been granted access permissions to all keys (through, for
        /// example, IAM user policies that grant <code>Decrypt</code> permission on all resources),
        /// then ciphertext encrypted by using keys in other accounts where the key grants access
        /// to the caller can be decrypted. To remedy this, we recommend that you do not grant
        /// <code>Decrypt</code> access in an IAM user policy. Instead grant <code>Decrypt</code>
        /// access only in key policies. If you must grant <code>Decrypt</code> access in an IAM
        /// user policy, you should scope the resource to specific keys or to specific trusted
        /// accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public DecryptResponse Decrypt(DecryptRequest request)
        {
            var marshaller = new DecryptRequestMarshaller();
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptRequest,DecryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DecryptRequestMarshaller();
            var unmarshaller = DecryptResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptRequest,DecryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes the specified alias. To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public DeleteAliasResponse DeleteAlias(string aliasName)
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAlias(request);
        }


        /// <summary>
        /// Deletes the specified alias. To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the specified alias. To map an alias to a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAliasAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAliasRequestMarshaller();
            var unmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasRequest,DeleteAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedKeyMaterial


        /// <summary>
        /// Deletes key material that you previously imported and makes the specified customer
        /// master key (CMK) unusable. For more information about importing key material into
        /// AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When the specified CMK is in the <code>PendingDeletion</code> state, this operation
        /// does not change the CMK's state. Otherwise, it changes the CMK's state to <code>PendingImport</code>.
        /// </para>
        ///  
        /// <para>
        /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
        /// same key material into the CMK.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request)
        {
            var marshaller = new DeleteImportedKeyMaterialRequestMarshaller();
            var unmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedKeyMaterialRequest,DeleteImportedKeyMaterialResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportedKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteImportedKeyMaterialRequestMarshaller();
            var unmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportedKeyMaterialRequest,DeleteImportedKeyMaterialResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey


        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier, a fully specified ARN to either an alias or a key, or an alias name prefixed by "alias/". <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> <li> Alias Name Example - alias/MyAliasName </li> </ul></param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public DescribeKeyResponse DescribeKey(string keyId)
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKey(request);
        }


        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var marshaller = new DescribeKeyRequestMarshaller();
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier, a fully specified ARN to either an alias or a key, or an alias name prefixed by "alias/". <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> <li> Alias Name Example - alias/MyAliasName </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKeyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyRequestMarshaller();
            var unmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyRequest,DescribeKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKey


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. For more information about how key state affects
        /// the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. Use the CMK's unique identifier or its Amazon Resource Name (ARN). For example: <ul> <li> Unique ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul></param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public DisableKeyResponse DisableKey(string keyId)
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKey(request);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. For more information about how key state affects
        /// the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var marshaller = new DisableKeyRequestMarshaller();
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRequest,DisableKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. For more information about how key state affects
        /// the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. Use the CMK's unique identifier or its Amazon Resource Name (ARN). For example: <ul> <li> Unique ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKeyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableKeyRequestMarshaller();
            var unmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRequest,DisableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation


        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public DisableKeyRotationResponse DisableKeyRotation(string keyId)
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotation(request);
        }


        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var marshaller = new DisableKeyRotationRequestMarshaller();
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableKeyRotationRequestMarshaller();
            var unmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRotationRequest,DisableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKey


        /// <summary>
        /// Marks a key as enabled, thereby permitting its use.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public EnableKeyResponse EnableKey(string keyId)
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKey(request);
        }


        /// <summary>
        /// Marks a key as enabled, thereby permitting its use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var marshaller = new EnableKeyRequestMarshaller();
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRequest,EnableKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Marks a key as enabled, thereby permitting its use.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKeyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableKeyRequestMarshaller();
            var unmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRequest,EnableKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation


        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public EnableKeyRotationResponse EnableKeyRotation(string keyId)
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotation(request);
        }


        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var marshaller = new EnableKeyRotationRequestMarshaller();
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotationAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableKeyRotationRequestMarshaller();
            var unmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRotationRequest,EnableKeyRotationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Encrypt


        /// <summary>
        /// Encrypts plaintext into ciphertext by using a customer master key. The <code>Encrypt</code>
        /// function has two primary use cases:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can encrypt up to 4 KB of arbitrary data such as an RSA key, a database password,
        /// or other sensitive customer information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are moving encrypted data from one region to another, you can use this API
        /// to encrypt in the new region the plaintext data key that was used to encrypt the data
        /// in the original region. This provides you with an encrypted copy of the data key that
        /// can be decrypted in the new region and used there to decrypt the encrypted data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Unless you are moving encrypted data from one region to another, you don't use this
        /// function to encrypt a generated data key within a region. You retrieve data keys already
        /// encrypted by calling the <a>GenerateDataKey</a> or <a>GenerateDataKeyWithoutPlaintext</a>
        /// function. Data keys don't need to be encrypted again by calling <code>Encrypt</code>.
        /// </para>
        ///  
        /// <para>
        /// If you want to encrypt data locally in your application, you can use the <code>GenerateDataKey</code>
        /// function to return a plaintext data encryption key and a copy of the key encrypted
        /// under the customer master key (CMK) of your choosing.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public EncryptResponse Encrypt(EncryptRequest request)
        {
            var marshaller = new EncryptRequestMarshaller();
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptRequest,EncryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EncryptRequestMarshaller();
            var unmarshaller = EncryptResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptRequest,EncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey


        /// <summary>
        /// Returns a data encryption key that you can use in your application to encrypt data
        /// locally.
        /// 
        ///  
        /// <para>
        /// You must specify the customer master key (CMK) under which to generate the data key.
        /// You must also specify the length of the data key using either the <code>KeySpec</code>
        /// or <code>NumberOfBytes</code> field. You must specify one field or the other, but
        /// not both. For common key lengths (128-bit and 256-bit symmetric keys), we recommend
        /// that you use <code>KeySpec</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation returns a plaintext copy of the data key in the <code>Plaintext</code>
        /// field of the response, and an encrypted copy of the data key in the <code>CiphertextBlob</code>
        /// field. The data key is encrypted under the CMK specified in the <code>KeyId</code>
        /// field of the request.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use this operation (<code>GenerateDataKey</code>) to retrieve a data encryption key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data encryption key (returned in the <code>Plaintext</code> field
        /// of the response) to encrypt data locally, then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (returned in the <code>CiphertextBlob</code> field of
        /// the response) alongside the locally encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data locally:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key into a plaintext
        /// copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data locally, then erase the plaintext data
        /// key from memory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To return only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To return a random byte string that is cryptographically secure, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use the optional <code>EncryptionContext</code> field, you must store at least
        /// enough information to be able to reconstruct the full encryption context when you
        /// later send the ciphertext to the <a>Decrypt</a> operation. It is a good practice to
        /// choose an encryption context that you can reconstruct on the fly to better secure
        /// the ciphertext. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var marshaller = new GenerateDataKeyRequestMarshaller();
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateDataKeyRequestMarshaller();
            var unmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyRequest,GenerateDataKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext


        /// <summary>
        /// Returns a data encryption key encrypted under a customer master key (CMK). This operation
        /// is identical to <a>GenerateDataKey</a> but returns only the encrypted copy of the
        /// data key.
        /// 
        ///  
        /// <para>
        /// This operation is useful in a system that has multiple components with different degrees
        /// of trust. For example, consider a system that stores encrypted data in containers.
        /// Each container stores the encrypted data and an encrypted copy of the data key. One
        /// component of the system, called the <i>control plane</i>, creates new containers.
        /// When it creates a new container, it uses this operation (<code>GenerateDataKeyWithoutPlaintext</code>)
        /// to get an encrypted data key and then stores it in the container. Later, a different
        /// component of the system, called the <i>data plane</i>, puts encrypted data into the
        /// containers. To do this, it passes the encrypted data key to the <a>Decrypt</a> operation,
        /// then uses the returned plaintext data key to encrypt data, and finally stores the
        /// encrypted data in the container. In this system, the control plane never sees the
        /// plaintext data key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var marshaller = new GenerateDataKeyWithoutPlaintextRequestMarshaller();
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateDataKeyWithoutPlaintextRequestMarshaller();
            var unmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyWithoutPlaintextRequest,GenerateDataKeyWithoutPlaintextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public GenerateRandomResponse GenerateRandom(int numberOfBytes)
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandom(request);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var marshaller = new GenerateRandomRequestMarshaller();
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandomAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateRandomRequestMarshaller();
            var unmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRandomRequest,GenerateRandomResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy


        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="policyName">String that contains the name of the policy. Currently, this must be "default". Policy names can be discovered by calling <a>ListKeyPolicies</a>.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public GetKeyPolicyResponse GetKeyPolicy(string keyId, string policyName)
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicy(request);
        }


        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var marshaller = new GetKeyPolicyRequestMarshaller();
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="policyName">String that contains the name of the policy. Currently, this must be "default". Policy names can be discovered by calling <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetKeyPolicyRequestMarshaller();
            var unmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPolicyRequest,GetKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus


        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public GetKeyRotationStatusResponse GetKeyRotationStatus(string keyId)
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatus(request);
        }


        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var marshaller = new GetKeyRotationStatusRequestMarshaller();
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatusAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetKeyRotationStatusRequestMarshaller();
            var unmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyRotationStatusRequest,GetKeyRotationStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForImport


        /// <summary>
        /// Returns the items you need in order to import key material into AWS KMS from your
        /// existing key management infrastructure. For more information about importing key material
        /// into AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify the key ID of the customer master key (CMK) into which you will import
        /// key material. This CMK's <code>Origin</code> must be <code>EXTERNAL</code>. You must
        /// also specify the wrapping algorithm and type of wrapping key (public key) that you
        /// will use to encrypt the key material.
        /// </para>
        ///  
        /// <para>
        /// This operation returns a public key and an import token. Use the public key to encrypt
        /// the key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
        /// request. The public key and import token from the same response must be used together.
        /// These items are valid for 24 hours, after which they cannot be used for a subsequent
        /// <a>ImportKeyMaterial</a> request. To retrieve new ones, send another <code>GetParametersForImport</code>
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            var marshaller = new GetParametersForImportRequestMarshaller();
            var unmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForImportRequest,GetParametersForImportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetParametersForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetParametersForImportRequestMarshaller();
            var unmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForImportRequest,GetParametersForImportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyMaterial


        /// <summary>
        /// Imports key material into an AWS KMS customer master key (CMK) from your existing
        /// key management infrastructure. For more information about importing key material into
        /// AWS KMS, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You must specify the key ID of the CMK to import the key material into. This CMK's
        /// <code>Origin</code> must be <code>EXTERNAL</code>. You must also send an import token
        /// and the encrypted key material. Send the import token that you received in the same
        /// <a>GetParametersForImport</a> response that contained the public key that you used
        /// to encrypt the key material. You must also specify whether the key material expires
        /// and if so, when. When the key material expires, AWS KMS deletes the key material and
        /// the CMK becomes unusable. To use the CMK again, you can reimport the same key material.
        /// If you set an expiration date, you can change it only by reimporting the same key
        /// material and specifying a new expiration date.
        /// </para>
        ///  
        /// <para>
        /// When this operation is successful, the specified CMK's key state changes to <code>Enabled</code>,
        /// and you can use the CMK.
        /// </para>
        ///  
        /// <para>
        /// After you successfully import key material into a CMK, you can reimport the same key
        /// material into that CMK, but you cannot import different key material.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the provided import token is expired. Use <a>GetParametersForImport</a>
        /// to retrieve a new import token and public key, use the new public key to encrypt the
        /// key material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the provided key material is invalid or is not the
        /// same key material that was previously imported into this customer master key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different customer master key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            var marshaller = new ImportKeyMaterialRequestMarshaller();
            var unmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<ImportKeyMaterialRequest,ImportKeyMaterialResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportKeyMaterialRequestMarshaller();
            var unmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyMaterialRequest,ImportKeyMaterialResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Lists all of the key aliases in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesRequest,ListAliasesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListAliasesRequestMarshaller();
            var unmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesRequest,ListAliasesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListGrants


        /// <summary>
        /// List the grants for a specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var marshaller = new ListGrantsRequestMarshaller();
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsRequest,ListGrantsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListGrantsRequestMarshaller();
            var unmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGrantsRequest,ListGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies


        /// <summary>
        /// Retrieves a list of policies attached to a key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var marshaller = new ListKeyPoliciesRequestMarshaller();
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListKeyPoliciesRequestMarshaller();
            var unmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPoliciesRequest,ListKeyPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Lists the customer master keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var marshaller = new ListKeysRequestMarshaller();
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysRequest,ListKeysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListKeysRequestMarshaller();
            var unmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysRequest,ListKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTags


        /// <summary>
        /// Returns a list of all tags for the specified customer master key (CMK).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            var marshaller = new ListResourceTagsRequestMarshaller();
            var unmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTagsRequest,ListResourceTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListResourceTagsRequestMarshaller();
            var unmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTagsRequest,ListResourceTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public ListRetirableGrantsResponse ListRetirableGrants(string retiringPrincipal)
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrants(request);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public ListRetirableGrantsResponse ListRetirableGrants()
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrants(request);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var marshaller = new ListRetirableGrantsRequestMarshaller();
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrantsAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetirableGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRetirableGrantsRequestMarshaller();
            var unmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetirableGrantsRequest,ListRetirableGrantsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. Use the CMK's unique identifier or its Amazon Resource Name (ARN). For example: <ul> <li> Unique ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul></param>
        /// <param name="policy">The key policy to attach to the CMK. If you do not set <code>BypassPolicyLockoutSafetyCheck</code> to true, the policy must meet the following criteria: <ul> <li> It must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the likelihood that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section in the <i>AWS Key Management Service Developer Guide</i>. </li> <li> The principals that are specified in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before specifying the new principal in a key policy because the new principal might not immediately be visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>IAM User Guide</i>. </li> </ul> The policy size limit is 32 KiB (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. This value must be <code>default</code>.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public PutKeyPolicyResponse PutKeyPolicy(string keyId, string policy, string policyName)
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicy(request);
        }


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var marshaller = new PutKeyPolicyRequestMarshaller();
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. Use the CMK's unique identifier or its Amazon Resource Name (ARN). For example: <ul> <li> Unique ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul></param>
        /// <param name="policy">The key policy to attach to the CMK. If you do not set <code>BypassPolicyLockoutSafetyCheck</code> to true, the policy must meet the following criteria: <ul> <li> It must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the likelihood that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section in the <i>AWS Key Management Service Developer Guide</i>. </li> <li> The principals that are specified in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before specifying the new principal in a key policy because the new principal might not immediately be visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>IAM User Guide</i>. </li> </ul> The policy size limit is 32 KiB (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. This value must be <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicyAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutKeyPolicyRequestMarshaller();
            var unmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyPolicyRequest,PutKeyPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt


        /// <summary>
        /// Encrypts data on the server side with a new customer master key (CMK) without exposing
        /// the plaintext of the data on the client side. The data is first decrypted and then
        /// reencrypted. You can also use this operation to change the encryption context of a
        /// ciphertext.
        /// 
        ///  
        /// <para>
        /// Unlike other operations, <code>ReEncrypt</code> is authorized twice, once as <code>ReEncryptFrom</code>
        /// on the source CMK and once as <code>ReEncryptTo</code> on the destination CMK. We
        /// recommend that you include the <code>"kms:ReEncrypt*"</code> permission in your <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policies</a> to permit reencryption from or to the CMK. This permission is automatically
        /// included in the key policy when you create a CMK through the console, but you must
        /// include it manually when you create a CMK programmatically or when you set a key policy
        /// with the <a>PutKeyPolicy</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified <code>KeySpec</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var marshaller = new ReEncryptRequestMarshaller();
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptRequest,ReEncryptResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReEncryptRequestMarshaller();
            var unmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptRequest,ReEncryptResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public RetireGrantResponse RetireGrant(string grantToken)
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrant(request);
        }


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var marshaller = new RetireGrantRequestMarshaller();
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantRequest,RetireGrantResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrantAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RetireGrantRequestMarshaller();
            var unmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RetireGrantRequest,RetireGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant


        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public RevokeGrantResponse RevokeGrant(string grantId, string keyId)
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrant(request);
        }


        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var marshaller = new RevokeGrantRequestMarshaller();
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrantAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeGrantRequestMarshaller();
            var unmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeGrantRequest,RevokeGrantResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletion(request);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId, int pendingWindowInDays)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletion(request);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var marshaller = new ScheduleKeyDeletionRequestMarshaller();
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the state
        /// of the CMK changes to <code>PendingDeletion</code>. Before the waiting period ends,
        /// you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After the
        /// waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is rendered unrecoverable. To restrict
        /// the use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) to delete. To specify this value, use the unique key ID or the Amazon Resource Name (ARN) of the CMK. Examples: <ul> <li> Unique key ID: 1234abcd-12ab-34cd-56ef-1234567890ab </li> <li> Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab </li> </ul> To obtain the unique key ID and key ARN for a given CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ScheduleKeyDeletionRequestMarshaller();
            var unmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleKeyDeletionRequest,ScheduleKeyDeletionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for the specified customer master key (CMK). 
        /// 
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty (null) strings.
        /// </para>
        ///  
        /// <para>
        /// You cannot use the same tag key more than once per CMK. For example, consider a CMK
        /// with one tag whose tag key is <code>Purpose</code> and tag value is <code>Test</code>.
        /// If you send a <code>TagResource</code> request for this CMK with a tag key of <code>Purpose</code>
        /// and a tag value of <code>Prod</code>, it does not create a second tag. Instead, the
        /// original tag is overwritten with the new tag value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TagResourceRequestMarshaller();
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tag or tags from the specified customer master key (CMK). 
        /// 
        ///  
        /// <para>
        /// To remove a tag, you specify the tag key for each tag to remove. You do not specify
        /// the tag value. To overwrite the tag value for an existing tag, use <a>TagResource</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UntagResourceRequestMarshaller();
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates an alias to map it to a different key.
        /// 
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be mapped to and unmapped
        /// from an existing key without changing the properties of the key.
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. This value can be a globally unique identifier or the fully specified ARN of a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul> You can call <a>ListAliases</a> to verify that the alias is mapped to the correct <code>TargetKeyId</code>.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public UpdateAliasResponse UpdateAlias(string aliasName, string targetKeyId)
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAlias(request);
        }


        /// <summary>
        /// Updates an alias to map it to a different key.
        /// 
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be mapped to and unmapped
        /// from an existing key without changing the properties of the key.
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates an alias to map it to a different key.
        /// 
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be mapped to and unmapped
        /// from an existing key without changing the properties of the key.
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the key it is mapped to must be in the same AWS account and the same
        /// region.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. This value can be a globally unique identifier or the fully specified ARN of a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul> You can call <a>ListAliases</a> to verify that the alias is mapped to the correct <code>TargetKeyId</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAliasAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAliasRequestMarshaller();
            var unmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasRequest,UpdateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription


        /// <summary>
        /// Updates the description of a customer master key (CMK).
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="description">New description for the CMK.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(string keyId, string description)
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescription(request);
        }


        /// <summary>
        /// Updates the description of a customer master key (CMK).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var marshaller = new UpdateKeyDescriptionRequestMarshaller();
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the description of a customer master key (CMK).
        /// </summary>
        /// <param name="keyId">A unique identifier for the CMK. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li> Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012 </li> <li> Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012 </li> </ul></param>
        /// <param name="description">New description for the CMK.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescriptionAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateKeyDescriptionRequestMarshaller();
            var unmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyDescriptionRequest,UpdateKeyDescriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}