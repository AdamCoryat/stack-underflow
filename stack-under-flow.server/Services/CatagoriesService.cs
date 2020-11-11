using System;
using Stack.Models;
using Stack.Repositories;

namespace Stack.Services
{
    public class CatagoriesService
    {
      private readonly CatagoriesRepository _repo;

    public CatagoriesService(CatagoriesRepository repo)
    {
      _repo = repo;
    }

    internal object GetAll()
    {
      throw new NotImplementedException();
    }

    internal object GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal Catagory Create(Catagory newCatagory)
    {
      throw new NotImplementedException();
    }

    internal object Edit(Catagory editCatagory, string id)
    {
      throw new NotImplementedException();
    }

    internal object Delete(int id1, string id2)
    {
      throw new NotImplementedException();
    }
  }
}