using AdventOfCode.Puzzles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic input = "878938232157342756754254716586975125394865297349321236586574662994429894259828536842781199252169182743449435231194436368218599463391544461745472922916562414854275449983442828344463893618282425242643322822916857935242141636187859919626885791572268272442711988367762865741341467274718149255173686839265874184176985561996454253165784192929453678326937728571781212155346592432874244741816166328693958529938367575669663228335566435273484331452883175981955679335327231995452231118936393192583338222595982522833468533262224874637449624644318418748617949417939228988293391941457722641936417456243894182668197174255786445994567477582715692336249243254711653529871336129825735249667425238573952339922948214218872417858525199642194588448543565474847272984232637466664695217176358283788781843171636841215675851778984619377575696447366844854289534215286959727688419731976631323833892247438149829975856161755122857643731945913335556288817112993911694972667656914238999291831997163412548977649491227219477796124134958527843213824792685117696631512141241496451845758655276186597724748432996276498527911292531185292149948139724345841584782352214921634858734671118495424143437282979243347831258285851259579133433182387444656386679831584933397915132785411686688447731696776459621924821667112751789884987883991845818513249994767543526169463766975791464756526911587399764736557959464923353896921342944821833991457125256329564489631352268722457628514564128231487382111682976886838192412996932924373337524262135399256658638418515239876732866596731888779532573243713128238419234963195589987539467221517535272384899524386267268959484881379944796392255419838743164714275463459351741296586465213689853743856518583451849661592844879264196761867481258778393623584884535246239794178981387632311238115362178576899121425428114696158652976277392224226268242332589546757477683398264294929442592131949398261884548427951472128841328376819241955153423452531538413492577262348369581399925647624623868299468436859667152463974949436359589931136236247929554899679139746162554183855278713574244211854227829969443151478986413333429144796664423754818256172862812877688675514142265239992529776262844329188218189254491238956497568".ToCharArray();
            Console.WriteLine(Day1.PuzzleOne(input));
            Console.WriteLine(Day1.PuzzleTwo(input));

            input = @"5806	6444	1281	38	267	1835	223	4912	5995	230	4395	2986	6048	4719	216	1201
74  127 226 84  174 280 94  159 198 305 124 106 205 99  177 294
1332    52  54  655 56  170 843 707 1273    1163    89  23  43  1300    1383    1229
5653    236 1944    3807    5356    246 222 1999    4872    206 5265    5397    5220    5538    286 917
3512    3132    2826    3664    2814    549 3408    3384    142 120 160 114 1395    2074    1816    2357
100 2000    112 103 2122    113 92  522 1650    929 1281    2286    2259    1068    1089    651
646 490 297 60  424 234 48  491 245 523 229 189 174 627 441 598
2321    555 2413    2378    157 27  194 2512    117 140 2287    277 2635    1374    1496    1698
101 1177    104 89  542 2033    1724    1197    474 1041    1803    770 87  1869    1183    553
1393    92  105 1395    1000    85  391 1360    1529    1367    1063    688 642 102 999 638
4627    223 188 5529    2406    4980    2384    2024    4610    279 249 2331    4660    4350    3264    242
769 779 502 75  1105    53  55  931 1056    1195    65  292 1234    1164    678 1032
2554    75  4406    484 2285    226 5666    245 4972    3739    5185    1543    230 236 3621    5387
826 4028    4274    163 5303    4610    145 5779    157 4994    5053    186 5060    3082    2186    4882
588 345 67  286 743 54  802 776 29  44  107 63  303 372 41  810
128 2088    3422    111 3312    740 3024    1946    920 131 112 477 3386    2392    1108    2741";

            Console.WriteLine(Day2.PuzzleOne(input));
            Console.WriteLine(Day2.PuzzleTwo(input));

            input = @"bdwdjjo avricm cjbmj ran lmfsom ivsof
mxonybc fndyzzi gmdp gdfyoi inrvhr kpuueel wdpga vkq
bneh ylltsc vhryov lsd hmruxy ebnh pdln vdprrky
fumay zbccai qymavw zwoove hqpd rcxyvy
bcuo khhkkro mpt dxrebym qwum zqp lhmbma esmr qiyomu
qjs giedut mzsubkn rcbugk voxk yrlp rqxfvz kspz vxg zskp
srceh xdwao reshc shecr
dcao isz wwse bbdgn ewsw qkze pwu
lbnvl lviftmr zqiv iadanl fdhrldn dlaani lxy dhfndrl fkoukx
raovmz pdysjsw hqps orsyqw rrwnzcz vrzoam jjljt
wgt gzi icpwp qeefgbe msadakj jbbrma sbj dufuujx zex
cfzx bvyu eswr hafcfy klw bgnhynv qrf aop
rzlq atrzcpb hpl pajjw cdxep ean aptzcrb rzcbapt
xogpf ucc nsukoz umtfbw xfvth ozusnk fopxg ubp iflb
xot nqcdyu kpwix szo cyxv hpmp hwtrc zso nyuqdc aha
mkzf cat tkjprc izxdggf obspan lmlbg bsyspf twox
lfmfrd ooclx tcl clt
dxvnyd nxwojj arutn eyqocj swzao tmh juvpezm
teu eman rlmdmk xkbodv fvrcm zorgy wmwe
hmo fdayx duciqf cgt duciqf
imjnv vfmsha cyrusow xjswoq nclrmjy sjxowq ynjrcml
rwbsay alsi bmzpvw ozq aduui nihwx glwdiz ixmkgfx
vtjzc ntkh zekj qrbkjhn zekj lyfnbg
afaig jqhli oie lhwyduh kqfnraz nfrzaqk mayfg iljqh
inb zum zmu dnl zjxg vrdziq ypdnsvt
uhbzmre mpdxm alkbmsq aopjmkl mqxenry ayvkrf zxvs qkfqva
fimjr ccv cnug crdsv
bqyve lhxdj ydu qbyve vihwjr vyodhc
vmng dyttyf noagpji tdtyfy ewiest ogg
kgscfj klmsv vmksl vmlks
qlvh veo wruft wtm fbrlvjr evo wvwmny dhp bvrlrfj lvt vgzuyyw
mxuro orxmu tivu tjdq ojjvju cdd
kjexme gxbysxp yxrum hinrklv fxehytd qkt tqk umryx nim
kywnux wab tzrft dsaz jgwuw dubarmi fle wjguvr umjp uzncwj mzz
qokwh zrda xywufk tbxhhj eejqaoa hwoqk zer hwt hbjxth xyf hmh
eregs qdx tdequa agrlrg mwwpba qjie yrjvhr txujk
iyot fxwdcb zvwfv vfzwv wvkw ncwbr wdejrr ltcdza
waix eza znmonya ldfghws ialwfvc dey ubsz uhbnh svgekg nonzyam
bryz tfbqn xznfmw xiplgww wwxigpl jxzcgxl rzyb
cqvl rrcoqxs staeuqr hzzow cwv tsvol dio coc ddavii uuojy
txbn qvkkyh gbqnjtq ndpkqr srt bkpqfmm ytycev ypcv bpqmmfk
uqkjmul dour zgq ztango yrrjhrg ufxnmuw
ekxbcv vkxbec xbcevk jiq bar
wczff qdu cwffz hhk wlvyg
zjlconc osgsro dajzo hqih ehml
hnio shccluw cpu ivaby tormn vkef abv vkef ivaby
xgbdeso xiizs omqwy sbtnnt khago evviclw xyu dtvg wsyxfuc humewp
cnzu bia vdyqrf wwb qveum hmh ouupgc owli
pjpmfxa dvd lxgh ndy gwph oebfkqv vtlxdg efl ekj dyn
mvan nmdkc ucyshia mavn ecst poo
oybm pjwm bmyo wovgu xykziaq obmy eiirhqd
xkvomx yxvv oxxpth elh vxvy lhe ycn
okxglw gmaangx gnxaamg yduzrr nzwxtnd rcxcu xjjvno yat cin gaxnamg yss
oicgs rrol zvnbna rrol
abb edpnxuo peoudxn bab ceay
ncpkfz gvwunb fckpzn caafx pkcfzn tsfl
fnrt ymenkpq wodubcm niv nvi ziluu cuowbdm zocg pdakwt mlzxkex nuxqclo
uouxcgl stgua otadr ideannq wizxunv iqsdpj mxddt ldst ucxogul
rbrwyhk wqoz zqwo ikwgexl atpu iza
smo yolp pcahlu muljxkq cbkljmz zlbcmkj zvbmgz eaiv ncv zplifm yplo
ocutdhz zmnaap llgv llzpl loavju guzkfq saay rxyhng cwxzx lcv anrnzs
etyzx tcm upxrtvd imyoiu rdpj fed dmm
gonqa szteh szteh razdqh phyff upf knfqfaf knfqfaf fpsgl kakag
mcju mixskop isrwat lcr nfyi lcr aaevr nfyi pqrbk gnful
xfmr fkmnq fbnhd mxrf litniid xbae frxm zcenf
yuh lzojtj rqsh hyu
vbjgql yeshsuv lokt efqota wpwjfu ykyq rxc fxxh ycqfkk gndts vdf
wnylmr kkuruxm azr xukrkum dohkwx dmdb
bjiyrwf dvf fdv vdf gnokekr
jsaq hcww iayqtu llv gdpxdrd hwlo nosjit wpm lcab fcgwr
fxjp bys nnf xzllckh bys hvojw zcwtgwz wye ccyvjv
grafa hbb ghk wkdpsf ufa uoqmysd
yvacf kssbff iovrm mvrio cfbpb avh zzje
gqd qmsen wkvrfz vhtsa zrwfkv gul zkvwrf
hrbi svaogb aogsvb bgrk hibr jbtkr
ljl ryc mrewrge yky
fcqyymt emk qcmyytf mcfvusb luy qany cbsvumf
oknt mcozuc ccmuoz uoccmz
uziil xobutwf acnof iqgwl diso
sekq fxbtsuv ddnnqg rnemlt dngnqd hhgjfus stxvubf
lajcp qgiw fyz blrlcd pviwv buh wnkk
wolqfk nvpapfc rwcqxfz xobno yzjfz irpj wolqfk wbnwjt
vmabj noiljne hhqf holxkbk swwzx ylgj lnmxy lqodhk abjvm bmsrf
bpnp yrz pjepxxs jlmhuy vihlx zacm inuazhc xsxjepp
tryl kryh eonvaad ucevssk umkxg lqej nswopjj svkeucs bmh stosxxz
cfdwd dmfdrvm ibuhsz nwtgmb pjt dmfdrvm cqdcm fzjjz afa ibuhsz
erwp abn jwx ynmkkj rhgg abn epd atqhs rst rhgg
jtnp cegdsoy gfuvfbg gdmn ahlsc
jgrp diu jrgp onjnml nojmnl vxockc
lakqyuw khq dcpiwt ykwlqua hkq plklx ujbckec hjcvur jnp pvyf
usuvoo jkih ylafyy yhio jureyj
uazisdf cnwlfnf ewodatr woaddkd wbla qmn atdrowe
bnyepaa ntqh xppe ydtsw ppex
yewjwsp jxylmtk ijese ewry ijese kbja nfml zeuwcsh juimz
qbvmf nca zsfreo uurgaiz twe fbqmv ncwi etdcsk atowfp
jeotslx kgdpzp wxlcww pdd dcn ddp
macllv ldl kyluine lbt hbxbr wxcaspp ezwvc qxkeu
ivg gxv zsf ucr uff yrz
tdlwbny bqlrlz tbynwdl lwtbdny
tnekq pdaievs ttwpfh xfm fcaa
zqqhl zbf fbz uqrv bfz ffwavhk foccg
vcw ebqdd cwv eddbq nrmq
hpiusz sizphu xzq sgyehk wgagkv hsygek
vagkxa iou frqdnnr ipcg uxvh vvh eskf katgpiq aqktigp gzvseyi
xkwgd kzfxk pgdy fmtvq ngf rshx zti pamviob ely knz
hwo rteohu qzwoe rotuhe wzb
bsqgg tid dti gtats dit
sjtux djwxv dljwjq xwvjd xnqfvx veqdrtl uxtsj nnkjn wnhilaf unirrp
fruuqjk gtote gooklg bzwhim zfnccmm ezipnf cxwdxa wfu fdca
zcyxb byzxc cxbyz pgcqco ivlxz
wrjh zfdinsf ihw xwosiah hdg xpiabno bilyy azdeczg javuwa
rinlv dcpt qhencba mmb njxw gadc
qwcpua qzyzt cxjsgh kumh byiimas qhsgf qytzz rqqruwp ismyiba xydcxz rwkscqa
xbzefi hltca ibzxfe fkx xizbfe wvaynts
oyuce vzk ouxvj gfh efgbv ubc nyb bxnbhd mtwboe whksy ovmrt
ljrebp tacn bpjler utphw wmfw rcnha
drdnic eyodes rcnidd yseeod
umxmsf kfroz ukhjin awpnnnu ooyyohh tuv rafano jze
bakz lfzpjyg gfkqcgn kzh zwpvk gqfngck
jpaony ojpnya hmro xaaz tovary aaxz iel pbg
swvbgc bbhjp yvrcddd rhj clfu eao afrkegn qvvb yvcx nxjmdo rcvtx
conbjy jeqtri wvujt jeqtri rkhllgw tsdt zowreo qxr qbpragn kuzmplw wvujt
jrpxyp hchljy rkowqb eeaf ltllebb gtksrwx iazx vnsfmc zzrxw hlcjyh
piehb cjdzt eqn kuje rls oaewoz lrqwt lcrrq
hdjowxv uknhlv hluknv pokxg
txiqxfr fyyp pyyf xfxtrqi tvm rtvby cfx trx nwrf kqrxtat alwot
wdaadr stexpow ardawd uejqxc
wwgwjel wwgwjel mtjt wwgwjel
mczx uua lgceb dqru vkcea tcet ruz
jkt yroojr qdrtdu wze ovwz fdmqnr xxsyfd kchytwl hctlkwy gyd
eif irnrce iamhxgh bmis uxye azrwdi sznv yuowb vdlqqxu
dxdjyj hngqwzs yhwku qhsctfe rhbc rchb tqhcfse
fxyxnzs qtxevin rvtxtc iqnxtve
zgbpk mwzxx bgpkz wkpkn
rjiym iub lcyw agbtlb bzhx osv rbtf
emmyu uoflio tinih skpqaj rbor gezbhhv ine mij qlqte uuj ycns
owmwc uhxv pyho ftjh jzsg blqn bszyo bob trbycy mkru
mwgz bbqsmpp fgzs bihhg bbn pjxxexs qrqmt htsxfwo qltqp vqqaxi
lpr wcvy sxjqq ltd rftdgv pdnog ymu
qhcos shuy icdhucu lrikh rwslv yxbgibl rcomhn wakirz
civdmee owlzocl vedecim rogmjnn pix pohcmk dsjm yworm
vzdpxp lvt inufv yofqt omm qfoty qrlseqy amkt kjcvg vgkjc
huhq quhh levzsws sjuun ofgqr cjhp nfxbbft rnt wtbd tbzab
tjftkx xpfcv hvftvhw lpypbjg batrn fhwhtvv uthl arbtn brb sthv
ogr uyuxdco bpjgir edztxv sxtgu jzfmx ihnauz zwegqkr kvkw
mhxthf pervvn gshy jig ezjteq ckkcpy gww
tiljyki rpe prcojy tjkylii moxu
pjsdqc lgqydfd lohck emrtejw axwmo wuuv rfi qzyncmw gjijdfb bljfd xrs
ywjab gynzi relf kziy xmsby izyk ocwoho kqnyh bwayj
bhjlz uonz jhmzuq eiajoos zjnbj tomj bmyv hjlbz fgw jjbnz
kszz xzw xzw prtznyb
ghzk vxhwt thxwv slwpayp qxegmi dawdwo kgzh
ibpcvuf wnuwxu sbf jsj bfjynl cdp jbylnf
epaxr vfhf hvff azepadz pwf sbo pgfzya hslyo rqqj rmklw hwtta
yyolko pwbvxvg xdwl yfje hftep kzzsr kho jeyf yvslxpw kfyv
xmk juyjxy eqno mdwklum reg dgn cirh wmxfyj bnxlgo dlobk
oyv gshqyot jgcqe dsf gyohqst gqgeojo egoogjq dmqpyp
sypianq yss lmhu ulmh itilh ndkda lhiit
qbxxl bxxql ikald nfap qixwbqq
jtqhqty ljysnl nwoj toa bmmyj pal
ahktew sxody nkvsf pbxyt baws wgwfwej bevgzm jus hcvajfy kzrb jwgwewf
jzsb szbj ujngwf nfuuf lfiuxdu uufnf orsy
vgo hto isstyul gau wsmxoqw
uxw itwf epaw hec wape hemol rpwyosc xzxmrll eetz zui kagca
mjncux muv rygdeis rygdeis
qgkqjvf iprzibd fkvqqgj llcrl vbh vlf lllrc zwrunt
dslsa wvoex eqbwj tjem gbx ayn xcan fnacl xggxon gnwjlh
yzosv hcxjiz yvon gcgd
bixpny ecln sda eymt bjiwk
rlcad lrdca adoqfzs rgty mds pwb kmwj
wkai pmryffq rrdmodc wgyx taz yxwg nkap
auynzwc vzg uapdv qkrh
ldmuysp oyu kpn ejbl mfifa bzs hwyn brlw qpzqx uyilao ysdumpl
czoxoj pwnultl wezolbw lyk aonesgb
nqy nhb nle yycp lgtbo ojf dytwyh ufa
rwr eph obg peh pejret prjtee ovgz
vdqf vdqf ycjrg ovzl lelbe vdqf
gvagdqm gvdgqam dmb zaxe nepzwn
emwh bkkbgec qwdgk mhvfsrf wmdfpp ekzuua
mbqw lgkyazt ckyhvnq uladwo owt
qwiwd pbo tkjoqda zapo dygqopv zzdlwfn
qty dhb iinncba ytq kvh idgoevt chx waq
ulffsvk vplsz ulffsvk uxsh cpwgxd ikgcacx nrirke uowcjvn
gknmxr grkxnm fco dilyyj grmxkn
saqxkh uhue nvu fef xsuxq ekyyoc bcaavd
qltwqa vrmpv vhra nof yprauc vkreojm eaq igiy mec
wvheiyg uthy gpvcs nhnjrne mqaejr tfnsly zfbhn entcc nystfl cpq
zxv jzk dwsjgrd gqqxhp xqxu naunwc yeh qzpkz awcnnu aoosa icadax
vpmqmg qmvpgm tqs mvpqmg
inehzu zwxeoy jxia fcyzxc hwikd
bzwnp kamsen ajpn kdls bzh xqcb bzwnp cmjnfa wmgx
hbuhc qgvhxy smzkxh zzebox hbcuh net wyrdppc yvgxqh
oeum oemu iyags xaipdi euom
tqljgoq ghtdhw xhnni lux qltojqg lki zxztda pcqjif acpzvwy
ydijaq kbyjxpu onyd hsfgz geqvbg
rwoih xog dtbzyr ryzbdt tdbyzr
vcdxf zosw pardxfz bmb mscmain lwfc jvq hbszcqh fxomsmm ahnugx
zutsemg pqzil ddv nsstz gmeuzst bedvy xkzzjpw xlqbd
xxf ltnnu yeb hbml agj meovtjr qrul kexerkw xxf
tqrpd hhcx bmdv nlmr pnu pajdtc rpatqi yekedx oeiuew epsshog
ttbfpv plairk toh jagfsg njnqpa tmwh vwqp irtxv
vdky uwc tkkkztp vdky vdky qlcw lza
rzie yundymy pwgx wtwtbg kpiw mewnb liveysj uvsbn
jgfvyny hacg pzra arpz uowswu puzsfu hoe heo vrq naup
hqv vrl uko qgpikho lligvxa wdld qgpikho
whvby yomxwj dieffc jkprinh dsaqy yfrnba woyq yexeb mjn cbszn xeswvvo
wowtgu rciyg rlas bra quyfec ihe thuu asxhscu bsbdpbi ogxosu
vydsaet tvnkjq piedkzj foeiqz zqivt iatsju tjnqvk drauaf vqitz invoz
cppn jqzw zmxr qksuas iifmjg xtkgf cppn cppn jpsd
nkifpsq cxdx bokxhm ebww kghagrp bofhrl grc cheuzyj
ibgrlvm hrcx jjuoh ipmt
hcoqkh fzt rgravb cimauj jxjq blct qhc vjxw pqpg qzp
jycxz xcv czxjy vxc
liljaur cgmg neldxb xfummcq yfhiukd dnqhl iolxn cmewhb
hpvoihj fkwokod txy uuktw vmqqb dpldzh yxmcay cyaxmy xycaym wekr
ccnaf wuxc ecadb vbgpt ccntf sezo skjdkbf fnctc
hqdtwho kdhyman bjtcjvr bwllva ncyffyr
xprn jrrvmj pdw yvexm ewbflbe eapml rvrmjj xmevy rxyzhf
wjcbpy qdgtcp cfjh muww fhg sgfdleo nelpte yucqa aavev
rci vqypsqt xmg rzii
gramh wwprtc ampdhw dajr
ovrm mdyhpbl mdylbph aykz
cbmo fxs nuugu guunu upt ljjuhjw nituh utp kxqc
rhabal rhabal rhabal vah lfrs
nrq qway ftzp rtjcks mbygdtd hsiqbh wypqb rtjcks cllp hsiqbh
ywa anhcf nvd puqkwg molrwck wsctx xvd molrwck
wox jzq jfen wcvus cswvu oxw irg lmu tpj viahm jesic
qenad neqad smlgi ydwzq ppdemvs ucyuf qtunm eoqx jlgv
sucpl nrdwbl ltvetok npbw ozzw hafyay sjmui sjmui jkqlq pyn pbuopx
nxgaiu ybyl meo kgh saqjaz xhbqr otelcyp vkwc
iqrl ldjlwvl ajhrl dnhutr gkknyqs mcvluet fgyu ogiz cxo aiunl orb
psd cyq xpoyqny yqc kozqh vonfd uhozwz pds hcpw
tvaxder tulwmw qiw avddbmh irog vynjzcc refx efxr emnvk
myjx npqk whm egw kpy igrrohg ukglx ldnuqw caqg ynx fckhnsh
dafv bkdoqg zcqvbco xgikoac cvbqczo
rtzhpwk ukuyp bayhzp upkuy ahbpyz
oarcuv pnlkxvw fqdkj hwzsz nauwl lpufibz vzfbgc unkluxy rwh xuknuyl
vxhsaj ppdxw qrswqtu ulwv uqtqwsr ppxwd
cww cww cww scu
wiiikwa bfpewt zbgxfkl iqpk tpbwfe aazdcxj ipqk icggn fwn fjr
net ovxuwpz yvzmzd yvzmzd
xgar czuhp vuhisaq fgrqxy evvrtf mnmar lsk
hld mxuedug itswju vmmejqx snzslqj toe bbmugph mgubhpb mowj nrjnzu
qbz ouhye hsldmp lcf hyhlrb ewvle zko
cke mupaq quapm eck
owu zdt lales tzd apjjo fhpx bmuktbw dvehpz
libvl zxypk azazc vtsom ohdzycb
kiowxnc scxygrf ckxnwio ycxsrgf
vcjj fqz lfawfx mps zhv qykch vhz psu zud spu fnpvkx
scfvum fuktgk tua ieosetl wwmjtt exnsw wwmttj plvd pfb kku pdbom
wkfw snukd wkfw gyaojdf bjw htagy cdsp
beh gatqxcu ibrooxr ssww orrioxb eenkqz
jlv affah mtbemf tylh aafhf
zqfajd uwzrw csouuip qzadjf
gsnlrw tcel hha tfbzrp ild aenqa
iirfxef kdux yvj vbzgj
ibx pfll rgkp nancij llpf xib gbkfy
uvw kkbavj pznsnk okigtxl ogitxkl eobbs xhaz wroabn ltogxki
bivdf lotvmoh vrb kpaeeue tdab qhukcb qmy kuqf kesu
egs hbsfeu esg twxko uib
ocraimu qilp ijmx eco nhevqp juxf ksejr bcqqau uhpt
pyx jmpglf juokd dxszjw cml vcjge pfg
gxwrt btmimse dkpbha idmz mtignka ngakmti
dpjhm jyalra hukf imocr lkgt rqywn quhe fukh
nbau xyc bdh yni xaawxm cyx xwaaxm akx gyodqe htbifc
bywdxe bfrp rvb rndl onal jghiwb nuta aint qlciwcx
fpic yrqce land soxhci qzc zoebsq hcdohcc fzhcl iyxb dqinum hchdcoc
zok ghgp zok lmk
ozfz zofz dkdekzb sqc
gfti zuqvg cexmtyl qwuqnj stepb erduqhy cuoizcs qudyreh kqvfdd guzqv
jrugz jzugr lmqu jgihgo hjfbz duxkn unxkd
ckiys dbqmi ckiys ckiys
iylp uvvdp pluifaa djo
esxec rwvel djxppqf jymwt ilm aiz upn aiz wrfefwi rwvel
nitgjr pokxuy puhdwg qtxpb veylp zqvzkbd lrvpcgu zuy rnigjt ibci
jboyzq ogcldr hlon ywav jqqtz qjzqt vyaw cok
aqdw jxn hqknh azbylg
jya qpxtmsj hqrtsgg qjtpxsm
pofcs sxw dlvru dlvur swx
yphvvb qqyyfsp sjkbff dqyerxe jxzes oof
pwbya txk bbwsj ywgimd kmdpc bawpy lbnt
bkbazff ldmaq tyfl acqurpy ndnrp
asw ctiv mnxzyc weeuwb gsn bzk irbyhxl cgqomj izy zbk
yrxcrbt bcrryxt pofe wwzl
vuaqez kbtuyai vuaqez dxqud uvo gmhtg dxqud
tpzs gqdxpxo zzpgta uurjx xpqxodg
cil lsv vznqw vro zqzvjhm jhgauzw uxnwk lci zpgpu frjvyzo tsv
zfvcuim gwn gnw dxfppok
btb goof iwadca aac tbb jha uvzi
qah ned ipmure kyta ffhrwe njz paq kaag xmlui
rkmw vrblwyy gpax hxsf zpbza gypuwf jbib ypcjwd vrlybyw
yfjljn uxpvg huik jsnah nkhsg yfjljn lqzsz
hagjlqx agnax jqalxgh rvjgtc mjrmph azznzcq gxajlqh
ipki bhoabp rmiyl dmjyxl zzsmap aju
tyjrr rigrf ciq qic avmwu jtr wpq
vuf cosgytm toycgms ufv qzpcbrs
epzgxr lydrsj ezxrpg expzgr
ecm prj kmak makk jpr
ccwyq txy okj matxa socoa
zrjphq gigayv ywkfmru yrwukmf fxjjrha gqkxx zhjy tisutx kufrywm izjfj igg
lfhgsro gsroflh wrpo lofhgsr
kgkgj wkhnab ubrjaoa ubrjaoa ubrjaoa ggdgh
hztutpn epnqmz ffcroq mnqpez niibpn kdloak xjui ozttj lyzsc pzgq inpnib
kruz sjqp mmd hhdxjgc mauouma asevvo upjwqi hxcgjhd etqzagp
zylf qime cho oraid svytv gqrjufv mker cho vnkyiin tjms
dotjul qyv hnh cibtg gdpauyx wzp
fabtira ejxoeor cqyethv ndjrq hnxn joq otng lrr csytrub
txhgepd fwdaanm nawdamf pxine qqrn pronw exnip qwkimt rvy
kuxzhi jln urzxtw rzu ebsuylm tscru qwlhfgq nnu nuchvz vuht
cqgu camlr umkltcf stx izp rtdwxff wkfvs
jhje cxix lefcrsu nebv idfzhic xqri xkft
utzxb znb ietupd uqgbhje aobip oawjwm hetyan uqtqv hpwzyri kwxyu
jvzvbt xuyvp aegdkb srbw bzabpf lyfriez cruyfu
nhi nih aeb ihn
hcf zypt djcm pkjx pvhh
rhvxcfk exydvk ids hybme hnk yfchvs mjbo meocn
rpboxr rxoprb hdzje zhedj
ziildbo apzvatr vsv isndq ebxyy ntm tdttg wkvdh qnids vkdhw xxolip
ywu uyw ipcjz pjzci xjn kvgk vsocprw
euzo njlpv ndrlhi drlnhi ivmjkb fjrtxta skvgmrd
gbyvj dkck gevpfvb lhadhx rgjcdn yraxh bdk oen vqryd bkr
vgkp hncttxb wgxh gdyjo bbdfzvc xhgw rznzgda yxrrlo gxhw
ifjlb fpecyic svhjp ilmj oxgr svhaf
vbqky lhccj xtmm xzjyykn oqmdq qywir bswly
euxxziv totzer vsxfx leo djho uoeaz edaig fbu lumbi
ooqtwq pvo kid vpo jxin bod btqc fbyuz
jhabi mronu htqqyz umjcbv sgnbp wyn cetmt pcjf
tnrkcyl dduuhxh rylkctn pwj rtynkcl mzzfomr
rxx ldqffi ulappk nltawbn tplhb kyb cqyi
vzkw gviooah vxh xeae ohvcad oaiwcj dkx
sdofdjt hcifv dqws sia mlwm vfich kavh myzue roops mzuye
uxs nlbmjp nlbmjp tlaxa tlaxa
ynnisp twx xtw jgkc yinpns
kumorsm wav xhx bpvz clqc ffmadzl ndny ymslo lobv
ljzabj tqhves mezh pwn wue dwfqq lynvtt boeknvi xqbd pkud tzlanis
lgq qiikzl oihnsr pivtjmu qhic yvmeebg rxu qgl yuxnqse dvu faxqez
ldk mlwja vmdqr yzlxiua amlubt ejmzfx nonm zhkxbn gaqbnqq
ttc ctt kneknx smtnaft abljip tct
uybhbiw zwojzlm cfxoopp abulenj znz zzn opllzmm yufk witwxzp
qvkybwi rdbxb qiuizmo fqgne jgot jxz dqhapn
vzinf ehaley amnk laheye invfz
pedakl ivld agzyhr wmzba tzzzg bazwm wjwgux thrnxkn
cmyhae nwfs nfsw kmh pxkaffq
vdf szupev tyunp qiiu deevxmy wozvtt nelnr kgdexy gparqj hajavz biizn
pwspk skpwp ontbjee pkspw cfbj
ihsmh djxtak wkzllao oyr djxtak prc
uhvihqq jrgf hdfek pdrfpt tghz gthz awae wcygi wujti svq fhedk
gnfhsj odqlt netmsul rviio nkzw nkzw
xyvc clxw cyxv lxcw
duegck pkviu npwsp zdx wpvn dmxgnv ixv fybs xteru
vih kgk hads boaddu daiwo hozoufv nef vtcplc isiw
tzqoo dqlgvno jzlay sywx ecej addt ecej addt mnfcu
ymgmby zegudpx ipsjai ger wcwjw brzebb
eqekxlx itra xekelxq exqkexl
rciu ojaa ircu nxjga puvmwou remgu
sltth pprimb slnxopq avtir hvpv ppww fhfap wisn kzs jcuuuuf
xbppc ydpbq zhjh oym iljzvk vsb
ueye shtps uccehi ccheiu dqm yeeu
gwywf lcpv qza qza gzuovj jfzffyh oybfxqv
aawi ynsvdco azdoz cqr tnyquq xlyvbx eca kcalpes
zumgzhy rou kguqa vubw bwgd qprxcg etnbev nqmi
fyd tuoz uwclqn cgl lrpkf irz dizv nxze clg jghx jbpt
kwuanos eorjr tcahp kwuanos cyrpfji zxayggd kwuanos jkqt qqvbork lizk
vtu ovje vhg ovje vtu zcy hrhtr puawfgv
bliz exp wot svxv epx
jiqgxwj yips hjsatc jgsrno msfp vxvbt bba bqmw xjgpgog
vpvypp ggwp wggp gndp hedpse afji hcqgof
hxueubt hiynoa qqzaj ohb qway
akq nfnes sdrlza nfnes weq
udxpdpx gctuv llhxuow rqtetm hdbnpte oebapv civy oeobu ftgivd pykj
pbgbvn jgmr xrz dfn gosjobw ndf
gnf dtbsnc fwcmml tscdnb fgn qgadusl eifpk
vmnv yuxrup qcphi tanc tnca kjrv cphqi
hclggs sghglc fgplp odn pfglp emkrulf whwtmbs qnuyg
wcxtr ani ain sha hsa zxbkf bzxokat qezo ljqxi xqcwfmd dxo
waiq smpbu dbyka uibxjrg nze wiqa rfpts ddjsjv jqqjez bpusm
lpcxf vsbj owjwc tuqj vkrgrh jsjdepv oil lxrjox frsxsi clr
vzunp prwk nnd rfs vpuzn
pqpqv lvsk sqxf nhobsm hakbn ywj
xxu uxx szqnmi lnwtmx
akq nmlw fupwsth jduvhva
nac wwlxqck hpbce vxxqa fyp xvxqa kxwclqw yvlmv bfwi
pzxjbj nvwv mdooiez vvftp enjrsck iypu uhru fpx omtd
llxgp qwf pwaj cuhb scloot hbcu jgp vjw ooclst
sisd akawvzd wvdzkaa gyoij ikt eeeosb jiwiup
tche vxj sbctqv jvx gosur usgor ibo yqxo qqgd zspl
cidd welisl fxblxqk qxbklfx fbdoqcz glhq iylodvz zvds ghlq
cnsa hrxst mrnkqtj bptq jmi cpbcofs kveyeur uzmga modphm rtx kntqjrm
dvyup usfaq rtghoec bvcos fqsua zohwwg
onf vncybi dlaxni oqyqqkn
okfwa qyyx ebnv llql nphq etdt ytgivlo jwgwz kiob
ann vqnqvpx wth lpwid bjvzw xpwqxcj azg ioeyzzp onwf
smy epzomx xep yid zctvrfj astdj cfg fgc eriuxt
rljqgin wzobzrh cuwtx vcsbx tmg tuysq vxipgho
ewp rsrnsj wgeyin lrji ddgt utol xxwut fjiwopa
upu ftvqbk tfkvbq fdwga rmu puu hbiasjw
cfl lmqkb lfc wbtlfi uqsjs ejgmphi tbliwf nzcela gzb
zop unwmiu acull mkwh hvruknw rfk mmhaz iqmenq fifino
iczua bjut tlgf zicau jtbu
mtka ipd mdifj kps
irqkysw xfsjl tedx yckkbx iktxb sqxn pbfvubv uudzppz
mdrn cihat wcext kufs awwtjok pfjg
wdevt tyo zzbp pqlqq wdevt
yhatqkv ntuhw tdfd buxazh xbcsv bas gkv rbzi tddf jbj bsa
malip hiiy qezz yhii wlfojre
zqnfll bssveq lprwbep bhqml tztbt
npnxotu yupdytb jptqo klfydfe fpucmfq svxcqr unopxnt
gdpz gwj iytiohu efk ctjzf asade abhotq brmhu tbtdur zzksbh
kxft klzslf tjdzciy lzslkf
ejei ezmemvg xlt zte tbwhz dgnfpao zotck wus uaz gbwbb
dgednf vypmbs eiytot empfmny
uopmui uehue wdvzt adpfcif mutl ifaztka vydi xumtz orstno
dleero olxiq gxnlfm nfmxlg wloeavr olhrwg hrjd yicj ymyeex qav gxyjgfq
hevj rqcne zycgb qgqtn rqcne ptfvu yyyu zlm hevj
zrkhuh sttnkt hkuzhr vqtu
ppsfm kcao qjq dgadglx cxaawjn pbucfu fed qgioarc dfe ricoaqg
vmawf oktunea zraoir gkt zraoir jcvkqoq
mqgml ecawug ugwace szwul iwbmooj owmiojb
auggaw cypcuw npci vuyxijd pofswjx vdkrgx xylk rom ksj
qmwx jgsrdj ikva xzxw avik
zzhcqu rbg pywjdn wyndpj zchuqz
wzd wqycftu yldezp zovuy oydia hovewe
kfid qkkk thak qhbf rvzlzvu uuxh pbj hkat gow oeqcw knqqzha
sua itv hfpg bdqye bznlrk hfpg bdqye kvir kaai ggtz jqn
ulggl guitamm tkpckso fupacz otxtqpd jxnqc
ueesb ndyik vjftz jgqqv nrcf
krh dqpmsw fybzynl zhjbvkw exefc rhs neq ldprb bhhvxm pjwirun
ymavl qwxr yavml wagwc ekokrpq zewppw iumcgin cxdvwx
wwdukav kuawvwd kowv dkwvuwa
eazot bil tzu vdwwbm fvauwrq
esq tixokph yspf ztoxfut lgzush pwv swh pwv auqhuu tixokph
pdbeyxi poio mugfkb brwbbx aao uszw fokjeb uswz
sbs ryjr ptispi tvnhu htunv vthnu
czjmg hbdjhvi jrkoy fpgwc syafy aar kvnq eaecsb wqzpx
twtp dvl uvyje qtlzj dsvyr qpjnj eyoigx bhgpccy gwn dtuf
mxit xunctu vbyks wmqc jriuupl ybvks uncutx nsoxwrb ykt prc
yye mgf uhc irowpc dsdv iwaxod ftavlj dxzp tcch tcch mefz
rxe xwrrgl xwrrgl duu rxe xbbgoe
ucsz akswcd ojrmqq cox hgfh lxwu ltnnf cenikcp
opjhdp svwezr svwezr opjhdp
qojlkl ircxqnt utfmdg fcvr vehkcvt ufmzcpv xwlh ddavv xel bwlz fii
rzkayeh iursm zhily hdnq fqydfvt uwoy hptpiqu tdqy bgr xdr
ymruz umzry hbltwya jhwhzk flh tahylbw bdbaimb qscbp ntkuf
uxpato owsqyao vaog oenomkc usrmnc epua vzkppls
qxqczbk qyguz alawj xgjawtw wxtjgwa snfcdmz
fjfgos rmpd mgs vbk dlls jkljao eoovdfb ucdvaoq qmjmqku ney porr
nmcrqz zcoxpk dlnzksd ymh zyg spxss ruyk bychq gsgv eusiuid mnrqcz
jbzadnx lzl sdamer okoico frqisrm lxet agriw
xceoqr qai vahc jjzifsn exg
igjpn wfy ukn aag quro wklsq cjq bgtjrdz gmub wyhh
fzlwnm mygfn vkzwvw zvhsex gfki
ijvzgai ebmeq wssfmbq uguh sfuutm nwkgmex dxael liakdxs rnf sky yowpxc
bjzkyjh fced nji esowk qxsubsk qgtts
nkdgo bbjfq fgnxnhd gfjchl jetdb xubsgj eiju ldlm oxsx znft bbqfj
xovcnob pxfe pmstes yzkdm iqlvha nmcziix fexp ivqalh rxecqps
xpyew xudfud wwqe qhfjlcu epv fnrbgyv ihli qngtx yjlfg ozqbzn esp
timl gcohx vqzic gzm shwlkkv icqzv urchuc
xpqq gaqzwo cci dowahsr gaqzwo
jjsagdl umbpxre kyre zvaryft tmw pxpnjy
aqovcz nunq nnuq xjrvvh autjmit jiatumt
elg lps lge zjjot hwz tmqrup xaxxmo zlbzp uftd fukdad kvpymsm
iokwzal ywti zbdmzbu lprywe wbgbwza ypogbga kzliwao wstqi eqm keaeaj gbabwwz
lwfpk mhufe eddzgd ljxyqy vhzkct uemhf
lwqil fzugdo faq feppo usl llwqi
nje hthr ropq qvcepu bexszfj avmzjvv zajmvvv fhcd xnc cnx qnuaux
kvksn dphbyz nsx wrcc ccrw
nzpa pzzunfv ygzjy gxrrtcj hrt trh pwxpg yifgjmo fnupzzv wbzx
aepti rbojui ypvhe ubojri tcema aan dntkw qjx bfvmyos tcm hvoqytn
qpwq exu jvsiwj gsw avr vbemldy
xsbzpf xbzyvx xax sxh vpxt gccy xxa zhgbwoa hwwxoky fhvdxfc pvtx
pnsa ovtjolz tyutl eyjjzt jvtoolz owbypvr tytlu ewtzgec
cyg dwwk eihsp aeuk bbnay aluwyz hdmv uaek mwt ihpse wjhnkeg
fhzx vjetz vjub tejvz
ewwyb jidhu pyvyenn igtnyd tiwr akwkkbi myz xxjwb jjrdeg
jbkuw kwir rkiw ubwkj
bltffuw lftwufb hhsh wfbtulf nrxaa rlszi toijxnz czlci
bqrm pga zgblgcw pgwhhn lcgzwbg bcgzlgw yqb
mhjj vjoa gnjlc kclcr ito ofksy giavy fpqeioj
bkiqmif izidbui sttxxi bswhkxp sduuw
mjgnvw mjgwnv ojzyuv gvj
qxn kkhc whd fgwk auzugg augzgu kqfov wfgk
spdxbnu xpfofsb bpfsoxf ahjywql spbxoff
bwqxhlm wbqlxmh kqgpl fyzgf guhkvgx ovk qhmp gnrmu wvd wedj
vvwf hcnc vvwsngj qedzoxm hcnc qedzoxm kjthdi cbwqep qtvu
gio iqklmro noqablo bab jiqc rwebyg rqkloim wzmgs uunl amqs iwj
snxj szobqt zcgvwv wiyqknu
uto jteikwd cew gqsks hmvjtcy sach
zpgl qnkoex amhufmr figns upv xezrl rjleak nwrna
pzkvrdz dtonazj gtr gfxucuf lstjl lsjtl rgkope kzpdzrv lyptn zfxjys ttk
ddxgm lumlgki jhv doft kok swy ckds swy ddxgm lbfbdv
qfs rcufzgz iaiqw qfs qfs
nvkbo sgv mquwb ritpye nbkov poex hraorm qrrr qdt qefl
irxannd fiud ehyb ggx plqg pvvn uuptop tcvbm abuf bcfnmw
qwya ukblz epmbfr vmlon yqwa
hlo mmv vmm mvm
svzpxun yugbbe sbbpxs dmy xspbbs zhpovyf fyovhzp cpbt pke
zgk gft zybs zrgcoo ypu bue htgo
xnesq srsx pkzaoh cfqzugh
lntd nvxetbv clykjpd svmibpx evxtvnb yldkpjc
jsqq tzwak hephg eqwczd ioisa yim tmdifn mceip
kuwqz wzkqu zwchmj lfec uexne iztp llityt
kvamkpc pvbryqh ion cwizjde gln kcpvmak pzzlw gnl
ydeqf bfaab sydqhbp smsxdjr pynrs cqymt
onb eiab bno nob
mqslq scnelxv hyllrf scnelxv mqslq wmnbk
pttu kubby lgop bbyuk gsk skg ikktlbb inbyvz
xznvl zwtdj vbxdyd clhw
hgy zudelp ickc drfjgn iyws xhc
zzv wik iorhat qkb kjb lykdz vrce yjsjwj
gyw xzgbi efus uuy
hwcy ujdun bjjuvd jbdvju onnk xeyy mmp onkn qyzl
jwfm ptjwrbl hhuv uolz adyweh qpj wxyogp igvnojq jmfw pqs fsnirby";
            Console.WriteLine(Day4.PuzzleOne(input));
            Console.WriteLine(Day4.PuzzleTwo(input));

            Console.ReadKey();
        }
    }
}
