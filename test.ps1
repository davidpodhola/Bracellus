$FSharpCore = [reflection.assembly]::LoadFrom($PSScriptRoot + "\bin\Bracellus\FSharp.Core.dll") 
# $FSharpCore.FullName

$OnAssemblyResolve = [System.ResolveEventHandler] {
  param($sender, $e)

  # from:FSharp.Core, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
  # to:  FSharp.Core, Version=4.4.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
  if ($e.Name -eq "FSharp.Core, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a") { return $FSharpCore }
  
  foreach($a in [System.AppDomain]::CurrentDomain.GetAssemblies())
  {
	# Write-Host $e.name
    if ($a.FullName -eq $e.Name)
    {
      return $a
    }
  }
  return $null
}

[System.AppDomain]::CurrentDomain.add_AssemblyResolve($OnAssemblyResolve)

#[System.AppDomain]::CurrentDomain.GetAssemblies() | select-object  FullName

Add-PSSnapin Bracellus
ConvertFrom-Markdown README.md
