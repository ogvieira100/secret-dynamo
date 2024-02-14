using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamo
{
    public class ConfiguracaoTI
    {
        [DynamoDBProperty("ClienteId")]
        public string ClienteId { get; set; }

        [DynamoDBProperty("UrlSQSPreviaDesconto")]
        public string UrlSQSPreviaDesconto { get; set; }

        [DynamoDBProperty("UrlSQSAgregacaoMargem")]
        public string UrlSQSAgregacaoMargem { get; set; }

        [DynamoDBProperty("BucketS3Monetario")]
        public string BucketS3Monetario { get; set; }

        [DynamoDBProperty("BaseUrlApiTesouraria")]
        public string BaseUrlApiTesouraria { get; set; }

        [DynamoDBProperty("UrlS3Ressarcimento")]
        public string UrlS3Ressarcimento { get; set; }

        [DynamoDBProperty("BucketS3DescontoFolha")]
        public string BucketS3DescontoFolha { get; set; }
    }
}
