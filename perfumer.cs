IEnumerator English()
    {
        /*while (true)
        {*/

        if (bb)
        {
            PlayerPrefs.SetInt("count", PlayerPrefs.GetInt("count", 0) + 1);
            gamelogic.On();
        }
        switch (PlayerPrefs.GetInt("count", 0))
        {
            case 0:
                mesh.text = "한 낚시꾼이 물고기를 잡으려고";
                mesh.text = "One angler throw the Fishing needle ";
                break;
            case 1:
                mesh.text = "낚시 바늘을 던졌지만,";
                mesh.text = "to catch the fish,";
                break;
            case 2:
                mesh.text = "물고기들은 낚시 바늘로부터 발버둥 쳤다.";
                mesh.text = "but fishes run away from the Fishing needle.";
                break;
            case 3:
                mesh.text = "허나, 한 물고기는";
                mesh.text = "A fish, ";
                break;
            case 4:
                mesh.text = "미끼가 끼어지지 않은 \n낚시 바늘을 물었고,";
                mesh.text = "however, bites a fishing needle without bait,";
                break;
            case 5:
                mesh.text = "그 광경을 본 낚시꾼은 낚시대를 놓고";
                mesh.text = "and the angler";
                break;
            case 6:
                mesh.text = "그 장면을 지켜보았다.";
                mesh.text = "who watched the sight watched the scene \n with a fishing rod.";
                break;
            case 7:
                mesh.text = "낚시꾼은";
                mesh.text = "The angler";
                break;
            case 8:
                mesh.text = "그 낚시대를 두고 \n어디론가 사라졌다.";
                mesh.text = "vanished somewhere with his fishing rod left";
                break;
            case 9:
                mesh.text = "그리고 그 낚시대의 낚시 바늘엔 \n여전히 물고기가 걸려 있었다.";
                mesh.text = "And the fishing hook of the fishing rod still caught fish.";
                break;
            case 10:
                mesh.text = "낚시꾼이 돌아오지 않자,";
                mesh.text = "The angler did not return,";
                break;
            case 11:
                mesh.text = "물고기는 자신의 살점을 뜯고 사라졌다.";
                mesh.text = "the fish grazed his flesh and disappeared.";
                break;
            case 12:
                mesh.text = "낚시꾼이 다시 돌아올때쯤, \n낚시대에는 물고기가 없는것을 보고, \n다시 기다렸다.";
                mesh.text = "By the time the fisherman came back,\n he saw that there was no fish on the fishing rod and waited again.";
                break;
            case 13:
                mesh.text = "낚시꾼도 기다림에 지쳐 \n졸기 시작했다.";
                mesh.text = "The angler was exhausted from the wait and began to sleep.";
                break;
            case 14:
                mesh.text = "\"하...이제 일어나야지\"";
                mesh.text = "\"Ha ... should get up now\"";
                break;
            case 15:
                mesh.text = "옛날에 이런 이야기를 들은적이 있었다.";
                mesh.text = "Long ago,I once heard that story.";
                break;
            case 16:
                mesh.text = "- \"그런데, 난 누군가와 헤어져 \n낚시바늘을 기다리는 물고기 꼴이라니 ㅋㅋ\"";
                mesh.text = "- \"By the way,\nI split up with somebody\n and wait for a fishing needle....\"";
                break;
            case 17:
                mesh.text = "헤어진지 4일이 지났지만, \n아직도 후유증이 가시지 않았다.";
                mesh.text = "Four days after it broken up,\nthere was still,\nthe aftereffects did not improve.";
                break;
            case 18:
                mesh.text = "배고픈것을 핑계로 집을 나섰다.";
                mesh.text = "I came out of my house with a hungry excuse.";
                break;
            case 19:
                mesh.text = "4일전부터 모든것이 흑백으로 보인다.";
                mesh.text = "From 4 days ago everything looks black and white.";
                break;
            case 20:
                mesh.text = "이제 나에게 올 편지도 없지만 수시로 통을 확인했다.";
                mesh.text = "I know i do not have any letter for me anymore,\nbut I checked the mailbox every so often.";
                break;
            case 21:
                mesh.text = "- \"혹시나, 만날 수 있을까...\"";
                mesh.text = "- \"I wonder if I'll ever meet you....\"";
                break;
            case 22:
                mesh.text = "허나, 이 망상의 끝은 허무함뿐이다.";
                mesh.text = "However,\nthe end of this delusion is only vanity.";
                break;
            case 23:
                mesh.text = "그렇지만, 늘 그랬듯 태초호수로 향했다.";
                mesh.text = "But, as always,\nI went to Lake Taecho.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            ////////////////////////////////////////
            case 24:
                mesh.text = "호수길로 가는 길, 친구를 만났다.";
                mesh.text = "On the way to the lake road,\nI met a friend.";
                break;
            case 25:
                mesh.text = "연락한지 좀 된 친구였지만, \n그 친구는 나를 반가워하며 근처 식당가로 대려갔다.";
                mesh.text = "He was a friend he had seen for a long time,\nThe friend welcomed me and went to a nearby restaurant.";
                break;
            case 26:
                mesh.text = "- (호수는 나중에 가지 뭐.)";
                mesh.text = "- (I'll go to the lake later.)";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            //////////////////////////////////////////
            case 27:
                mesh.text = "친구는 식당에서 그 동안 \n뭐 하며 지냈냐며 상당히 밝아보였다.";
                mesh.text = "At the restaurant,\nMy friend looked quite cheerful, \nsaying, \"How have you been?\"";
                break;
            case 28:
                mesh.text = "가끔 그 친구를 보다보면 \n흑백의 삶이 점차 다채로워진다.";
                mesh.text = "Sometimes when I look at him,\n my black and white life becomes more colorful.";
                break;
            case 29:
                mesh.text = "허나, 그것도 잠시 내 삶의 흑백은 \n아무도 관여하지 못할것 같다.";
                mesh.text = "However, it seems that nobody can get involved in \nthe black and white of my life for a while.";
                break;
            case 30:
                mesh.text = "식당에서 30분쯤 있었을까,\n친구 전화로 전화가 왔다.";
                mesh.text = "About 30 minutes in the restaurant, \nhe got a phone call from his friend.";
                break;
            case 31:
                mesh.text = "그 친구는 급하다며 먼저 자리를 떴다.";
                mesh.text = "The friend said that he was in a hurry and left first.";
                break;
            case 32:
                mesh.text = "- (ㅅㅂ.... 계산은 내가 하냐...)";
                mesh.text = "- (shit...... am I paying......)";
                PlayerPrefs.SetInt("namjufriend", 0);
                break;
            case 33:
                mesh.text = "흑백 삶이 곧 암흑 속 으로 \n떨어질 처지이다.";
                mesh.text = "Black-and-white life is about to fall into darkness.";
                break;
            case 34:
                mesh.text = "계산을 하려고 나가려는 찰나,";
                mesh.text = "It began to rain at the moment that ";
                break;
            case 35:
                mesh.text = "비가 오기 시작했다.";
                mesh.text = "I was going to pay the bill.";
                PlayerPrefs.SetInt("rain", 1);
                break;
            case 36:
                mesh.text = "이런 날 비라니 더 어두워져 갔다.";
                mesh.text = "It was getting darker on this day.";
                break;
            case 37:
                mesh.text = "이제 호수라도 가볼까....";
                mesh.text = "Let's go to the lake now ....";
                break;
            case 38:
                mesh.text = "우산이 없었기에 전화기를 꺼내 \n형에게 전화를 걸었다.";
                mesh.text = "I took out my phone and called my brother\n because I didn't have an umbrella.";
                break;
            case 39:
                mesh.text = "몇 분을 기다리자 형은 우산을 들고왔고, \n형은 아무렇지 않다는듯 식당으로 들어가 \n몇몇의 음식을 주문했다.";
                mesh.text = "After waiting a few minutes,\n my brother came with an umbrella, \nand he went into the restaurant and ordered some food.";
                break;
            case 40:
                mesh.text = "우산을 피고 호수 쪽으로 가려했지만, \n설상가상으로 호수 쪽 가로수길이 \n공사를 하여 한 바퀴 돌아가야한다.";
                mesh.text = "I tried to go to the lake with an umbrella,\n but to make it worse, \nThe road to the lake is under construction\n and should be turned around.";
                break;
            case 41:
                mesh.text = "호수에 갈 필요가 없지만,\n항상 호수를 들렸으니, 오늘도 가야했다.";
                mesh.text = "I didn't have to go to the lake,\n but I had to go today because I always went to the lake.";
                break;
            case 42:
                mesh.text = "그냥 호수쪽 무언가가 내 본능에 촛농을 떨어뜨렸다.";
                mesh.text = "I just wanted to go to the lake for no reason.";
                PlayerPrefs.SetInt("cryingbaby", 1);
                PlayerPrefs.SetInt("fadeout", 1);
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 43:
                mesh.text = "가로수길 5 분을 걸었을까, \n비오는날 한아이가 흠뻑젖은채 \n엄마를 찾고 있었다.";
                mesh.text = "When I was walking a boulevard for a few minutes,\nOn a rainy day a child was drenched and looking for mom.";
                break;
            case 44:
                mesh.text = "그 아이의 처지가 꼭 누군가와 닮아 다가갔다.";
                mesh.text = "The child 's situation was similar to someone.";
                break;
            case 45:
                mesh.text = "도와주기는 싫었는데 그냥 가까이 가고 싶었을 뿐인데,우는 아이가 나에게 다가가 또 울음을 터뜨렸다.";
                mesh.text = "I did not want to help but I just wanted to get close,\n and a crying child approached me and burst into tears.";
                break;
            case 46:
                mesh.text = "호수가는건 나중으로 미루고 \n이 아이좀 도와줘야겠다.";
                mesh.text = "I'll put off going to the lake later and help him.";
                break;
            case 47:
                mesh.text = "아이에게 물어보았다.";
                mesh.text = "I asked the child.";
                break;
            case 48:
                mesh.text = "- \"혹시, 길을 잃었니?\"";
                mesh.text = "- \"By any chance, did you get lost?\"";
                break;
            case 49:
                mesh.text = "그 아이는 내가 방금 있었던 \n식당가에서 길을 잃었다고 한다.";
                mesh.text = "The child says I got lost around the restaurant \nwhere I just stayed.";
                break;
            case 50:
                mesh.text = "그 아이와 손을 잡고 아이의 엄마를 \n찾으려고 돌아다녔다.";
                mesh.text = "I held hands with the child \nand went around looking for his mother.";
                break;
            case 51:
                mesh.text = "찾으러 돌아다니는 중, \n그 아이와 많은 이야기를 나누었다.";
                mesh.text = "While I was going around looking for his mother, \nI talked a lot with him.";
                break;
            case 52:
                mesh.text = "- \"어떻게 길을 잃었니?\"";
                mesh.text = "- \"How did you get lost?\"";
                break;
            case 53:
                mesh.text = "- \"훌쩍...엄마랑 싸우다....\n훌쩍...반댓길로 다니다...ㅠㅠ\"";
                mesh.text = "- \"Fight with my mom...\ntravel on an opposite path...;-;\"";
                break;
            case 54:
                mesh.text = "- \"그렇다고 반대로 돌아가니....\"";
                mesh.text = "- \"Why the opposite....\"";
                break;
            case 55:
                mesh.text = "그냥 이 아이와 이야기하는 것이 재밌기 보다는 이 아이의 처지가 매우 누군가와 비슷했을 뿐이다.";
                mesh.text = "It's not funny talking to this kid,\nJust this child is very similar to someone.";
                break;
            case 56:
                mesh.text = "이 아이와 걷는 거리는 차가웠지만 \n쥐고 있는 손은 따듯했다.";
                mesh.text = "The child's walking street was cold,\n but his hands were warm.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                PlayerPrefs.SetInt("mom", 1);
                PlayerPrefs.SetInt("cryingbaby", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 57:
                PlayerPrefs.SetInt("findbaby", 1);
                mesh.text = "얼만큼을 걸었을까, 식당가 앞에서 \n그의 어머님을 만났다.";
                mesh.text = "how many long I walked, \nI met his mother around the restaurant.";
                break;
            case 58:
                mesh.text = "결국 그 식당가 앞에 다시 돌아왔고 그 아이의 어머니는 나에게 감사하다며 울먹였지만,";
                mesh.text = "Finally, I came back around the restaurant\n and her mother cried, \"Thank you.\"";
                break;
            case 59:
                mesh.text = "나는 그 말에 신경쓰지 않았다.";
                mesh.text = "I didn't care about that.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                PlayerPrefs.SetInt("bus_story", 1);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 60:
                mesh.text = "식당 안을 들여다 보았다. \n형은 만두 몇 개를 먹고있었다.";
                mesh.text = "I looked into the restaurant.\n My brother was eating some dumplings.";
                break;
            case 61:
                mesh.text = "그 옆엔 두 커플이 사이좋게 밥을 먹고 있었다.";
                mesh.text = "Next to him,\n two couples were eating well together.";
                break;
            case 62:
                mesh.text = "그냥 아무렇지도 않게 왔다갔을뿐, \n이 식당가는 나의 여자친구가 많이 왔었던 곳이다.";
                mesh.text = "This restaurant is where my girlfriend visited a lot.";
                break;
            case 63:
                mesh.text = "이 곳에 들리진 않았을까 \n그냥 왠지 모르게 가게 안에서는 \n그녀의 향수 냄새가 배여있었다.";
                mesh.text = "maybe she visited here,\nSomehow her perfume smelled inside the store.";
                break;
            case 64:
                mesh.text = "멍하니 식당을 얼마나 보았을까, \n형은 만두를 먹는 도중 나와 눈이 마주쳤다.";
                mesh.text = "How many times did I see the restaurant,\nMy brother ran into me while eating dumplings.";
                break;
            case 65:
                mesh.text = "형은 아까부터 지금까지 \n내가 기다린줄 아는 것 같다.";
                mesh.text = "My brother seems to think I've been waiting.";
                break;
            case 66:
                mesh.text = "나는 그냥 무시하고, \n다시 호수 쪽으로 걸었다.";
                mesh.text = "I just ignored it and walked back to the lake.";
                break;
            case 67:
                mesh.text = "그런데 같은 길 가는게 얼마나 지겨운지 얼마 안 되는 거리를 버스를 타기 위해 \n버스 정류장에서 버스를 기다렸다.";
                mesh.text = "By the way, I waited for a bus from the bus stop\n to take a bus for a few miles \nbecause it was boring to go the same way.";
                break;
            case 68:
                mesh.text = "이 정류장도 그녀의 집을 바래다 주기 전, \n같이 기다렸던 곳.........";
                mesh.text = "This stop is where \nI waited with her before she took her home.........";
                break;
            case 69:
                mesh.text = "이 곳도 왠지 모르게 \n그녀의 향수 냄새가 깊게, \n아주 깊게 베여있었다.";
                mesh.text = "This place smelled of her perfume\n deep and deep, somehow.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 70:
                mesh.text = "버스가 도착하자, 버스에 올라타, 카드를 찍었다. 운전기사 아저씨를 힐끔 보았다.";
                mesh.text = "When the bus arrived, \nI got on the bus and took a card. \nI glanced at the driver's uncle.";
                break;
            case 71:
                mesh.text = "어라? 어디서 본 얼굴인데, 맨 뒤에서 3 번째 창가 자리에 앉았다.";
                mesh.text = "What? I saw her face from somewhere, \nand she sat at the back of the window for the third time.";
                break;
            case 72:
                mesh.text = "백미러로 힐끔힐끔 운전기사 아저씨를 보았는데,";
                mesh.text = "I saw the driver in the rearview mirror.";
                break;
            case 73:
                mesh.text = "정말 우연인지 여자친구가 버스를 탈때 보았던 그 운전 기사 아저씨였다.";
                mesh.text = "It was accidently the driver \nwhom I saw when I got on the bus \nwith my girlfriend former days.";
                break;
            case 74:
                mesh.text = "심지어 버스 안 에서도 버디 향수가 곳곳에 퍼져있었고 내 창가자리 옆에는 아무도 없었다.";
                mesh.text = "Even in the bus, \nthere were perfume of Buddy everywhere \nand no one was by my window seat.";
                break;
            case 75:
                mesh.text = "2번째 정류장, 한 할머니가 탔다.";
                mesh.text = "At the second stop, \nan old lady got on.";
                break;
            case 76:
                mesh.text = "그 할머니는 목적지가 아마 이 전 정류장인데, 잘못 타신것 같았다.";
                mesh.text = "The grandmother may have her destination \nat this former stop,\n but she was on the wrong ride.";
                break;
            case 77:
                mesh.text = "하지만, 아무 말 하고 싶지 않았다.";
                mesh.text = "However, I didn't want to say anything.";
                break;
            case 78:
                mesh.text = "그냥..... 누군가가 헤매인다는 것을 도와주지 않고 있으면 그 상황이 궁금하달까....";
                mesh.text = "I just... I wonder what \nhappens if I let someone wander.";
                break;
            case 79:
                PlayerPrefs.SetInt("bus_story", 0);
                //mesh.text = "3 번째 정류장에 도착한 후 내렸다.";
                mesh.text = "I arrived at the third stop and got off.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                SceneManager.LoadScene(9);
                PlayerPrefs.SetInt("fadeout", 1);

                //////////////////////////////////////
                PlayerPrefs.SetInt("namjufriend", 1);
                break;
            case 80:
                mesh.text = "사실, 호수 쪽은 2 번쨰 정류장이 가깝지만, 왠지 오래 걷고 싶었다.";
                mesh.text = "Actually, the second stop in the lake is close,\n but I wanted to walk for a long time.";
                break;
            case 81:
                mesh.text = "\'쏴아아아아아아--\'";
                mesh.text = "\'The rain pours down in a torrent\'";
                break;
            case 82:
                mesh.text = "흑백 삶에 하얀 빗 줄기 엄청난 고독을 느꼈다.";
                mesh.text = "I felt a great loneliness in \nblack and white with white rain in my life.";
                break;
            case 83:
                mesh.text = "시간이 늦어도 집에 갈건 아니지만, 핸드폰 시간을 확인했다.";
                mesh.text = "I won't go home late, \nbut I checked my cell phone time.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 84:
                mesh.text = "오후 3시..... 3시 치곤 먹구름때문에 어두웠다.";
                mesh.text = "3 p.m...... 3 p.m. was dark because of black cloud.";
                break;
            case 85:
                mesh.text = "길을 걷다가 거센 바람에 의해 우산이 망가졌고, 그냥 비를 맞은채 걸어갔다.";
                mesh.text = "While walking along the road, \nthe umbrella was destroyed by the strong wind, \nand just walked in the rain.";
                break;
            case 86:
                mesh.text = "한 물고기의 무리에서 벗어나온 한 물고기같은 느낌이 들었다.";
                mesh.text = "I felt like a fish out of a pack of fish.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 87:
                mesh.text = "걷는 도중 방금전 만난 친구를 만났다.";
                mesh.text = "I met a friend I had just met while I was walking.";
                break;
            case 88:
                mesh.text = "그 친구는 과자 한 봉지를\n사고 집을 가는길 같았다.";
                mesh.text = "He looked like he was going home \nafter buying a bag of cookies.";
                break;
            case 89:
                mesh.text = "급한 일이라더니.. 계산을 떠맡겼네.\n참신한 개XX.";
                mesh.text = "I heard it was urgent.... \nI've taken care of the bill.... shit...";
                break;
            case 90:
                mesh.text = "그 친구와 같이 걸었다. \n계산을 둘째치고 진지한 이야기를 나누고 싶은 마음이였던 걸까,";
                mesh.text = "I walked with the friend. \nI think he wanted to have a serious talk.";
                break;
            case 91:
                mesh.text = "나의 사정을 말하자, 친구는 그런 일이 있으면 말을 하지!";
                mesh.text = "When I tell my friend my story,\n he said \"You should have told me if that happened!\"";
                break;
            case 92:
                mesh.text = "라는 표정을 지으며 갈 곳이 있다며 어디론가 데려갔다.";
                mesh.text = "My friend took me somewhere.";
                PlayerPrefs.SetInt("fadein", 1);
                yield return new WaitForSeconds(2f);
                break;
            case 93:
                mesh.text = "정신 차려보니 포장마차.\n이런 늦 오후에도, 어두우니 포장마차도 문을 열였다."; 
                mesh.text = "Even in this late afternoon, \nthe food stall opened.";
                break;
            case 94:
                mesh.text = "그 친구는 술을 따르며 말 같지도 않은 이야기를 들려 주었다.";
                mesh.text = "The friend gave me a drink \nand told me an unspeakable story.";
                break;
            case 95:
                mesh.text = "\"있잖아....딸꾹...낚시꾼이 왜 그 물고기를 보고 멍하니 서있었을까?\"";
                mesh.text = "\"You know... hiccups...\nWhy did the fisherman stand blank at the sight of the fish?\"";
                break;
            case 96:
                mesh.text = "\"그냥 닥치고 있어 줄래\"";
                mesh.text = "\"Just shut up.\"";
                break;
            case 97:
                mesh.text = "\"아냐아냐..들어봐\"";
                mesh.text = "\"No, no, listen.\"";
                break;
            case 98:
                mesh.text = "\"말해\"";
                mesh.text = "\"Tell me\"";
                break;
            case 99:
                mesh.text = "\"나 같았으면 그 물고기를 건져 한 잔하는 건데...\"";
                mesh.text = "\"If it was me, \nI'd get that fish and have a drink...\"";
                break;
            case 100:
                mesh.text = "\"하...나 갈게\"";
                mesh.text = "\"Ha... I'm going.\"";
                break;
            case 101:
                mesh.text = "친구는 진짜 도움이 안된다.";
                mesh.text = "Friend is really not helpful.";
                break;
            case 102:
                mesh.text = "\"어이!어이!, 내 말은 낚시꾼은 낚시만 하지않아....\"";
                mesh.text = "\"Hey! Hey! I mean, anglers don't just fish....\"";
                break;
            case 103:
                mesh.text = "\"그 낚시꾼이 물고기를 잡고 싶었으면 미끼 없는 낚시바늘을 던졌을까?....잘가라\"";
                mesh.text = "\"If the angler wanted to catch the fish, \nwould he have thrown the hook without bait?Goodbye.\"";
                PlayerPrefs.SetInt("namjufriend", 0);
                break;
            case 104:
                PlayerPrefs.SetInt("CHAR_MOVE_ACTIVE", 1);
                PlayerPrefs.SetFloat("CH_X", 24);
                PlayerPrefs.SetFloat("CH_Y", -15.7f);
                PlayerPrefs.SetInt("fadeout", 1);
                mesh.text = "그냥 무심코 던진 말인줄알고 무시했지만, 들으면 들을 수록 이 말같지 않은 말에 의문을 가졌다.";
                mesh.text = "I thought it was just a slip of the tongue and ignored it, \nbut the more I heard it, the more I questioned it.";
                break;
            case 105:
                mesh.text = "\'낚시꾼이 잡히지 않을걸 알면서도 낚시바늘을 던진이유??\'";
                mesh.text = "\'Reason Why did he throw his hook \nwhen he knew wouldn't get caught??\'";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                PlayerPrefs.SetInt("ribble", 1);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 106:
                mesh.text = "나는 이 의문을 가지며 호수로 향했다.";
                mesh.text = "I headed for the lake with this question.";
                break;
            case 107:
                mesh.text = "호수를 거의 다 와가는데, 옆집 누나가 나를 불렀다.";
                mesh.text = "When I almost arrived at the lake, \nI met a sis.";
                break;
            case 108:
                mesh.text = "병신같지만 걱정은 잘 들어주는 누나이다.\n그 누나는 반갑다며 달려오다";
                mesh.text = "She seems like a moron, \nbut She is a sister who listens to her troubles well.";
                PlayerPrefs.SetInt("ribble_getdown", 1);
                break;
            case 109:
                mesh.text = "물 웅덩이에 미끄러져 넘어졌다.";
                mesh.text = "The sister came running for joy and slipped \nand fell in a pool of water.";
                break;
            case 110:
                mesh.text = "그 누나에게 다가갔지만, 쪽팔린건지 그냥 도망갔다.";
                mesh.text = "I approached the sister, \nbut she was embarrassed and just ran away.";
                break;
            case 111:
                mesh.text = "물 웅덩이쪽에 누나의 향수가 떨어졌다.";
                mesh.text = "sister's perfume fell on the a pool of water.";
                PlayerPrefs.SetInt("ribble", 0);
                break;
            case 112:
                mesh.text = "누나에게 갖다 주어야 하지만, 그냥 한 번 뿌려보았다.";
                mesh.text = "I had to give it to my sister,\n but I just sprayed it.";
                break;
            case 113:
                mesh.text = "냄새는 독했다. 그냥 향수를 뿌린거였지만, 왠지 모르게 눈물이 났다.";
                mesh.text = "The smell was strong. \nI just sprayed perfume, but somehow I burst into tears.";
                break;
            case 114:
                mesh.text = "\"이 향.... 많이 좋아했던 향인거 같았는데..\"";
                mesh.text = "\"This scent... it must have been my favorite flavor..\"";
                break;
            case 115:
                mesh.text = "그냥 이 향수가 좋은건 아니였지만 세 번 뿌리고 가방에 넣었다.";
                mesh.text = "This perfume was not good, \nbut I sprinkled it three times and put it in my bag.";
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 116:
                mesh.text = "갑작스레 엄마한테 전화가 왔다.";
                mesh.text = "Suddenly, my mom called me.";
                break;
            case 117:
                mesh.text = "\"어,영빈이니? 반찬주려고 들렸는데 없네?!\"\n지금 반찬두고 오늘길ㅇ...!!!!!!!!";
                mesh.text = "\"Hey, Son?I stopped by to give you a side dish,\n but you're not here?!\"\nI'm on my way to dinner....!!!!!!!!";
                break;
            case 118:
                mesh.text = "\"아 맞다!! 가스불을 안껐네!! 어쩌지\"";
                mesh.text = "\"Oh, right! \nI didn't put out a gas gas! What should I do...\"";
                break;
            case 119:
                mesh.text = "하.. 집에 다시 돌아가야겠다.\n뭐 잘된거일 수 도 있다.";
                mesh.text = "Ha... I have to go back home.\nIt could be a good thing.";
                PlayerPrefs.SetInt("fadeout", 1);
                SceneManager.LoadScene(5);
                yield return new WaitForSeconds(2f);
                break;
            case 120:
                mesh.text = "집에 가는길 호수 옆 쪽으로 피해서 갔다.";
                mesh.text = "On my way home, \nI took a long way from the lake.";
                PlayerPrefs.SetInt("fadeout", 1);
                SceneManager.LoadScene(4);
                yield return new WaitForSeconds(2f);
                break;
            case 121:
                mesh.text = "그냥 호수를 가고 싶은 마음이 아니였다.";
                mesh.text = "I just didn't mean to go to the lake.";
                PlayerPrefs.SetInt("fadeout", 1);
                SceneManager.LoadScene(2);
                yield return new WaitForSeconds(2f);
                break;
            case 122:
                mesh.text = "\"지금 뭐하고 있을까 ? \"";
                mesh.text = "\"What are you doing now? \"";
                break;
            case 123:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "그냥 나만 이러는것 같아 슬펐다.";
                mesh.text = "I was sad that I was just doing this.";
                PlayerPrefs.SetInt("returnHome", 1);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);

                break;
            case 124:
                mesh.text = "집에 도착하려던 중 옆집누나가 씻고 나온것 같았다.";
                mesh.text = "I was about to get home when sister washed up.";
                break;
            case 125:
                mesh.text = "\"어이! 뭐하냐!ㅋㅋㅋ!!\"";
                mesh.text = "\"Hey! What are you doing?Haha!!\"";
                break;
            case 126:
                mesh.text = "누나는 정신을 차리고 철없이 웃으며 다가왔다.";
                mesh.text = "sister came to me with a smile.";
                break;
            case 127:
                mesh.text = "\"혹시, 향수 못 봤니?\"";
                mesh.text = "\"By any chance, \nhave you seen any perfume?\"";
                break;
            case 128:
                mesh.text = "\"이거 ??\"";
                mesh.text = "\"This ??\"";
                break;
            case 129:
                mesh.text = "\"아 너가 찾았구나!ㅎㅎ 다른건 없고 너 오늘 생일이잖아.\"";
                mesh.text = "\"Ah, you found it!\nThere is nothing else, you are birthday today.\"";
                break;
            case 130:
                mesh.text = "\"여자들이 좋아한다는 향수야, 가져ㅋㅋㅋㅋ\"";
                mesh.text = "\"It is perfume that women like, take it.\"";
                break;
            case 131:
                mesh.text = "\'?생일??\'";
                mesh.text = "\'?My birthday..??\'";
                break;
            case 132:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "생일은 아니였지만, 향수가 맘에 들어 끄덕였다.";
                mesh.text = "It was not my birthday, \nbut I nodded because I liked the perfume.";
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 133:
                PlayerPrefs.SetInt("fadein", 1);
                mesh.text = "집에 도착후, 가스불을 끄고\n엄마가 쌓아놓고 간 도시락을 보았다.";
                mesh.text = "After arriving home, \nI turned off the gas \nand saw the lunch box my mom had piled up.";
                yield return new WaitForSeconds(2f);
                break;
            case 134:
                mesh.text = "그냥...여자친구가 해준 도시락을\n잠시 떠올렸을 뿐이다.";
                mesh.text = "I just remembered a lunch box that\n my girlfriend gave me.";
                break;
            case 135:
                mesh.text = "집을 나서니, 왠지 모르게 \n버버리 버디향이 깊숙히 베어 들었다.";
                mesh.text = "When I left home, \nsomehow I cut deep into Burberry Buddy.";
                break;
            case 136:
                mesh.text = "시간이 좀 지났다. 호수는 \n항상 아침에 갔는데, 밤에 가게 생겼다.";
                mesh.text = "It's been a while. \nThe lake always went in the morning,\n but I think I will go there tonight.";
                PlayerPrefs.SetInt("ribble", 1);
                break;
            case 137:
                PlayerPrefs.SetInt("fadeout", 1);
                mesh.text = "누나가 집 앞에서 기다리고 있었다.\n그 누나는 손을 잡으며 놀러가자고 했다.";
                mesh.text = "sister was waiting in front of my house.\nThe sister held hands to go out.";
                yield return new WaitForSeconds(2f);
                break;
            case 138:
                mesh.text = "\"비오는데 뭘 놀아\"";
                mesh.text = "\"Even though it's raining...?\"";
                break;
            case 139:
                mesh.text = "하지만 누나는 급히 어딘가로 향했다.";
                mesh.text = "But my sister hurried somewhere.";
                break;
            case 140:
                mesh.text = "\'그래, 호수는 나중에 슬슬 가지,뭐\'";
                mesh.text = "\'Ok..., the lake goes away slowly...\'";
                break;
            case 141:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "누나는 나를 데리고 쇼핑몰로 향했다.";
                mesh.text = "sister took me to the shopping mall.";
                PlayerPrefs.SetInt("rain", 0);
                SceneManager.LoadScene(10);
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 142:
                mesh.text = "\'아나... 놀자고 한게 쇼핑인가\'";
                mesh.text = "\'what...Playing was shopping.\'";
                break;
            case 143:
                mesh.text = "이 누나는 옷을 사야한다며\n여성의류 쪽으로 갔다.";
                mesh.text = "sister went to the women's clothing department \nto buy clothes.";
                break;
            case 144:
                mesh.text = "\"어때?? 이거 이쁘지?\"";
                mesh.text = "\"How is it? Is it pretty?\"";
                break;
            case 145:
                mesh.text = "\"아니\"";
                mesh.text = "\"No\"";
                break;
            case 146:
                mesh.text = "\"그럼 이건??\"";
                mesh.text = "\"Then this??\"";
                break;
            case 147:
                mesh.text = "\"와 별로다\"";
                mesh.text = "\"Umm....Not good.\"";
                break;
            case 148:
                mesh.text = "\"이건 어때\"";
                mesh.text = "\"How about this one\"";
                break;
            case 149:
                mesh.text = "\"오~ 존나~ 별론데~\"";
                mesh.text = "\"Oh~ That's really not good~!\"";
                break;
            case 150:
                mesh.text = "결국 두 대정도 맞고 옷을 골랐다.";
                mesh.text = "Eventually, he was beaten two times and chose clothes.";
                break;
            case 151:
                mesh.text = "\"뭐, 너는 살거 없어?\"";
                mesh.text = "\"Umm.., do you have anything to buy?\"";
                break;
            case 152:
                mesh.text = "\"응, 관심이 없어\"";
                mesh.text = "\"Yeah, I'm not interested.\"";
                break;
            case 153:
                mesh.text = "호수에 빨리 가고 싶은 마음이었다.";
                mesh.text = "I wanted to go to the lake quickly.";
                break;
            case 154:
                mesh.text = "\"그럼, 여기 식당가 가자!!\"";
                mesh.text = "\"Then, let's go to the restaurant here!\"";
                break;
            case 155:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "배고프진 않았지만 그냥 따라갔다.";
                mesh.text = "I wasn't hungry, but I just followed.";
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 156:
                mesh.text = "식당가 가는길 펀치기계에서 신기록을 깨면";
                mesh.text = "Several couples lined up on the way to the restaurant,";
                break;
            case 157:
                mesh.text = "엄청난 상품을 준다며 여러명의 커플들이 줄을 섰다.";
                mesh.text = "saying that breaking a new record in the punching machine \nwould give a great deal of prize.";
                break;
            case 158:
                mesh.text = "\'하나님, 제발 누나가 이 광경을 무시했으면...\'";
                mesh.text = "\'God, please,I wish sister would ignore this sight....\'";
                break;
            case 159:
                mesh.text = "\"어머! 저게뭐야 저거 해보자!!\"";
                mesh.text = "\"Oh! What is that? Let's do that!!\"";
                break;
            case 160:
                mesh.text = "ㅅㅂ";
                mesh.text = "Shit";
                break;
            case 161:
                mesh.text = "\"으라차차!!!!\"";
                mesh.text = "\"Urracha!!!!\"";
                break;
            case 162:
                mesh.text = "많은 남성들이 여자친구 옆에서 멋진 척을 했지만 ";
                mesh.text = "Many men pretended to be cool next to their girlfriend, ";
                break;
            case 163:
                mesh.text = "2000점을 넘지 못하고 돌아갔다.";
                mesh.text = "They did not pass the 2,000 mark.";
                break;
            case 164:
                mesh.text = "\'어쩌지 나 힘 약한데...ㅠ\'";
                mesh.text = "\'What should I do?.... I'm weak.\'";
                break;
            case 165:
                mesh.text = "우리 차례 바로 앞에 건강한 남성과 여성의 커플이 있었다.";
                mesh.text = "There was a healthy man-woman couple \nright before our turn.";
                break;
            case 166:
                mesh.text = "\"X됐네\"";
                mesh.text = "\"I'm doomed.\"";
                break;
            case 167:
                mesh.text = "건강한 남성의 차례가 되었다.";
                mesh.text = "It was the turn of a healthy man.";
                break;
            case 168:
                mesh.text = "\"으라차차차!!!\"";
                mesh.text = "\"Aaracha!!!\"";
                break;
            case 169:
                mesh.text = "엄청났다.";
                mesh.text = "It was awesome.";
                break;
            case 170:
                mesh.text = "2237점인것 같았다.";
                mesh.text = "It was like 2237 points.";
                break;
            case 171:
                mesh.text = "\"누나...돌아가요....\"";
                mesh.text = "\"Pls...Go back...\"";
                break;
            case 172:
                mesh.text = "\"누구 맘대로오오오오!!\"";
                mesh.text = "\"with whose permission!!\"";
                break;
            case 173:
                mesh.text = "사회자: 네 ~ 다음 커플 나오세요.";
                mesh.text = "event host: Yes, the next couple.";
                break;
            case 174:
                mesh.text = "\'하 ㅠㅠ\'";
                mesh.text = "\'noooooo.....\'";
                break;
            case 175:
                mesh.text = "오른팔 소매를 걷으려던 찰나 ";
                mesh.text = "Just as I was trying to walk my right arm sleeve,";
                break;
            case 176:
                mesh.text = "누나가 펀치기계에 주먹을 날린 것이다!";
                mesh.text = "sister threw a punch at the punching machine!";
                break;
            case 177:
                mesh.text = "사회자: 3200점!!! 역대 신기록입니다!!!";
                mesh.text = "event host: 3200! It's a new record!!!";
                break;
            case 178:
                mesh.text = "?";
                mesh.text = "?";
                break;
            case 179:
                mesh.text = "\"봤지? 뭘 자꾸 가자그래...\"";
                mesh.text = "\"See? Why did you just keep telling me to go?...\"";
                break;
            case 180:
                mesh.text = "\"그래서 상품이 뭐요?!?\"";
                mesh.text = "\"So what is the product?!\"";
                break;
            case 181:
                mesh.text = "사회자: 무료 식당권 2 개요.";
                mesh.text = "event host: Free restaurant tickets 2 overview.";
                break;
            case 182:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "\"ㅇㅋ\"";
                mesh.text = "\"Ok\"";
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 183:
                mesh.text = "엄청난 괴력(?)에 의해 우린 \n식당가에서 밥을 먹었다.";
                mesh.text = "We ate at a restaurant \nbecause of she's great power.";
                break;
            case 184:
                mesh.text = "하지만, 난 호수에 빨리 \n가고싶어 발을 동동 굴렀다.";
                mesh.text = "However, I wanted to go to the lake quickly.";
                break;
            case 185:
                mesh.text = "\"어때? 이집 맛있지?\"";
                mesh.text = "\"How do you like it? Is it delicious?\"";
                break;
            case 186:
                mesh.text = "\"어..네네..\"";
                mesh.text = "\"Uh..ok..\"";
                break;
            case 187:
                mesh.text = "파스타를 먹으면서 여자친구가 \n좋아했던 까르보나라가 생각났다.";
                mesh.text = "While eating pasta, \nI remembered Carbonara that my girlfriend liked.";
                break;
            case 188:
                mesh.text = "그리고 왠지 모르게 ";
                mesh.text = "And somehow,";
                break;
            case 189:
                mesh.text = "버버리 버디 향수 냄새가 \n식당안 곳곳에 깊게 물들여졌다.";
                mesh.text = "the smell of Burberry Buddy's perfume was \ndeeply smeared \nall over the restaurant.";
                break;
            case 190:
                mesh.text = "\"아~! 좋다~~ 이제 일어날까?!!\"";
                mesh.text = "\"Ah! Good! Shall we go now?!!\"";
                PlayerPrefs.SetInt("returnHome", 0);
                break;
            case 191:
                mesh.text = "여자친구 생각 후로 입에 맞지 않아\n반쯤 남기고 자리를 떴다..";
                mesh.text = "After thinking about my girlfriend, \nI left half the food.";
                break;
            case 192:
                mesh.text = "\"야!내가 준 향수 좀 뿌려!\"";
                mesh.text = "\"Hey! Spray some perfume I gave you!\"";
                break;
            case 193:
                mesh.text = "\"아.. 하하 알겠어요...\"";
                mesh.text = "\"oh..haha, ok...\"";
                break;
            case 194:
                mesh.text = "두 번쯤 뿌리고 누나는\n만족했다는듯 롯데몰을 나갔다.";
                mesh.text = "Sprinkle with it about twice, \nand sister went out of the shopping mall \nas if she was satisfied.";
                break;
            case 195:
                mesh.text = "\"이제... 집에 가야겠지??\"";
                mesh.text = "\"Now... we should go home, right??\"";
                break;
            case 196:
                mesh.text = "\"아 네 ㅎㅎ 재밌었어요!\"";
                mesh.text = "\"Oh yes, it was fun!\"";
                break;
            case 197:
                mesh.text = "\"나도~, 고맙다\"";
                mesh.text = "\"Me too. Thank you.\"";
                break;
            case 198:
                mesh.text = "\"집에 가는길 호수길로 같이 갈래??\"";
                mesh.text = "\"Do you want to go to \nthe lake road on your way home?\"";
                break;
            case 199:
                mesh.text = "듣던 소리중 가장 반가운 소리였다.";
                mesh.text = "It was the most pleasant sound I've ever heard.";
                break;
            case 200:
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "\"그래요...가요!\"";
                mesh.text = "\"Yeah... Go!\"";
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 201:
                PlayerPrefs.SetInt("fadeout", 1);
                SceneManager.LoadScene(8);
                mesh.text = "밤 10시 20분, 호수길을 지나갔다.";
                mesh.text = "At 10:20 p.m., I passed the lake road.";
                /////////////////////////////////////////////////////////////////
                PlayerPrefs.SetInt("2" + "position", 0);
                yield return new WaitForSeconds(2f);
                break;
            case 202:
                mesh.text = "호수에 비쳐진 달빛을 보며 옛생각이 났다.";
                mesh.text = "The moonlight reflected on the lake \nreminded me of the past.";
                break;
            case 203:
                mesh.text = "그리 왠지 모르게 향수냄새가 피어올랐다.";
                mesh.text = "And somehow, perfume smelled.";
                break;
            case 204:
                mesh.text = "집 가는길이라 그런지,";
                mesh.text = "As I was going to my house, ";
                break;
            case 205:
                mesh.text = "호수길을 몇분정도 밖에 걷지 못했다.";
                mesh.text = "I could only walk on the lake road \nfor a few minutes.";
                yield return new WaitForSeconds(2f);
                SceneManager.LoadScene(2);
                break;
            case 206:
                PlayerPrefs.SetInt("fadeout", 1);
                mesh.text = "집 도착할때 쯤 이였을까,";
                mesh.text = "By the time I got home,";
                break;
            case 207:
                mesh.text = "\"그럼, 다음에 또 보자...!\"";
                mesh.text = "\"See you later...!\"";
                break;
            case 208:
                mesh.text = "\"안녕히가세요\"";
                mesh.text = "\"Goodbye.\"";
                break;
            case 209:
                mesh.text = "\"가기전에 그 향수 뿌려줄래?\"";
                mesh.text = "\"Will you spray that perfume before you go?\"";
                break;
            case 210:
                mesh.text = "\'아 귀찮아.\'";
                mesh.text = "\'Oh, bother.\'";
                break;
            case 211:
                mesh.text = "대충 한 번 뿌리고,";
                mesh.text = "After sprinkling roughly once,";
                break;
            case 212:
                mesh.text = "누나는 만족했다는듯 천천히 집으로 들어갔다.";
                mesh.text = "sister slowly entered the house \nas if she was satisfied.";
                PlayerPrefs.SetInt("ribble", 0);
                break;
            case 213:
                mesh.text = "나도 집에 들어가 씻고\n침대에 누워 잠시 눈을 감았다.";
                mesh.text = "I went home, washed, lay in bed, \nand closed my eyes for a while.";
                PlayerPrefs.SetInt("fadein", 1);
                yield return new WaitForSeconds(2f);
                break;
            case 214:
                mesh.text = "옛 생각을 회상하다,\n피식 웃음이 나왔다.";
                mesh.text = "think of the past,A smile came out.";
                break;
            case 215:
                mesh.text = "결국 그냥 한 편의 추억이구나 하면서.";
                mesh.text = "It's just a memory after all.";
                break;
            case 216:
                mesh.text = "하루가 피곤했는지, 잠시 눈을 붙였다.";
                mesh.text = "I slept for a while because the day was tired.";
                break;
            case 217:
                mesh.text = "그리곤 꿈을 꾸었다.";
                mesh.text = "Then I had a dream.";
                yield return new WaitForSeconds(1f);
                break;
            case 218:
                mesh.text = "낚시꾼은 그 낚시대를 두고 어디론가 사라졌다.";
                mesh.text = "The angler vanished somewhere over the rod.";
                break;
            case 219:
                mesh.text = "그리고 그 낚시대의 낚시 바늘엔\n여전히 물고기가 걸려 있었다.";
                mesh.text = "And the fishing hook of the fishing rod still caught fish.";
                break;
            case 220:
                mesh.text = "낚시꾼이 돌아오지 않자,";
                mesh.text = "The angler did not return,";
                break;
            case 221:
                mesh.text = "물고기는 자신의 살점을 뜯고 사라졌다.";
                mesh.text = "the fish grazed his flesh and disappeared.";
                break;
            case 222:
                mesh.text = "낚시꾼이 다시 돌아올때쯤,";
                mesh.text = "By the time the fisherman came back,";
                break;
            case 223:
                mesh.text = "낚시대에는 물고기가 없는것을 보고,\n다시 기다렸다.";
                mesh.text = "he saw that there was no fish on the fishing rod \nand waited again.";
                break;
            case 224:
                mesh.text = "낚시꾼도 기다림에 지쳐 졸기 시작했다";
                mesh.text = "The angler was exhausted from the wait \nand began to sleep.";
                break;
            case 225:
                mesh.text = "\'벌떡\'";
                mesh.text = "\'oh\'";
                yield return new WaitForSeconds(1f);
                break;
            case 226:
                mesh.text = "갑자기 잠에서 깨고 이러났다.";
                mesh.text = "I suddenly woke up.";
                break;
            case 227:
                mesh.text = "시간은 새벽 3시, 피곤했나 보다.";
                mesh.text = "It must have been tiring at 3 a.m.";
                break;
            case 228:
                mesh.text = "외투를 입고 잠시 외출을 하려했다.";
                mesh.text = "I tried to go out in my coat.";
                break;
            case 229:
                mesh.text = "나가기 전 뿌아죵향수를 두 번 뿌렸다.";
                mesh.text = "Before going out, \nI sprinkled the perfume twice.";
                break;
            case 230:
                PlayerPrefs.SetInt("returnHome_2", 1);
                /////////////////////
                PlayerPrefs.SetInt("fadeout", 1);
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                mesh.text = "길을 나서자, 아무도 없었고 추위만 느껴졌다.";
                mesh.text = "As I left, there was no one \nbut I could feel the cold.";
                yield return new WaitForSeconds(2f);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            case 231:
                mesh.text = "몽유병환자처럼 돌아다니다,\n다시 왠지 모르게 버버리 버디 향이 났다.";
                mesh.text = "I was walking around like a sleepwalker, \nand it smelled like Burberry Buddy again.";
                break;
            case 232:
                mesh.text = "그 향울 찾으며... 이리저리...";
                mesh.text = "Looking for the scent... \nfrom place to place...";
                break;
            case 233:
                SceneManager.LoadScene(8);
                mesh.text = "돌아다니다가 결국 도착한 곳은 '태초호수'";
                mesh.text = "Finally, we arrived at Lake Taecho.";
                yield return new WaitForSeconds(2f);
                break;
            case 234:
                mesh.text = "그냥 향에 이끌려 태초호수를 걸었다.";
                mesh.text = "The smell attracted me to the lake.";
                break;
            case 235:
                mesh.text = "아무 이유는 없었다.";
                mesh.text = "There was no reason.";
                break;
            case 236:
                mesh.text = "옆에는 달빛을 머금은 호수의 찬란한 빛.";
                mesh.text = "the glorious glow of the moonlit lake.";
                break;
            case 237:
                mesh.text = "그 빛과 내가 아는 익숙한 냄새";
                mesh.text = "the light and the familiar smell I know.";
                break;
            case 238:
                mesh.text = "그 둘에 홀려 어딘가로 향해지는 나.";
                mesh.text = "I'm led somewhere by those two thing.";
                break;
            case 239:
                mesh.text = "그리고 마주친건,\n누구가를 찾고있는 나와 유사한 누군가.";
                mesh.text = "And what I encountered was someone \nwho was similar to me looking for someone.";
                break;
            case 240:
                mesh.text = "그 누군가와 눈이 마주쳤고 멍하니 섰다.";
                mesh.text = "My eyes met with someone and I stood blank.";
                break;
            case 241:
                mesh.text = "별 이유는 없었고,\n세상이 컬러로 가득찼다.";
                mesh.text = "There was no reason, \nand the world was full of color.";
                PlayerPrefs.SetFloat("color", 0);
                PlayerPrefs.SetInt("color_ch", 1);
                break;
            case 242:
                mesh.text = "끝네,";
                mesh.text = "Finished,";
                break;
            case 243:
                //mesh.text = "나는 낚시를 멈추었다.";
                mesh.text = "I stopped fishing.";
                //StartCoroutine(CO());Escravinha gulosa
                yield return new WaitForSeconds(4f);
                SceneManager.LoadScene(12);
                PlayerPrefs.SetInt("textstop", 1);
                PlayerPrefs.SetInt("texttCo", 0);
                PlayerPrefs.SetInt("fadeout", 1);
                //yield return new WaitForSeconds(2f);
                PlayerPrefs.SetInt("ending", 1);
                bb = false;
                gamelogic.text.SetActive(false);
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(0.1f);
        bb = false;

        // }
    }
