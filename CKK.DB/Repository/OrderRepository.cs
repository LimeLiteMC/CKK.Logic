using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic;
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
        public int Add(Order entity)
        {
            var sql = "Insert into Orders (OrderNumber, CustomerId, ShoppingCartId, OrderId) VALUES (@OrderNumber, @CustomerId, @ShoppingCartId, @OrderId)";
            var sqlDelete = "DELETE FROM Orders WHERE OrderId = @OrderId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                connection.Execute(sqlDelete, entity);
                connection.Execute(sql, entity);
                return 1;
            }
        }

        public int Delete(int id)
        {
            var sql = "DELETE FROM Orders WHERE OrderId = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                connection.Execute(sql, new {Id = id});
                return 1;
            }
        }

        public List<Order> GetAll()
        {
            var sql = "SELECT * FROM Orders";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                List<Order> result = new List<Order>();
                foreach (var i in connection.Query(sql))
                {
                    result.Add(i);
                }
                return result;
            }
        }

        public Order GetById(int id)
        {
            var sql = "SELECT * FROM Orders WHERE OrderId = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Query<Order>(sql, new {Id = id});
                foreach (var row in result)
                {
                    return row;
                }
                return null;
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

        public int Update(Order entity)
        {
            var sql = "UPDATE Orders SET OrderNumber = @Entity.OrderNumber, CustomerId = @Entity.CustomerId, ShoppingCartId = @Entity.ShoppingCartId WHERE Id = @Entity.OrderId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = (int)connection.Execute(sql, new { Entity = entity });
                return result;
            }
        }
    }
}
