using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sever.Constraints;
using Sever.Dto.MovieMedia;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.MovieMedias;
using Sever.Services.Cloudinaries;

namespace Sever.Services.MovieMedias
{
    public class MovieMediaService : IMovieMediaService
    {
        private readonly IMapper _mapper;
        private readonly IClodinaryService _clodinaryService;
        private readonly IMovieMediaRepository _movieMediaRepository;

        public MovieMediaService(IMapper mapper, IClodinaryService clodinaryService, IMovieMediaRepository movieMediaRepository)
        {
            _mapper = mapper;
            _clodinaryService = clodinaryService;
            _movieMediaRepository = movieMediaRepository;
        }

        public async Task<MovieMediaDto> AddMovieMedia(CreateMovieMediaDto createMovieMediaDto)
        {
            dynamic result;
            if (createMovieMediaDto.Type == EFileType.VIDEO)
            {
                result = await _clodinaryService.UploadVideoAsync(createMovieMediaDto.FileUpload, createMovieMediaDto.Type.ToString());
            }
            else
            {
                result = await _clodinaryService.UploadImageAsync(createMovieMediaDto.FileUpload, createMovieMediaDto.Type.ToString());
            }

            if (result.Error != null) throw new InvalidException(result.Error.Message);

            MovieMedia movieMedia = new()
            {
                Name = result.OriginalFilename ?? result.DisplayName,
                Url = result.SecureUri.AbsoluteUri,
                PublicId = result.PublicId,
                Type = createMovieMediaDto.Type,
                MovieId = createMovieMediaDto.MovieId,
            };

            _movieMediaRepository.CreateMovieMedia(movieMedia);

            return _mapper.Map<MovieMediaDto>(movieMedia);
        }

        public async Task<string> DeleteMovieMedia(int id)
        {
            MovieMedia movieMedia = _movieMediaRepository.GetMovieMediaById(id) ?? throw new NotFoundException("Movie media does not exists");

            var result = await _clodinaryService.DeleteMediaAsync(movieMedia.PublicId);
            if (result.Error != null) throw new InvalidException(result.Error.Message);

            _movieMediaRepository.DeleteMovieMedia(movieMedia);

            return "Delete successfully";
        }
    }
}
