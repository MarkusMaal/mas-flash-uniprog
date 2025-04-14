@echo off
setlocal EnableDelayedExpansion EnableExtensions
set driv=%1
set driv=!driv:+= !
for /d /r %%a in ("!driv!") do set /a mc+=1
@echo !mc!
