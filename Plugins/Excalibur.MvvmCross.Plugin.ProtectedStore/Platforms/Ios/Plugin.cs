﻿using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.Plugin;

namespace Excalibur.MvvmCross.Plugin.ProtectedStore.Platforms.Ios
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.ConstructAndRegisterSingleton<IProtectedStore, ProtectedStore>();
        }
    }
}
