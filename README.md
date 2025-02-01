# WebView2-Game-Launcher
Simple game launcher using C# winforms and webview2

## Example HTML code (this will be the GUI for ur launcher)
```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Game Launcher</title>
    <script src="https://cdn.tailwindcss.com"></script>
  </head>
  <body
    class="bg-gray-900 text-white flex flex-col items-center justify-center h-screen p-4"
  >
    <div class="flex space-x-4">
      <img
        src="https://bluemoji.io/cdn-proxy/646218c67da47160c64a84d5/66b3e5d0c2ab246786ca1d5e_86.png"
        alt="Game Logo"
        class="rounded-lg h-[60px] w-[60px]"
      />

      <button
        id="playButton"
        class="bg-blue-500 hover:bg-blue-600 text-white font-bold py-3 px-20 rounded-lg shadow-md transition"
      >
        Play Game
      </button>
    </div>

    <div class="mt-6 w-full max-w-md bg-gray-800 p-4 rounded-lg shadow-lg">
      <h2 class="text-lg font-semibold mb-2">Latest News</h2>
      <p class="text-sm text-gray-300">
        🔹 Update 1.1 released! New maps and skins available.
      </p>
      <p class="text-sm text-gray-300 mt-2">
        🔹 Server maintenance scheduled for tomorrow.
      </p>
    </div>

    <footer class="absolute bottom-4 text-gray-400 text-sm">
      <a href="https://smirkzyy.xyz" target="_blank" class="hover:text-white"
        >Powered by smirkzyy.xyz</a
      >
    </footer>

    <script>
      document
        .getElementById("playButton")
        .addEventListener("click", function () {
          window.chrome.webview.postMessage("launch_game");
        });
    </script>
  </body>
</html>
```
