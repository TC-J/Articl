# Running On Linux

[Install .NET Framework & CLI Tools for Linux](https://learn.microsoft.com/en-us/dotnet/core/install/linux-scripted-manual#scripted-install)

Clone:
```
$ git clone https://github.com/TC-J/Articl.git
```

[See the .NET CLI Overview for details on the usage below.](https://learn.microsoft.com/en-us/dotnet/core/tools/) 

Building:
```
$ dotnet build
# then the executable will be in bin/Debug/articl
```

Managed build & run:
```
$ dotnet run -- <cli-arguments>
```

Local Publish & Install:
```
$ dotnet publish -o <dirpath>
# recommend publishing to the current directory with the name  
# 'articl' 
$ sudo install <dirpath>/articl /usr/local/bin
# eg install articl/articl /usr/local/bin
```