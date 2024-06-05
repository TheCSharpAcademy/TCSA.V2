using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Runtime.CompilerServices;

namespace TCSA.V2.Services;

public class HeartBeat
{
    public async Task<string> Beat()
    {
        return await Task.FromResult("Stay alive");
    }
}
