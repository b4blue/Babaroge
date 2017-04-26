using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.scripts.view
{
    public class DoorView : View
    {

        public int materialIndex = 0;
        public Vector2 uvAnimationRate = new Vector2(0.5f, 0.0f);
        public string textureName = "_MainTex";
        private Renderer rend;
        override protected void Start()
        {
            rend = GetComponent<Renderer>();
        }
        Vector2 uvOffset = Vector2.zero;
        void LateUpdate()
        {
            uvOffset += (uvAnimationRate * Time.deltaTime);
            if (rend.enabled)
            {
                rend.materials[materialIndex].SetTextureOffset(textureName, uvOffset);
            }
        }
    }
}