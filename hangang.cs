using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using UnityEngine.Networking;

public class hangang : MonoBehaviour {
    string url = "http://hangang.dkserver.wo.tc/";
    //string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1171058000";

    public TextMesh mesh;
    void Start() {
        GET(url);
    }

    public WWW GET(string url)
    {

        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
        return www;
    }

    /*public WWW POST(string url, Dictionary<string, string> post)
    {
        WWWForm form = new WWWForm();
        foreach (KeyValuePair<String, String> post_arg in post)
        {
            form.AddField(post_arg.Key, post_arg.Value);
        }
        WWW www = new WWW(url, form);

        StartCoroutine(WaitForRequest(www));
        return www;
    }*/

    private IEnumerator WaitForRequest(WWW www)
    {
        yield return www;

        // check for errors
        if (www.error == null)
        {
            Debug.Log("WWW Ok!: " + www.text);
            mesh.text = www.text;
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }

}
