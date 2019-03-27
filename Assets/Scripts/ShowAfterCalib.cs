using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PupilLabs
{
    public class ShowAfterCalib : MonoBehaviour
    {

        public CalibrationController controller;
        public bool enableAfterCalibration;

        void Start()
        {
            gameObject.SetActive(false);
        }

        void OnEnable()
        {
            controller.OnCalibrationSucceeded += EnableMePls;
            controller.OnCalibrationFailed += EnableMePls;
        }

        void EnableMePls()
        {
            if (enableAfterCalibration)
            {
                gameObject.SetActive(true);
            }
        }

        void DisableMePls()
        {
            gameObject.SetActive(false);
        }
    }
}
