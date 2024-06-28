﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINI_TEAM6_PROJECT_RPG_GAME
{
    public partial class Form1 : Form
    {
        public Form1(int x)
        {
            InitializeComponent();
            Monster monster = new Monster();
            string story = "";
            string CR = "";
            
            switch (x)
            {
                case 0:
                    monster = new Monster(Monster.MONTYPE.MON0);
                    CR = "0등급";
                    story = "마법의 여신 ‘미스트라’가 ‘시어릭’에게 살해당하면서 \n\n" +
                        "‘주문역병’이라는 대재앙이 발생한 후 이 정체 모를 털뭉치가 \n\n" +
                        "포가튼 렐름 전역에 나타났습니다. 평소에는 들이나 숲에 가만히 \n\n" +
                        "숨어있다가 누군가가 지나가면 우와아아하고 겁을 줍니다. \n\n" +
                        "체력:1 공력:1 골드:1 경험:1 \n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "1(0)   1(0)   1(0)   1(0)   1(0)   1(0)";
                    break;
                case 1:
                    monster = new Monster(Monster.MONTYPE.MON1);
                    CR = "1등급";
                    story = "알미라지는 부드러운 노란색 털을 가진 커다란 토끼 또는 \n\n" +
                        "토끼와 비슷했으며 일반적으로 검은색인 30Cm의 나선형 뿔이 \n\n" +
                        "이마에 유니콘 처럼 있습니다. 알미라지는 일반적으로 소심한 \n\n" +
                        "생물이었고 일부 사람들은 어리석고 예측할 수 없다고 생각했습니다. \n\n" +
                        "그러나 알미라지는 두려움이 없었습니다. 사람들은 쉽게 쓰다듬고 \n\n" +
                        "길들일 수 있었고, 그들의 주인에게 믿을 수 없을 정도로 충실했스며, \n\n" +
                        "주문 사전자들은 종종 그들을 친숙하게 만들기 위해 그들을 찾았습니다. \n\n" +
                        "강제로 싸워야 할 때, 그들은 적에게 달려들어 뿔로 찔러 매우 \n\n" +
                        "위험할 수 있습니다. 그들은 가능한 한 갈등을 피했지만, 필요한 경우 \n\n" +
                        "심각한 피해를 입힐 수도 있습니다. 알미라지는 눈에 띄지 않게 \n\n" +
                        "움직이고 적을 기습 공격하기 위해 굴을 파는 것과 같은 간단한 \n\n" +
                        "전술을 사용하여 싸울 만큼 지능적이었습니다.\n\n" +
                        "체력:2 공력:2 골드:2 경험:2\n\n" +
                        "STR   DEX    CON    INT   WIS    CHA\n\n" +
                        "2(-4) 16(+3) 10(+0) 2(-4) 14(+2) 10(+0)\n\n\n\n\n\n\n\n";
                    break;
                case 2:
                    monster = new Monster(Monster.MONTYPE.MON2);
                    CR = "2등급";
                    story = "심연의 닭은 작은 생물이었습니다. 그들은 가죽 날개를 가지고 \n\n" +
                        "있었지만 지속적으로 비행할 수는 없었습니다. 그들의 날개는 그들 \n\n" +
                        "위에 접혀 있어 눈물 모양의 모습을 보였습니다. 그들은 송곳니로 \n\n" +
                        "가득 찬 큰 입과 긴 혀를 가지고 있었습니다. 심연 닭의 주요 이동 \n\n" +
                        "형태는 두 개의 큰 다리 였으며, 그 끝의 발은 일반 닭과 \n\n" +
                        "비슷했습니다. 각 발에는 세 개의 큰 발톱이 있었습니다. 심연의 \n\n" +
                        "닭은 자신을 방어하거나 먹이를 공격하기 위해 발톱과 송곳니를 \n\n" +
                        "사용했습니다. 그들은 빠르게 달리고 날개를 사용하여 속도를 높였습니다. \n\n" +
                        "심연에 서식하는 심연의 닭은 ‘아베르누스’에서도 발견되었습니다. \n\n" +
                        "그들은 산란 나무에서 완전히 자란 채로 산란되었습니다. 나무들은 \n\n" +
                        "가지에 살이 많은 자루를 달고 있었고, 다 자라면 땅에 떨어져 \n\n" +
                        "갈라졌습니다. 심연의 닭은 사냥되어 식량으로 사용되었습니다. \n\n" +
                        "그들의 살은 기름진 닭의 맛과 똑같았습니다. 그들은 때때로 \n\n" +
                        "퍼밀리어로 사용되었습니다. \n\n" +
                        "체력:3 공력:3 골드:3 경험:3 \n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "6(-2) 14(+2)13(+1)4(-3) 9(-1) 5(-3)\n\n\n\n\n\n\n\n";
                    break;
                case 3:
                    monster = new Monster(Monster.MONTYPE.MON3);
                    CR = "3등급";
                    story = "꼬꼬댁은 혼란스러운 장난으로 락도스의 공연을 더욱 \n\n" +
                        "돋보이게 하는 작고 재잘거리는 광대입니다. 그들의 끊임없는 \n\n" +
                        "낄낄거림은 모든 것, 심지어 가장 소름끼치는 광경까지도 \n\n" +
                        "웃기는 것처럼 보이게 만들어 통제할 수 없는 웃음을 불러일으킬 \n\n" +
                        "수 있습니다. 일부 낄낄거리는 소리는 흉내내는 데 탁월합니다. \n\n" +
                        "그들은 다른 사람들의 그림자 속에 숨어 지나가는 사람들을 \n\n" +
                        "겁주어 가학적인 경향을 이용합니다. 락도스 공연자들은 다양한 \n\n" +
                        "가면, 모자, 의상을 입고 꽥꽥거리는 소리를 내며 공인을 \n\n" +
                        "풍자하는 것을 즐깁니다. 천사들이 정의의 이상을 확신하는 \n\n" +
                        "것처럼 악마도 타락한 충동, 즉 이기심, 잔인함, 증오, 탐욕, \n\n" +
                        "권력에 대한 욕망을 구현합니다. 악마는 락도스 교단과 \n\n" +
                        "밀접하게 연관되어 있습니다. 사실, 라브니카의 악마는 보로스 \n\n" +
                        "군단의 창시자가 천사를 창조한 것과 같은 방식으로 락도스에 \n\n" +
                        "의해 창조되었을 수도 있습니다. 라브니카에 살기로 선택한 \n\n" +
                        "악마 군주로서 락도스는 이 세계의 모든 악마에 대한 권위를 \n\n" +
                        "주장합니다. 심지어 악마처럼 야심 차고 고집이 센 일부 악마가 \n\n" +
                        "그의 권위에 반항하더라도 말입니다. 악마는 락도스 교단의 \n\n" +
                        "후원을 받아 눈에 잘 띄는 곳에 테러 행위를 가하는 파괴의 \n\n" +
                        "대리인입니다. 이들은 관객들을 피범벅이면서도 ​​황홀하게 만드는 \n\n" +
                        "드라마틱한 퍼포먼스를 통해 그들의 잔인함을 드러낸다. 그들은 \n\n" +
                        "도시 전체를 파괴하는 폭동을 선동합니다. 악마가 두려워하는 \n\n" +
                        "유일한 것은 라이벌을 용납하지 않고 낙담하는 것을 싫어하는 \n\n" +
                        "락도스 자신입니다. \n\n" +
                        "체력:5 공력:5 골드:5 경험:5 \n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "9(-1) 16(+3) 11(+0) 11(+0) 7(-2) 12(+1)\n\n\n\n\n\n\n\n";
                    break;
                case 4:
                    monster = new Monster(Monster.MONTYPE.MON4);
                    CR = "4등급";
                    story = "다크맨틀은 석회암 색깔의 피부와 각 촉수 사이에 뻗어 \n\n" +
                        "있는 두꺼운 피부막을 가진 문어나 오징어와 비슷했으며 끝 부분까지 \n\n" +
                        "약 2/3에 달합니다. 몸의 일부는 돌로 된 등껍질로 덮여 있었습니다. \n\n" +
                        "완전히 가만히 있을 때는 종유석, 석순 ,기타 돌덩어리처럼 \n\n" +
                        "보입니다. 암흑맨틀에는 8개의 눈점이 있었는데, 이것들은 진짜 \n\n" +
                        "눈이 아니었습니다. 다크맨틀의 각 촉수는 “이빨”로 \n\n" +
                        "덮여있었고 교차점에는 칠성장어 같은 입이 있었습니다. 머리 \n\n" +
                        "뒤쪽에는 점액으로 뒤덮인 발 근육이 있어서 벽이나 천장에 \n\n" +
                        "달라붙을 수 있었습니다. 전형적인 표본의 무게는 약 10킬로 \n\n" +
                        "그램이고 머리 끝부터 촉수 끝까지 약 1미터 정도 뻗어 있습니다. \n\n" +
                        "그들은 뼈가 없었기 때문에 성체가 되기 전의 개체는 놀라울 \n\n" +
                        "정도로 좁은 공간을 비집고 들어갈 수 있었습니다. \n\n" +
                        "체력:8 공력:8 골드:8 경험:8\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "16(+3) 12(+1) 13(+1) 2(-4) 10(+0) 5(-3)\n\n\n\n\n\n\n\n";
                    break;
                case 5:
                    monster = new Monster(Monster.MONTYPE.MON5);
                    CR = "5등급";
                    story = "본리스 일부는 나른한 인간형 형태를 취할 수 있었습니다. \n\n" +
                        "그러한 형태들은 오래도록 시든 팔다리, 유연한 끈 같은 목, 쪼그라들고 \n\n" +
                        "주름진 머리, 그리고 반투명한 적갈색 색조의 악취나는 피부를 \n\n" +
                        "가지고 있었습니다. 헐렁한 누더기를 입고 있는 모습도 가끔 보였지만 \n\n" +
                        "주인이 피부에 직접 꿰매는 경우가 많았습니다. 그러한 본리스는 \n\n" +
                        "일반적으로 불안정한 불확실성으로 움직이며 때로는 동물적인 질주를 \n\n" +
                        "위해 네발로 뛰어내립니다. 두 가지 유형의 뼈 없는 동물은 믿을 \n\n" +
                        "수 없을 만큼 유연하고 강했으며, 몸의 유연성을 이용해 자신을 \n\n" +
                        "압축하고 작은 틈새를 비집고 들어갈 수 있었습니다. 그러나 이를 \n\n" +
                        "유지하려면 본리스를 일주일에 한 번 물에 담가야 합니다. 그렇게 \n\n" +
                        "하지 않으면 본리스들은 경직되고, 격투 능력을 잃게 되며, 특히 \n\n" +
                        "불에 취약해지게 됩니다. 본리스들은 완전한 어둠 속에서도 볼 수 \n\n" +
                        "있습니다 . 그들은 독 , 매혹 주문 , 공포 주문, 수면 주문, 죽음의 \n\n" +
                        "마법 에 면역입니다 . 대부분의 언데드와 마찬가지로 그들은 성수, \n\n" +
                        "성스러운 상징 , 턴 언데드 주문 에 취약합니다.\n\n" +
                        "체력:13 공력:13 골드:13 경험:13\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "16(+3) 14(+2) 15(+2) 1(-5) 10(+0) 1(-5)\n\n\n\n\n\n\n\n";
                    break;
                case 6:
                    monster = new Monster(Monster.MONTYPE.MON6);
                    CR = "6등급";
                    story = "앙크헤그는 강력한 키틴질 갑옷으로 덮여있었습니다. 앙크헤그는 \n\n" +
                        "칠흑 같은 어둠 속에서도 볼 수 있을 뿐만 아니라 최대 18미터 떨어진 \n\n" +
                        "곳에서도 지구의 진동을 감지할 수 있습니다. '공격' 산은 생물의 소화 \n\n" +
                        "시스템의 일부였기 때문에 배출 후 6시간 동안 음식을 소화할 수 없었습니다. \n\n" +
                        "앙크헤그는 먹이가 제자리로 돌아오기를 지하 2~3미터에서 기다리는 매복 \n\n" +
                        "포식자였습니다.  먹이를 짓밟고 하악골을 갈고 산성 소화 효소로 공격했기 \n\n" +
                        "때문이다. 적이 너무 어렵다면 앙크헤그는 산성을 뿌려 적을 쓰러뜨릴 수도 \n\n" +
                        "있습니다. [1여러 개의 앙크헤그가 한 그룹을 공격하는 경우, 앙크헤그는 \n\n" +
                        "서로 다른 대상을 공격하려고 시도합니다. 먹잇감이 한 마리 이상의 앙크헤그에게 \n\n" +
                        "공격을 당하면 앙크헤그들은 불행한 먹잇감과 줄다리기 놀이를 하게 됩니다. \n\n" +
                        "체력:21 공력:21 골드:21 경험:21\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "17(+3) 11(+0) 13(+1) 1(-5) 13(+1) 6(-2)\n\n\n\n\n\n\n\n";
                    break;
                case 7:
                    monster = new Monster(Monster.MONTYPE.MON7);
                    CR = "7등급";
                    story = "구경꾼의 몸은 0.91~1.2m, 무게는 110kg이었습니다. 그들은 일반적인 \n\n" +
                        "10개의 눈자루와 달리 4개의 눈자루를 가지고 있으며, 2개는 몸의 상반신 \n\n" +
                        "양쪽에 위치합니다. 구경꾼의 피부는 두껍고 울퉁불퉁하고 고무 같았으며 \n\n" +
                        "표면에 수많은 혈관이 보였다. 일반 주시자들과 마찬가지로 그들은 부유체 \n\n" +
                        "중앙에 하나의 주눈을 가지고 있었습니다. 구경꾼은 경계심이 강하고 신뢰할 \n\n" +
                        "수 있었으며 가장 끔찍한 상황을 제외한 모든 상황에서 물품을 보호하기 위해 \n\n" +
                        "신뢰할 수 있었습니다. 그들은 자유로운 사고 모드와 명상 모드라는 두 가지 \n\n" +
                        "행동 방식을 가지고 있었습니다. 자유로운 생각을 가진 구경꾼들은 마음대로 \n\n" +
                        "비행기를 돌아다니며 조심스럽게 공개적으로 만난 사람들과 대화를 나누곤 \n\n" +
                        "했습니다. 명상 상태에서 그들은 방대한 철학적 질문을 숙고하는 데 한 세기가 \n\n" +
                        "넘는 시간을 보낸 철학자였습니다. 이 상태에서 접근했을 때 그들은 여전히 \n\n" +
                        "​​우호적이었고 담론을 즐겼지만, 계속해서 철학적 사고를 하기 위해 혼자 \n\n" +
                        "남겨지도록 요청한 직후에 그들은 곧 말했습니다. 수년간의 고립으로 인해 \n\n" +
                        "관중은 자신을 3인칭으로 지칭하거나 소환사의 목소리를 채택하는 등 개성 \n\n" +
                        "있는 특성을 얻게 될 수 있습니다. 구경꾼들은 대부분의 필멸의 소환사들이 \n\n" +
                        "자격을 갖춘 하급 생명체를 위해 물건을 지키는 것을 싫어했으며 단지 주저할 \n\n" +
                        "뿐입니다. 그러나 그렇게 하기로 약속한 후에는 소환사에 대한 충성심이 \n\n" +
                        "절대적이어서 시간이 다 될 때까지 문제의 물건을 지켰습니다. 그들은 자신들의 \n\n" +
                        "후견인에 자부심을 갖고 다른 것을 지키라는 요청을 받거나 소환사의 손아귀에서 \n\n" +
                        "떠나도록 허용될 때까지 다른 어떤 것도 하라는 명령을 거부했습니다. 대부분의 \n\n" +
                        "관중에게 가장 큰 즐거움은 혼돈의 세력을 물리치고 귀중한 물건을 방어하는 \n\n" +
                        "것이었습니다. 자신의 의무를 침해하지 않는 생물은 살아갈 권리가 있으며, \n\n" +
                        "교활하거나 잔인한 수단으로 공격하지 않는 한 무기력한 상대를 공격하지 \n\n" +
                        "않을 것이라는 구경꾼의 강한 정의감이 지배적이었다. 의무나 자기 방어 \n\n" +
                        "이외의 이유로 생물을 죽이는 것은 대부분의 구경꾼이 스스로 부과한 뇌 \n\n" +
                        "과부하로 인해 괴로워 자살하게 만들 것입니다. \n\n" +
                        "체력:34 공력:34 골드:34 경험:34\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "8(-1) 14(+2) 14(+2) 13(+1) 14(+2) 11(+0)\n\n\n\n\n\n\n\n";
                    break;
                case 8:
                    monster = new Monster(Monster.MONTYPE.MON8);
                    CR = "8등급";
                    story = "뼈 나가는 본질적으로 골격 나가였으며 일반적으로 길이가 약 \n\n" +
                        "3.7m이고 눈 대신 '차갑고 잔인한 빛'이 있습니다. 뼈 나가는 자신의 \n\n" +
                        "창조자에게 충성을 바쳤지만 그들의 노예 생활을 혐오했습니다. 뼈 \n\n" +
                        "나가들은 정상적인 능력(독, 수면, 마비, 질병 등에 대한 면역)을 \n\n" +
                        "지닌 언데드였다. 그러나 그들은 지능을 유지했으며 다른 나가들에게 \n\n" +
                        "알려진 주문 시전 재능을 갖고 있어 대부분의 구성 요소가 필요하지 \n\n" +
                        "않더라도 보통 수준의 기술과 힘을 가진 마법사로서 주문을 시전할 \n\n" +
                        "수 있었습니다. 뼈나가는 또한 살아있는 나가의 독니와 독침을 갖고 \n\n" +
                        "있었습니다. 뼈나가는 특히 자연적으로 생각을 감지 할 수 있었지만 \n\n" +
                        "그들 자신은 모든 형태의 마음 읽기에 면역이었으며 일부 사이오닉 \n\n" +
                        "공격에 약간 저항했습니다(구체적으로 주문을 강제로 시전할 수 없었습니다). \n\n" +
                        "그들은 말을 할 수 없었고 대신 텔레파시에 의존하여 다른 생물과 의사소통을 \n\n" +
                        "했습니다. 일부 보고에서는 그들이 공통어를 사용했다고 다소 혼란스럽게 \n\n" +
                        "주장했지만. \n\n" +
                        "체력:55 공력:55 골드:55 경험:55\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "15(+2) 16(+3) 12(+1) 15(+2) 15(+2) 16(+3)\n\n\n\n\n\n\n\n";
                    break;
                case 9:
                    monster = new Monster(Monster.MONTYPE.MON9);
                    CR = "9등급";
                    story = "그들은 움직이는, 막연하게 인간 모양의 썩어가는 초목 \n\n" +
                        "덩어리처럼 보였습니다. 구불구불한 꾸물거리는 둔덕은 오염된 \n\n" +
                        "블루베리로 인해 오염되었습니다. 그들의 몸은 한쪽 끝에 머리와 \n\n" +
                        "손이 있고 다른 쪽 끝에 다리가 있는 뱀처럼 뻗어 있었지만 그 \n\n" +
                        "외에는 뱀과 공통점이 전혀 없었습니다. 이 생물은 소수에 불과했습니다. \n\n" +
                        "꾸물거리는 둔덕은 온대 습지대에서 자주 발견되었습니다. \n\n" +
                        "1357 DR [15] 부터 1368 DR 까지 Waterdeep 아래의 하수구에서 \n\n" +
                        "꾸물거리는 둔덕이 때때로 발견될 수 있었습니다. 1374 DR에, \n\n" +
                        "Shadowscale lizardfolk는 동물의 시체를 가져와 그들의 워렌 \n\n" +
                        "뒷문으로 꾸물거리는 둔덕을 유인했습니다 . 그것은 보호자와 \n\n" +
                        "폐기물 처리라는 두 가지 목적을 모두 수행했습니다. 그러나 먹이를 \n\n" +
                        "주지 않으면( 언데드가 되어 더 이상 먹을 필요가 없음) 스스로 사냥을 \n\n" +
                        "하다가 그 지역을 굴로 사용했다. 두 마리의 쇼커 도마뱀이 합류하여 \n\n" +
                        "상호주의적인 관계를 형성했습니다. \n\n" +
                        "체력:89 공력:89 골드:89 경험:89\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "18(+4) 8(-1) 16(+3) 5(-3) 10(+0) 5(-3)\n\n\n\n\n\n\n\n";
                    break;
                case 10:
                    monster = new Monster(Monster.MONTYPE.MON10);
                    CR = "10등급";
                    story = "무섭고, 비참하고 역겨운 외모를 지닌 캐즈미는 파리와 \n\n" +
                        "인간 사이의 끔찍한 악마 혼종과 비슷했습니다. 거대한 파리의 \n\n" +
                        "몸을 지닌 이 생물은 두 쌍의 크고 윙윙거리는 날개를 갖고 \n\n" +
                        "있으며 여섯 개의 팔다리를 가지고 있었습니다. 앞다리 두 개는 \n\n" +
                        "긴 손가락이 달린 인간의 길고 가느다란 팔과 비슷했으며, 나머지 \n\n" +
                        "네 개는 갈고리 모양의 곤충형 팔다리였습니다. 흉부에서 나온 이 \n\n" +
                        "머리는 어렴풋이 인간과 비슷하지만 흉측하고 과장되었으며, 작은 입, \n\n" +
                        "겹눈, 커다란 뿔 같은 코를 갖고 있었습니다. 이 코는 단단하고 \n\n" +
                        "날카로우며 구부러져 있고 물고 피를 빨아들일 수 있었습니다. \n\n" +
                        "캐즈미의 아가미에는 이빨보다는 검은색의 뼈가 있는 능선이 있었고, \n\n" +
                        "혀는 속이 비어 있었습니다. 두꺼운 곤충형 몸을 덮고 있는 검은 판 \n\n" +
                        "사이에서 뻣뻣한 털 다발이 돋아났습니다. 캐즈미는 원하는 대로 \n\n" +
                        "똑바로 걷거나 벽과 천장을 기어 다닐 수 있으며, 물론 뛰어난 \n\n" +
                        "기동성으로 날 수도 있습니다. 캐즈미의 길이는 2.1미터에서 \n\n" +
                        "2.7미터까지 자랄 수 있습니다. 그러나 날아다니는 생물에 적합하기 \n\n" +
                        "때문에 무게는 68kg에 불과할 정도로 매우 가볍습니다. 말을 할 때 \n\n" +
                        "캐즈미는 거칠고 윙윙거리는 목소리를 냈지만 일반적으로 텔레파시를 \n\n" +
                        "통해 의사소통하는 것을 선호했습니다. 그들의 피는 흘렸을 때 \n\n" +
                        "검은색이었지만, 다른 액체는 녹색과 노란색이었습니다. 그들은 \n\n" +
                        "시체 냄새를 맡는 경향이 있었습니다. 체력:1 공력:1 골드:1 경험:1\n\n" +
                        "체력:144 공력: 144 골드: 144 경험: 144\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "15(+2) 15(+2) 12(+1) 11(+0) 14(+2) 10(+0)\n\n\n\n\n\n\n\n";
                    break;
                case 11:
                    monster = new Monster(Monster.MONTYPE.MON11);
                    CR = "11등급";
                    story = "블루 슬래드는 키가 3미터이고 무게가 약 450kg인 두발 동물로, \n\n" +
                        "대략 인간형 두꺼비와 비슷하며 회색 줄무늬로 표시된 파락색 밝은 \n\n" +
                        "전기 피부를 가지고 있습니다. 레드 슬래드보다 더 크고, 더 넓고, \n\n" +
                        "강함에도 불구하고 그들은 또한 더 유연하고 더 긴 주둥이를 가졌습니다. \n\n" +
                        "레드 슬래드의 큰 손과는 대조적으로, 블루 슬라드는 양 손등에서 튀어나온 \n\n" +
                        "두 개의 긴 초승달 모양의 뼈 갈고리를 가지고 있었습니다. 그렇지 않으면 \n\n" +
                        "그들은 일반적으로 신체 구조, 안색 및 복장이 빨간색 슬래드와 동일했습니다. \n\n" +
                        "블루 슬래드는 레드 슬래드보다 약간 더 지능적일 뿐이며 다른 행동, \n\n" +
                        "즉 성격이 좋지 않음을 공유했습니다. 힘은 그들이 소중히 여기는 유일한 \n\n" +
                        "특성이었고 그들은 끊임없이 자신의 특성을 증명하려고 노력했습니다. \n\n" +
                        "블루 슬래드는 발톱과 갈고리로 싸우고 송곳니로 살을 찢는 등 이미 \n\n" +
                        "육체적으로 강력한 레드 슬래드보다 강했지만 드물지만 부패하는 질병을 \n\n" +
                        "일으킬 수 있다는 추가 이점도 있었습니다. 마치 미라에 물린 것처럼. \n\n" +
                        "그들은 또한 홀드 퍼슨(Hold Person), 패스월(Passwall), 염동력(Telekinesis)과 \n\n" +
                        "같은 주문과 유사한 능력을 보유하고 있는 것으로 보고되었습니다. 그들의 \n\n" +
                        "슬래드 소환 능력은 다른 블루 슬래드를 소환할 수 있게 해주었지만, 그린 \n\n" +
                        "슬래드도 소환할 수 있었고 극히 드물게 레드 슬래드도 소환할 수 있었다고 \n\n" +
                        "합니다.\n\n" +
                        "체력:233 공력:233 골드:233 경험:233\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "20(+5) 15(+2) 18(+4) 7(-2) 7(-2) 9(-1)\n\n\n\n\n\n\n\n";
                    break;
                case 12:
                    monster = new Monster(Monster.MONTYPE.MON12);
                    CR = "12등급";
                    story = "숲을 좋아하는 어린 초록 용은 때때로 늪지 숲에서는 블랙 드래곤, \n\n" +
                        "아북극 타이가에서는 화이트 드래곤과 영토를 놓고 경쟁합니다. 그러나 \n\n" +
                        "어린 초록 용이 통제하는 숲은 쉽게 발견할 수 있습니다. 전설적인 어린 \n\n" +
                        "초록 용의 숲에는 영원한 안개가 공중에 떠 있으며, 그 생물의 독 숨결의 \n\n" +
                        "매콤한 냄새가 납니다. 이끼로 뒤덮인 나무들은 구불구불한 길이 숲 속으로 \n\n" +
                        "미로처럼 이어지는 곳을 제외하고 서로 가깝게 자랍니다. 숲 바닥에 도달하는 \n\n" +
                        "빛은 에메랄드 그린 빛을 띠고 모든 소리가 뭉개지는 것처럼 보입니다.  \n\n" +
                        "숲 중앙에 있는 어린 초록 용은 깎아지른 듯한 절벽이나 언덕에 있는 동굴을 \n\n" +
                        "은신처로 선택하고, 눈에 띄지 않는 입구를 선호합니다. 어떤 사람들은 폭포 \n\n" +
                        "뒤에 숨겨진 동굴 입구를 찾거나 호수나 개울을 통해 접근할 수 있는 부분적으로 \n\n" +
                        "물속에 잠긴 동굴을 찾습니다. 다른 사람들은 초목으로 자신의 은신처 입구를 숨깁니다. \n\n" +
                        "주도권이 20이 되면(선도권 관계를 잃음) 용은 다음 효과 중 하나를 유발하기 위해 \n\n" +
                        "소굴 행동을 취합니다. 용은 두 라운드 연속으로 동일한 효과를 사용할 수 없습니다. \n\n" +
                        "용이 60미터 이내에서 볼 수 있는 땅의 한 지점을 중심으로 움켜쥐는 뿌리와 덩굴이 \n\n" +
                        "10미터 반경으로 분출합니다. 그 지역은 어려운 지형이 되며, 그곳의 각 생물은 \n\n" +
                        "DC [15] STR 내성굴림에 성공하지 않으면 뿌리와 덩굴에 의해 제지되어야 합니다. \n\n" +
                        "그 생물이나 다른 생물이 DC [15] STR 검사를 하고 성공하는 행동을 취하면 그 \n\n" +
                        "생물은 풀려날 수 있습니다. 드래곤이 이 둥지 행동을 다시 사용하거나 드래곤이 \n\n" +
                        "죽을 때 뿌리와 덩굴은 시들어집니다. 가시로 뭉쳐진 얽힌 덤불 벽이 용으로부터 \n\n" +
                        "60미터 이내의 단단한 표면에 솟아오릅니다. 벽은 길이가 최대 30미터, \n\n" +
                        "높이가 5미터, 두께가 3미터에 달해 시야를 차단합니다. 벽이 나타나면 \n\n" +
                        "그 지역에 있는 각 생물은 DC 15 DEX 내성 굴림을 해야 합니다. 내성에 \n\n" +
                        "실패한 생물은 18(4d8)의 관통 피해를 입고 벽 공간에서 3미터 밖으로 밀려나며 \n\n" +
                        "원하는 벽의 어느 쪽으로든 나타납니다. 생물은 느리고 고통스럽기는 하지만 \n\n" +
                        "벽을 통과하여 이동할 수 있습니다. 생물이 1미터마다 벽을 통과하여 이동할 \n\n" +
                        "때마다 2미터의 이동 시간을 소비해야 합니다. 게다가, 벽 공간에 있는 생물은 \n\n" +
                        "매 라운드마다 벽에 닿을 때마다 DC 15 DEX 내성굴림을 해야 하며, 내성굴림에 \n\n" +
                        "실패하면 18(4d8)의 관통 피해를 입거나, 성공하면 절반의 피해를 입습니다. \n\n" +
                        "벽의 각 5미터 부분은 AC 5, 15 HP, 화염 피해에 대한 취약성, 타격 및 관통 \n\n" +
                        "피해에 대한 저항, 정신 피해에 대한 면역을 갖습니다. 드래곤이 이 소굴 행동을 \n\n" +
                        "다시 사용하거나 드래곤이 죽을 때 벽은 땅 속으로 다시 가라앉습니다. \n\n" +
                        "용이 60미터 이내에서 볼 수 있는 생물 한 마리 주위에 마법의 안개가 자욱합니다. \n\n" +
                        "그 생물은 DC 15 WIS 내성굴림에 성공해야 하며, 그렇지 않으면 다음 라운드에서 \n\n" +
                        "주도권 카운트가 20이 될 때까지 용의 매혹을 받아야 합니다. \n\n" +
                        "체력:377 공력:377 골드:377 경험:377\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "19(+4) 12(+1) 17(+3) 16(+3) 13(+1) 15(+2)\n\n\n\n\n\n\n\n";
                    break;
                case 13:
                    monster = new Monster(Monster.MONTYPE.MON13);
                    CR = "13등급";
                    story = "오실루스는 키가 2.7~2.9미터에 달하고 몸의 모든 뼈가 팽팽하게 늘어진 \n\n" +
                        "것처럼 보이는 건조하고 병든 피부를 가진 생물이었습니다. 230kg의 생물임에도 \n\n" +
                        "불구하고 그들의 몸은 믿을 수 없을 정도로 수척한 껍질이어서 뼈만 남은 \n\n" +
                        "것처럼 보였습니다. 그들의 꼬리는 거대 전갈의 꼬리였으며 머리는 위협적인 \n\n" +
                        "해골처럼 보였습니다. 부패한 부패한 악취가 그들의 무시무시한 형상을 둘러싸고 \n\n" +
                        "있었습니다. 오실루스는 하등 생물의 고통을 즐기면서도 여전히 인내심을 갖고 \n\n" +
                        "경계하고 교활하게 행동하는 악의적인 새디스트였습니다. 그들은 거의 전적으로 \n\n" +
                        "다른 모든 존재에 대한 정욕, 질투, 증오, 분노를 포함한 다양한 부정적인 감정에 \n\n" +
                        "의해 움직였습니다. 반항적인 하급자들의 고통은 그들에게는 특히 기쁜 일이었지만, \n\n" +
                        "동시에 자신의 지위 때문에 윗사람에게는 쓰라린 일이기도 했습니다. 그들은 바테주 \n\n" +
                        "도덕의 교리와 주인의 뜻을 절대적으로 고수할 것으로 예상되었으며, 대부분은 \n\n" +
                        "광적으로 충성스럽거나 적어도 순종적이었고, 다른 바테주들도 비슷한 수준의 사악함과 \n\n" +
                        "열성을 보이도록 장려했습니다. 자신의 반경 1.5m 내에서 공포 의 오라를 발산하여 \n\n" +
                        "적을 공포에 빠뜨릴 수 있는 오실루스입니다. 그들의 다른 타고난 마법 능력을 통해 \n\n" +
                        "그들은 날고 , 투명 하게 되고 , 강력한 환영을 만들고, 얼음 벽을 만들 수 있었습니다. \n\n" +
                        "그들은 또한 1~100마리의 누페리보(nupperibos) , 여우원숭이 또는 스피나곤의 \n\n" +
                        "작은 그룹, 또는 최대 2개의 다른 오실루스를 소환할 수 있었습니다. \n\n" +
                        "체력:610 공력:610 골드:610 경험:610\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "18(+4) 16(+3) 18(+4) 13(+1) 14(+2) 16(+3)\n\n\n\n\n\n\n\n";
                    break;
                case 14:
                    monster = new Monster(Monster.MONTYPE.MON14);
                    CR = "14등급";
                    story = "아볼레스는 길이가 6.1미터에 달하고 무게가 최대 2,900킬로그램에 이르는 \n\n" +
                        "거대한 크기의 물고기와 같은 양서류였습니다. 길이가 12미터에 달할 수도 있습니다. \n\n" +
                        "그들은 길고 관 모양의 몸체와 한쪽 끝에 꼬리가 있고 머리 근처에 두 개의 지느러미가 \n\n" +
                        "있고 뒤쪽에 다른 지느러미가 있는 기괴한 장어와 비슷했습니다. 아볼레스의 입은 \n\n" +
                        "칠성장어 같았고, 톱니 모양의 턱 없는 이빨로 가득 차 있었습니다. 아볼레스는 \n\n" +
                        "하복부는 종종 주황색-분홍색이었고 윗면은 일반적으로 바다색이었습니다. 머리에서 \n\n" +
                        "약간 뒤쪽에는 네 개의 긴 촉수가 있었는데, 두 개는 위쪽에서 서로 교차하여 돋아났고, \n\n" +
                        "아랫배에는 같은 촉수가 두 개 더 돋아났습니다. 그들의 머리는 대략 삼각형 모양이었고 \n\n" +
                        "구형의 다소 부리 같은 코를 가지고 있었습니다. 코 위에는 세 개의 눈이 있었는데, \n\n" +
                        "각 눈은 서로 겹쳐져 있었습니다. 덩굴손과 짧은 촉수 몇 개가 머리 바닥에 매달려 \n\n" +
                        "있었습니다. 네 개의 청흑색 점액 분비 구멍이 몸의 바닥에 늘어서 있습니다. \n\n" +
                        "아볼레스의 피는 녹색이고 걸쭉하며 수액처럼 흘러나왔습니다. 아볼레스는 몸을 \n\n" +
                        "덮고 있는 두꺼운 회색 점액 같은 물질을 통해 숨을 쉬었고, 움직일 때 몸을 따라 \n\n" +
                        "맥동하는 네 개의 기관에서 이 물질이 흘러나왔습니다. 이 점액을 배출하는 능력을 \n\n" +
                        "빼앗기면 아볼레스는 물에서든 땅에서든 질식할 것입니다. 따라서 아볼레스는 점액을 \n\n" +
                        "관리해야 했습니다. 물 밖에서는 아볼레스의 막과 같은 피부가 빠르게 건조해졌지만, \n\n" +
                        "이것이 그 자체로 치명적인 것으로 판명되지는 않았습니다. 대신, 아볼레스는 결국 긴 \n\n" +
                        "꿈이라고 불리는 정지된 애니메이션 상태에 들어가게 되는데, 이는 단순히 아볼레스 \n\n" +
                        "사이에서 죽는 것보다 훨씬 더 나쁜 것으로 간주되는 운명입니다. 이 과정에서, 그렇게 \n\n" +
                        "방해받은 아볼레스는 견고한 방수막을 형성했습니다. 그러나 이 막이 뚫리면 액체가 \n\n" +
                        "넘쳐 흘러나오고 대개 아볼레스에게는 죽음이 멀지 않았습니다. 아볼레스는 늙어서 죽지 \n\n" +
                        "않았으므로 폭력이나 질병 없이 무한정 살았습니다.\n\n" +
                        " 체력:987 공력:987 골드:987 경험:987\n\n" +
                        "STR   DEX   CON  INT   WIS   CHA" +
                        "21(+5) 9(-1) 15(+2) 18(+4) 15(+2) 18(+4)\n\n\n\n\n\n\n\n";
                    break;
                case 15:
                    monster = new Monster(Monster.MONTYPE.MON15);
                    CR = "15등급";
                    story = "이번 모험의 최종 보스.‘주문역병’이라는 초유의 혼란이 발생하면서 \n\n" +
                        "모든 마법이 정지 되자, 넬로론을 둘러싸고 있던 결계도 또한 사라졌습니다. \n\n" +
                        "서식지를 찾아 이동하던 레모라즈는 결계가 해제되자 혼란을 틈타 넬로론의 \n\n" +
                        "포비든 마운튼에 정착해 둥지를 틀었고 우리의 이야기는 여기에서 시작됩니다. \n\n" +
                        "레모라즈는 가죽처럼 질긴 날개(나는 데 사용할 수 없음), 곤충 같은 머리, \n\n" +
                        "12미터 길이의 비늘 모양 몸체를 가졌습니다. 그 색깔은 담청색이었고, 수십 \n\n" +
                        "개의 다리가 있었고, 등은 가장 강한 금속을 제외한 모든 것을 녹일 수 있는 \n\n" +
                        "내면의 불로 붉게 빛났습니다. 몸에는 뿔이 있고 단검 같은 이빨이 있었습니다. \n\n" +
                        "당연히 마법 저항력이 매우 높았다. 레모라즈는 엄청난 양의 열을 생산하여, \n\n" +
                        "원래 환경에 있는 많은 생물들이 가지고 있는 취약성을 활용할 수 있었습니다. \n\n" +
                        "그 열은 또한 붉게 달궈진 돌출부를 공격하는 비마법 무기를 녹일 수 있게 \n\n" +
                        "해주었습니다. 레모라즈는 잠재적인 먹잇감을 매복하여 기다리는 것을 \n\n" +
                        "좋아했습니다. 살아있는 생명체가 가까이 다가오자 레모라즈는 땅에서 튀어나와 \n\n" +
                        "공격을 가했습니다. 전투에서는 주로 이빨을 사용하거나, 상대를 통째로 삼켜 \n\n" +
                        "모래주머니와 불타오르는 내장에 노출시킵니다.\n\n" +
                        "체력:1597 공력:1597 골드:1597 경험:1597\n\n" +
                        "STR   DEX   CON   INT   WIS   CHA\n\n" +
                        "24(+7) 13(+1) 21(+5) 4(-3) 10(+0) 5(-3)\n\n\n\n\n\n\n\n";
                    break;

            }
            pictureBox1.Image = monster.MonsterImg;
            label1.Text = "몬스터 이름 : " + monster.ObjInfo.Name + "\n\n적합 도전 지수 : " + CR + "\n\n몬스터 정보 : " + story;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Monster_Form1.swi = true;
        }
    }
}
