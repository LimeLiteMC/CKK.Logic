using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.DB.Interfaces;
using CKK.Logic.Interfaces;
using CKK.Logic.Models;
using Dapper;

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
            var sql = "SELECT SUM(Price) FROM Products WHERE Id IN (SELECT ProductId FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId)";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                var result = connections.Query<decimal>(sql, new {ShoppingCartId = ShoppingCartId});
                foreach (var item in result)
                {
                    return item;
                }
                return 1;
            }
        }

        public void Ordered(int shoppingCartId)
        {
            var sql = "DELETE FROM ShoppingCartItems WHERE ShoppingCartId = @shoppingCartId";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                connections.QuerySingleOrDefault(sql, shoppingCartId = shoppingCartId);
            }
        }
    }
}
