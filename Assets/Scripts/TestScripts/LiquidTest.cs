//using UnityEngine;
//using Obi;

//public class LiquidTest : MonoBehaviour
//{
//    private ObiEmitter emitter;

//    // Start is called once before the first execution of Update after the MonoBehaviour is created
//    void Start()
//    {
//        emitter = FindAnyObjectByType<ObiEmitter>();
//        emitter.KillAll();
//    }

//    public void PlayLiquid()
//    {
//        emitter.EmitParticles();
//        Debug.Log("Trying to play particles...");
//    }


//    public void ResetParticles()
//    {
//        emitter.KillAll();
//        Debug.Log("Killing particles");

//    }


//    private void Update()
//    {
//        if (Input.GetKey(KeyCode.A))
//        {
//            PlayLiquid();
//        }

//        if(Input.GetKey(KeyCode.S))
//        {
//            ResetParticles();
//        }
//    }

//}
