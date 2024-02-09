using Amazon;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;
using Serilog;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSecret
{
    public static class SecretsManager
    {
        public static readonly ConcurrentDictionary<string, string> _cache = new ConcurrentDictionary<string, string>();

        public static async Task<string> GetSecretValueFromAWSAsync(string secretId)
        {
            string secret = "";
            Log.Information("Consultando Secret {SecretId}", secretId);
            try
            {
                GetSecretValueRequest request = new GetSecretValueRequest
                {
                    SecretId = secretId
                };
                using IAmazonSecretsManager client = new AmazonSecretsManagerClient(RegionEndpoint.USEast1);
                GetSecretValueResponse getSecretValueResponse = await client.GetSecretValueAsync(request);
                if (getSecretValueResponse != null)
                {
                    if (getSecretValueResponse.SecretString != null)
                    {
                        secret = getSecretValueResponse.SecretString;
                    }
                    else
                    {
                        using StreamReader streamReader = new StreamReader(getSecretValueResponse.SecretBinary);
                        secret = Encoding.UTF8.GetString(Convert.FromBase64String(streamReader.ReadToEnd()));
                    }
                }
            }
            catch (ResourceNotFoundException)
            {
                Log.Warning("Verifique a necessidade de cadastrar o secret {SecretId}", secretId);
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Erro ao obter o secret {SecretId}.", secretId);
                throw;
            }

            return secret;
        }

        public static async Task<string> GetSecretValueAsync(string secretId)
        {
            if (!_cache.TryGetValue(secretId, out var value))
            {
                value = await GetSecretValueFromAWSAsync(secretId);
                _cache.TryAdd(secretId, value);
            }

            return value;
        }

        public static async Task UpdateSecret(string SecretId, string SecretString)
        {
            using IAmazonSecretsManager client = new AmazonSecretsManagerClient(RegionEndpoint.USEast1);
            var updateResponse = await client.UpdateSecretAsync(new UpdateSecretRequest
            {
                SecretId = SecretId, 
                SecretString = SecretString
            });
        }

        public static async Task InsertSecret(string SecretId, string SecretString, string Description)
        {
            using IAmazonSecretsManager client = new AmazonSecretsManagerClient(RegionEndpoint.USEast1);
            var insertResponse = await client.CreateSecretAsync(new CreateSecretRequest
            {
                Name = SecretId,
                SecretString = SecretString,
                Description = Description
            });
        }

        public static string GetSecretValue(string secretId)
        {
            return Task.Factory.StartNew(() => GetSecretValueAsync(secretId)).Unwrap().GetAwaiter()
                .GetResult();
        }
    }
}
