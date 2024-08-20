using System;
using System.Threading;
using System.Threading.Tasks;

namespace XenoDB;

public partial class XenoService
{
    public async Task<string[]> QueryHaveFile(string file, CancellationToken ctoken = default)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }

    public async Task<byte[]> GetThumbnail(string file, CancellationToken ctoken = default)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }

    public async Task<byte[]> GetThumbnail(byte[] hash, CancellationToken ctoken = default)
    {
        await Task.Yield();
        throw new NotImplementedException();
    }
}