using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace SubjectNerd.PsdImporter
{
    public class PsdImporterSettings : ScriptableObject
    {

        [SerializeField]
        private TextureImporterType textureImporterType = TextureImporterType.Default;

        public TextureImporterType TextureImporterType {
            get { return textureImporterType; }
        }


        [SerializeField]
        private TextureImporterNPOTScale npotScale = TextureImporterNPOTScale.ToNearest;

        public TextureImporterNPOTScale NPOTScale {
            get { return npotScale; }
        }

        [SerializeField]
        private bool generateMipmaps = false;   

        public bool GenerateMipmaps {
            get { return generateMipmaps; }
        }


        [SerializeField]
        private bool useRawImage = true;

        public bool UseRawImage {
            get { return useRawImage; }
        }
    }
}
