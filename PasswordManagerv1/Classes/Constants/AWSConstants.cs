using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerv1.Classes.Constants
{
    public static class AWSConstants
    {
        // You should replace these values with your own
        public const string COGNITO_POOL_ID = "us-east-1:498cc4b0-c0ea-4a28-b31c-29b94999d5e2";

        // Note, the bucket will be created in all lower case letters
        // If you don't enter an all lower case title, any references you add
        // will need to be sanitized
        public const string BUCKET_NAME = "aws-mobile-service-app";
        public static RegionEndpoint REGION = RegionEndpoint.USEast1;

        public const HttpStatusCode NO_SUCH_BUCKET_STATUS_CODE = HttpStatusCode.NotFound;
        public const HttpStatusCode BUCKET_ACCESS_FORBIDDEN_STATUS_CODE = HttpStatusCode.Forbidden;
        public const HttpStatusCode BUCKET_REDIRECT_STATUS_CODE = HttpStatusCode.Redirect;
    }
}
