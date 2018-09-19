using Dapper;
using DNT.NorthWind.DataAccess.Interface;
using DNT.NorthWind.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DNT.NorthWind.DataAccess.Implementation
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly IDNTConnectionFactory _connectionFactory;

        public EmployeesRepository(IDNTConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        
        public IList<Employees> GetEmployeesByQuery()
        {
            var EmpList = new List<Employees>();
            var SqlQuery = @"SELECT [EmployeeID],[LastName],[FirstName],[Title],[TitleOfCourtesy],[City],[Country] FROM [Northwind].[dbo].[Employees]";

            using (IDbConnection conn = _connectionFactory.GetConnection)
            {   
                var result =  conn.Query<Employees>(SqlQuery);
                return result.ToList();
            }
        }
    }
}
