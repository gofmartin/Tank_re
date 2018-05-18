using UnityEngine;

namespace Complete
{
    public class UIDirectionControl : MonoBehaviour
    {
        
        //是否实时旋转
        public bool m_UseRelativeRotation = true;       

        //旋转角度
        private Quaternion m_RelativeRotation;


        private void Start ()
        {
            //初始角度等于父物体的旋转角度
            m_RelativeRotation = transform.parent.localRotation;
        }


        private void Update ()
        {
            //如果是实时旋转，则实时保持和父物体一样的旋转角度
            if (m_UseRelativeRotation)
                transform.rotation = m_RelativeRotation;
        }
    }
}