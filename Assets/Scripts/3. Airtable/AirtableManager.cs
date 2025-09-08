using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

public class AirtableManager : MonoBehaviour
{
    //[Header("UI Elements")]
    //public Slider experienceSlider1;
    //public Slider experienceSlider2;
    //public Slider experienceSlider3;
    //public Slider experienceSlider4;
    //public Slider experienceSlider5;

    [Header("Airtable Configuration")]
    public string airtableEndpoint = "https://api.airtable.com/v0/";
    public string accessToken = "YOUR_ACCESS_TOKEN";
    public string baseId = "YOUR_BASE_ID";
    public string tableName = "YOUR_TABLE_NAME";
    private string dataToParse;

    [Header("Experience Data")]
    public string experience1;
    public string experience2;
    public string experience3;
    //public string experience4;
    //public string experience5;

    public void CreateRecord()
    {
        string url = airtableEndpoint + baseId + "/" + tableName;

        //experience1 = experienceSlider1.value.ToString();
        //experience2 = experienceSlider2.value.ToString();
        //experience3 = experienceSlider3.value.ToString();
        //experience4 = experienceSlider4.value.ToString();
        //experience5 = experienceSlider5.value.ToString();

        string jsonFields = "{\"fields\": {" +
                           "\"experienceSlider1\":\"" + experience1 + "\", " +
                           "\"experienceSlider2\":\"" + experience2 + "\", " +
                           "\"experienceSlider3\":\"" + experience3 + "\"" +
                           "}}";

        StartCoroutine(SendRequest(url, "POST", response =>
        {
            Debug.Log("Record created: " + response);
            dataToParse = response;
            JSONParse();
        }, jsonFields));
    }

    private IEnumerator SendRequest(string url, string method, Action<string> callback, string jsonData = "")
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = method;
        request.ContentType = "application/json";
        request.Headers["Authorization"] = "Bearer " + accessToken;

        if (!string.IsNullOrEmpty(jsonData))
        {
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(jsonData);
            }
        }

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string jsonResponse = reader.ReadToEnd();
                callback?.Invoke(jsonResponse);
            }
        }
        yield return null;
    }

    public void JSONParse()
    {
        dynamic data = JObject.Parse(dataToParse);
        //Debug.Log("Airtable Response Parsed: " + data);
    }
}
