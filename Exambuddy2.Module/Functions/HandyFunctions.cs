using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Exambuddy2.Module.BusinessObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace Exambuddy2.Module.Functions
{
    public static class HandyFunctions
    {
        public static Exambuddy2EFCoreDbContext MakeContext()
        {
            var builder = new DbContextOptionsBuilder<Exambuddy2EFCoreDbContext>()
                .UseSqlServer(@";");
            
            return new Exambuddy2EFCoreDbContext(builder.Options);
        }

        public static List<T> RunQuery<T>(Exambuddy2EFCoreDbContext context, string query, Func<DbDataReader, T> map,
            params SqlParameter[] parameters)
        {
            var cn = context.Database.GetDbConnection();
            var oldState = cn.State;
            if (cn.State.Equals(ConnectionState.Closed)) cn.Open();
            using var command = cn.CreateCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            foreach (var param in parameters) command.Parameters.Add(param);
            if (cn.State.Equals(ConnectionState.Closed)) cn.Open();
            var entities = new List<T>();
            using (var result = command.ExecuteReader())
            {
                while (result.Read()) entities.Add(map(result));
            }

            if (oldState.Equals(ConnectionState.Closed) && cn.State == ConnectionState.Open) cn.Close();
            return entities;
        }

        public static int? RunNumQuery(string sql)
        {
            var connect = MakeContext();
            var results = RunQuery(connect, sql, x => new DtoInt { Num = (int)x[0] } );
            return results.Count == 0 ? null : results.FirstOrDefault()?.Num;
        }
    }
    public class DtoInt
    {
        public int Num { get; set; }
    }
}