namespace GNW_Bazzar.Dto
{
    internal class ResponseDto<T>
    {
        public int ResponseCode { get; set; }
        public string Message { get; set; } = default!;
        public T? Value { get; set; }
    }
}
