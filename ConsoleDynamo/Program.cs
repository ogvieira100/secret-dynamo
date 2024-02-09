// See https://aka.ms/new-console-template for more information
using Amazon.DynamoDBv2.DocumentModel;
using ConsoleDynamo;
using Newtonsoft.Json;


var dynamoBaseRepository = new DynamoBaseRepository<ConfiguracaoSistema>();

Console.WriteLine("Hello, World!");
string[] processo_executar = { "L" , "WORKER-GERACAO-REMESSA-DESCONTOEMFOLHA" , "WORKER-SERPRO-ENVIO-DESCONTO" };


Console.WriteLine("Informe o processo");
var processo = Console.ReadLine();
while (!processo_executar.Contains(processo))
{
    Console.WriteLine("Informe o processo");
    processo = Console.ReadLine();
}
if (processo == "L")
{
    var repo = new DynamoBaseRepository<Amazon.DynamoDBv2.DocumentModel.Document>();
    var table = repo.ObterTabela("Master-Configuracoes-Sistema");
    // Consulta na tabela
    ScanFilter scanFilter = new ScanFilter();
    Search search = table.Scan(scanFilter);
    List<Document> documentList = await search.GetRemainingAsync();

    // Serializa os objetos para uma representação de string (JSON)
    string jsonString = JsonConvert.SerializeObject(documentList);

    Console.WriteLine(jsonString);
    Console.ReadLine();

}
else if (processo == "WORKER-GERACAO-REMESSA-DESCONTOEMFOLHA")
{

    var configWorkerSerpro = await dynamoBaseRepository.BuscarAsync("WORKER-GERACAO-REMESSA-DESCONTOEMFOLHA"); ;
    string jsonStrings = JsonConvert.SerializeObject(configWorkerSerpro);

}
else if (processo == "WORKER-SERPRO-ENVIO-DESCONTO")
{

    var configWorkerSerproEnvioDesconto = await dynamoBaseRepository.BuscarAsync("WORKER-SERPRO-ENVIO-DESCONTO");
    string jsonStringss = JsonConvert.SerializeObject(configWorkerSerproEnvioDesconto);
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.QuantidadeRequestsParalelos = 1;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.StatusProcessar = 1;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.QuantidadeRegistrosRequest = 1;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.CodigoConvenioSerpro = new CodigoConvenioSerpro();
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.CodigoConvenioSerpro.CodMfacil = 24342;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.CodigoConvenioSerpro.CodCredcesta = 24342;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.RubricaAverbacaoSiape = new CodigoConvenioSerpro();
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.RubricaAverbacaoSiape.CodCredcesta = 35014;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.RubricaAverbacaoSiape.CodMfacil = 34921;
    //configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.FuncionarioNaoTemMargemParaEssaSolicitacao = 8058;

    configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.QuantidadeRegistrosCarregadosRetornoRemessaMargemBD = 0;
    configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.QuantidadeRegistrosRequestRetornoRemessa = 10;
    configWorkerSerproEnvioDesconto.ConfiguracaoNegocio.QuantidadeRequestsParalelosRetornoRemessa = 1;


    await dynamoBaseRepository.SalvarAsync(configWorkerSerproEnvioDesconto);
}


Console.ReadLine(); 