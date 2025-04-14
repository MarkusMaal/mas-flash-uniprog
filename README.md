![uniprog-logo](Resources/mas_flash.png)
# Markuse mälupulga universaalprogramm (aegunud)

* Keel: Visual Basic .NET ja Batch (back-end mõnede funktsioonide jaoks)
* UI platvorm: Windows Forms
* Sõltuvused: Microsoft VisualBasic PowerPacks 10.0
* Valmimise aasta: 2017
* Viimane uuendus: 21. august 2018. a
* Eelkäija: Markuse mälupulga pakkfail (Batchfile)
* Järeltulija: Markuse mälupulga juhtpaneel (C#)
* Ilmumine videotes: [Markuse asjad 2017 (treiler)](https://www.youtube.com/watch?v=QdDMVHuoAzM), [Markuse asjad aastal 2017](https://www.youtube.com/watch?v=h7_XD_JmE3Y)
* Arendaja PIN kood: 43218765

## Alternatiivsed käivitusreþiimid

Programmi laadimisakna kuvamise ajal saate vajutada erinevaid klahve, et muuta käivitusreþiimi.

* ESC - Katkesta 
* M/m - Arendaja
* a - Pakkfail
* r - Taaste
* k - Kiirkäivitus (pakkfail)
* u - Käsitsi seade
* s - Turvareþiim (pakkfail)
* e - Katkesta (pakkfail)

## Vormid

* br - Varundamine ja taaste
* del - Markuse asjade kustutamine
* delb - Varunduse kustutamine (ei ole kasutusel)
* delstr - Kiirrakenduse kustutamine
* Developer - Arendaja aken
* Drivedialog - Ketta valiku aken (kui arvutisse on sisestatud mitu mälupulka)
* Editor - Uudise redigeerimise aken
* MainScreen - Põhiaken
* option - Veaekraan, mis kuvatakse kui mälupulka ei leita
* Splash - Programmi laadimiskuva


## Oodatav mälupulga failistruktuur

Markuse mälupulkadel on väga kindel kaustastruktuur, mida see programm nõuab.

* E_INFO\ - Mälupulga väljaande info
	* edition.txt - Väljaande nimi (lihttekstina, üks rida UTF-8 kodeeringus)
	* edition.cmd - Batch formaadis muutujate määratlused, sh verifycode (suvaline 7-kohaline arv), edition (väljaande nimi, sama mis edition.txt-s) ja verifyspace (tühi sõne)
	* uudis1.rtf - uudis5.rtf - Uudise failid (kuvatakse programmi põhiaknas)
	* videod.txt - Loetelu failidest \Markuse_videod kaustas ilma järjekorranumbrita, nimed eraldatud semikooloniga
* Markuse_videod\ - Uusimad/Esiletõstetud videod (3 tk)
	* Iga video failinimi on nummerdatud vastavalt sellest järjakorras, mis nad ilmuvad videod.txt failis, nt kui videod.txt failis on esimene video failinimega "TestVideo.mp4", siis siin oleks ta tegelik failinimi "1. TestVideo.mp4"
* NTFS\ - Kontrollinfo
	* config.sys - Mälupulga PIN kood UTF-8 lihttekstina, faili lõpus on tühi rida (\r\n)
* PortableInstall\
	* files\ - Vaikefailid
		* autorun.inf - Mälupulga autorun
		* set_attrib.bat - Peidab autorun.inf faili mälupulga juurkataloogis
* markuse asjad\ - Markuse asjade juurkataloog
	* Kiirrakendused - Mälupulgal olevad kiirrakendused. Iga kiirrakenduse alamkataloogis (tähis [Nimi]) on erinevad failid, mida see programm otsib.
		* [Nimi]\
			* [Nimi]Info.txt - Kiirrakenduse kirjeldus UTF-16 LE kodeeringus
			* [Nimi]Portable.exe - Käivitatav kiirrakendus
			* [Nimi]ScreenShot.bmp - Kiirrakenduse kuvatõmmis, mis kuvatakse universaalprogrammis
		* Ehk näiteks siis kui kiirrakendus asub kataloogis 7-Zip, siis seal sees omakorda on failid 7-ZipInfo.txt, 7-ZipPortable.exe, 7-ZipScreenShot.bmp ja kõik muu kiirrakenduse toimimiseks vajalik, mis ei kasuta neid failinimesid
	* markuse asjad\ - Kasutaja/Profiili kataloogid (tähis [Profiil])
		* [Profiil] - Kasutaja profiili kataloog (alamkaustades võib olla ükskõik mis)
			* Abi\
			* Minu videod\
			* Muud asjad\
			* Muusika\
			* Paigaldatavad failid\
			* Pildid\
			* PowerPoint\
			* PowerPointi mallid\
			* Tekst\
			* Word\
		* Mine\
		* kasutajad.txt - List kasutajaprofiilidest lihttekstina, UTF-8 kodeering, nimed eraldatud semikooloniga, fail peab lõppema semikooloniga
* multiboot\ - YUMI paigaldus
* Batch\ - Uuemates programmides Pakkfailid\, siin kaustas on erinevad Batch failid
	* markuse_asjad.bat - Mälupulga pakkfail (vajalik ainult "Pakkfail" käivitusreþiimi jaoks)
	* markuse_asjade_seaded.cmd - Mälupulga pakkfaili seadete fail (vajalik ainult "Pakkfail" käivitusreþiimi jaoks)
* mas_flash.ico - Markuse mälupulga ikoon
* autorun.inf - Mälupulga autorun
* autorun.exe - See programm kompileeritud kujul

## Puudused

* Uuemad Premium väljaande mälupulgad ei toimi õigesti selle programmiga erinevuste tõttu mälupulga juhtpaneeliga
* Ei toeta turvalist PIN-koodi süsteemi (seepärast tuleb uuemates programmides sisse lülitada "Ebaturvaline PIN-kood")
* Nõuab administratiivseid õigusi, kui arvutis ei ole C:\mas kausta (hoidla: [mas-corefiles](https://github.com/MarkusMaal/mas-corefiles/tree/windows_legacy))
* Osaliselt aegunud mälupulga kausta struktuur
* 2017(.) standarditele vastav kood (mis ei ole eriti hea)
* Varundamise ja taaste süsteem on katki
* Kasutajaliides on disainitud peamiselt 5:4 kuvasuhtega XGA standardile vastavatele ekraanidele, seetõttu on akna suuruse muutmise võimalused piiratud moodsatel ekraanidel
* Aegunud .NET versioon
* Jookseb ainult Windowsis