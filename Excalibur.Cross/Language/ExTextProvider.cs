﻿using System;
using System.Collections.Generic;
using System.Reflection;
using MvvmCross.Plugin.JsonLocalization;

namespace Excalibur.Cross.Language
{
    public class ExTextProvider
    {
        internal static IList<Assembly> ProjectAssemblies = new List<Assembly>();
        internal static string RootFolderForResources = String.Empty;
        internal static string GeneralNamespace = String.Empty;
        internal static string SharedNamespace = String.Empty;

        public static void InitializeAndCreateBuilder(IList<Assembly> projectAssemblies, string rootFolderForResources, string generalNamespace, string sharedNamespace)
        {
            ProjectAssemblies = projectAssemblies;
            RootFolderForResources = rootFolderForResources;
            GeneralNamespace = generalNamespace;
            SharedNamespace = sharedNamespace;

            var builder = new ExTextProviderBuilder();

            MvvmCross.Mvx.RegisterSingleton<IMvxTextProviderBuilder>(builder);
            MvvmCross.Mvx.RegisterSingleton(builder.TextProvider);
        }
    }
}
