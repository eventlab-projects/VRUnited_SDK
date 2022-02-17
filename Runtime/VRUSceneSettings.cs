using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.AddressableAssets;

namespace VRUnited
{

    [CreateAssetMenu(fileName = "SceneSettings", menuName = "VRUnited/SceneSettings")]
    public class VRUSceneSettings : ScriptableObject
    {

        public string _address = "";
        public string _displayName = "";
        public Texture2D _thumbnail = null;

        public AssetReference _scene = null;

    }

}


