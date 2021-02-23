# Flow1UnityHandIn

Lines Mathias
#
Mit arbejde har været været med disse emner: Simple shapes, camera, components, scripting/references, input, colliders/triggers og terrain. I mit afsnit, vil jeg beskrive hvad jeg har lavet på projektet.
Vulkanens form og struktur, samt banen op af vulkanen, er lavet af mig. I forhold til banen, har jeg, med små skridt, lavet en "set height" på terrænet så der kom en trappelignende truktur op af vulkanen, og det samme med udformingen af indgangen til vulkanen. Texture på terrain og vulkan blev også downloadet og tegnet på.

Nede i vulkanen, er der en sphere med en meshcollider som trigger. Så når spilleren trigger den, skrev jeg et script, så han/hun bliver teleporteret til foden af vulkanen. Foran vil man så kunne se en floating 3d text der siger "you win". Denne funktion fungerer som ønsket, men i fremtiden, ønskes en endnu bedre løsning.

Udfordringen kom da jeg skulle lave en "player", der kunne bevæge sig og kameraet med den. Jeg forsøgte mig med en sphere, kom en rigidbody på og måtte google mig til en tutorial om input og bevægelse. Kuglen bevægede sig derefter. Jeg måtte også se en tutorial om kameraet, som jeg fik til at følge player, og fik musen til at panoere rundt om playeren. Problemet var, at når jeg bevæger kuglen, er inputtets "nord-øst-syd-vest" retninger, fastslået og kunne ikke få den til at rette sig efter kameraet retning, så fremad altid var fremad i forhold til kameraets synsvinkel. Måtte give op på denne spiller, og vi tog beslutningen om at bruge "shadow" som spiller.



#
Lines Matti
#
Mine 3 læringsmål brugt er First Scripting + references (both in code and inspector), Components, Colliders & Triggers.

Jeg har arbejdet på vulkanen og lavet obstacles som ruller ned af vulkanen random. Det havde den udfordring at man ikke ville havde at de kunne lande på vejen op i playeren uden at han havde chancen for at se den komme først.

Jeg har lavet respawn som også justeret text til at sige "you lost", når man så fuldføre målet at komme op i vulkanen bliver den så inactive. Jeg har lavet en nummer 2 fjende som er vandpytter som hvis man rør dem bliver man også sendt tilbage til starten. Jeg har prøvet at lære om partikle effekter og har brugt en del af tiden på at adde partikle effekter til vulkanen og vandpytterne for at skabe en lidt mere levende effekt. Prøvede og at lave vind men det fik jeg ikke helt taget med til sidst da det ikke virkede på den måde jeg ønskede det skulle. Jeg har tilføjet en bro og nogen hegn for at få verden til at se mindre tom ud og for at gøre så player ikke bliver ramt i spawn. 

Burde nok også nævnes at jeg forsøgte at lave respawn til en "også slet alle obstacles knap" men at den ikke kunne det da den var afhængig af et af obstacle på samme tid, altså det som den respawner pga den ramte. 

I fremtidige projekter vil der forhåblig ikke være så mange problemer med github så vi kan komme i gang lidt hurtigere og få lavet lidt mere.
Kunne godt havde ønsket at der var noget der fuldte player op af bjerget eller en tredje måde at respawne på som gjorde at selve obstacles som kom ned af bjerget ikke havde en lige så stor rolle i spillet.
