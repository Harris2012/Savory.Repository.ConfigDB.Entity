msbuild Savory.Repository.ConfigDB.Entity\Savory.Repository.ConfigDB.Entity.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.Repository.ConfigDB.Entity.xml;DebugType=none

nuget pack Savory.Repository.ConfigDB.Entity.nuspec

move /y Savory.Repository.ConfigDB.Entity.*.nupkg D:\LocalWebRoot\SavoryNuget\Packages

pause