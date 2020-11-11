using System;
using System.Collections.Generic;
using System.Data;
using Stack.Models;

namespace Stack.Repositories
{
    public class QuestionsRepository
    {
      private readonly IDbConnection _db;

    public QuestionsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Question> GetAll()
    {
      throw new NotImplementedException();
    }

    internal Question GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal int Create(Question newQuestion)
    {
      throw new NotImplementedException();
    }

    internal Question Edit(Question editQuestion)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}