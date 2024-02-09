using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDynamo
{
    public class DynamoBaseRepository<T> 
    {
        private readonly DynamoDBContext _context;

        public DynamoBaseRepository()
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            _context = new DynamoDBContext(client);
        }


        public async Task SalvarAsync(T item)
        {
            await _context.SaveAsync(item);
        }

        public async Task<T> BuscarAsync(object id)
        {

            return await _context.LoadAsync<T>(id);
        }

        public async Task<IEnumerable<T>> BuscarPorScanAsync(List<ScanCondition> condicoes)
        {
            return await _context.ScanAsync<T>(condicoes, new DynamoDBOperationConfig
            {
                ConsistentRead = true
            }).GetRemainingAsync();
        }

        public Table ObterTabela(string tabela)
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(RegionEndpoint.USEast1);
            return Table.LoadTable(client, tabela);
        }

        public async Task<IEnumerable<T>> BuscarPorIndiceAsync(QueryOperationConfig operacao)
        {
            return await _context.FromQueryAsync<T>(operacao).GetRemainingAsync();
        }

        public async Task<IEnumerable<T>> BuscarTodosAsync()
        {
            List<ScanCondition> conditions = new List<ScanCondition>();
            return await _context.ScanAsync<T>(conditions).GetRemainingAsync();
        }

        public async Task DeletarAsync(T item)
        {
            await _context.DeleteAsync(item);
        }
    }
}
