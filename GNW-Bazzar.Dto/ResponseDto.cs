namespace GNW_Bazzar.Dto
{
    public class ResponseDto<T>
    {
        public int ResponseCode { get; set; }
        public string Message { get; set; } = default!;
        public T? Value { get; set; }
    }
}
