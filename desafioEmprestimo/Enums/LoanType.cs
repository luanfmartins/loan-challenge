using System.ComponentModel;
using System.Text.Json.Serialization;

namespace desafioEmprestimo.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LoanType
    {
        [Description("PERSONAL")]
        PERSONAL = 1,
        [Description("GUARANTEED")]
        GUARANTEED = 2,
        [Description("CONSIGNMENT")]
        CONSIGNMENT = 3,
    }
}

