using YRTJapan.Core.Entities;

namespace YRTJapan.UI.Services.Interfaces
{
    public interface IApiService
    {
        Task<ApiResponse<dynamic>> AjGetAsync(string sql);
        Task<ApiResponse<dynamic>> RunMultipleQueriesAsync(List<string> sql);
    }
}
