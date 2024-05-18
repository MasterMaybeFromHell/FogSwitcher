using MelonLoader;
using System.Collections;
using UnityEngine;

namespace FogSwitcher
{
    public class Script : MelonMod
    {
        private bool _fogColor = false;
        private int _index = 0;
        private string _text;

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F9))
            {
                _fogColor = !_fogColor;
                _index = 0;
            }
            if (_fogColor)
            {
                MelonCoroutines.Start(FogColor());
            }
        }

        private IEnumerator FogColor()
        {
            switch (_index)
            {
                case 0:
                    RenderSettings.fogColor = Color.white;
                    yield return new WaitForSeconds(.3f);
                    _index = 1;
                    break;
                case 1:
                    RenderSettings.fogColor = Color.black;
                    yield return new WaitForSeconds(.3f);
                    _index = 2;
                    break;
                case 2:
                    RenderSettings.fogColor = Color.gray;
                    yield return new WaitForSeconds(.3f);
                    _index = 3;
                    break;
                case 3:
                    RenderSettings.fogColor = Color.blue;
                    yield return new WaitForSeconds(.3f);
                    _index = 4;
                    break;
                case 4:
                    RenderSettings.fogColor = Color.red;
                    yield return new WaitForSeconds(.3f);
                    _index = 5;
                    break;
                case 5:
                    RenderSettings.fogColor = Color.green;
                    yield return new WaitForSeconds(.3f);
                    _index = 6;
                    break;
                case 6:
                    RenderSettings.fogColor = Color.yellow;
                    yield return new WaitForSeconds(.3f);
                    _index = 7;
                    break;
                case 7:
                    RenderSettings.fogColor = Color.magenta;
                    yield return new WaitForSeconds(.3f);
                    _index = 8;
                    break;
                case 8:
                    RenderSettings.fogColor = Color.cyan;
                    yield return new WaitForSeconds(.3f);
                    _index = 9;
                    break;
                case 9:
                    RenderSettings.fogColor = Color.clear;
                    yield return new WaitForSeconds(.3f);
                    _index = 0;
                    break;
            }
        }
    }
}