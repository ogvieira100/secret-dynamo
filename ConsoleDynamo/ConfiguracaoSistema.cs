using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamo
{
    [DynamoDBTable("Master-Configuracoes-Sistema")]
    public class ConfiguracaoSistema
    {
        [DynamoDBProperty("sistema")]
        public string Sistema { get; set; }
        [DynamoDBProperty("ConfigNegocio")]
        public ConfiguracaoNegocio ConfiguracaoNegocio { get; set; }
        [DynamoDBProperty("ConfigTI")]
        public ConfiguracaoTI ConfiguracaoTI { get; set; }
    }
}
