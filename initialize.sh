dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Runway \
  RunwayClient \
  https://raw.githubusercontent.com/api/openapi.json \
  tryAGI \
  --output .
