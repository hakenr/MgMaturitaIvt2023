# Mensa gymnázium, o.p.s. - Maturitní zkouška z IVT 2023 - Zadání

## Pokyny
Níže najdete zadání čtyř úloh. Tři z nich naprogramujte ve vhodném programovacím jazyce, jednu můžete vynechat, nebo využít pro získání bonusových bodů. Na práci máte 240 minut, po krátké přestávce pak 15 minut na obhajobu před komisí.

Komunikovat smíte pouze se zkoušejícím(i), ale jinak můžete používat internet, literaturu, knihovny, tutoriály, dokumentace, svoje vlastní poznámky, svůj vlastní kód apod.

Pište přehledný, komentovaný, čitelný kód. Nebojte se ptát zkoušejících, v nejhorším vám neodpovíme, nebo nabídneme popostrčení kupředu za cenu bodové ztráty.

Není-li předepsaný formát vstupu/výstupu, zvolte vhodnou reprezentaci dle vlastního uvážení, která vám umožní předvést funkčnost algoritmu při obhajobě (stdin-out, konzolová aplikace, GUI, ...).

### Odevzdání a obhajoba
Založte si privátní GitHub repozitář(e), do kterého **průběžně pushujte** postup své práce. Do repozitáře [**nastavte přístup (colaborator)**](https://docs.github.com/en/account-and-profile/setting-up-and-managing-your-github-user-account/managing-access-to-your-personal-repositories/inviting-collaborators-to-a-personal-repository) pro následující GitHub účty:
* `hakenr`
* `TODO`

Při závěrečné obhajobě (15 min) bude vaším úkolem představit řešení a funkčnost jednotlivých úloh:
* vysvětlit stručně postup algoritmu,
* ukázat a popsat zdrojový kód (lze spojit s vysvětlováním algoritmu),
* předvést spustitelný a funkční program (musí být možné předat vstupy a ověřit výstupy)

Pamatujte na omezený čas obhajoby, na každou úlohu je max. 5 minut.

### Hodnocení
Za každou úlohu můžete získat 0-30 bodů, dalších 0-10 bodů pak můžete získat u obhajoby.
Výsledné hodnocení se určí takto:
* 86 a více bodů - výborné,
* 68 až 85 bodů - chvalitebné,
* 50 až 67 bodů - dobré,
* 33 až 49 bodů - dostatečné,
* 32 a méně bodů - nedostatečné - neuspěl(a)



## Úloha 1: Fibonacciho součet
V matematice existuje zajímavá vlastnost, která umožňuje jednoznačně vyjádřit každé kladné celé číslo `n` jako součet různých členů Fibonacciho posloupnosti, kdy žádné dva členy spolu nesousedí.

(Fibonacciho posloupnost je posloupnost čísel, kde každé číslo je součtem dvou předchozích čísel v posloupnosti `F(n) = F(n-1) + F(n-2)`. Fibonacciho posloupnost začíná čísly 0, 1, 1, 2, 3, 5, 8, 13, 21, ...)

Vaším úkolem je vytvořit program, který pro zadané celé číslo `n` určí, jakými členy Fibonacciho posloupnosti se dá toto číslo vyjádřit. Jako vstupní hodnota bude použito kladné celé číslo menší nebo rovné 1 000 000.

#### Vstup

* číslo *n*

#### Výstup

* členy Fibonacciho posloupnosti, jejichž součtem je číslo `n`

#### Příklad vstupu a výstupu

```
10 = 8 + 2
27 = 21 + 5 + 1
1000 = 987 + 13
```

*Poznámka:* Tento jev má své pojmenování, které zde záměrně neuvádíme, abychom příliš neusnadnili hledání vzorových řešení úlohy.


## Úloha 2: Rotující prvočíslo
Vaším úkolem je napsat program, který bude schopen identifikovat n-té rotující prvočíslo. Program by měl být schopen přijmout celé číslo `n` jako vstup od uživatele a vracet `n`-té rotující prvočíslo jako výstup.

#### Pravidla
* Rotující prvočíslo je prvočíslo, které zůstává prvočíslem pro každou rotaci jeho číslic.
* Příkladem může být číslo 197, protože všechny rotace jeho číslic (197, 971 a 719) jsou prvočísla.
* Číslo 1 je považováno za první prvočíslo.

#### Příklady vstupu a výstupu
```
5 => 11
10 => 71
15 => 131
```

Pokuste se svůj algoritmus výkonově optimalizovat, popř. si připravte další možnosti optimalizace k obhajobě.