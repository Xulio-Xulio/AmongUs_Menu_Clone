using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
   public MeshRenderer move;
   public float speed;

   void Update() {
       move.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
   }
}
