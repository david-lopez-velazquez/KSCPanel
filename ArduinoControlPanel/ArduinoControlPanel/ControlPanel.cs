using System;
using UnityEngine;

//TODO: references to find on KSP_Install\KSP_x64_Data\Managed
// UnityEngine.dll
// UnityEngine.UI.dll
// Assembly-Csharp.dll
// Assembly-Csharp-firstpass.dll

namespace ArduinoControlPanel
{
    //    [KSPAddon(KSPAddon.Startup.Flight,false)]
    [KSPAddon(KSPAddon.Startup.MainMenu,false)]
    public class ControlPanel : MonoBehaviour
    {
        public void Awake() { } // not recommended

        public void Start()
        {// called once for every instance (when enter flight mode)
            Debug.Log("STARTING:Hello World!" + Time.realtimeSinceStartup);
        } 

        public void Update()// called 60 times by second if running at 60fps
        {
            Debug.Log("STARTING:Hello World!" + Time.realtimeSinceStartup);
        } 

        public void FixedUpdate() { } // physics update, not synchro with previous

        public void OnDisable() { }

        public void OnSave(ConfigNode node) { }

        public void OnLoad(ConfigNode node) { }



    }
}
