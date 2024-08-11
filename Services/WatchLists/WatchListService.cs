using AutoMapper;
using Sever.Dto.Movie;
using Sever.Dto.MovieActor;
using Sever.Dto.WatchList;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Movies;
using Sever.Repository.Users;
using Sever.Repository.WatchLists;

namespace Sever.Services.WatchLists
{
    public class WatchListService : IWatchListService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly IWatchListRepository _watchListRepository;

        public WatchListService(IMapper mapper, IUserRepository userRepository, IMovieRepository movieRepository, IWatchListRepository watchListRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _movieRepository = movieRepository;
            _watchListRepository = watchListRepository;
        }

        public WatchListDto AddWatchList(CreateWatchListDto createWatchListDto)
        {
            WatchList watchList = _watchListRepository.GetWatchListByUserIdAndMovieId(createWatchListDto.UserId, createWatchListDto.MovieId);
            if (watchList != null)
            {
                throw new ConflictException("User added movie to watch list");
            }

            User user = _userRepository.GetUserById(createWatchListDto.UserId) ?? throw new NotFoundException("User does not exists");
            Movie movie = _movieRepository.GetMovieById(createWatchListDto.MovieId) ?? throw new NotFoundException("Movie does not exists");

            watchList = _mapper.Map<WatchList>(createWatchListDto);
            _watchListRepository.CreateWatchList(watchList);

            watchList.User = user;
            watchList.Movie = movie;

            return _mapper.Map<WatchListDto>(watchList);
        }

        public string DeleteWatchList(int id)
        {
            WatchList watchList = _watchListRepository.GetWatchListById(id) ?? throw new NotFoundException("Watch list does not exists");
            _watchListRepository.DeleteWatchList(watchList);

            return "Delete successfully";
        }

        public List<WatchListDto> GetAllWatchListByUserId(int userId)
        {
            _ = _userRepository.GetUserById(userId) ?? throw new NotFoundException("User does not exists");
            List<WatchList> watchList = _watchListRepository.GetWatchListByUserId(userId);
            return _mapper.Map<List<WatchListDto>>(watchList);
        }
    }
}
