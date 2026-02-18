using static LoLCLI.Program;

namespace TestProject1
{
    public class UnitTest1
    {
        public Hos teszthos = new Hos("Parzival;a Magányos hős;Fighter;Fighter,Tank;Aatrox legendás harcos, egy ősi faj, a darkinok utolsó öt megmaradt tagjának egyike. Hatalmas pengéjét könnyedén és kecsesen forgatja – hipnotikus látvány, ahogy ellenségeit tizedeli. Aatrox pengéje mintha életre kelne, és levágott ellenfelei vérét ...;500;100;345;24,384;150;6,59;60,376;3,2;3");

        public UnitTest1()
        {
            hoslist.Add(teszthos);
        }

        [Fact]
        public void Test1()
        {
            
            Assert.Equal(1500,HpErtek("Parzival",10));
        }
        [Fact]
        public void Test2()
        {

            Assert.Equal(600, HpErtek("Parzival", 1));
        }
        [Fact]
        public void Test3()
        {

            Assert.Equal(1000, HpErtek("Parzival", 5));
        }
        [Fact]
        public void Test4()
        {

            Assert.Equal(2300, HpErtek("Parzival", 18));
        }



    }
}
