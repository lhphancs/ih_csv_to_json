using FileConverter.Models;

namespace FileConverter.Interfaces;

interface ISkuTransferEntriesWriter
{
    public void WriteTransferEntries(string pathToWrite, IEnumerable<SkuTransferEntry> SkuTransferEntriesToWrite);
}
