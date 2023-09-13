using System.Collections.Generic;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;

namespace CKK.DB.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public OrderRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }
        public async Task Add(Order entity)
        {
            var sql = "Insert into Orders (OrderNumber, CustomerId, ShoppingCartId, OrderId) VALUES (@OrderNumber, @CustomerId, @ShoppingCartId, @OrderId)";
            var sqlDelete = "DELETE FROM Orders WHERE OrderId = @OrderId";
            using ( var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sqlDelete, entity);
                await connection.ExecuteAsync(sql, entity);
            }
        }

        public async Task Delete(int id)
        {
            var sql = "DELETE FROM Orders WHERE OrderId = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new {Id = id});
            }
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            var sql = "SELECT * FROM Orders";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QueryAsync<Order>(sql);
                return result;
            }
        }

        public async Task<Order> GetById(int id)
        {
            var sql = "SELECT * FROM Orders WHERE OrderId = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Order>(sql, new {Id = id});
                return result; 
            }
        }

        public Order GetOrderByCustomerID(int id)
        {
            var sql = "SELECT * FROM Orders WHERE CustomerId = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = (Order)connection.QuerySingleOrDefault(sql, new {Id = id});
                return result;
            }
        }

        public async Task Update(Order entity)
        {
            var sql = "UPDATE Orders SET OrderNumber = @Entity.OrderNumber, CustomerId = @Entity.CustomerId, ShoppingCartId = @Entity.ShoppingCartId WHERE Id = @Entity.OrderId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new { Entity = entity });
            }
        }
    }
}
