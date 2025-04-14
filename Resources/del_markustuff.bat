@echo off
if exist "K:\E_INFO\edition.txt" set drv=K:&goto backstart
if exist "A:\E_INFO\edition.txt" set drv=A:&goto backstart
if exist "B:\E_INFO\edition.txt" set drv=B:&goto backstart
if exist "C:\E_INFO\edition.txt" set drv=C:&goto backstart
if exist "D:\E_INFO\edition.txt" set drv=D:&goto backstart
if exist "E:\E_INFO\edition.txt" set drv=E:&goto backstart
if exist "F:\E_INFO\edition.txt" set drv=F:&goto backstart
if exist "G:\E_INFO\edition.txt" set drv=G:&goto backstart
if exist "H:\E_INFO\edition.txt" set drv=H:&goto backstart
if exist "I:\E_INFO\edition.txt" set drv=I:&goto backstart
if exist "J:\E_INFO\edition.txt" set drv=J:&goto backstart
if exist "L:\E_INFO\edition.txt" set drv=L:&goto backstart
if exist "M:\E_INFO\edition.txt" set drv=M:&goto backstart
if exist "N:\E_INFO\edition.txt" set drv=N:&goto backstart
if exist "O:\E_INFO\edition.txt" set drv=O:&goto backstart
if exist "P:\E_INFO\edition.txt" set drv=P:&goto backstart
if exist "Q:\E_INFO\edition.txt" set drv=Q:&goto backstart
if exist "R:\E_INFO\edition.txt" set drv=R:&goto backstart
if exist "S:\E_INFO\edition.txt" set drv=S:&goto backstart
if exist "T:\E_INFO\edition.txt" set drv=T:&goto backstart
if exist "U:\E_INFO\edition.txt" set drv=U:&goto backstart
if exist "V:\E_INFO\edition.txt" set drv=V:&goto backstart
if exist "W:\E_INFO\edition.txt" set drv=W:&goto backstart
if exist "X:\E_INFO\edition.txt" set drv=X:&goto backstart
if exist "Y:\E_INFO\edition.txt" set drv=Y:&goto backstart
if exist "Z:\E_INFO\edition.txt" set drv=Z:&goto backstart
exit
:backstart
Echo ----------------------------->>%drv%\E_INFO\process.txt
Echo Alustati kustutamisega>>%drv%\E_INFO\process.txt
Echo.>>%drv%\E_INFO\process.txt
Echo Kustutamisega alustati kell %time%>>%drv%\E_INFO\process.txt
Echo Kustutatakse kaust Markuse asjad>>%drv%\E_INFO\process.txt
Echo ----------------------------->>%drv%\E_INFO\process.txt
Echo Ette valmistamine...>>%drv%\E_INFO\process.txt
if not exist "%drv%\markuse asjad" goto error
Echo Andmete kustutamine...>>%drv%\E_INFO\process.txt
rd "%drv%\markuse asjad" /s /q >NUL
Echo Teisendamine...>>%drv%\E_INFO\process.txt
ping localhost -n 3 >nul
del %drv%\E_INFO\edition.txt /Y >nul
del %drv%\E_INFO\edition.cmd /Y >nul
@echo.set verifycode=2593391>>%drv%\E_INFO\edition.cmd
@echo.set edition=Premium>>%drv%\E_INFO\edition.cmd
@echo.set verifyspace=>>%drv%\E_INFO\edition.cmd
Echo ----------------------------->>%drv%\E_INFO\process.txt
Echo Valmis>>%drv%\E_INFO\process.txt
Echo.>>%drv%\E_INFO\process.txt
Echo Saate seda programmi uuesti kasutada,>>%drv%\E_INFO\process.txt
Echo et vana Ultimate varundust taastada.>>%drv%\E_INFO\process.txt
Echo ----------------------------->>%drv%\E_INFO\process.txt
@echo.>>%drv%\E_INFO\endprocess.txt
exit

:error
Echo ----------------------------->>%drv%\E_INFO\process.txt
Echo Viga: Markuse asjad kaust ei eksisteeri>>%drv%\E_INFO\process.txt
Echo ----------------------------->>%drv%\E_INFO\process.txt
@echo.>>%drv%\E_INFO\endprocess.txt
exit