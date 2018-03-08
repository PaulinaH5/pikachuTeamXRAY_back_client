﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractLibrary.Models
{
    public class CameraImageCaptureRequest
    {
        public int light;
        public int contrast;
        public bool blackWhite;
        public string patientName;
        public string user;
        public string imageDate;
        public string imageTime;

        public CameraImageCaptureRequest() {
            imageDate = DateTime.Now.ToShortDateString();
            imageTime = DateTime.Now.ToLongTimeString();
        }

    }
}