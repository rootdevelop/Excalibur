﻿using Excalibur.Base.Configuration;
using Excalibur.Base.Storage;
using MvvmCross;
using MvvmCross.Plugin;

namespace Excalibur.Providers.FileStorage
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterType<IStorageService, ExStorageService>();
            Mvx.IoCProvider.RegisterType<IConfigurationManager, ConfigurationManager>();
        }
    }
}