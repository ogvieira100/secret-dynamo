using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamo
{
    public class CodigoConvenioSerpro
    {
        [DynamoDBProperty("CodMfacil")]
        public int CodMfacil { get; set; }

        [DynamoDBProperty("CodCredcesta")]
        public int CodCredcesta { get; set; }
    }
}
