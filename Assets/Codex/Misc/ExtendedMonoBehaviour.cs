using Sirenix.OdinInspector;
using UnityEngine;

namespace Codex.Misc
{
    public class ExtendedMonoBehaviour : MonoBehaviour
    {
        //Todo Get these into a drawer or something. They should not be changeable AFAIK
        [Title("Transform and RB Refs")] 
        public Transform _TR;
        public GameObject _GO;

        public Rigidbody _RB;
        public Rigidbody2D _RB2D;

        [Title("Init and Id")] 
        public bool didInit;
        public bool canControl;
        public int id;

        [System.NonSerialized] public Vector3 tempVec3;
        [System.NonSerialized] public Transform tempTR; //Why are these public?

        public virtual void SetId(int newId)
        {
            id = newId;
        }

        public virtual void GetComponents()
        {
            _TR ??= transform;
            _GO ??= gameObject;
        }
        
        public Transform Spawn(Transform spawnObject, Vector3 spawnPosition, Quaternion spawnRotation)
        {
            return Instantiate(spawnObject, spawnPosition, spawnRotation);
        }
        
        public static bool IsInLayerMask(int layer, LayerMask layerMask)
        {
            return layerMask == (layerMask | (1 << layer));
        }
    }
}