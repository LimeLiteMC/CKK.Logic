using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using Dapper;
using static Dapper.SqlMapper;

namespace CKK.DB.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public ShoppingCartRepository(IConnectionFactory Conn)
        {
            _connectionFactory = Conn;
        }
        public ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity)
        {
            var sqlCheckQuantity = "SELECT Quantity FROM Products WHERE Id = @productId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var test = connection.Query<int>(sqlCheckQuantity, new {productId = ProductId});
                foreach (var item in test)
                {
                    if (item+1 == quantity)
                    {
                        return null;
                    }
                }
            }

            var sqlCheckPresence = "SELECT * FROM ShoppingCartItems WHERE ProductId = @productId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var test = connection.Query<ShoppingCartItem>(sqlCheckPresence, new {productId = ProductId});
                foreach (var item in test)
                {
                    if (item == null)
                    {
                        continue;
                    }
                    else if (item != null)
                    {
                        var sqlUpdateQuantity = "UPDATE ShoppingCartItems SET Quantity = @Quantity WHERE ProductId = @Id";
                        using (var connection1 = _connectionFactory.GetConnection)
                        {
                            connection1.Open();
                            var result = connection1.QuerySingleOrDefault(sqlUpdateQuantity, new { Quantity = quantity, Id = ProductId });
                            return result;
                        }
                    }
                }
            }

            var sql = "Insert into ShoppingCartItems (ShoppingCartId, ProductId, Quantity) VALUES(@ShoppingCartId, @ProductId, @quantity)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault(sql, new {ShoppingCartId = ShoppingCartId, ProductId = ProductId, quantity = quantity});
                return result;
            }
        }

        public int ClearCart(int shoppingCartId)
        {
            var sql = "DELETE FROM ShoppingCartItems WHERE Id = @ShoppingCartId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                connection.Execute(sql, new {ShoppingCartId = shoppingCartId});
                return 1;
            }
        }

        public List<ShoppingCartItem> GetProducts(int shoppingCartId)
        {
            var sql = "SELECT * FROM ShoppingCartItems WHERE ShoppingCartId = @shoppingCartId";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                var result = connections.QuerySingleOrDefault(sql, new {shoppingCartId = shoppingCartId});
                return result;
            }
        }

        public decimal GetTotal(int ShoppingCartId)
        {
            var sql = "SELECT SUM(s.Quantity * p.Price) FROM Products p JOIN ShoppingCartItems s ON p.Id = s.ProductId";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                var result = connections.Query<decimal>(sql, new {ShoppingCartId = ShoppingCartId});
                foreach (var item in result)
                {
                    if (item == null)
                    {
                        return 1;
                    }
                    return item;
                }
                return 1;
            }
        }

        public void Ordered(int shoppingCartId)
        {
            var sql = "DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                connections.QuerySingleOrDefault(sql, new { ShoppingCartId = shoppingCartId });
            }
        }
        public int Update(ShoppingCartItem entity)
        {
            var sql = "UPDATE ShoppingCartItems SET ShoppingCartId = @Entity.ShoppingCartId, ProductId = @Entity.ProductId, Quantity = @Entity.Quantity WHERE Id = @Entity.Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Entity = entity });
                return 1;
            }
        }

        public int Add(ShoppingCartItem entity)
        {
            var sqlCheck = "SELECT Quantity FROM Products WHERE Id = @entity.Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var test = connection.Query<int>(sqlCheck, entity);
                foreach (var item in test)
                {
                    if (item == entity.Quantity)
                    {
                        return 1;
                    }
                }
            } 
            var sql = "Insert into ShoppingCartItems Id, ShoppingCartId, ProductId, Quantity) VALUES (@entity.Id, @entity.ShoppingCartId, @entity.ProductId, @entity.Quantity)";
            var sqlDelete = "DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                connection.Execute(sqlDelete, entity);
                connection.Execute(sql, entity);
                return 1;
            }
        }
    }
}
