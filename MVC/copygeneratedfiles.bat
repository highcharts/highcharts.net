rmdir /s /q CodeAddOns
rmdir /s /q CodeGeneration\Enums
rmdir /s /q CodeGeneration
echo f | xcopy /f /y ..\CodeGenerator\CodeAddOns CodeAddOns\
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration CodeGeneration\
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration\Enums CodeGeneration\Enums\