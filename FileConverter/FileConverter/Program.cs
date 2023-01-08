using FileConverter.Factory;

var READ_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}/_files/input.csv";
var WRITE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}/_files/output.txt";

var reader = new SkuTransferEntriesReaderCsv();
var writer = new SkuTransferEntriesWriterJson();

var results = reader.GetTransferEntries(READ_PATH).ToList();
Console.WriteLine($"Found {results.ToList().Count} entries in file");

var now = DateTime.Now;
foreach(var entry in results)
{
    entry.Date = now;
}

writer.WriteTransferEntries(WRITE_PATH, results);