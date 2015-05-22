﻿using KeePass.Plugins;

namespace GostPlugin
{
    public sealed class GostPluginExt : KeePass.Plugins.Plugin
    {
        private static readonly GostCipherEngine _gostCipher = new GostCipherEngine();
        public override string UpdateUrl { get { return "https://yaruson.github.io/GostPlugin/VersionInformation.txt"; } }

        public override bool Initialize(IPluginHost host)
        {
            if (host != null && host.CipherPool != null)
            {
                host.CipherPool.AddCipher(_gostCipher);
                return true;
            }
            return false;
        }
    }
}