﻿using Sever.Models;

namespace Sever.Repository.Movies
{
    public interface IMovieRepository
    {
        void CreateMovie(Movie movie);
        Movie GetMovieById(int id);
        void UpdateMovie(Movie movie);
        void DeleteMovie(Movie movie);
        List<Movie> GetAllMovie();
    }
}
