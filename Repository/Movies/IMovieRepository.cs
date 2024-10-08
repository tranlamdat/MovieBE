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
        List<Movie> GetMoviesByWeek();
        List<Movie> GetMoviesComingSoon();
        List<Movie> GetMoviesRelatedByGenre(int genreId);
        List<Movie> SearchMovie(string name, string type);
        List<Movie> TopMostView(int top);
        List<Movie> TopMovieLike(int top);

    }
}
