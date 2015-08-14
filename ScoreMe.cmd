@echo Testing your project
@pushd .
@cd ExercisesTest\bin\debug
@"%VS120COMNTOOLS%\..\ide\commonextensions\microsoft\testwindow\vstest.console.exe" ExercisesTest.dll /Logger:trx
@popd
