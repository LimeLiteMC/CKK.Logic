using System.Collections.Generic;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;

namespace CKK.DB.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public ProductRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }
        public async Task Add(Product entity)
        {
            var sql = "Insert into Products (Price, Quantity, Name) VALUES (@Price, @Quantity, @Name)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new { Entity = entity });

            }
        }

        public async Task Delete(int id)
        {
            var sql = "DELETE * FROM Products WHERE id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new {Id = id});
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QueryAsync<Product>(sql);
                return result;
            }
        }

        public async Task<Product> GetById(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync(sql, new {Id = id});
                return result;
            }
        }

        public async Task GetByName(string name)
        {
            var sql = "SELECT * FROM Products WHERE Name = @Name";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                await connections.QuerySingleOrDefaultAsync(sql, new {Name = name});
            }

        }
        public async Task Update(Product entity)
        {
            var sql = "UPDATE Products SET Name = @Entity.Name, Price = @Entity.Price, Quantity = @Entity.Quantity WHERE Id = @Entity.Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new { Entity = entity });
            }
        }
    }
}
