// See https://aka.ms/new-console-template for more information
using ConsoleSecret;

Console.WriteLine("Hello, World!");

string[] processo_executar = { "SECRETS-WORKER-RESSARCIMENTO", "SECRETS-WORKER-PREVIA", "PLATAFORMA-CONSIGNADO-BACKOFFICE-DESCONTO-FOLHA", "PLATAFORMA-RELATORIO-API" };


Console.WriteLine("Informe o processo");
var processo = Console.ReadLine();
while (!processo_executar.Contains(processo))
{
    Console.WriteLine("Informe o processo");
    processo = Console.ReadLine();
}
if (processo == "SECRETS-WORKER-PREVIA")
{

    var secretWorkerPrevia = await SecretsManager.GetSecretValueAsync("SECRETS-WORKER-PREVIA");

}
else if (processo == "SECRETS-WORKER-RESSARCIMENTO")
{
    var secretPlataformaConsignadoBackofficeDescontoFolha = await SecretsManager.GetSecretValueAsync("SECRETS-WORKER-RESSARCIMENTO");
    //await SecretsManager.InsertSecret("SECRETS-WORKER-RESSARCIMENTO", secretPlataformaConsignadoBackofficeDescontoFolha, "Secret WorkerRessarcimento ");

}
else if (processo == "PLATAFORMA-RELATORIO-API")
{
    var secretWorkerPrevia = await SecretsManager.GetSecretValueAsync("PLATAFORMA-RELATORIO-API");
    await SecretsManager.UpdateSecret("PLATAFORMA-RELATORIO-API", @"{
  'connectionStrings': {
    'autorizador': 'Server=maws-rdb-d01.bancomaxima.com.br;Database=MAX_AUTORIZADOR_CREDCESTA;Uid=plataformacredcesta;Pwd=plat$cred2020;',
    'funcao': 'Server=MAWS-FDB-D01.bancomaxima.com.br;Database=MAXAPOIO;Uid=plataforma_credcesta;Pwd=pl4t4f0rmaCRED;MultipleActiveResultSets=True;',
    'controleAcesso': 'Server=maws-rdb-d01.bancomaxima.com.br;Database=BCO_CREDCESTA_LOGIN;Uid=plataformacredcesta;Pwd=plat$cred2020;',
    'credcestaSite': 'Server=maws-rdb-d01.bancomaxima.com.br;Database=BCO_CREDCESTA_SITE;Uid=plataformacredcesta;Pwd=plat$cred2020;',
    'operacoes': 'Server=maws-rdb-d05.bancomaxima.com.br;Database=OPERACOES;Uid=SVC-DEV-Mtoraverb;Pwd=Dc8Re3LTrMwNuWXDZkgM1;',
    'ImpostoRenda':'Server=MAWS-RDB-D05.bancomaxima.com.br;Database=IMPOSTO_RENDA;Uid=srv-dev-platrelat;Pwd=ayYc4sT@;MultipleActiveResultSets=True;'
  },
  'uris': {
    'autorizadorPlataforma': 'https://hml-api-autorizador-plataforma.credcesta.com.br',
    'elasticSearch': 'https://vpc-dev-logs-open-unificado-tkrvwmvonkhvvkwa7j7xzple2y.us-east-1.es.amazonaws.com',
    'urlApiRendimentos': 'https://dev-api-rendimento.bancomaxima.com.br',
    'urlApiCreditoPessoal': 'https://dev-api-credito-pessoal.bancomaxima.com.br'
  },
  'mongoDb': {
    'connection': 'mongodb://devdocdb:7Av4ceNHicOl@maws-docdb-d01.cluster-c8uv6nz2pkga.us-east-1.docdb.amazonaws.com:27017/?ssl=true&ssl_ca_certs=rds-combined-ca-bundle.pem&replicaSet=rs0&readPreference=secondaryPreferred&retryWrites=false',
    'dataBase': 'plataforma_auditoria',
    'collection': 'LogAuditoria'
  },
  'NomeBucket' : 'br.com.bancomaster.relatorio-consignado.dev',
  'FilaRelatorioContratoMonitoramentoListaRestritiva': 'https://sqs.us-east-1.amazonaws.com/830010148122/relatorio-monitoramento-lista-restritiva',
  'FilaRelatorioPreviaAnalitico': 'https://sqs.us-east-1.amazonaws.com/830010148122/relatorio-previa-analitico',
  'FilaRelatorioContrato': 'https://sqs.us-east-1.amazonaws.com/830010148122/relatorio-contratos',
  'UrlCpflCobrancaExclusao':'https://dev-api-cpfl.bancomaster.com.br/api/v1/Cpfl',
  'FilaExclusaoParcelaCPFLSqs': 'https://sqs.us-east-1.amazonaws.com/830010148122/exclusao-parcela-cpfl',
  'BucketsS3Relatorios':{
      'RelatorioEsteiraSaque':'br.com.bancomaster.relatorio-saque-esteira.dev',
      'RelatorioUsuario':'relatorio-usuarios',
      'ImpostoRenda':'dev-imposto-renda',
      'RelatorioContrato': 'br.com.bancomaster.relatorio.contratos.dev',
      'NaoPertube': 'br.com.bancomaster.naopertube'
   },
   'BatchProcessamentoAWS':{
      'JobDefinition':'dev-job-def-batch-alimentacao-irpf',
      'JobName':'dev-job-def-batch-alimentacao-irpf-',
      'JobQueue':'dev-jobqueue-batch-alimentacao-irpf',
      'BatchEnvironmentName':'CORRELATION_ID',
   }
}");

}
else if (processo == "SECRETS-WORKER-REMESSA-ORGAO")
{

    var secretWorkerRemessaOrgao = await SecretsManager.GetSecretValueAsync("SECRETS-WORKER-REMESSA-ORGAO");


}
else if (processo == "CONNSTR-AUTORIZADORSITECONTEXT-CREDCESTA")
{

    //
    //CONNSTR-AUTORIZADORSITECONTEXT-CREDCESTA
    var secretAutorizadorSiteCredCesta = await SecretsManager.GetSecretValueAsync("CONNSTR-AUTORIZADORSITECONTEXT-CREDCESTA");


}
else if (processo == "PLATAFORMA-CONSIGNADO-BACKOFFICE-DESCONTO-FOLHA")
{

    //

    //
    var secretWISECONS = await SecretsManager.GetSecretValueAsync("CONNSTR-WISECONS-CREDCESTA");
    //CONNSTR-WISECONS-CREDCESTA
    var secretPlataformaConsignadoBackofficeDescontoFolha = await SecretsManager.GetSecretValueAsync("PLATAFORMA-CONSIGNADO-BACKOFFICE-DESCONTO-FOLHA");

    //



}



Console.ReadLine(); 