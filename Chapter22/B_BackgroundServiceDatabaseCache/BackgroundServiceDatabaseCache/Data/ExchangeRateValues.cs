using System.ComponentModel.DataAnnotations.Schema;

namespace BackgroundServiceDatabaseCache
{
    public class ExchangeRateValues
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExchangeRateValuesId { get; set; }
        public string Rate { get; set; }
        public decimal Value { get; set; }
    }
}
