namespace YRTJapan.Core.Entities
{
    public class ApiResponse<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public int StatusCode { get; set; }
        
        public T? Data { get; set; }
    }
}
