//
// MonoTests.Mono.Math.PrimeTestingTest.cs
//
// Authors:
//	Ben Maurer
//
// Copyright (c) 2003 Ben Maurer. All rights reserved
//

using System;
using Mono.Math;
using Mono.Math.Prime;
using NUnit.Framework;

namespace MonoTests.Mono.Math {

	public abstract class PrimeTesting_Base : BigIntegerTestSet {

		BigInteger P1, P2, P3;

		public PrimeTesting_Base () 
		{
			P1 = new BigInteger (p1);
			P2 = new BigInteger (p2);
			P3 = new BigInteger (p3);
		}

		public abstract uint[] p1 {
			get;
		}

		public abstract uint[] p2 {
			get;
		}

		public abstract uint[] p3 {
			get;
		}
		
		[Test]
		public void p1prime ()
		{
			ExpectPrime (P1);
		}

		[Test]
		public void p2prime ()
		{
			ExpectPrime (P2);
		}

		[Test]
		public void p3prime ()
		{
			ExpectPrime (P3);
		}

		[Test]
		public void p1p2composite ()
		{
			ExpectComposite (P1 * P2);
		}

		[Test]
		public void p1p3composite ()
		{
			ExpectComposite (P1 * P3);
		}

		[Test]
		public void p2p3composite ()
		{
			ExpectComposite (P2 * P3);
		}

		[Test]
		public void p1p2p3composite ()
		{
			ExpectComposite (P1 * P2 * P3);
		}

		private void ExpectComposite (BigInteger bi)
		{
			Assert.AreEqual (false, bi.IsProbablePrime ());
		}

		private void ExpectPrime (BigInteger bi)
		{
			Assert.AreEqual (true, bi.IsProbablePrime ());
		}
	}

	public class PrimeTesting_Rand1024 : PrimeTesting_Base {

		public override uint[] p1 {
			get {
				return new uint[] {
					0x48595126, 0xd1e0c772, 0x87f352a7, 0xeb3c496c, 0xce17d7ff, 0xce260883,
					0x4892835e, 0x4457170e, 0xb90a0893, 0x2a1bfd80, 0x56665a9c, 0x36b06f35,
					0x61988d45, 0xa04e18c2, 0xa2308414, 0xa0be5e2c, 0x423fad73, 0x7117b883,
					0x3977c11c, 0xf34c2c20, 0x045713c9, 0x0c82ea36, 0x3811b550, 0x7b03aafb,
					0xbc31f3c4, 0x8667b5a5, 0x3a5697f7, 0x064169e8, 0xd70dbae4, 0x9bb2a4f8,
					0xba6a1c1c, 0x7c6db863
				};
			}
		}

		public override uint[] p2 {
			get {
				return new uint[] {
					0x884462b0, 0x8295cefd, 0x444cbcb7, 0xd3916039, 0x45b1e26d, 0x02b3d8d5,
					0x3547b6ee, 0x0791ef10, 0x6da42d3e, 0xee537c9f, 0x339ee744, 0x97d328c7,
					0xebc9055a, 0xf3e1835c, 0xd9cff3db, 0xfe5f33d8, 0x45234644, 0x4af5031b,
					0x27f41403, 0x1d9d751b, 0xb711ddc7, 0xb331784f, 0x992b4148, 0x50a8ac7d,
					0x5c3f1fbb, 0x209d76e3, 0xfbd05088, 0xacf87776, 0xad214d60, 0x1f2ab42d,
					0xe9bc81fc, 0xe997d55b
				};
			}
		}

		public override uint[] p3 {
			get {
				return new uint[] {
					0xf732ee, 0x019ec52e, 0xfc360881, 0x4fd07211, 0x77d44ed0, 0xc27a4b3d,
					0xde2a9500, 0x2d4a2a70, 0x834e5d32, 0x715f5884, 0xc5922ca1, 0x94d48b60,
					0xb0262fce, 0x72040eb9, 0x5a4fd41c, 0x4e095cba, 0x3a840a36, 0x0175b3b4,
					0x64363623, 0xc03bd892, 0x39231a04, 0x521eee6c, 0x560e7c10, 0xa8476256,
					0xeefc3f37, 0xadd4c5ee, 0xf8407afc, 0x30e9c52c, 0x026849d3, 0x040533df,
					0xc286e00b, 0x9c377705
				};
			}
		}
	}

	public class PrimeTesting_Rand512 : PrimeTesting_Base {

		public override uint[] p1 {
			get {
				return new uint[] {
					0x99d95780, 0xd02a33bb, 0x980c079b, 0xbc43c3c2, 0xca501ce0, 0x3fc4bd85,
					0x51035dcc, 0x11dd4c8e, 0x59696b91, 0xcdc7cbc0, 0x29e5c884, 0xae628e88,
					0x908855b7, 0xab6218f3, 0x6abd6fb5, 0x3ca12af7
				};
			}
		}

		public override uint[] p2 {
			get {
				return new uint[] {
					0xc77a6a36, 0xfe547705, 0x98a57094, 0xc0dd1e8b, 0x78b62bc9, 0x19aea0da,
					0xb91b141b, 0xe4d34402, 0xdd16b9c6, 0x0ec73ea4, 0x8ad59ae5, 0x0d4b0f09,
					0x1fd1858d, 0xaac2891c, 0xbd56c29f, 0xb398ffa5
				};
			}
		}

		public override uint[] p3 {
			get {
				return new uint[] {
					0xb98e9b3a, 0x197d7671, 0x104d6b15, 0xe8c76058, 0xed9fcb77, 0x65c38af7,
					0xdd660b8e, 0x412c5bbb, 0x80b5f777, 0x70c1a458, 0xc9ad52ae, 0x489bae51,
					0x795f99a7, 0x2f2cb4ae, 0xc902c3ad, 0x9d96456f
				};
			}
		}
	}
	
	public class PrimeTesting_Rand128 : PrimeTesting_Base {

		public override uint[] p1 {
			get {
				return new uint[] {
					0x28480536, 0xeaf326bc, 0x2957b03b, 0xa1549e59
				};
			}
		}

		public override uint[] p2 {
			get {
				return new uint[] {
					0xd9ce28be, 0x6a279407, 0x8da0afbc, 0xa57eb9b3
				};
			}
		}

		public override uint[] p3 {
			get {
				return new uint[] {
					0x1d777a45, 0x957a0fad, 0x25d049a7, 0x4f73383b
				};
			}
		}
	}

	// Adapted from http://lists.ximian.com/archives/public/mono-devel-list/2003-November/003026.html
	// Note: these primes are taken from RFC 2412 [http://www.faqs.org/rfcs/rfc2412.html]
	[TestFixture]
	public class Rfc2412WellTestedPrimes {

		// E.1. Well-Known Group 1:  A 768 bit prime
		[Test]
		public void Prime768 () 
		{
			string prime = "1552518092300708935130918131258481755631334049434514313202351194902966239949102107258669453876591642442910007680288864229150803718918046342632727613031282983744380820890196288509170691316593175367469551763119843371637221007210577919";
			BigInteger bi = BigInteger.Parse (prime);
			Assert.IsTrue (bi.IsProbablePrime (), "isProbablePrime-768");
			Assert.AreEqual (prime, bi.ToString (), "ToString()");
		}

		// E.2. Well-Known Group 2:  A 1024 bit prime
		[Test]
		public void Prime1024 () 
		{
			string prime = "179769313486231590770839156793787453197860296048756011706444423684197180216158519368947833795864925541502180565485980503646440548199239100050792877003355816639229553136239076508735759914822574862575007425302077447712589550957937778424442426617334727629299387668709205606050270810842907692932019128194467627007";
			BigInteger bi = BigInteger.Parse (prime);
			Assert.IsTrue (bi.IsProbablePrime (), "isProbablePrime-1024");
			Assert.AreEqual (prime, bi.ToString (), "ToString()");
		}

		// Note: E.3 and E.4 are for Elliptic Curve Groups

		// E.5. Well-Known Group 5:  A 1536 bit prime
		[Test]
		public void Prime1536 () 
		{
			string prime = "2410312426921032588552076022197566074856950548502459942654116941958108831682612228890093858261341614673227141477904012196503648957050582631942730706805009223062734745341073406696246014589361659774041027169249453200378729434170325843778659198143763193776859869524088940195577346119843545301547043747207749969763750084308926339295559968882457872412993810129130294592999947926365264059284647209730384947211681434464714438488520940127459844288859336526896320919633919";
			BigInteger bi = BigInteger.Parse (prime);
			Assert.IsTrue (bi.IsProbablePrime (), "isProbablePrime-1536");
			Assert.AreEqual (prime, bi.ToString (), "ToString()");
		}
	}

	// http://primes.utm.edu/lists/small/small.html
	// note: BigInteger.IsProbablePrime defaults to Prime.ConfidenceFactor.Medium
	[TestFixture]
	public class SmallRandomPrimes {

		private void AssertPrime (ulong value)
		{
			Assert.IsTrue (new BigInteger (value).IsProbablePrime (), value.ToString ());
		}

		private void AssertPrime (string value)
		{
			Assert.IsTrue (BigInteger.Parse (value).IsProbablePrime (), value);
		}

		[Test]
		public void IsProbablePrime_10_digits ()
		{
			AssertPrime (5915587277);
			AssertPrime (1500450271);
			AssertPrime (3267000013);
			AssertPrime (5754853343);
			AssertPrime (4093082899);
			AssertPrime (9576890767);
			AssertPrime (3628273133);
			AssertPrime (2860486313);
			AssertPrime (5463458053);
			AssertPrime (3367900313);
		}

		[Test]
		public void IsProbablePrime_20_digits ()
		{
			AssertPrime ("48112959837082048697");
			AssertPrime ("54673257461630679457");
			AssertPrime ("29497513910652490397");
			AssertPrime ("40206835204840513073");
			AssertPrime (12764787846358441471);
			AssertPrime ("71755440315342536873");
			AssertPrime ("45095080578985454453");
			AssertPrime ("27542476619900900873");
			AssertPrime ("66405897020462343733");
			AssertPrime ("36413321723440003717");
		}

		[Test]
		public void IsProbablePrime_30_digits ()
		{
			AssertPrime ("671998030559713968361666935769");
			AssertPrime ("282174488599599500573849980909");
			AssertPrime ("521419622856657689423872613771");
			AssertPrime ("362736035870515331128527330659");
			AssertPrime ("115756986668303657898962467957");
			AssertPrime ("590872612825179551336102196593");
			AssertPrime ("564819669946735512444543556507");
			AssertPrime ("513821217024129243948411056803");
			AssertPrime ("416064700201658306196320137931");
			AssertPrime ("280829369862134719390036617067");
		}

		[Test]
		public void IsProbablePrime_40_digits ()
		{
			AssertPrime ("2425967623052370772757633156976982469681");
			AssertPrime ("1451730470513778492236629598992166035067");
			AssertPrime ("6075380529345458860144577398704761614649");
			AssertPrime ("3615415881585117908550243505309785526231");
			AssertPrime ("5992830235524142758386850633773258681119");
			AssertPrime ("4384165182867240584805930970951575013697");
			AssertPrime ("5991810554633396517767024967580894321153");
			AssertPrime ("6847944682037444681162770672798288913849");
			AssertPrime ("4146162919458530168953357282201621124057");
			AssertPrime ("5570373270183181665098052481109678989411");
		}

		[Test]
		public void IsProbablePrime_50_digits ()
		{
			AssertPrime ("22953686867719691230002707821868552601124472329079");
			AssertPrime ("30762542250301270692051460539586166927291732754961");
			AssertPrime ("29927402397991286489627837734179186385188296382227");
			AssertPrime ("46484729803540183101830167875623788794533441216779");
			AssertPrime ("95647806479275528135733781266203904794419563064407");
			AssertPrime ("64495327731887693539738558691066839103388567300449");
			AssertPrime ("58645563317564309847334478714939069495243200674793");
			AssertPrime ("48705091355238882778842909230056712140813460157899");
			AssertPrime ("15452417011775787851951047309563159388840946309807");
			AssertPrime ("53542885039615245271174355315623704334284773568199");
		}

		[Test]
		public void IsProbablePrime_60_digits ()
		{
			AssertPrime ("622288097498926496141095869268883999563096063592498055290461");
			AssertPrime ("610692533270508750441931226384209856405876657993997547171387");
			AssertPrime ("668486051696691190102895306426999370394054817506916629001851");
			AssertPrime ("313539589974026666385010319707341761012894704055733952484113");
			AssertPrime ("470287785858076441566723507866751092927015824834881906763507");
			AssertPrime ("361720912810755408215708460645842859722715865206816237944587");
			AssertPrime ("378348910233465647859184421334615532543749747185321634086219");
			AssertPrime ("669483106578092405936560831017556154622901950048903016651289");
			AssertPrime ("351300033958683656629281197430236951045077917074227778834807");
			AssertPrime ("511704374946917490638851104912462284144240813125071454126151");
		}

		[Test]
		public void IsProbablePrime_70_digits ()
		{
			AssertPrime ("4669523849932130508876392554713407521319117239637943224980015676156491");
			AssertPrime ("4906275427767802358357703730938087362176142642699093827933107888253709");
			AssertPrime ("2409130781894986571956777721649968801511465915451196376269177305066867");
			AssertPrime ("7595009151080016652449223792726748985452052945413160073645842090827711");
			AssertPrime ("3822535632033509464266159811805197854872067042990716005808372194664933");
			AssertPrime ("5885903965180586669073549360644800583458138238012033647539649735017287");
			AssertPrime ("5850725702766829291491370712136286009948642125131436113342815786444567");
			AssertPrime ("4237080979868607742750808600846638318022863593147774739556427943294937");
			AssertPrime ("3773180816219384606784189538899553110499442295782576702222280384917551");
			AssertPrime ("9547848065153773335707495885453566120069130270246768806790708393909999");
		}

		[Test]
		public void IsProbablePrime_80_digits ()
		{
			AssertPrime ("18532395500947174450709383384936679868383424444311405679463280782405796233163977");
			AssertPrime ("39688644836832882526173831577536117815818454437810437210221644553381995813014959");
			AssertPrime ("44822481511601066098713481453161748979849764719554039096395688045048053310178487");
			AssertPrime ("54875133386847519273109693154204970395475080920935355580245252923343305939004903");
			AssertPrime ("40979218404449071854385509743772465043384063785613460568705289173181846900181503");
			AssertPrime ("56181069873486948735852120493417527485226565150317825065106074926567306630125961");
			AssertPrime ("19469495355310348270990592580191998639221450743640952620236903851789700309402857");
			AssertPrime ("34263233064835421125264776608163440537925705997962346596977803462033841059628723");
			AssertPrime ("14759984361802021245410475928101669395348791811705709117374129427051861355011151");
			AssertPrime ("67120333368520272532940669112228025474970578938046280618394371551488988323794243");
		}

		[Test]
		public void IsProbablePrime_90_digits ()
		{
			AssertPrime ("282755483533707287054752184321121345766861480697448703443857012153264407439766013042402571");
			AssertPrime ("370332600450952648802345609908335058273399487356359263038584017827194636172568988257769601");
			AssertPrime ("463199005416013829210323411514132845972525641604435693287586851332821637442813833942427923");
			AssertPrime ("374413471625854958269706803072259202131399386829497836277471117216044734280924224462969371");
			AssertPrime ("664869143773196608462001772779382650311673568542237852546715913135688434614731717844868261");
			AssertPrime ("309133826845331278722882330592890120369379620942948199356542318795450228858357445635314757");
			AssertPrime ("976522637021306403150551933319006137720124048624544172072735055780411834104862667155922841");
			AssertPrime ("635752334942676003169313626814655695963315290125751655287486460091602385142405742365191277");
			AssertPrime ("625161793954624746211679299331621567931369768944205635791355694727774487677706013842058779");
			AssertPrime ("204005728266090048777253207241416669051476369216501266754813821619984472224780876488344279");
		}

		[Test]
		public void IsProbablePrime_100_digits ()
		{
			AssertPrime ("2074722246773485207821695222107608587480996474721117292752992589912196684750549658310084416732550077");
			AssertPrime ("2367495770217142995264827948666809233066409497699870112003149352380375124855230068487109373226251983");
			AssertPrime ("1814159566819970307982681716822107016038920170504391457462563485198126916735167260215619523429714031");
			AssertPrime ("5371393606024775251256550436773565977406724269152942136415762782810562554131599074907426010737503501");
			AssertPrime ("6513516734600035718300327211250928237178281758494417357560086828416863929270451437126021949850746381");
			AssertPrime ("5628290459057877291809182450381238927697314822133923421169378062922140081498734424133112032854812293");
			AssertPrime ("2908511952812557872434704820397229928450530253990158990550731991011846571635621025786879881561814989");
			AssertPrime ("2193992993218604310884461864618001945131790925282531768679169054389241527895222169476723691605898517");
			AssertPrime ("5202642720986189087034837832337828472969800910926501361967872059486045713145450116712488685004691423");
			AssertPrime ("7212610147295474909544523785043492409969382148186765460082500085393519556525921455588705423020751421");
		}

		[Test]
		public void IsProbablePrime_200_digits ()
		{
			AssertPrime ("58021664585639791181184025950440248398226136069516938232493687505822471836536824298822733710342250697739996825938232641940670857624514103125986134050997697160127301547995788468137887651823707102007839");
			AssertPrime ("29072553456409183479268752003825253455672839222789445223234915115682921921621182714164684048719891059149763352939888629001652768286998932224000980861127751097886364432307005283784155195197202827350411");
			AssertPrime ("41184172451867371867686906412307989908388177848827102865167949679167771021417488428983978626721272105583120243720400358313998904049755363682307706550788498535402989510396285940007396534556364659633739");
			AssertPrime ("54661163828798316406139641599131347203445399912295442826728168170210404446004717881354193865401223990331513412680314853190460368937597393179445867548835085746203514200061810259071519181681661892618329");
			AssertPrime ("71611195866368241734230315014260885890178941731009368469658803702463720956633120935294831101757574996161931982864195542669330457046568876289241536680683601749507786059442920003278263334056542642264651");
			AssertPrime ("28591045597720075832628274729885724490653298360003309382769144463123258670807750560985604954275365591715208615509779345682419533206637382048824349415329839450792353652240682445321955199147316594996133");
			AssertPrime ("49790921912819110019003521637763748399072771256062128988437189616228355821145834783451215869998723492323628198577054239101181556609916127864608488018093426129641387774385490891035446702272744866010729");
			AssertPrime ("15474811206486587193258690501682404626361341756658894201908294153626080782693777003022566996735796983239343580281979005677758015801189957392350213806122307985157041153484138150252828152419133170303749");
			AssertPrime ("12654646219963267405298825104551142450213038420566798208417393291567314379831789259173233506811083774527183953999862675239292185131178671317061020444490733287588383918793095608410078925861028249824377");
			AssertPrime ("40992408416096028179761232532587525402909285099086220133403920525409552083528606215439915948260875718893797824735118621138192569490840098061133066650255608065609253901288801302035441884878187944219033");
		}

		[Test]
		public void IsProbablePrime_300_digits ()
		{
			AssertPrime ("203956878356401977405765866929034577280193993314348263094772646453283062722701277632936616063144088173312372882677123879538709400158306567338328279154499698366071906766440037074217117805690872792848149112022286332144876183376326512083574821647933992961249917319836219304274280243803104015000563790123");
			AssertPrime ("531872289054204184185084734375133399408303613982130856645299464930952178606045848877129147820387996428175564228204785846141207532462936339834139412401975338705794646595487324365194792822189473092273993580587964571659678084484152603881094176995594813302284232006001752128168901293560051833646881436219");
			AssertPrime ("319705304701141539155720137200974664666792526059405792539680974929469783512821793995613718943171723765238853752439032835985158829038528214925658918372196742089464683960239919950882355844766055365179937610326127675178857306260955550407044463370239890187189750909036833976197804646589380690779463976173");
			AssertPrime ("250556952327646214427246777488032351712139094643988394726193347352092526616305469220133287929222242315761834129196430398011844978805263868522770723615504744438638381670321613949280530254014602887707960375752016807510602846590492724216092721283154099469988532068424757856392563537802339735359978831013");
			AssertPrime ("290245329165570025116016487217740287508837913295571609463914348778319654489118435855243301969001872061575755804802874062021927719647357060447135321577028929269578574760547268310055056867386875959045119093967972205124270441648450825188877095173754196346551952542599226295413057787340278528252358809329");
		}
	}
}
