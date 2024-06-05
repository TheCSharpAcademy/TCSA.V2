using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Runtime.CompilerServices;

namespace TCSA.V2.Services;

public class HeartBeat
{
    //This is a service to ping back to layout page to keep connection alive in intervals
    //This method is called from layout page
    public async Task<string> Beat()
    {
        return await Task.FromResult("Stay alive");
    }
}
