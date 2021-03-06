﻿using ContractLibrary.Interfaces;

namespace ImageAcquisitionLibrary.Interfaces
{
    public interface IImageAcquisition : ICameraImage
    {
        void CreateCaptureLogForImage(string image);
    }
}
