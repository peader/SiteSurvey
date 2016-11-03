/* 
 * SiteSurvey
 * https://github.com/peader/SiteSurvey/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using ExcelDna.Integration.CustomUI;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelDNAExample.Controls
{

    // Needs to be COM-visible to work
    [ComVisible(true)]
    public class Ribbon : ExcelDna.Integration.CustomUI.ExcelRibbon
    {
        // The function GetCustomUI loads the xml file into the .dna file i.e. it defines the structure of the custom tabs in excel
        public override string GetCustomUI(string uiName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream("ExcelDNAExample.Controls.Ribbon.xml"));

            // For some reason doc.getElementById() isn't working
            // XmlNodeList buttons = doc.GetElementsByTagName("button");
            //foreach (XmlNode button in buttons)
            //{
            //    if (button.Attributes["id"].Value == "UpdateButton")
            //    {
            //        if (Main.UpdateAvailable())
            //        {
            //            button.Attributes["visible"].Value = "true";
            //        }
            //        break;
            //    }
            //}
            return doc.InnerXml;
        }
        //The functions FunctionsClick is called by the xml and decides what to do when the function buttons are clicked i.e. it calls the functions
        // Note: Functions click identifies functions via there xml tag name
        public void FunctionsClick(IRibbonControl control)
        {
            Excel.Application app = (Excel.Application)ExcelDna.Integration.ExcelDnaUtil.Application;
            Excel.Range activeCell = app.ActiveCell;
            string origFormula = app.ActiveCell.Formula;

            // Add formula to Excel
            if (origFormula == "")
            {
                // Add equals sign if formula is blank
                activeCell.Formula = "=" + control.Tag + "()";
            }
            else
            {
                // Add plus sign if no valid operator exists at end of formula
                switch (origFormula[origFormula.Length - 1])
                {
                    case ',':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        activeCell.Formula += control.Tag + "()";
                        break;
                    default:
                        activeCell.Formula += "+" + control.Tag + "()";

                        break;
                }
            }

            // Replace original formula if user escapes function dialog wizard
            if (!app.Dialogs[Excel.XlBuiltInDialog.xlDialogFunctionWizard].Show())
            {
                activeCell.Formula = origFormula;
            }
        }


        public void AboutButton_Click(IRibbonControl control)
        {
            new AboutForm().Show();
        }

        public void SetGoogleAPIKeyButton_Click(IRibbonControl control)
        {
            new ElevationDataAPI.TerrainProfiler.SetGoogleAPIKey().Show();
        }

    }
}
