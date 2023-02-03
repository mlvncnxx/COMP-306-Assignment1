using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectLevelOps
{
    public class ObjectLevelOpsHelper
    {
        public readonly static IAmazonS3 s3Client;
        static ObjectLevelOpsHelper()
        {
            s3Client = GetS3Client();
        }

        private static IAmazonS3 GetS3Client()
        {
            string awsAccessKey = "AKIAZCMIMLOVJNW2AAML";
            string awsSecretKey = "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";
            return new AmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);
        }

        public static async Task<ObservableCollection<BucketObject>> GetObjectsFromBucket(string bucketName)
        {
            ObservableCollection<BucketObject> bucketObjects = new ObservableCollection<BucketObject>();

            try
            {
                var request = new ListObjectsV2Request
                {
                    BucketName = bucketName,
                    MaxKeys = 5,
                };

                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Listing the contents of {bucketName}:");
                Console.WriteLine("--------------------------------------");

                var response = new ListObjectsV2Response();
                response = await s3Client.ListObjectsV2Async(request);

                foreach (S3Object file in response.S3Objects)
                {
                    bucketObjects.Add(new BucketObject(file.Key, file.Size));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered on server. Message:'{ex.Message}' getting list of objects.");

            }

            return bucketObjects;
        }

        public static async Task<string> UploadObject(string filePath, string bucketName)
        {
            try
            {
                var fileTransferUtility = new TransferUtility(s3Client);
                await fileTransferUtility.UploadAsync(filePath, bucketName);
                return "success";
            }
            catch (AmazonS3Exception e)
            {
                return e.Message;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
