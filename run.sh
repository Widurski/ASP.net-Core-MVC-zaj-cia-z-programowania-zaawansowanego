#!/usr/bin/env bash
# Simple runner for the published MyVscMvcApp
# Starts the self-contained published binary on 127.0.0.1:5005 and logs to /tmp/myvscmvcapp.log
set -euo pipefail
PUBLISH_BIN="$(pwd)/publish/MyVscMvcApp"
CONTENT_ROOT="$(pwd)/asp.net core/asp.net core"
PORT=5005
BIND=0.0.0.0
if [ ! -x "$PUBLISH_BIN" ]; then
  echo "Publish binary not found or not executable: $PUBLISH_BIN"
  exit 1
fi
nohup "$PUBLISH_BIN" --urls "http://$BIND:$PORT" --contentRoot "$CONTENT_ROOT" > /tmp/myvscmvcapp.log 2>&1 &
PID=$!
echo "Started MyVscMvcApp PID=$PID, logs: /tmp/myvscmvcapp.log"
