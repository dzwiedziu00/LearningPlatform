using AutoMapper;

namespace LearningServer.DAL.Dtos.Extensions
{
    public static class DtoMapperExtensions
    {
        public static NewCommentForInsertDto NewCommentToInsertDto(this INewCommentDto dto)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<INewCommentDto, NewCommentForInsertDto>());

            return Mapper.Map<INewCommentDto, NewCommentForInsertDto>(dto);
        }
    }
}
