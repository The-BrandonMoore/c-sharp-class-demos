﻿using CH20EFBmdbConsole.Models;

namespace CH20EFBmdbConsole.Db
{
    internal class MovieDb
    {
        private BmdbContext dbContext = new();


        //CRUD methods
        public List<Movie> GetMovies()
        {
            return dbContext.Movies.ToList();
        }
        public Movie FindMovie(int id)
        {
            return dbContext.Movies.Where(m => m.Id == id).FirstOrDefault();
        }
        public void AddMovie(Movie movie)
        {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }
        public void UpdateMovie(Movie movie)
        {
            dbContext.SaveChanges();
        }
        public void RemoveMovie(Movie movie) { 
            dbContext.Movies.Remove(movie); 
            dbContext.SaveChanges();
        }



    }






}
