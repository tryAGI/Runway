dotnet tool install --global autosdk.cli --version 0.30.1-dev.3

autosdk init \
  Runway \
  RunwayClient \
  https://raw.githubusercontent.com/api/openapi.json \
  tryAGI \
  --output .
