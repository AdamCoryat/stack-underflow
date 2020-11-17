using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Stack.Models;

namespace Stack.Repositories
{
    public class ResponsesRepository
    {
      private readonly IDbConnection _db;

    public ResponsesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Response> GetAll()
    {
      string sql = @"
      SELECT
      r.*,
      p.*
      FROM responses r
      JOIN profiles p on r.creatorId = p.id";
      return _db.Query<Response, Profile, Response>(sql, (response, profile) => {response.Creator = profile; return response;}, splitOn: "id");
    }

    internal Response GetById(int id)
    {
      string sql = @"
      SELECT
      r.*,
      p.*
      FROM responses r
      JOIN profiles p on r.creatorId = p.id
      WHERE q.id = @id LIMIT 1";
      return _db.Query<Response, Profile, Response>(sql, (response, profile) => {response.Creator = profile; return response;}, new {id}, splitOn: "id").FirstOrDefault();
    }

    internal int Create(Response newResponse)
    {
      string sql = @"
      INSERT INTO Responses
      (creatorId, title, description, votes, questionId, isAnswer)
      VALUES
      (@CreatorId, @Title, @Description, @Votes, @QuestionId, @IsAnswer)
      SELECT LAST_INSERT_ID();";
      return _db.ExecuteScalar<int>(sql, newResponse);
    }

    internal Response Edit(Response editResponse)
    {
      string sql = @"
      UPDATE responses
      SET
      title = @Title,
      description = @Description,
      votes = @Votes,
      isAnswer = @IsAnswer
      WHERE id = @Id;";
      _db.Execute(sql, editResponse);
      return editResponse;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM responses WHERE id = @Id LIMIT 1";
      _db.Execute(sql, new {id});
    }

    
  }
}