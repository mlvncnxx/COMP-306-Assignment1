using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketOps
{
    public static class Helper
    {
        public readonly static IAmazonS3 s3Client;

        static Helper()
        {
            s3Client = GetS3Client();
        }

        private static IAmazonS3? GetS3Client()
        {
            string awsAccessKey = "AKIAZCMIMLOVJNW2AAML";
            string awsSecretKey = "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";
            return new AmazonS3Client(awsAccessKey, awsSecretKey, RegionEndpoint.USEast1);
        }

        private static BasicAWSCredentials GetBasicCredentials()
        {


            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSettings.json");

            var accessKeyID = builder.Build().GetSection("AWSCredentials").GetSection("AccesskeyID").Value;
            var secretKey = builder.Build().GetSection("AWSCredentials").GetSection("Secretaccesskey").Value;

            return new BasicAWSCredentials(accessKeyID, secretKey);
        }
        
        public static async Task<ObservableCollection<Bucket>> GetBucketList()
        {
            ObservableCollection<Bucket> buckets = new ObservableCollection<Bucket>();

            ListBucketsResponse response = await s3Client.ListBucketsAsync();
            foreach (S3Bucket bucket in response.Buckets)
            {
                buckets.Add(new Bucket(bucket.BucketName, bucket.CreationDate));
            }

            return buckets;
        }

        public static async Task<string> CreateBucket(string bucketName)
        {
            if (GetBucketName(bucketName, out String newbBucketName))
            {
                // If a bucket name was supplied, create the bucket.
                // Call the API method directly
                try
                {
                    Console.WriteLine($"\nCreating bucket {bucketName}...");
                    var createResponse = await s3Client.PutBucketAsync(newbBucketName);
                    Console.WriteLine($"Result: {createResponse.HttpStatusCode.ToString()}");
                    return createResponse.HttpStatusCode.ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught exception when creating a bucket:");
                    Console.WriteLine(e.Message);
                }
            }
            return "Invalid";

        }

        // Method to parse the command line.
        private static Boolean GetBucketName(string name, out String bucketName)
        {
            Boolean retval = false;
            bucketName = String.Empty;
            if (name.Length == 0)
            {
                Console.WriteLine("\nNo arguments specified. Will simply list your Amazon S3 buckets." +
                  "\nIf you wish to create a bucket, supply a valid, globally unique bucket name.");
                bucketName = String.Empty;
                retval = false;
            }
            else if (name.Length > 1)
            {
                bucketName = name;
                retval = true;
            }
            else
            {
                Environment.Exit(1);
            }
            return retval;
        }
    }
}
