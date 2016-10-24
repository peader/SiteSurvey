/* 
 * TerrainProfiler
 * https://github.com/peader/TerrainProfiler/
 * 
 * Copyright 2016, Peter Mahady
 * Licensed under the MIT license
 * http://www.opensource.org/licenses/mit-license.php
 */

using System.Collections.Generic;
using ExcelDNAExample.Properties;
using System.Text;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System;

namespace ElevationDataAPI.TerrainProfiler
{
    internal class GoogleMapsElevationProfile: ElevationProfileBase
    {
        private List<string> _APIStrings = new List<string>();
        private List<string> APIStrings { get { return this._APIStrings; } }

        // Build up the strings required for the requests to the google maps api
        private void buildGoogleAPIStrings()
        {
            int index = 0;
            while(index <= this.Count -1)
            {
                long count = 0;
                StringBuilder APIString = new StringBuilder();
                 APIString.Append("https://maps.googleapis.com/maps/api/elevation/xml?locations=");
                for (count = 0; count <= 50 & index <= this.Count - 1; count++)
                {
                    APIString.Append(this[index].ToString());
                    index++;
                }
                var i = APIString.ToString().LastIndexOf('|');
                //Remove the last "|" from the string before adding the API key data
                APIString = APIString.Remove(i, 1);
                APIString.Append("&key=" + Settings.Default.APIKey);
                // Add this api string to the list
                _APIStrings.Add(APIString.ToString());

            }

        }

        // Use the API strings to request Elevation data from google maps for this profile
        private void SendWebRequests()
        {
            try
            {
                // we use this index to keep our place in the API strings 
                // so we know where to put the current elevation responses
                int i = 0;
                foreach (string APIString in this.APIStrings)
                {
                    //if (Profile[0].theta == 90) continue;
                    WebRequest PElevation = WebRequest.Create(APIString);
                    // If required by the server, set the credentials.
                    PElevation.Credentials = CredentialCache.DefaultCredentials;
                    // Get the response.
                    WebResponse response = PElevation.GetResponse();
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Parse the response from the server
                    var responseFromServerXML = XDocument.Parse(responseFromServer);
                    // Check the status of the reponse before validating it
                    string status = responseFromServerXML.Root.Element("status").Value.ToString();
                    // if there is no data available we assign the elevations as NaN and skip to the next iteration
                    if (status.ToLower() == "data_not_available") {
                        foreach (var result in responseFromServerXML.Root.Elements("result"))
                        {
                            this[i].elevation = double.NaN;
                            i++;
                        }
                        continue;
                    }

                    //Validate web request
                    this.CheckWebRequestForErrors(responseFromServerXML);

                    foreach (var result in responseFromServerXML.Root.Elements("result"))
                    {
                        var loc = result.Element("location");
                        var lata = double.Parse(loc.Element("lat").Value);
                        var longa = double.Parse(loc.Element("lng").Value);
                        var elevation = double.Parse(result.Element("elevation").Value);
                        this[i].elevation = elevation;
                        i++;
                    }


                    // Clean up the streams and the response.
                    reader.Close();
                    response.Close();
                }
            }
            catch(Exception)
            {
                throw;
            }

        }

        // @responseXMLFromServer the xml returned from the server after the web requests was sent
        // Checks that a valid connection can be made to the google server 
        internal void CheckWebRequestForErrors(XDocument responseXMLFromServer)
        {
            string status = responseXMLFromServer.Root.Element("status").Value.ToString();
            if (status.ToLower() != "ok")
            {
                string errorMessage = responseXMLFromServer.Root.Element("error_message").Value.ToString();
                throw new Exception(errorMessage);
            }
        } 


        public override void GetElevationData()
        {
            this.buildGoogleAPIStrings();
            this.SendWebRequests();
        }


    }
}
