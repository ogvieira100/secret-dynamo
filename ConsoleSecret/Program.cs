// See https://aka.ms/new-console-template for more information
using ConsoleSecret;

Console.WriteLine("Hello, World!");


var secretWorkerPrevia =  await SecretsManager.GetSecretValueAsync("SECRETS-WORKER-PREVIA");

var secretWorkerRemessaOrgao = await SecretsManager.GetSecretValueAsync("SECRETS-WORKER-REMESSA-ORGAO");

//
//CONNSTR-AUTORIZADORSITECONTEXT-CREDCESTA
var secretAutorizadorSiteCredCesta = await SecretsManager.GetSecretValueAsync("CONNSTR-AUTORIZADORSITECONTEXT-CREDCESTA");

//

//
var secretWISECONS = await SecretsManager.GetSecretValueAsync("CONNSTR-WISECONS-CREDCESTA");
//CONNSTR-WISECONS-CREDCESTA
var secretPlataformaConsignadoBackofficeDescontoFolha = await SecretsManager.GetSecretValueAsync("PLATAFORMA-CONSIGNADO-BACKOFFICE-DESCONTO-FOLHA");

//


//var novasecretWISECONS = "{\"conFuncao\":\"Server=MAWS-FDB-D01.bancomaxima.com.br;Database=MAXCDCEMPR;Uid=plataforma_credcesta;Pwd=pl4t4f0rmaCRED;MultiSubnetFailover=True;\",\"conOperacoes\":\"Server=maws-rdb-d05.bancomaxima.com.br;Database=operacoes;Uid=SVC-DEV-Mtoraverb;Pwd=Dc8Re3LTrMwNuWXDZkgM1;MultiSubnetFailover=True;\",\"conCredCesta\":\"Server=maws-rdb-d01.bancomaxima.com.br;Database=MAX_AUTORIZADOR_CREDCESTA;Uid=plataformacredcesta;Pwd=plat$cred2020;\"}";

//await SecretsManager.UpdateSecret("SECRETS-WORKER-PREVIA", novasecretWISECONS);

//


Console.ReadLine(); 