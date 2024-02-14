using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamo
{
    public class ConfiguracaoNegocio
    {
        [DynamoDBProperty("QuantidadeRegistrosCarregadosBD")]
        public int QuantidadeRegistrosCarregadosBD { get; set; }

        [DynamoDBProperty("QuantidadeRegistrosCarregadosRetornoRemessaMargemBD")]
        public int QuantidadeRegistrosCarregadosRetornoRemessaMargemBD { get; set; }

       
        [DynamoDBProperty("QuantidadeRegistrosRequestRetornoRemessa")]
        public int QuantidadeRegistrosRequestRetornoRemessa { get; set; }


        [DynamoDBProperty("QuantidadeRequestsParalelosRetornoRemessa")]
        public int QuantidadeRequestsParalelosRetornoRemessa { get; set; }

        [DynamoDBProperty("StatusProcessar")]
        public int StatusProcessar { get; set; }

        [DynamoDBProperty("FuncionarioNaoTemMargemParaEssaSolicitacao")]
        public int FuncionarioNaoTemMargemParaEssaSolicitacao { get; set; }

        [DynamoDBProperty("IdConvenioProcessar")]
        public int IdConvenioProcessar { get; set; }

        [DynamoDBProperty("ConveniosProcessar")]
        public ConveniosProcessar ConveniosProcessar { get; set; }

        [DynamoDBProperty("QuantidadeRequestsParalelos")]
        public int QuantidadeRequestsParalelos { get; set; }

        [DynamoDBProperty("QuantidadeRegistrosRequest")]
        public int QuantidadeRegistrosRequest { get; set; }

        [DynamoDBProperty("ConvenioClassificacao77")]
        public string ConvenioClassificacao77 { get; set; }

        [DynamoDBProperty("ConvenioClassificacao99")]
        public string ConvenioClassificacao99 { get; set; }

        [DynamoDBProperty("CodigoConvenioSerpro")]
        public CodigoConvenioSerpro CodigoConvenioSerpro { get; set; }

        [DynamoDBProperty("RubricaAverbacaoSiape")]
        public CodigoConvenioSerpro RubricaAverbacaoSiape { get; set; }

        //
        [DynamoDBProperty("QuantidadeRegistrosCarregadosRessarcimentoBD")]
        public int QuantidadeRegistrosCarregadosRessarcimentoBD { get; set; }

        [DynamoDBProperty("QuantidadeRegistrosRessarcimentoRequest")]
        public int QuantidadeRegistrosRessarcimentoRequest { get; set; }

        [DynamoDBProperty("QuantidadeRequestsRessarcimentoParalelos")]
        public int QuantidadeRequestsRessarcimentoParalelos { get; set; }
    }
}
