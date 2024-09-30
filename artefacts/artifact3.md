# Technical specification
  
## Konceptual domain model
Vytvořte jednoduchý návrh doménového modelu 

https://www.uml-diagrams.org/examples/hospital-domain-diagram.html
https://www.uml-diagrams.org/library-domain-uml-class-diagram-example.html


1. Model doplňte o tabulky s odhady velikostí entit a jejich množstvím.
    * Tabulka s přílohami bude mít 1-5mb na záznam a systém počítá se 100 000 až 1 000 000 záznamů.
    * Tabulka s uživateli bude mít max 500kb na záznam a max 100 000 záznamů.


1. Odhad počtu uživatelů současně pracujících se systémem.
    * Odhadněte peak a průměr.
2. Typy interakcí uživatelů se systémem a odhad jejich náročnosti.
    * jaké operace systém budou vytěžovat po stránce výpočetní náročnosti, IO operací etc.
3. První představa o rozložení systému a volba platforem.
    * Jaké technologie použijete(.net, js, typ DB), jaké platformy budou cíleny(mobile, web, desktop)