using Amazon.CognitoIdentity;
using Amazon.S3.Model;
using Amazon.S3;
using PasswordManagerv1.Classes.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerv1.Classes.Utils
{
    public class AWSS3Utils
    {
        private static CognitoAWSCredentials cognitoCredentials = new CognitoAWSCredentials(AWSConstants.COGNITO_POOL_ID, AWSConstants.REGION);
        private static IAmazonS3 s3Client = new AmazonS3Client(Credentials, AWSConstants.REGION);

        public static CognitoAWSCredentials Credentials
        {
            get
            {
                if (cognitoCredentials == null)
                {
                    cognitoCredentials = new CognitoAWSCredentials(AWSConstants.COGNITO_POOL_ID, AWSConstants.REGION);
                }
                return cognitoCredentials;
            }
        }

        public static IAmazonS3 S3Client
        {
            get
            {
                if (s3Client == null)
                {
                    s3Client = new AmazonS3Client(Credentials, AWSConstants.REGION);
                }
                return s3Client;
            }
        }

        public static async Task<bool> BucketExist()
        {
            try
            {
                var response = await S3Client.ListObjectsAsync(new ListObjectsRequest()
                {
                    BucketName = AWSConstants.BUCKET_NAME.ToLowerInvariant(),
                    MaxKeys = 0
                }).ConfigureAwait(false);
                return true;
            }
            catch (AmazonS3Exception e)
            {
                if ((e.StatusCode.Equals(AWSConstants.BUCKET_REDIRECT_STATUS_CODE)) || e.StatusCode.Equals(AWSConstants.BUCKET_ACCESS_FORBIDDEN_STATUS_CODE))
                {
                    //bucket exists if there is a redirect error or forbidden error
                    return true;
                }
                else if (e.StatusCode.Equals(AWSConstants.NO_SUCH_BUCKET_STATUS_CODE))
                {
                    return false;
                }
                else
                {
                    throw e;
                }
            }
        }

        public static async Task CreateBucket()
        {
            string name = AWSConstants.BUCKET_NAME.ToLowerInvariant();

            await S3Client.PutBucketAsync(new PutBucketRequest()
            {
                BucketName = name,
                BucketRegion = S3Region.USEast1
            });
        }

        public static async Task DeleteBucket()
        {
            string name = AWSConstants.BUCKET_NAME.ToLowerInvariant();
            await S3Client.DeleteBucketAsync(new DeleteBucketRequest()
            {
                BucketName = name,
                BucketRegion = S3Region.USEast1
            });
        }

        public static async Task<ListBucketsResponse> GetBuckets()
        {
            return await s3Client.ListBucketsAsync();
        }

        public static async Task<List<S3ObjectVersion>> GetObjectListWithAllVersionsAsync(string bucketName)
        {
            List<S3ObjectVersion> s3ObjectVersions = new();
            try
            {
                ListVersionsRequest request = new ListVersionsRequest()
                {
                    BucketName = bucketName,
                    // You can optionally specify key name prefix in the request
                    // if you want list of object versions of a specific object.

                    // For this example we limit response to return list of 2 versions.
                    MaxKeys = 2
                };
                do
                {
                    ListVersionsResponse response = await s3Client.ListVersionsAsync(request);
                    // Process response.
                    foreach (S3ObjectVersion entry in response.Versions)
                    {
                        s3ObjectVersions.Add(entry);
                    }

                    // If response is truncated, set the marker to get the next 
                    // set of keys.
                    if (response.IsTruncated)
                    {
                        request.KeyMarker = response.NextKeyMarker;
                        request.VersionIdMarker = response.NextVersionIdMarker;
                    }
                    else
                    {
                        request = null;
                    }
                } while (request != null);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }

            return s3ObjectVersions;
        }
    }
}
