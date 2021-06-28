@ECHO OFF
:var
SET apptitle=Escritor
SET appfile=Escritor.exe
SET version=1.0.5.1
SET path=%PROGRAMFILES(x86)%\SAKSYS\%apptitle%
SET relatedfiles="%path%\contact_me.png" "%path%\*.html" "%path%\writer.ico"

ICACLS /G %username%:F %path% 
ICACLS /G %username%:F %app%
PAUSE
ECHO Desinstalando %apptitle% %version%. . .
ECHO ========
ECHO 1. Excluindo aplicativo.
ERASE "%path%\%app%"
ECHO 2. Excluindo arquivos relacionados.
ERASE %relatedfiles%
ECHO 3. Finalizando . . .
ECHO Desintalacao concluida!
PAUSE

