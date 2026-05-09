# MARKETING.md

## Product
- One-liner: A .NET command-line tool that turns one prompt into a planned, multi-shot Runway short video.
- Category: developer tools / creative CLI

## Audience
- Persona: indie developers and creative engineers who already automate things from the terminal
- Awareness stage: solution-aware
- Pain points: five Runway dashboard tabs open at once, sticky notes covered in prompt fragments, manually copying clips into a folder, running ffmpeg concat by hand, losing track of which prompt produced which shot, fifteen-minute round trip from idea to first frame

## Goal
- Primary objective: activation
- Call to action: install with `dotnet tool install -g Runway.Cli` and run `runway short-video`
- Success metric: first successful `runway short-video` plan generated within 5 minutes of install

## Message
- Core value proposition: one terminal command takes a scenario, plans the shots, generates them on Runway, and concatenates a final mp4 — no dashboard, no manual stitching.
- Differentiators: show the BEFORE — chaotic desktop with multiple Runway dashboard tabs, sticky notes, scattered clip files, an ffmpeg invocation in a side terminal. Show the AFTER — one clean terminal running `runway short-video`, plan JSON streaming, shot progress percentages climbing, a polished vertical mp4 appearing on the desktop ready to upload.
- Proof points: ships as a NuGet dotnet tool, source-generated JSON, 60+ integration tests, sub-second deterministic planner, ffmpeg concat fallback baked in

## Voice
- Tone: practical, technical, quietly confident
- Words to avoid: revolutionary, magic, game-changing, hack

## Format
- Platform: youtube-shorts
- Aspect ratio: 720:1280
- Length seconds: 30
- Captions on screen: yes
