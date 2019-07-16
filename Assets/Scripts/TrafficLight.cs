using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kawaiiju.Traffic
{
    public class TrafficLight : MonoBehaviour
    {
        [Tooltip("First is green, second is red")]
        public MeshRenderer[] Renderer;

        public void SetLight(bool input)
        {
            if (input)
            {
                Renderer[0].material.EnableKeyword("_EMISSION");
                Renderer[1].material.DisableKeyword("_EMISSION");
            }
            else
            {
                Renderer[0].material.DisableKeyword("_EMISSION");
                Renderer[1].material.EnableKeyword("_EMISSION");
            }
        }
    }
}
