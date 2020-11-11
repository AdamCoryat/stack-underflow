using System;
using System.Collections.Generic;
using System.Data;
using Stack.Models;

namespace Stack.Repositories
{
    public class CatagoriesRepository
    {
      private readonly IDbConnection _db;

    public CatagoriesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Catagory> GetAll()
    {
      throw new NotImplementedException();
    }

    internal Catagory GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal int Create(Catagory newCatagory)
    {
      throw new NotImplementedException();
    }

    internal Catagory Edit(Catagory editCatagory)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}