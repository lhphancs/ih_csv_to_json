
using FileConverter.Models;

namespace FileConverter.Interfaces;

interface ISkuTransferEntriesReader
{
    public IEnumerable<SkuTransferEntry> GetTransferEntries(string pathToRead);
}
