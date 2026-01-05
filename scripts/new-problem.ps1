<#
Creates a new problem folder.
Usage:
  ./new-problem.ps1 -Topic arrays-strings -Id 0002 -Name "Contains Duplicate"
#>
param(
  [Parameter(Mandatory=$true)][string]$Topic,
  [Parameter(Mandatory=$true)][string]$Id,
  [Parameter(Mandatory=$true)][string]$Name
)

$slug = $Name.ToLower() -replace '[^a-z0-9]+','-' -replace '^-|-$',''
$path = Join-Path -Path "..\dsa\$Topic" -ChildPath "$Id-$slug"
New-Item -ItemType Directory -Force -Path $path | Out-Null
Copy-Item -Force "..\docs\problem-template.md" (Join-Path $path "README.md")
Copy-Item -Force "..\docs\leetcode-solution-template.cs" (Join-Path $path "Solution.cs")
Write-Host "Created: $path"
