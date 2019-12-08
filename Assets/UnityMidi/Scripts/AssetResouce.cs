using UnityEngine;
using System.IO;
using AudioSynthesis;

namespace UnityMidi
{
    [System.Serializable]
    public class AssetResouce : IResource
    {
        [SerializeField] string assetPath;

        public AssetResouce(string path)
        {
            assetPath = path;
        }

        public bool ReadAllowed()
        {
            return true;
        }

        public bool WriteAllowed()
        {
            return true;
        }

        public bool DeleteAllowed()
        {
            return true;
        }

        public string GetName()
        {
            return Path.GetFileName(assetPath);
        }

        public Stream OpenResourceForRead()
        {
            return File.OpenRead(Path.Combine(Application.dataPath, assetPath));
        }

        public Stream OpenResourceForWrite()
        {
            return File.OpenWrite(Path.Combine(Application.dataPath, assetPath));
        }

        public void DeleteResource()
        {
            File.Delete(Path.Combine(Application.dataPath, assetPath));
        }
    }
}
