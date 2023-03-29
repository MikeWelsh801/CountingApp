#!/bin/sh
exe_path=CountingApp/bin/Debug/net6.0
get_back=../../../../

clear
$exe_path/CountingApp.exe $1 $2 $3
echo ./CountingApp.exe $1 $2 $3
