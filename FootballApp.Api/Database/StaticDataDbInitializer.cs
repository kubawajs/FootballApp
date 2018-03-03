using FootballApp.Api.Models;

namespace FootballApp.Api.Database
{
    public static class StaticDataDbInitializer
    {
        public static PostedLink[] InitializePostedLinks()
        {
            var postedLinks = new PostedLink[]
            {
                PostedLink.Create("Heynckes doradził \"Lewemu\" w sprawie transferu", "http://sport.tvp.pl/36246905/heynckes-doradzil-lewemu-w-sprawie-transferu", "Media wciąż spekulują o przyszłości Roberta Lewandowskiego. Napastnika Bayernu Monachium łączy się z transferem do m.in. Realu Madyt oraz Chelsea. Głos w tej sprawie zabrał trener Bawarczyków Jupp Heynckes."),
                PostedLink.Create("Serie A. Arkadiusz Milik wraca do kadry meczowej! Oficjalnie", "http://www.sport.pl/pilka/7,65083,23094318,serie-a-arkadiusz-milik-wraca-do-kadry-meczowej-oficjalnie.html#MT_2Zdjecia", "Stało się. Arkadiusz Milik znalazł się w kadrze meczowej Napoli na hit Serie A. W sobotę o godz. 20.45 lider ligi włoskiej zagra na własnym stadionie z Romą. Czekamy na powrót na boisko!"),
                PostedLink.Create("PSG. Operacja Neymara zakończona powodzeniem", "https://eurosport.interia.pl/raporty/raport-ms-rosja-2018/aktualnosci/news-psg-operacja-neymara-zakonczona-powodzeniem,nId,2552663", "Operacja stopy piłkarza Paris Saint-Germain Neymara zakończyła się powodzeniem - poinformował w oficjalnym oświadczeniu rzecznik prasowy brazylijskiej federacji Vinicius Rodrigues. Zabieg został przeprowadzony w klinice w Belo Horizonte."),
                PostedLink.Create("Debiut w Chinach Yannicka Carrasco jak z koszmaru", "https://eurosport.interia.pl/pilka-nozna/news-debiut-w-chinach-yannicka-carrasco-jak-z-koszmaru,nId,2552686", "Yannick Carrasco, do niedawna jeden z gwiazdorów Atletico Madryt, sensacyjnie zimą przeniósł się do Dalian Yifang. Beniaminek chińskiej Super League zapłacił za Belga aż 40 milionów euro. Jednak klub i jego nowy napastnik nie będą dobrze wspominać ligowego debiutu, przegranego z Szanghaj SIPG 0-8."),
                PostedLink.Create("To już wiemy na pewno! VAR będzie używany na Mundialu!", "https://footroll.pl/newsy/reprezentacje/3296,to-juz-wiemy-na-pewno-var-bedzie-uzywany-na-mundialu", "Jeśli wydawało wam się, że jedynym czynnikiem, który może podwyższyć poziom adrenaliny we krwi przed Mundialem jest losowanie grup, to byliście w błędzie. Dyskusja zawrzała ponownie, a to dlatego, że już wiemy na pewno, że VAR pojawi się na Mistrzostwach Świata!"),
                PostedLink.Create("Heynckes doradził \"Lewemu\" w sprawie transferu", "http://sport.tvp.pl/36246905/heynckes-doradzil-lewemu-w-sprawie-transferu", "Media wciąż spekulują o przyszłości Roberta Lewandowskiego. Napastnika Bayernu Monachium łączy się z transferem do m.in. Realu Madyt oraz Chelsea. Głos w tej sprawie zabrał trener Bawarczyków Jupp Heynckes."),
                PostedLink.Create("Serie A. Arkadiusz Milik wraca do kadry meczowej! Oficjalnie", "http://www.sport.pl/pilka/7,65083,23094318,serie-a-arkadiusz-milik-wraca-do-kadry-meczowej-oficjalnie.html#MT_2Zdjecia", "Stało się. Arkadiusz Milik znalazł się w kadrze meczowej Napoli na hit Serie A. W sobotę o godz. 20.45 lider ligi włoskiej zagra na własnym stadionie z Romą. Czekamy na powrót na boisko!"),
                PostedLink.Create("PSG. Operacja Neymara zakończona powodzeniem", "https://eurosport.interia.pl/raporty/raport-ms-rosja-2018/aktualnosci/news-psg-operacja-neymara-zakonczona-powodzeniem,nId,2552663", "Operacja stopy piłkarza Paris Saint-Germain Neymara zakończyła się powodzeniem - poinformował w oficjalnym oświadczeniu rzecznik prasowy brazylijskiej federacji Vinicius Rodrigues. Zabieg został przeprowadzony w klinice w Belo Horizonte."),
                PostedLink.Create("Debiut w Chinach Yannicka Carrasco jak z koszmaru", "https://eurosport.interia.pl/pilka-nozna/news-debiut-w-chinach-yannicka-carrasco-jak-z-koszmaru,nId,2552686", "Yannick Carrasco, do niedawna jeden z gwiazdorów Atletico Madryt, sensacyjnie zimą przeniósł się do Dalian Yifang. Beniaminek chińskiej Super League zapłacił za Belga aż 40 milionów euro. Jednak klub i jego nowy napastnik nie będą dobrze wspominać ligowego debiutu, przegranego z Szanghaj SIPG 0-8."),
                PostedLink.Create("To już wiemy na pewno! VAR będzie używany na Mundialu!", "https://footroll.pl/newsy/reprezentacje/3296,to-juz-wiemy-na-pewno-var-bedzie-uzywany-na-mundialu", "Jeśli wydawało wam się, że jedynym czynnikiem, który może podwyższyć poziom adrenaliny we krwi przed Mundialem jest losowanie grup, to byliście w błędzie. Dyskusja zawrzała ponownie, a to dlatego, że już wiemy na pewno, że VAR pojawi się na Mistrzostwach Świata!")
            };

            return postedLinks;
        }
    }
}
