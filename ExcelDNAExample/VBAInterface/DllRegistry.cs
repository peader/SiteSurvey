using System;
using ExcelDna.Integration;
using ExcelDna.ComInterop;
using ExcelDNAExample.Functions;
using System.Runtime.InteropServices;
//
namespace ExcelVBAInterface
{
    //
    [ComVisible(false)]
    class ExcelAddin : IExcelAddIn
    {
        public void AutoOpen()
        {
            ComServer.DllRegisterServer();
        }
        public void AutoClose()
        {
            ComServer.DllUnregisterServer();
        }
    }
}
