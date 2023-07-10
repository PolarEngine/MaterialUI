using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering;


namespace PolarMaterialMod
{
    [BepInPlugin("com.polar.PolarMaterialMod", "PolarMaterialMod", "1.0.0")]

    public class MainPlugin : BaseUnityPlugin
    {
        public void OnGUI()
        {
            bool NoTexture = GUI.Button(new Rect(20, 40, 125, 25), "No Texture Material");
            if (NoTexture)
            {
                GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla").GetComponent<SkinnedMeshRenderer>().material.mainTexture = null;
            }

            bool Galaxy = GUI.Button(new Rect(20, 85, 125, 25), "Galaxy Material");
            if (Galaxy)
            {
                Texture2D texture2D = new Texture2D(2, 2, GraphicsFormat.R8G8B8A8_UNorm, 1, TextureCreationFlags.None);
                texture2D.LoadImage(File.ReadAllBytes(Environment.CurrentDirectory + "/BepInEx/plugins/MaterialMod/Textures/Galaxy.jpg"));
                GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla").GetComponent<SkinnedMeshRenderer>().material.mainTexture = texture2D;
            }

            bool Matrix = GUI.Button(new Rect(20, 130, 125, 25), "Matrix");
            if (Matrix)
            {
                Texture2D texture2D = new Texture2D(2, 2, GraphicsFormat.R8G8B8A8_UNorm, 1, TextureCreationFlags.None);
                texture2D.LoadImage(File.ReadAllBytes(Environment.CurrentDirectory + "/BepInEx/plugins/MaterialMod/Textures/Matrix.png"));
                GameObject.Find("Global/Local VRRig/Local Gorilla Player/gorilla").GetComponent<SkinnedMeshRenderer>().material.mainTexture = texture2D;
            }
        }
    }
}
