using UnityEngine;
using UnityEngine.Events;

namespace PlatformGame.Contents
{
    public class Stage : MonoBehaviour
    {
        [SerializeField] UnityEvent mClearEvent;

        public void AddListenerClearEvent(UnityAction action)
        {
            mClearEvent.AddListener(action);
        }

        protected void Clear()
        {
            mClearEvent.Invoke();
        }
    }
}