using CsvHelper.Configuration;
using FileConverter.Models;

namespace FileConverter;

public class SkuTransferEntryMap : ClassMap<SkuTransferEntry>
{
    public SkuTransferEntryMap()
    {
        Map(m => m.SKU).Name("SKU");
        Map(m => m.Quantity).Name("Quantity");
    }
}
