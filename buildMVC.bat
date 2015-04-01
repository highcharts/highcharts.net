call "C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\Tools\vsvars32.bat" x86_amd64
MsTest.exe /testcontainer:MVC_UnitTests\bin\Debug\MVC_UnitTests.dll
cd MVC
call "copygeneratedfiles.bat"
MsBuild.exe /p:Configuration=Release
cd ..