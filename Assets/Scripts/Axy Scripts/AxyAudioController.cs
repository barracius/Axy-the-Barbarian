using UnityEditor;
using UnityEngine;

namespace Axy_Scripts
{
    public class AxyAudioController : MonoBehaviour
    {
        [SerializeField] private AxyMainController mainController;

        // Update is called once per frame
        void Update()
        {
            if (mainController.stateController.state.Equals("Loss"))
            {
                // Falta implementar el componente de AudioSource
                EditorApplication.Beep();
            }
        }
    }
}
