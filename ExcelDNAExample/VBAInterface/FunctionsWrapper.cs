/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System;
using ExcelDna.Integration;
using ExcelDna.ComInterop;
using ExcelDNAExample.Functions;
using System.Runtime.InteropServices;

//This class is a wrapper for the functions we already created
//The reason we need it is because The functions exported as UDFs must be 'static',
//while the COM-visible methods must be instance methods.
namespace ExcelVBAInterface
{
    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ProgId("CSharp_functionLibrary")]
    public class FunctionsWrapper
    {
    	public string HelloSam()
        {
    		return Functions.Hello();
        }  	
    	
    }
}
