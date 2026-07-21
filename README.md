<h1 align="center">Lumen RX</h1>

<p align="center">
    A third-party bootstrapper for Roblox on Windows, based on <a href="https://github.com/bloxstraplabs/bloxstrap">Bloxstrap</a>.
</p>

----

Lumen RX is a custom Roblox bootstrapper — an alternative launcher for the Roblox
client that layers useful features on top of the standard experience.

It is built on the open-source [Bloxstrap](https://github.com/bloxstraplabs/bloxstrap)
project (MIT licensed) and inherits its feature set:

- Discord Rich Presence to let friends see what you're playing at a glance
- Simple modding of client content files (death sound, mouse cursor, etc.)
- Fast flag (FFlag) management for graphics and UI tweaks
- See where your server is geographically located
- Custom bootstrapper themes and icons

Lumen RX is only supported on PCs running Windows.

## Building

Lumen RX targets **.NET 6** (Windows) and uses WPF with the
[WPF UI](https://github.com/lepoco/wpfui) library (included as a submodule).

```
git clone --recursive https://github.com/kylevoluu-hue/lumen-RX.git
cd lumen-RX
dotnet build -c Release
```

To run a published build you'll need the
[.NET 6 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/6.0).

## Privacy

This build ships with the upstream analytics/telemetry **disabled**: usage stats and
crash logs are never sent off your device, and the analytics setting defaults to off.

## Credits

Lumen RX is based on [Bloxstrap](https://github.com/bloxstraplabs/bloxstrap) by
[pizzaboxer](https://github.com/pizzaboxer) and its contributors, used under the MIT
license. Huge thanks to the Bloxstrap team for their work.

Lumen RX is an unofficial project and is not affiliated with or endorsed by Bloxstrap,
Roblox Corporation, or the WPF UI project.

## License

Licensed under the [MIT License](LICENSE). The original Bloxstrap copyright
(© 2022 pizzaboxer) is retained.
