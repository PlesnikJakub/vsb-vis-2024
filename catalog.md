# Patterns Catalog

## Business Layer

Business vrstva obsahuje obchodní logiku aplikace, tedy pravidla a procesy, které určují, jak se data zpracovávají a jaké operace lze provádět. Business layer komunikuje s prezentační vrstvou (pro uživatelské požadavky) a s datovou vrstvou (pro práci s daty). Izolace logiky v této vrstvě umožňuje snadnější správu a rozšiřitelnost systému.

### Transaction Script
**Transaction Script** je návrhový vzor, který organizuje logiku aplikace jako řadu procedur, kde každá procedura provádí jeden typ transakce. Tento vzor je vhodný pro jednoduché aplikace a logiku, kterou lze snadno oddělit do samostatných kroků.

### Domain Model
**Domain Model** představuje objektově orientovaný model doménové logiky. Každý objekt v modelu odpovídá prvku z domény problému a má své chování a stav, čímž umožňuje komplexnější a přirozenější reprezentaci logiky.

### Table Module
**Table Module** používá jednu třídu pro každou tabulku v databázi, kde každá instance reprezentuje řádek tabulky. Tento vzor centralizuje logiku pro konkrétní tabulku, což umožňuje jednodušší údržbu a rozšiřování aplikace.

### Service Layer
**Service Layer** definuje vrstvy služeb, které oddělují logiku aplikace od ostatních vrstev (např. prezentační či datové vrstvy). Tento vzor usnadňuje testování a opakované použití obchodní logiky.

## Data Layer
Datová vrstva spravuje přístup k datům a zajišťuje jejich uložení a načítání, typicky z databáze. Obsahuje kód pro připojení k databázím, CRUD operace (Create, Read, Update, Delete) a mapování dat mezi databází a objekty aplikace. Datová vrstva komunikuje s business vrstvou a je klíčová pro zabezpečení a integritu dat.

### Table Data Gateway
**Table Data Gateway** poskytuje rozhraní pro přístup k datům v databázové tabulce. Každá metoda odpovídá konkrétní operaci nad tabulkou, což umožňuje centralizovanou správu přístupu k datům.

### Row Data Gateway
**Row Data Gateway** zajišťuje přístup k jednotlivým řádkům tabulky databáze, přičemž každá instance představuje jeden řádek. Tento vzor umožňuje práci s daty na úrovni jednotlivých záznamů.

### Data Mapper
**Data Mapper** odděluje logiku mapování dat mezi objektovým modelem aplikace a relační databází. Tento vzor podporuje čistou architekturu, protože objekty nemají žádnou závislost na databázi.

### Active Record
**Active Record** je vzor, kde každá třída reprezentuje tabulku v databázi a každý objekt instancuje konkrétní řádek. Tento objekt je zodpovědný za operace sám nad sebou, což usnadňuje přístup k datům.

## Objektově relační chování

### Unit of Work
**Unit of Work** spravuje sadu změn v transakci a zajišťuje, že všechny operace s databází jsou vykonány jako jedna transakce. Pomáhá snížit konflikty při provádění více operací nad databází.

### Lazy Load
**Lazy Load** odkládá načítání dat až do okamžiku, kdy jsou skutečně potřeba. Tento vzor šetří systémové zdroje a zvyšuje efektivitu práce s daty.

### Identity Map
**Identity Map** slouží k uchování již načtených objektů, čímž zajišťuje, že každý objekt z databáze je načten pouze jednou a eliminuje duplicity.

## Objektově relační struktury

### Identity Field
**Identity Field** používá unikátní identifikátor pro jednoznačnou identifikaci objektů z databáze. Tento vzor pomáhá spravovat identifikaci objektů v aplikaci.

### Foreign Key Mapping
**Foreign Key Mapping** zajišťuje propojení objektů pomocí cizích klíčů z databáze. Tento vzor odráží relační vazby mezi daty přímo v objektovém modelu.

### Association Table Mapping
**Association Table Mapping** používá speciální tabulku k reprezentaci vazby mezi dvěma entitami v databázi, což umožňuje flexibilní propojení bez narušení struktury hlavních tabulek.

### Dependent Mapping
**Dependent Mapping** mapuje objekty, které jsou závislé na jiném objektu a nemají samostatnou identitu. Tento vzor je užitečný při práci s komplexními objekty, které je potřeba propojit.

### Embedded Value
**Embedded Value** ukládá hodnotu objektu přímo ve sloupci jiné tabulky, což umožňuje efektivnější strukturování složených dat bez vytvoření nové tabulky.

### Serialized LOB
**Serialized LOB** ukládá komplexní objekt jako jedno sériové pole ve formě Large Object (LOB), což usnadňuje ukládání nestrukturovaných dat do databáze.

## Mapování dědičnosti

### Single Table Inheritance
**Single Table Inheritance** používá jednu tabulku k reprezentaci všech tříd v hierarchii dědičnosti. Typ objektu je identifikován sloupcem, což umožňuje efektivní reprezentaci, ale může přinášet zbytečná data.

### Class Table Inheritance
**Class Table Inheritance** ukládá každou třídu z dědičné hierarchie do samostatné tabulky, což zlepšuje normalizaci dat, ale komplikuje složitost dotazování.

### Concrete Table Inheritance
**Concrete Table Inheritance** využívá samostatné tabulky pro každou konkrétní třídu, bez ohledu na dědičnost. Tento vzor minimalizuje redundantní data a uchovává pouze nezbytné sloupce pro konkrétní třídu.

## Ostatní

### DTO
**DTO (Data Transfer Object)** slouží pro přenos dat mezi vrstvami aplikace, aniž by byla sdílena složitá obchodní logika. Zajišťuje rychlý a efektivní přenos dat mezi různými částmi systému.