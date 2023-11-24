using berry.core.DataService;
using berry.core.DomainObjects.customer;
using DataAccess.Config;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly IMongoCollection<Customer> _collection;
        private readonly IConfiguration _configs;

        public CustomerRepository(IConfiguration config)
        {
            var c  = config.GetSection("ConnectionStrings")["Default"];
            var mongoClient = new MongoClient(config.GetConnectionString("Default"));
            var mongoDb = mongoClient.GetDatabase(config.GetSection("DatabaseName").Value);
            _collection = mongoDb.GetCollection<Customer>("customer");
        }
        public async Task DeleteAsync(string id)
        {
            try
            {
                var filter = Builders<Customer>.Filter.Eq(c => c.Id, id);
                var update = Builders<Customer>.Update.Set(c => c.IsDeleted, true);
                await _collection.UpdateOneAsync(filter, update);
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException($"An error occurred while deleting customer with id {id}.", ex);
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            try
            {
                var filter = Builders<Customer>.Filter.Eq(c => c.IsDeleted, false);
                var customers = await _collection.Find(filter).ToListAsync();
                return customers;
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException("An error occurred while fetching customers.", ex);
            }
        }
    

        public async Task<Customer> GetByIdAsync(string id)
        {
            try
            {
                var filter = Builders<Customer>.Filter.And(
                    Builders<Customer>.Filter.Eq(c => c.Id, id),
                    Builders<Customer>.Filter.Eq(c => c.IsDeleted, false)
                );

                return await _collection.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException($"An error occurred while fetching customer with id {id}.", ex);
            }
        }

        public async  Task InsertAsync(Customer item)
        {
            try
            {
                await _collection.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException("An error occurred while inserting a new customer.", ex);
            }
        }

        public async Task UpdateAsync(string id, Customer updatedItem)
        {
            try
            {
                var filter = Builders<Customer>.Filter.And(
                    Builders<Customer>.Filter.Eq(c => c.Id, id),
                    Builders<Customer>.Filter.Eq(c => c.IsDeleted, false)
                );

                var update = Builders<Customer>.Update
                    .Set(c => c.Name, updatedItem.Name);

                await _collection.UpdateOneAsync(filter, update);
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them as needed
                throw new ApplicationException($"An error occurred while updating customer with id {id}.", ex);
            }
        }
    }
}
