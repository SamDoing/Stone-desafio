using Newtonsoft.Json;

namespace Api
{
    public class ErrorModel
    {
        [JsonProperty("code")]
        public string CodeStr { get; set; }
        [JsonIgnore]
        public ErrorCodes Code
        {
            get
            {
                ErrorCodes response;
                try
                {
                    response = (ErrorCodes)Enum.Parse(typeof(ErrorCodes),
                    CodeStr);
                }
                catch
                {
                    response = ErrorCodes.Unknown;
                }
                return response;
            }
            set
            {
                CodeStr = value.ToString();
            }
        }
        public string Messagem { get; set; }
        public Dictionary<string, string> Detalhes { get; set; }
        public override string ToString()
        {
            var detailsString = string.Empty;
            if (Details != null && Details.Count > 0)
            {
                detailsString = Environment.NewLine +
                string.Join(Environment.NewLine, Details);
            }
            return $"{CodeStr} - {Message}{detailsString}";
        }
    }
}
