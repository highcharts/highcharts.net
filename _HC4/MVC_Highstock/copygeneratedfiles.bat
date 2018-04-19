rmdir /s /q CodeGeneration\Enums
rmdir /s /q CodeGeneration
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration\Highstock CodeGeneration\
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration\Highstock\Enums CodeGeneration\Enums\