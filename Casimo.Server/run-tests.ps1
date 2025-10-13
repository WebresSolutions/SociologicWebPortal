#!/usr/bin/env pwsh

<#
.SYNOPSIS
    Runs the Casimo.Server unit tests with various options.

.DESCRIPTION
    This script provides an easy way to run the unit tests for the Casimo.Server project.
    It supports different verbosity levels, filtering, and coverage options.

.PARAMETER Verbosity
    The verbosity level for test output. Options: quiet, minimal, normal, detailed, diagnostic.
    Default is normal.

.PARAMETER Filter
    A filter expression to run only specific tests.

.PARAMETER Coverage
    Whether to collect code coverage information.

.PARAMETER Build
    Whether to build the project before running tests.

.EXAMPLE
    .\run-tests.ps1
    Runs all tests with normal verbosity.

.EXAMPLE
    .\run-tests.ps1 -Verbosity detailed
    Runs all tests with detailed output.

.EXAMPLE
    .\run-tests.ps1 -Filter "FacilityServiceTests"
    Runs only the FacilityService tests.

.EXAMPLE
    .\run-tests.ps1 -Coverage
    Runs tests with code coverage collection.

.EXAMPLE
    .\run-tests.ps1 -Build
    Builds the project before running tests.
#>

param(
    [ValidateSet("quiet", "minimal", "normal", "detailed", "diagnostic")]
    [string]$Verbosity = "normal",
    
    [string]$Filter,
    
    [switch]$Coverage,
    
    [switch]$Build
)

# Set error action preference
$ErrorActionPreference = "Stop"

# Get the script directory
$ScriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$TestProjectDir = Join-Path $ScriptDir "Casimo.Server.Tests"

Write-Host "Casimo.Server Test Runner" -ForegroundColor Green
Write-Host "=========================" -ForegroundColor Green
Write-Host ""

# Check if test project directory exists
if (-not (Test-Path $TestProjectDir)) {
    Write-Error "Test project directory not found: $TestProjectDir"
    exit 1
}

# Change to test project directory
Set-Location $TestProjectDir

# Build the project if requested
if ($Build) {
    Write-Host "Building test project..." -ForegroundColor Yellow
    dotnet build
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Build failed. Please fix build errors before running tests."
        exit 1
    }
    Write-Host "Build completed successfully." -ForegroundColor Green
    Write-Host ""
}

# Build the base command
$TestCommand = "dotnet test"

# Add verbosity
$TestCommand += " --verbosity $Verbosity"

# Add filter if specified
if ($Filter) {
    $TestCommand += " --filter `"$Filter`""
    Write-Host "Running tests with filter: $Filter" -ForegroundColor Cyan
}

# Add coverage if requested
if ($Coverage) {
    $TestCommand += " --collect:`"XPlat Code Coverage`""
    Write-Host "Code coverage collection enabled" -ForegroundColor Cyan
}

Write-Host "Running tests..." -ForegroundColor Yellow
Write-Host "Command: $TestCommand" -ForegroundColor Gray
Write-Host ""

# Run the tests
Invoke-Expression $TestCommand

# Check exit code
if ($LASTEXITCODE -eq 0) {
    Write-Host ""
    Write-Host "All tests passed! 🎉" -ForegroundColor Green
} else {
    Write-Host ""
    Write-Host "Some tests failed. Please review the output above." -ForegroundColor Red
    exit $LASTEXITCODE
}

