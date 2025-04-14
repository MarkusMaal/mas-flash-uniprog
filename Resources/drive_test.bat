@echo on
setlocal EnableDelayedExpansion EnableExtensions
for %%a in (A B C D E F G H I J K L M N O P Q R S T U V W X Y Z) do (
if exist "%%a\E_INFO\edition.txt" set drv=%%a
)
:backstart
if not exist %drv%\E_INFO\communicate.cmd exit
call %drv%\E_INFO\communicate.cmd
ping localhost -n 2 >nul
del %drv%\E_INFO\communicate.cmd
if "%br%"=="backup" goto backup
if "%br%"=="restore" goto restore
if "%br%"=="" exit
echo Destination: %destination%
echo Backup cat 1: %cat1%
echo Backup cat 2: %cat2%
echo Backup cat 3: %cat3%
echo Backup cat 4: %cat4%
echo Backup cat 5: %cat5%
echo Backup cat 6: %cat6%
echo.

::cat1 - Markuse asjad
::cat2 - Windows 7 paigaldaja
::cat3 - Pakkfailid
::cat4 - YUMI ja opsüsteemid
::cat5 - Kontrollimise seaded
::cat6 - Muud failid ja autorun.inf

:backup
if "%cat1%"=="" exit
if "%cat2%"=="" exit
if "%cat3%"=="" exit
if "%cat4%"=="" exit
if "%cat5%"=="" exit
if "%cat6%"=="" exit
if "%destination%"=="" exit
if "%cat1%"=="no" set check1=false
if "%cat2%"=="no" set check2=false
if "%cat3%"=="no" set check3=false
if "%cat4%"=="no" set check4=false
if "%cat5%"=="no" set check5=false
if "%cat6%"=="no" set check6=false
if "%cat1%"=="yes" set check1=true
if "%cat2%"=="yes" set check2=true
if "%cat3%"=="yes" set check3=true
if "%cat4%"=="yes" set check4=true
if "%cat5%"=="yes" set check5=true
if "%cat6%"=="yes" set check6=true
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Algab varundamine>>%drv%\E_INFO\process.txt
echo.>>%drv%\E_INFO\process.txt
echo Sihtkaust: %destination%>>%drv%\E_INFO\process.txt
echo Varundamisega alustati kell %time%>>%drv%\E_INFO\process.txt
echo.>>%drv%\E_INFO\process.txt
echo Varundatavad \9ksused:>>%drv%\E_INFO\process.txt
echo.>>%drv%\E_INFO\process.txt
if "%cat1%"=="yes" echo Markuse asjad>>%drv%\E_INFO\process.txt
if "%cat2%"=="yes" echo Windowsi paigaldaja>>%drv%\E_INFO\process.txt
if "%cat3%"=="yes" echo Pakkfailid>>%drv%\E_INFO\process.txt
if "%cat4%"=="yes" echo YUMI ja ops\9steemid>>%drv%\E_INFO\process.txt
if "%cat5%"=="yes" echo M\2lupulga kontrollimise seaded>>%drv%\E_INFO\process.txt
if "%cat6%"=="yes" echo Muud failid ja autorun>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt

Echo Varunduskausta loomine...>>%drv%\E_INFO\process.txt
md "%destination%"
if not exist "%destination%" goto error404
Echo S\2tete kontrollimine...>>%drv%\E_INFO\process.txt
:backupnext1
if "%check1%"=="false" goto backupnext2
Echo \9ksuste loendamine...>>%drv%\E_INFO\process.txt
call %drv%\E_INFO\count.bat %drv%\markuse+asjad
echo %mc%>>%drv%\E_INFO\process.txt
Echo Markuse asjade varundamine....>>%drv%\E_INFO\process.txt
md "%destination%\markuse asjad"
attrib "%drv%\markuse asjad\desktop.ini" -h -s
copy "%drv%\markuse asjad\desktop.ini" "%destination%\markuse asjad" /Y >NUL
attrib "%drv%\markuse asjad\desktop.ini" +h +s
if exist db.txt del db.txt
start /b xcopy "%drv%\markuse asjad" "%destination%\markuse asjad" /e /c /h /y >db.txt
set /a ad=0
:dbloop
For /f %%j in ('Find "" /v /c ^< db.txt') Do Set /a fc=%%j
set /a AD=%fc%*100/%mc%
@echo.%AD%;Markuse asjad;>%drv%\E_INFO\pro.txt
if %ad% GTR 99 goto backupnext2
goto dbloop
:backupnext2
if "%check2%"=="false" goto backupnext3
Echo Windows 7 paigaldaja varundamine....>>%drv%\E_INFO\process.txt
Echo. Kaustade loomine...>>%drv%\E_INFO\process.txt
md "%destination%\.disk"
md "%destination%\boot"
md "%destination%\efi"
md "%destination%\sources"
md "%destination%\support"
md "%destination%\upgrade"
Echo. Alglaadur...>>%drv%\E_INFO\process.txt
xcopy "%drv%\boot" "%destination%\boot" /e /y /c /h /q >NUL
attrib "%drv%\bootmgr" -h
attrib "%drv%\bootmgr.efi" -h
copy "%drv%\bootmgr" "%destination%" /Y >NUL
copy "%drv%\bootmgr.efi" "%destination%" /Y >NUL
attrib "%drv%\bootmgr" +h
attrib "%drv%\bootmgr.efi" +h
Echo. Ketta info...>>%drv%\E_INFO\process.txt
copy "%drv%\_disk_id.pod" "%destination%" /Y >NUL
xcopy "%drv%\.disk" "%destination%\.disk" /e /y /c /h /q >NUL
Echo. EFI laadur...>>%drv%\E_INFO\process.txt
xcopy "%drv%\efi" "%destination%\efi" /e /y /c /h /q >NUL
del dirs.txt
for /d /r %%a in ('%drv%\sources') do set /a mc+=1
Echo. Installifailid...>>%drv%\E_INFO\process.txt
del db.txt
start /b xcopy "%drv%\sources" "%destination%\sources" /e /y /c /h >db.txt
set /a ad=0
:gbloop
For /f %%j in ('Find "" /v /c ^< db.txt') Do Set /a fc=%%j
set /a AD=%fc%*100/%mc%
del %drv%\E_INFO\pro.txt
@echo.%AD%;Windows 7 paigaldaja>>%drv%\E_INFO\pro.txt
if %ad% GTR 99 goto lala
goto gbloop
:lala
Echo. Abifailid>>%drv%\E_INFO\process.txt
xcopy "%drv%\support" "%destination%\support" /e /y /c /h /q >NUL
Echo. 'Upgrade' failid>>%drv%\E_INFO\process.txt
xcopy "%drv%\upgrade" "%destination%\upgrade" /e /y /c /h /q >NUL
:backupnext3
if "%check3%"=="false" goto backupnext4
Echo Pakkfailide varundamine...>>%drv%\E_INFO\process.txt
md "%destination%\Batch"
del dirs.txt
for /d /r %%a in ('%drv%\Batch') do set /a mc+=1
del db.txt
start /b xcopy "%drv%\Batch" "%destination%\Batch" /e /h /y >db.txt
set /a ad=0
:abloop
For /f %%j in ('Find "" /v /c ^< db.txt') Do Set /a fc=%%j
set /a AD=%fc%*100/%mc%
del %drv%\E_INFO\pro.txt
@echo.%AD%;Pakkfailid>>%drv%\E_INFO\pro.txt
if %ad% GTR 99 goto backupnext4
goto abloop
:backupnext4
if "%check4%"=="false" goto backupnext5
Echo YUMI ja ops\9steemide varundamine...>>%drv%\E_INFO\process.txt
Echo. Kaustade loomine...>>%drv%\E_INFO\process.txt
md "%destination%\multiboot"
md "%destination%\HBCD"
Echo. \9ksuste loendamine...>>%drv%\E_INFO\process.txt
del dirs.txt
for /d /r %%a in ('%drv%\multiboot') do set /a mc+=1
Echo. Varundamine..>>%drv%\E_INFO\process.txt
del db.txt
start /b xcopy "%drv%\multiboot" "%destination%\multiboot" /e /h /y >NUL
set /a ad=0
:xbloop
For /f %%j in ('Find "" /v /c ^< db.txt') Do Set /a fc=%%j
set /a AD=%fc%*100/%mc%
del %drv%\E_INFO\pro.txt
@echo.%AD%;YUMI ja OS-id>>%drv%\E_INFO\pro.txt
if %ad% GTR 99 goto backuphbcd
goto xbloop
:backuphbcd
Echo. Hiren's boot CD varundamine...>>%drv%\E_INFO\process.txt
Echo.  \9ksuste loendamine...
del dirs.txt
for /d /r %%a in ('%drv%\HBCD') do set /a mc+=1
Echo.  Varundamine...
del db.txt
start /b xcopy "%drv%\HBCD" "%destination%\HBCD" /e /h /y >db.txt
:ybloop
For /f %%j in ('Find "" /v /c ^< db.txt') Do Set /a fc=%%j
set /a AD=%fc%*100/%mc%
del %drv%\E_INFO\pro.txt
@echo.%AD%;Hiren's Boot CD failid>>%drv%\E_INFO\pro.txt
if %ad% GTR 99 goto backupnext5
goto ybloop
:backupnext5
if "%check5%"=="false" goto backupnext6
Echo M\2lupulga kontrollimise s\2tete varundamine....>>%drv%\E_INFO\process.txt
md "%destination%\NTFS"
copy "%drv%\NTFS\config.sys" "%destination%\NTFS" >NUL
attrib "%destination%\NTFS" +H
md "%destination%\E_INFO"
attrib "%drv%\E_INFO" -h -s
copy "%drv%\E_INFO\edition.cmd" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\edition.txt" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\uudis1.rtf" "%destination%\E_INFO" /
copy "%drv%\E_INFO\uudis2.rtf" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\uudis3.rtf" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\uudis4.rtf" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\uudis5.rtf" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\videod.txt" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\convert.bat" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\lang.cmd" "%destination%\E_INFO" /y
copy "%drv%\E_INFO\lang_en-us.cmd" "%destination%\E_INFO" /y
attrib "%drv%\E_INFO" +h +s
attrib "%destination%\E_INFO" +h +s
md "%destination%\PortableInstall"
xcopy "%drv%\PortableInstall" "%destination%\PortableInstall" /e /h /y /q >NUL
attrib "%destination%\PortableInstall" +h
:backupnext6
if "%check6%"=="false" goto finishbackup
Echo Muude failide kopeermine...>>%drv%\E_INFO\process.txt
attrib %drv%\autorun.inf -h
attrib %drv%\autorun.exe -h
attrib %drv%\mas_flash.ico -h
attrib %drv%\produkeys.txt -h
attrib %drv%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso -h
attrib %drv%\BOOTEX.LOG -h
attrib %drv%\jyrgen.mp4 -h
attrib %drv%\pfear.wmv -h
attrib %drv%\ktoootkoooo.wmv -h
attrib %drv%\m0nkrus.nfo -h
attrib %drv%\MediaID.bin -h

copy "%drv%\autorun.inf" "%destination%" /Y >NUL
copy "%drv%\autorun.exe" "%destination%" /Y >NUL
copy "%drv%\mas_flash.ico" "%destination%" /Y >NUL
copy "%drv%\produkeys.txt" "%destination%" /Y >NUL
copy "%drv%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso" "%destination%" /Y >NUL
copy "%drv%\BOOTEX.LOG" "%destination%" /Y >NUL
copy "%drv%\jyrgen.mp4" "%destination%" /Y >NUL
copy "%drv%\pfear.wmv" "%destination%" /Y >NUL
copy "%drv%\ktoootkoooo.wmv" "%destination%" /Y >NUL
copy "%drv%\MediaID.bin" "%destination%" /Y >NUL
copy "%drv%\m0nkrus.nfo" "%destination%" /Y >NUL
attrib %destination%\autorun.inf +h
attrib %destination%\autorun.exe +h
attrib %destination%\mas_flash.ico +h
attrib %destination%\produkeys.txt +h
attrib %destination%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso +h
attrib %destination%\BOOTEX.LOG +h
attrib %destination%\jyrgen.mp4 +h
attrib %destination%\pfear.wmv +h
attrib %destination%\ktoootkoooo.wmv +h
attrib %destination%\m0nkrus.nfo +h
attrib %destination%\MediaID.bin +h
attrib %drv%\autorun.inf +h
attrib %drv%\autorun.exe +h
attrib %drv%\mas_flash.ico +h
attrib %drv%\produkeys.txt +h
attrib %drv%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso +h
attrib %drv%\BOOTEX.LOG +h
attrib %drv%\jyrgen.mp4 +h
attrib %drv%\pfear.wmv +h
attrib %drv%\ktoootkoooo.wmv +h
attrib %drv%\m0nkrus.nfo +h
attrib %drv%\MediaID.bin +h
:finishbackup
@echo.%AD%;Kõik on valmis>>%drv%\E_INFO\pro.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Varundamine viidi l\6pule>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo>>%drv%\E_INFO\endprocess.txt
exit

:restore
set location=%destination%
if "%location%"=="" exit
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Alustati taastamisega>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Asukoht: %location%>>%drv%\E_INFO\process.txt
echo Draiv: %drv%>>%drv%\E_INFO\process.txt
Echo Protsess alustati kell %time%>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
if exist "%location%\markuse asjad" echo Markuse asjade taastamine>>%drv%\E_INFO\process.txt
if not exist "%drv%\markuse asjad" md "%drv%\markuse asjad"
if exist "%location%\markuse asjad" xcopy "%location%\markuse asjad" "%drv%\markuse asjad" /e /h /y /q
if exist "%location%\Batch" echo Pakkfailide taastamine>>%drv%\E_INFO\process.txt
if not exist "%drv%\Batch" md "%drv%\Batch"
if exist "%location%\Batch" xcopy "%location%\Batch" "%drv%\Batch" /e /h /y /q
if exist "%location%\multiboot" echo YUMI ja OSid>>%drv%\E_INFO\process.txt
if not exist "%drv%\multiboot" md "%drv%\multiboot"
if exist "%location%\multiboot" xcopy "%location%\multiboot" "%drv%\multiboot" /e /h /y /q
if exist "%location%\sources" echo Windows 7 paigaldaja taastamine>>%drv%\E_INFO\process.txt
if exist "%location%\.disk" echo. Kettainfo>>%drv%\E_INFO\process.txt
if exist "%location%\.disk" xcopy "%location%\.disk" "%drv%\.disk" /e /h /y /q
attrib "%location%\_disk_id.pod" -h
if exist "%location%\_disk_id.pod" copy "%location%\_disk_id.pod" "%drv%" /y
attrib "%drv%\_disk_id.pod" +h
if exist "%location%\boot" echo. Buutimisfailid>>%drv%\E_INFO\process.txt
if exist "%location%\boot" xcopy "%location%\boot" "%drv%\boot" /e /h /y /q
attrib "%location%\bootmgr" -h
attrib "%location%\bootmgr.efi" -h
copy "%location%\bootmgr" "%drv%" /Y >NUL
copy "%location%\bootmgr.efi" "%drv%" /Y >NUL
attrib "%drv%\bootmgr" +h
attrib "%drv%\bootmgr.efi" +h
if exist "%location%\efi" xcopy "%location%\efi" "%drv%\efi" /e /h /y /q
if exist "%location%\sources" echo. Installifailid (v6ib kaua aega võtta)>>%drv%\E_INFO\process.txt
if exist "%location%\sources" xcopy "%location%\sources" "%drv%\sources" /e /h /y /q
if exist "%location%\upgrade" xcopy "%location%\upgrade" "%drv%\upgrade" /e /h /y /q
attrib "%location%\setup.exe" -h
if exist "%location%\setup.exe" copy "%location%\setup.exe" "%drv%\setup.exe" /y
attrib "%drv%\setup.exe" +h
if exist "%location%\support" echo. Tugifailid>>%drv%\E_INFO\process.txt
if exist "%location%\support" xcopy "%location%\support" "%drv%\support" /e /h /y /q
if exist "%location%\E_INFO" echo Markuse asjade info taastamine>>%drv%\E_INFO\process.txt
md "%drv%\NTFS"
md "%drv%\E_INFO"
copy "%location%\NTFS\config.sys" "%drv%\NTFS" /Y >NUL
attrib "%drv%\NTFS" +H
attrib "%location%\E_INFO" -h -s
if exist "%location%\E_INFO" xcopy "%location%\E_INFO" "%drv%\E_INFO" /e /h /y /q
attrib "%drv%\E_INFO" +h +s
md "%drv%\PortableInstall"
if exist "%location%\PortableInstall" xcopy "%location%\PortableInstall" "%drv%\PortableInstall" /e /h /y /q >NUL
attrib "%drv%\PortableInstall" +h
echo Muude failide taastamine>>%drv%\E_INFO\process.txt

Echo Muude failide kopeermine...
attrib %location%\autorun.inf -h
attrib %location%\autorun.exe -h
attrib %location%\mas_flash.ico -h
attrib %location%\produkeys.txt -h
attrib %location%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso -h
attrib %location%\BOOTEX.LOG -h
attrib %location%\jyrgen.mp4 -h
attrib %location%\pfear.wmv -h
attrib %location%\ktoootkoooo.wmv -h
attrib %location%\m0nkrus.nfo -h
attrib %location%\MediaID.bin -h
copy "%location%\autorun.inf" "%drv%" /Y >NUL
copy "%location%\autorun.exe" "%drv%" /Y >NUL
copy "%location%\mas_flash.ico" "%drv%" /Y >NUL
copy "%location%\produkeys.txt" "%drv%" /Y >NUL
copy "%location%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso" "%drv%" /Y >NUL
copy "%location%\BOOTEX.LOG" "%drv%" /Y >NUL
copy "%location%\jyrgen.mp4" "%drv%" /Y >NUL
copy "%location%\pfear.wmv" "%drv%" /Y >NUL
copy "%location%\ktoootkoooo.wmv" "%drv%" /Y >NUL
copy "%location%\MediaID.bin" "%drv%" /Y >NUL
copy "%location%\m0nkrus.nfo" "%drv%" /Y >NUL
attrib %drv%\autorun.inf +h
attrib %drv%\produkeys.txt +h
attrib %drv%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso +h
attrib %drv%\BOOTEX.LOG +h
attrib %drv%\jyrgen.mp4 +h
attrib %drv%\mas_flash.ico +h
attrib %drv%\autorun.exe +h
attrib %drv%\pfear.wmv +h
attrib %drv%\ktoootkoooo.wmv +h
attrib %drv%\m0nkrus.nfo +h
attrib %drv%\MediaID.bin +h
attrib %location%\autorun.inf +h
attrib %location%\produkeys.txt +h
attrib %location%\pcriver.com_Windows_XP_Pro_SP3_32_bit.iso +h
attrib %location%\BOOTEX.LOG +h
attrib %location%\jyrgen.mp4 +h
attrib %location%\pfear.wmv +h
attrib %location%\ktoootkoooo.wmv +h
attrib %location%\m0nkrus.nfo +h
attrib %location%\MediaID.bin +h
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Taastamine viidi l\6pule>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo>>%drv%\E_INFO\endprocess.txt
exit

:error404
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo Illegaalne kausta nimi>>%drv%\E_INFO\process.txt
echo ------------------------------------------------------------------------------>>%drv%\E_INFO\process.txt
echo>>%drv%\E_INFO\endprocess.txt
exit

