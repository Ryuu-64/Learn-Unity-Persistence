using UnityEngine;
using Newtonsoft.Json;

namespace Ryuu.Learn.Unity.Persistence
{
    public class NewBehaviourScript : MonoBehaviour
    {
        private void Awake()
        {
            JsonConvert.DeserializeObject<bool>("false");
        }
    }
}