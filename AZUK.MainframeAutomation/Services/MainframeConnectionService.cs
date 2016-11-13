using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AZUK.MainframeAutomationRobot.Model;

namespace AZUK.MainframeAutomationRobot.Services
{
    public interface MainframeConnectionService
    {
        KeyingResultModel UploadToMainframe();
    }
}
