﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public int Add(Product entity)
        {
            var sql = "Insert into Products (Price, Quantity, Name) VALUES (@Price, @Quantity, @Name)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Entity = entity });
                return result;
            }
        }

        public int Delete(int id)
        {
            var sql = "DELETE * FROM Products WHERE id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new {Id = id});
                return result;
            }
        }

        public List<Product> GetAll()
        {
            var sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Query<Product>(sql);
                return result.ToList();
            }
        }

        public Product GetById(int id)
        {
            var sql = "SELECT * FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.QuerySingleOrDefault(sql, new {Id = id});
                Product Result = result.FirstOrDefault();
                return Result;
            }
        }

        public List<Product> GetByName(string name)
        {
            var sql = "SELECT * FROM Products WHERE Name = @Name";
            using (var connections = _connectionFactory.GetConnection)
            {
                connections.Open();
                var result = connections.QuerySingleOrDefault(sql, new {Name = name});
                return result;
            }

        }
        //May need to update Update Later
        public int Update(Product entity)
        {
            var sql = "UPDATE Products SET Name = @Entity.Name, Price = @Entity.Price, Quantity = @Entity.Quantity WHERE Id = @Entity.Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { Entity = entity });
                return result;
            }
        }
    }
}