#!/bin/sh
exe_path=CountingApp/bin/Debug/net6.0

if [[ ! -f $exe_path/CountingApp.exe ]]; then
  echo "building program..."
  dotnet build
fi

clear
echo $1 $2 $3
$exe_path/CountingApp.exe $1 $2 $3
