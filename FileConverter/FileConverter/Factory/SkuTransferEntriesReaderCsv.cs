using CsvHelper;
using FileConverter.Interfaces;
using FileConverter.Models;
using System.Globalization;

namespace FileConverter.Factory;

public class SkuTransferEntriesReaderCsv : ISkuTransferEntriesReader
{
    public IEnumerable<SkuTransferEntry> GetTransferEntries(string pathToRead)
    {
        using (var reader = new StreamReader(pathToRead))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<SkuTransferEntryMap>();
            var results = csv.GetRecords<SkuTransferEntry>().ToList();
            return results;
        }
    }
}
