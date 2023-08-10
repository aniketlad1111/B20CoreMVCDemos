namespace ValidationsDemo.Models
{
    internal class DateValidationAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}