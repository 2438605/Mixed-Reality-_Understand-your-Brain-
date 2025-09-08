//using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;
//using UnityEngine.XR.Interaction.Toolkit.Interactables;
//using UnityEngine.XR.Interaction.Toolkit.Interactors;

//public class BabyPickup : MonoBehaviour
//{
//    public Transform correctHoldPosition; // Position where hands should be
//    public float positionThreshold = 0.2f; // How close they need to be

//    private XRGrabInteractable grabInteractable;

//    void Awake()
//    {
//        grabInteractable = GetComponent<XRGrabInteractable>();
//        grabInteractable.selectEntered.AddListener(OnPickup);
//        grabInteractable.selectExited.AddListener(OnRelease);
//    }

//    private void OnPickup(SelectEnterEventArgs args)
//    {
//        IXRSelectInteractor interactor = args.interactorObject; // Player's hand controller
//        float distance = Vector3.Distance(interactor.transform.position, correctHoldPosition.position);

//        if (distance > positionThreshold)
//        {
//            Debug.Log("Adjust your hands to support the baby properly.");
//            // TODO: Add haptic feedback or show UI warning
//        }
//        else
//        {
//            Debug.Log("Holding baby correctly!");
//            // TODO: Play baby giggle animation/sound (if applicable)
//        }
//    }

//    private void OnRelease(SelectExitEventArgs args)
//    {
//        Debug.Log("Baby released.");
//    }

//    private void OnDestroy()
//    {
//        grabInteractable.selectEntered.RemoveListener(OnPickup);
//        grabInteractable.selectExited.RemoveListener(OnRelease);
//    }
//}
