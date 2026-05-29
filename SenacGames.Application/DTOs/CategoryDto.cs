using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // <Sumary>
        // Quantidade de games nesta categoria
        //ùtil para mostrar no dashboarda e na listagem
        // </sumary>
        public int GameCount { get; set; }
    }
    /// <summary>
    /// DTO para criação de uma nova categoria
    /// </summary>
    public class CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
    /// <summary>
    /// DTO para atualização de uma categoria existente.
    /// </summary>
    public class UpdateCategoryDto 
    {
        public string Name { get; set; } = string.Empty;
    }

}
