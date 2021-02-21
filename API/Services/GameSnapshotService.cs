    using API.IService;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia_App.Data;

namespace API.Services
{
    public class GameSnapshotService : IGenericService<GameSnapshot>
    {


        //Injecting Database
        [Inject]
        public AppDbContext db { get; set; }

        //CONSTRUCTOR
        public GameSnapshotService(AppDbContext _db)
        {
            db = _db;
            


        }
        
        //GET All
        public List<GameSnapshot> GetAll()
        {
            return db.gameSnapshots.ToList();
        }

        public List<GameSnapshot> Delete(string UserID)
        {


            var result = db.gameSnapshots.Where(p => p.UserID == UserID).FirstOrDefault();
            db.gameSnapshots.Remove(result);
            db.SaveChanges();
            return db.gameSnapshots.ToList();



        }


        public GameSnapshot GetById(string UserID)
        {

           
         var result = db.gameSnapshots.Where(p => p.UserID == UserID).FirstOrDefault();
            
         return result;



        }



        public List <GameSnapshot>Insert(GameSnapshot gameSnapshot)
        {
            var result = db.gameSnapshots.Where(p => p.UserID == gameSnapshot.UserID).FirstOrDefault();
            db.gameSnapshots.Update(gameSnapshot);
            //if (result != null)
            //{
            //    result.CorrectAnswers = gameSnapshot.CorrectAnswers;
            //    result.IncorrectAnswers = gameSnapshot.IncorrectAnswers;
            //    result.GameCategory = gameSnapshot.GameCategory;
            //    result.GameDifficulty = gameSnapshot.GameDifficulty;
            //    result.GameLength = gameSnapshot.GameLength;
            //    result.GameScorePercentage = gameSnapshot.GameScorePercentage;
            //    result.TimePlayed = gameSnapshot.TimePlayed;
            //    result.DatePlayed = gameSnapshot.DatePlayed;
            //    result.UserID = gameSnapshot.UserID;
            //    result.GameID = gameSnapshot.GameID;


            //}


            db.SaveChanges();
            return db.gameSnapshots.ToList();

        }
    }
}
