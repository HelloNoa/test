using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{

    public GameObject mapContents;
    public GameObject ratingContents;
    public GameObject categoryContents;
    public GameObject mypageContents;

    public bool mapStatus;
    public bool ratingStatus;
    public bool categoryStatus;
    public bool mypageStatus;

    public bool eatStatus;
    public bool seeStatus;
    public bool playStatus;

    public bool star5Status;
    public bool star4Status;
    public bool star3Status;

    //프리펩 설정
    public GameObject eatPrefab;
    public GameObject seePrefab;
    public GameObject playPrefab;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        mapStatus = true;
        ratingStatus = false;
        categoryStatus = false;
        mypageStatus = false;

        eatStatus = true;
        seeStatus = false;
        playStatus = false;

        star5Status = true;
        star4Status = false;
        star3Status = false;

        //페널 카테고리 이미지 불러오기
        Sprite bar = Resources.Load<Sprite>("Textures/EAT-bar_wrap");
        Sprite cafe = Resources.Load<Sprite>("Textures/EAT-cafe_wrap");
        Sprite res = Resources.Load<Sprite>("Textures/EAT-restaurant_wrap");
        Sprite club = Resources.Load<Sprite>("Textures/PLAY-show-club_wrap");
        Sprite shop = Resources.Load<Sprite>("Textures/PLAY-shopping_wrap");
        Sprite others = Resources.Load<Sprite>("Textures/PLAY-others_wrap");
        Sprite att = Resources.Load<Sprite>("Textures/SEE-attraction_wrap");
        Sprite mus = Resources.Load<Sprite>("Textures/SEE-museum_wrap");
        Sprite park = Resources.Load<Sprite>("Textures/SEE-park_wrap");

        //각 메뉴 버튼의 부모객체 소환
        mapContents = GameObject.FindWithTag("MapContents");
        ratingContents = GameObject.FindWithTag("RatingContents");
        categoryContents = GameObject.FindWithTag("CategoryContents").transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.gameObject;
        mypageContents = GameObject.FindWithTag("MypageContents");

        // 받아온 데이터 객체 정리
        JArray jsonData = GetAllList();
        for (int i = 0; i < jsonData.Count; i++)
        {
            if (((string)jsonData[i]["useYn"]).Equals("Y"))
            {
                float positionX = (float)System.Convert.ToDouble(jsonData[i]["positionX"]);
                float positionY = (float)System.Convert.ToDouble(jsonData[i]["positionY"]);
                float positionZ = (float)System.Convert.ToDouble(jsonData[i]["positionZ"]);
                string imgName = (string)jsonData[i]["imgPath"];
                Vector3 cubePosition = new Vector3(positionX, positionY, 0f);
                Quaternion qRotation = Quaternion.Euler(0f, 0f, 0.22f);
                WWW www;
                
                //생성
                GameObject go;
                if (((string)jsonData[i]["category"]).Equals("EAT"))
                {

                    go = Instantiate(eatPrefab, cubePosition, qRotation);
                }
                else if (((string)jsonData[i]["category"]).Equals("PLAY"))
                {
                    go = Instantiate(playPrefab, cubePosition, qRotation);
                }
                else
                {
                    go = Instantiate(seePrefab, cubePosition, qRotation);
                }
                float goScale = 1f / 2.685315f;
                go.transform.localScale = new Vector3(goScale, goScale, goScale);




                //부모객체 설정
                go.transform.parent = categoryContents.transform;
                GameObject mainImage = go.transform.Find("GameObject").gameObject;
                GameObject categoryImage = go.transform.Find("wrap").gameObject;
                categoryContents.transform.localPosition = new Vector3(-6.103516e-05f, 0f, 0f);
                int rating = (int)positionY/10;

                //객체 변수 적용

                PanelClass pc = go.GetComponent<PanelClass>();
                pc.rating = rating;
                pc.selectYn = false;


                Sprite cateSprite;
                if (((string)jsonData[i]["category"]).Equals("EAT"))
                {
                    pc.categoryType = "EAT";
                    www = new WWW("http://13.209.40.161/images/EAT/" + imgName);
                    if (((string)jsonData[i]["detailCategory"]).Equals("1"))
                    {
                        pc.activeYn = true;
                        cateSprite = res;
                        pc.detailCategoryType = "res";
                    }
                    else if (((string)jsonData[i]["detailCategory"]).Equals("2"))
                    {
                        cateSprite = cafe;
                        pc.detailCategoryType = "cafe";
                    }
                    else
                    {
                        cateSprite = bar;
                        pc.detailCategoryType = "bar";

                    }
                }
                else if (((string)jsonData[i]["category"]).Equals("PLAY"))
                {
                    pc.categoryType = "PLAY";
                    www = new WWW("http://13.209.40.161/images/PLAY/" + imgName);
                    if (((string)jsonData[i]["detailCategory"]).Equals("1"))
                    {
                        cateSprite = club;
                        pc.detailCategoryType = "con";
                    }
                    else if (((string)jsonData[i]["detailCategory"]).Equals("2"))
                    {
                        cateSprite = shop;
                        pc.detailCategoryType = "shop";
                    }
                    else
                    {
                        cateSprite = others;
                        pc.detailCategoryType = "others";

                    }
                }
                else
                {
                    pc.categoryType = "SEE";
                    www = new WWW("http://13.209.40.161/images/SEE/" + imgName);
                    if (((string)jsonData[i]["detailCategory"]).Equals("1"))
                    {
                        cateSprite = mus;
                        pc.detailCategoryType = "mus";
                    }
                    else if (((string)jsonData[i]["detailCategory"]).Equals("2"))
                    {
                        cateSprite = att;
                        pc.detailCategoryType = "att";
                    }
                    else
                    {
                        cateSprite = park;
                        pc.detailCategoryType = "park";
                    }
                }


                yield return www;
                mainImage.GetComponent<Image>().sprite = Sprite.Create(www.texture, new Rect(0f, 0f, www.texture.width, www.texture.height), new Vector2(0.5f, 0.5f));
                categoryImage.GetComponent<Image>().sprite = cateSprite;


                //텍스트 넣기

                GameObject placeName_holder = go.transform.Find("Text").gameObject;
                string text = (string)jsonData[i]["name"];
                placeName_holder.transform.GetComponent<Text>().text = text;

                //panel 상태값이 true일 경우에만 활성화
                if (pc.activeYn != true) {
                    go.SetActive(false);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void FirstMenu(string str)
    {
        if (str.Equals("map"))
        {
            mapStatus = true;
            ratingStatus = false;
            categoryStatus = false;
            mypageStatus = false;
        }
        else if (str.Equals("rating"))
        {
            mapStatus = false;
            ratingStatus = true;
            categoryStatus = false;
            mypageStatus = false;
        }
        else if (str.Equals("category"))
        {
            mapStatus = false;
            ratingStatus = false;
            categoryStatus = true;
            mypageStatus = false;
        }
        else if(str.Equals("mypage")){

            mapStatus = false;
            ratingStatus = false;
            categoryStatus = false;
            mypageStatus = true;
        }
    }

    public void SecondMenu(string str, bool overlap = true)
    {
        if (overlap)
        {
            if (str.Equals("eat"))
            {
                eatStatus = !eatStatus;
            }
            else if (str.Equals("see"))
            {
                seeStatus = !seeStatus;
            }
            else if (str.Equals("play"))
            {
                playStatus = !playStatus;
            }
        }
        else
        {
            if (str.Equals("eat"))
            {
                eatStatus = true;
                seeStatus = false;
                playStatus = false;
            }
            else if (str.Equals("see"))
            {
                eatStatus = false;
                seeStatus = true;
                playStatus = false;
            }
            else if (str.Equals("play"))
            {
                eatStatus = false;
                seeStatus = false;
                playStatus = true;
            }
        }
    }

    public void ThridMenu(string str)
    {
        if (str.Equals("star5"))
        {
            star5Status = true;
            star4Status = false;
            star3Status = false;
        }
        else if (str.Equals("star4"))
        {
            star5Status = false;
            star4Status = true;
            star3Status = false;
        }
        else if (str.Equals("star3"))
        {
            star5Status = false;
            star4Status = false;
            star3Status = true;
        }
    }

    private JArray GetAllList()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://13.209.40.161/SELECT/selectAll.php");
        request.Method = "POST";
        request.ContentType = "applicant/json";
        using (var stream = request.GetRequestStream())
        {
            stream.Flush();
            stream.Close();
        }
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string json = reader.ReadToEnd();
        JArray jsonArray = JArray.Parse(json);
        return jsonArray;
    }
}
