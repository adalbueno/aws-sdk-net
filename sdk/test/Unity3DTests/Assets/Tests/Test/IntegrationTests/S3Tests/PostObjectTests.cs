﻿using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using AWSSDK.Tests.Framework;
using System.IO;
using UnityEngine;

namespace AWSSDK.IntegrationTests.S3
{
    [TestFixture(TestOf = typeof(PostObjectTests))]
    [Category("Integration")]
    class PostObjectTests : TestBase<AmazonS3Client>
    {
        private static readonly string FileNamePrefix = "UnityTestFile";
        private static readonly string FileNameFormat = FileNamePrefix + "{0}.txt";
        private static string BucketName = null;

        private static readonly string AuthenticatedUsersUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string AllUsersUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";
        private static readonly string LogDeliveryUriSubstring = "acs.amazonaws.com/groups/global/AuthenticatedUsers";

        [OneTimeSetUp]
        public void SetUp()
        {
            BucketName = "unity-test-bucket" + DateTime.Now.Ticks;
            MissingAPILambdaFunctions.CreateBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            S3TestUtils.CleanBucket(Client, BucketName);
            MissingAPILambdaFunctions.DeleteBucket(BucketName, TestRunner.RegionEndpoint);
        }

        [Test]
        [Category("WWW")]
        public void SimpleTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            VersionStatus status = null;
            Client.GetBucketVersioningAsync(new GetBucketVersioningRequest()
            {
                BucketName = BucketName
            }, (response) =>
            {
                responseException = response.Exception;
                if (responseException == null)
                {
                    status = response.Response.VersioningConfig.Status;
                }
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = false });
            ars.WaitOne();
            Assert.IsNull(responseException);
            Assert.AreEqual(VersionStatus.Off, status);
            List<S3Object> s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            var count = s3Objects.Count;

            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);
            S3TestUtils.PostObjectHelper(Client, BucketName, key);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count + 1, s3Objects.Count);

            S3TestUtils.DeleteObjectHelper(Client, BucketName, key);

            s3Objects = S3TestUtils.ListObjectsHelper(Client, BucketName);
            Assert.IsNotNull(s3Objects);
            Assert.AreEqual(count, s3Objects.Count);
        }

        [Test]
        [Category("WWW")]
        public void TestHttpErrorResponseUnmarshalling()
        {
            try
            {
                S3TestUtils.PostObjectHelper(Client, "NonExistentBucket" + DateTime.Now.Ticks, "key");
            }
            catch (Amazon.Runtime.Internal.HttpErrorResponseException exception)
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, exception.Response.StatusCode);
                return;
            };
            Assert.Fail();
        }

        [Test]
        [Category("WWW")]
        public void TestCannedACL()
        {
            var key = string.Format(FileNameFormat, DateTime.Now.Ticks);

            // Authenticated Read
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate(PostObjectRequest request) { request.CannedACL = S3CannedACL.AuthenticatedRead; });
            var grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsContain(grants, AuthenticatedUsersUriSubstring, S3Permission.READ));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            // No canned ACL equivalent to Provate
            S3TestUtils.PostObjectHelper(Client, BucketName, key);
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            // Private
            S3TestUtils.PostObjectHelper(Client, BucketName, key, delegate(PostObjectRequest request) { request.CannedACL = S3CannedACL.Private; });
            grants = S3TestUtils.GetACLHelper(Client, BucketName, key).AccessControlList.Grants;
            Utils.AssertTrue(GrantsDoNotContain(grants, AuthenticatedUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, AllUsersUriSubstring));
            Utils.AssertTrue(GrantsDoNotContain(grants, LogDeliveryUriSubstring));

            S3TestUtils.DeleteObjectHelper(Client, BucketName, key);
        }

        private bool GrantsContain(List<S3Grant> grants, string uriSubstring, S3Permission s3Permission)
        {
            foreach (var grant in grants)
            {
                if (grant.Permission == s3Permission && grant.Grantee.URI != null && grant.Grantee.URI.Contains(uriSubstring))
                {
                    return true;
                }
            }
            return false;
        }

        private bool GrantsDoNotContain(List<S3Grant> grants, string uri)
        {
            foreach (var grant in grants)
            {
                if (grant.Grantee.URI == uri && grant.Grantee.URI != null && grant.Grantee.URI.Contains(uri))
                {
                    return false;
                }
            }
            return true;
        }

        [Test]
        [Category("WWW")]
        // TODO: Get Post object with path working
        public void SimplePathPostObjectTest()
        {
            AutoResetEvent ars = new AutoResetEvent(false);
            Exception responseException = new Exception();
            string fileName = string.Format(FileNameFormat, DateTime.Now.Ticks);
            string filePath = S3TestUtils.GetFileHelper(fileName);
            Client.PostObjectAsync(new PostObjectRequest()
            {
                Key = fileName,
                Bucket = BucketName,
                Path = filePath,
                CannedACL = S3CannedACL.Private
            }, (response) =>
            {
                responseException = response.Exception;
                ars.Set();
            }, new AsyncOptions { ExecuteCallbackOnMainThread = true });

            ars.WaitOne();
            Assert.IsNull(responseException);
        }

    }
}