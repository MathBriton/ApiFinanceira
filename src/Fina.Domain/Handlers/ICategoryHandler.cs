using Fina.Domain.Models;
using Fina.Domain.Requests.Categories;
using Fina.Domain.Responses;

namespace Fina.Domain.Handlers;

public interface ICategoryHandler

{
    Task<Response<Category?>> CreateAsync (CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAsync (DeleteCategoryRequest request);
    Task<Response<Category?>> GetByIdAsync (GetCategoryByIdRequest request);
    Task<PagedResponse<List<Category>>> GetAllAsync (GetAllCategoriesRequest request);
}