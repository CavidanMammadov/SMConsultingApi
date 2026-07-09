using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SMConsulting.BL.DTOs.Blog;
using SMConsulting.BL.Exceptions;
using SMConsulting.BL.ExternalServices.Abstracts;
using SMConsulting.BL.Services.Abstracts;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.BL.Services.Implements
{
    public class BlogService(IBlogRepository _repo, IFileService _file, IMapper _mapper) : IBlogService
    {
        public async Task<Blog> CreateAsync(BlogCreateDto dto)
        {
            string mainImage = null;
            string secondImage = null;

            try
            {
                if (dto.BlogMainImage != null)
                {
                    mainImage = await _file.SaveImageAsync(dto.BlogMainImage, "Blogs");
                }

                if (dto.BlogSecondaryImage != null)
                {
                    secondImage = await _file.SaveImageAsync(dto.BlogSecondaryImage, "Blogs");
                }

                var data = _mapper.Map<Blog>(dto);

                data.BlogMainImage = mainImage;
                data.BlogSecondaryImage = secondImage;

                await _repo.AddAsync(data);
                await _repo.SaveAsync();

                return data;
            }
            catch
            {
                if (mainImage != null)
                    await _file.DeleteImageAsync(mainImage);

                if (secondImage != null)
                    await _file.DeleteImageAsync(secondImage);

                throw;
            }
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Blog>();
            await _repo.RemoveAsync(id);
            await _file.DeleteImageAsync(data.BlogMainImage);
            await _file.DeleteImageAsync(data.BlogSecondaryImage);
            await _repo.SaveAsync();
        }


        public async Task<IEnumerable<BlogGetAllDto>> GetAllAsync()
        {
            var datas = await _repo.GetAll().ToListAsync();
            return _mapper.Map<IEnumerable<BlogGetAllDto>>(datas);
        }

        public async Task<BlogGetAllDto> GetByIdAsync(int id)
        {
            var data = await _repo.GetByIdAsync(id);
            if (data is null)
                throw new NotFoundException<Blog>();
            return _mapper.Map<BlogGetAllDto>(data);

        }

        public async Task<IEnumerable<BlogGetAllDto>> GetWithPagination(int page, int take)
        {
            var datas = await _repo
                     .GetWithPagination(page, take)
                        .ToListAsync();
            return _mapper.Map<IEnumerable<BlogGetAllDto>>(datas);
        }

        public async Task<Blog> UpdateAsync(int id, BlogUpdateDto dto)
        {
            var data = await _repo.GetByIdAsync(id);

            if (data is null)
                throw new NotFoundException<Blog>();

            if (dto.BlogMainImage != null)
            {
                string newMainImage = await _file.SaveImageAsync(dto.BlogMainImage, "Blogs");

                if (!string.IsNullOrEmpty(data.BlogMainImage))
                    await _file.DeleteImageAsync(data.BlogMainImage);

                data.BlogMainImage = newMainImage;
            }
            else
            {
                await _file.DeleteImageAsync(data.BlogMainImage);
                data.BlogMainImage = null;
            }

            if (dto.BlogSecondaryImage != null)
            {
                string newSecondaryImage = await _file.SaveImageAsync(dto.BlogSecondaryImage, "Blogs");

                if (!string.IsNullOrEmpty(data.BlogSecondaryImage))
                    await _file.DeleteImageAsync(data.BlogSecondaryImage);

                data.BlogSecondaryImage = newSecondaryImage;
            }
            else
            {
                await _file.DeleteImageAsync(data.BlogSecondaryImage);
                data.BlogSecondaryImage = null;
            }

            _mapper.Map(dto, data);

            await _repo.SaveAsync();

            return data;
        }
    }
}

