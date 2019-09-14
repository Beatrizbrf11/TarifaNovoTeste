using System.IO;

namespace Tarifas
{
    public interface IStreamReader
    {
        StreamReader GetReader(string path);
    }
}