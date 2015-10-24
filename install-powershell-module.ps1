$p = [Environment]::GetEnvironmentVariable("PSModulePath")
$p += (Get-Item -Path ".\" -Verbose).FullName + "\dist"
[Environment]::SetEnvironmentVariable("PSModulePath",$p)
