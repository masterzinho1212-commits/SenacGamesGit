using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


///<sumary>
/// Contrato de serviço de Games
/// Define as operações de negócio disponíveis para o game
/// </sumary>
namespace SenacGames.Application.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetAllAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> getFeaturedAsync();
        Task<IEnumerable<GameDto>> GetByCategoryAsync(int categoryId);
        Task<GameDto> CreateAsync(CreateGameDto dto);
        Task<GameDto?> UpdateAsync(int id, UpdateGameDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
