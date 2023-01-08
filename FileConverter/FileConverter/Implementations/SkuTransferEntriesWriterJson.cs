using FileConverter.Interfaces;
using FileConverter.Models;
using System.Text.Json;

namespace FileConverter.Factory;

public class SkuTransferEntriesWriterJson : ISkuTransferEntriesWriter
{
    public void WriteTransferEntries(string pathToWrite, IEnumerable<SkuTransferEntry> skuTransferEntriesToWrite)
    {
        var serializeOptions = new JsonSerializerOptions() { WriteIndented = true };
        serializeOptions.Converters.Add(new CustomDateTimeConverter("yyyy-MM-dd"));

        using (StreamWriter sw = new StreamWriter(pathToWrite))
        {
            sw.Write(JsonSerializer.Serialize(skuTransferEntriesToWrite, serializeOptions));
        }
    }
}
