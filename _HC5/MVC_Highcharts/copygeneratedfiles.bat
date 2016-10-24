rmdir /s /q CodeAddOns
rmdir /s /q CodeGeneration\Enums
rmdir /s /q CodeGeneration
echo f | xcopy /f /y ..\CodeGenerator\CodeAddOns CodeAddOns\
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration\Highcharts CodeGeneration\
echo f | xcopy /f /y ..\CodeGenerator\CodeGeneration\Highcharts\Enums CodeGeneration\Enums\