using UnityEngine;
using System.IO;
using AudioSynthesis;

namespace UnityMidi
{
    [System.Serializable]
    public class MemoryAsset : IResource
    {
        private string _name;
        private byte[] _datas;

        public MemoryAsset(string name, byte[] datas)
        {
            _name = name;
            _datas = datas;
        }

        public bool ReadAllowed()
        {
            return true;
        }

        public bool WriteAllowed()
        {
            return false;
        }

        public bool DeleteAllowed()
        {
            return false;
        }

        public string GetName()
        {
            return _name;
        }

        public Stream OpenResourceForRead()
        {
            return new MemoryStream(_datas);
        }

        public Stream OpenResourceForWrite()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteResource()
        {
            throw new System.NotImplementedException();
        }
    }
}
