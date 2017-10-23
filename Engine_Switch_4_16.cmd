@ECHO OFF
CALL clean_intermediate_files.cmd
SET APP="UnrealEngineVersionChanger\bin\Debug\UnrealEngineVersionChanger.exe"
IF NOT EXIST %APP% ECHO UnrealEngineVersionChanger needs to be compiled!
IF EXIST %APP% CALL "UnrealEngineVersionChanger\bin\Debug\UnrealEngineVersionChanger.exe" 4.16
COPY /Y UE4ChromaSDK_4_16.uproject UE4ChromaSDK.uproject
CALL SwitchEngineVersion.cmd
"C:\Program Files\7-Zip\7zFM.exe" "%CD%\ChromaSDKPlugin_4_16.zip\ChromaSDKPlugin\Binaries\Win64\"