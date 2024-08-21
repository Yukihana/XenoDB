﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace XenoDB;

// The front-end class
public partial class XenoService
{
    private readonly string _profilePath;

    // Use default profile path set in cfg
    public XenoService()
    {
        _profilePath = GetDefaultProfile();
    }

    // use passed profile path
    public XenoService(string profilePath)
    {
        _profilePath = profilePath;
    }

    private string GetDefaultProfile()
    {
        throw new NotImplementedException();
    }

    public async Task Initialize(CancellationToken ctoken = default)
    {
        await BuildEnvironment(ctoken);
    }
}