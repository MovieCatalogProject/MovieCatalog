namespace Katalog.Models.DTO
{
    public class Status //Класът предоставя обратна информация към потребителя относно дали извършената операция е успешна или не
    {
        public int StatusCode { get; set; }

        public string? Message { get; set; }
    }
}
