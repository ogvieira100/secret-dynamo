// See https://aka.ms/new-console-template for more information
using ConsoleSecret;

Console.WriteLine("Hello, World!");

string[] processo_executar = { "SECRETS-WORKER-PREVIA" };


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
else if (processo == "CONNSTR-WISECONS-CREDCESTA")
{

    //

    //
    var secretWISECONS = await SecretsManager.GetSecretValueAsync("CONNSTR-WISECONS-CREDCESTA");
    //CONNSTR-WISECONS-CREDCESTA
    var secretPlataformaConsignadoBackofficeDescontoFolha = await SecretsManager.GetSecretValueAsync("PLATAFORMA-CONSIGNADO-BACKOFFICE-DESCONTO-FOLHA");

    //



}



Console.ReadLine(); 