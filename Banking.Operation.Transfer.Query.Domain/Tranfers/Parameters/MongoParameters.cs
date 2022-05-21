namespace Banking.Operation.Transfer.Query.Domain.Tranfers.Parameters
{
    public class MongoParameters
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}