#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Haiper \
  --clientClassName HaiperClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

rm -rf ../../cli/Haiper.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Haiper.CLI \
  --sdk-project ../../libs/Haiper/Haiper.csproj \
  --targetFramework net10.0 \
  --namespace Haiper \
  --clientClassName HaiperClient \
  --package-id Haiper.CLI \
  --tool-command-name haiper \
  --user-secrets-id Haiper.CLI \
  --api-key-env-var HAIPER_API_KEY \
  --base-url-env-var HAIPER_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
