# MerchantNPCs

A Valheim mod that adds buildable merchant NPCs to your solo world. Each merchant is tied to a specific biome and progression stage.

![Merchant Building Menu](https://i.imgur.com/kNLAPQt.png)

![Trading Interface](https://i.imgur.com/y6Y5sC4.png)

## Watch the video to learn more:
[![Video:ValheimModReviews - MerchantNPCs](https://img.youtube.com/vi/i7iw1MlYw9I/maxresdefault.jpg)](https://youtu.be/i7iw1MlYw9I)

<details>
<summary><b>Features</b></summary>

- **Biome-Based Progression**: Merchants unlock as you defeat bosses
- **Eight Unique Merchants**: One for each biome in Valheim
- **Customizable Inventories**: Easily modify what each merchant sells
- **Customizable Merchant Build Requirements**: Set the build material requirements for each merchant
- **Automatic Selling**: Sell items to merchants at half their buy price
- **Easy to Use**: Build merchants using the hammer's "Merchants" tab
- **Solo Worlds Only**: The mod is designed to work only in solo worlds. If you would like multiplayer, check out KG's Marketplace and Server NPCs mod.
</details>

<details>
<summary><b>Installation</b></summary>

1. Install [BepInEx](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)
2. Install [Jotunn](https://valheim.thunderstore.io/package/ValheimModding/Jotunn/)
3. Download the latest release of MerchantNPCs
4. Place the `MerchantNPCs.dll` in your `BepInEx/plugins` folder
</details>

<details>
<summary><b>Merchant Types & Requirements</b></summary>

### 1. Meadows Merchant
- **Requirements**: Wood (50), Stone (50), Flint (25)
- **Sells**: Basic meadows resources and tools

### 2. Black Forest Merchant
- **Requirements**: Fine Wood (20), Troll Hide (10), Copper (10), Eikthyr Trophy (1)
- **Sells**: Black Forest resources and bronze equipment

### 3. Swamp Merchant
- **Requirements**: Ancient Bark (20), Guck (10), Iron (10), Elder Trophy (1)
- **Sells**: Swamp resources and iron equipment

### 4. Mountain Merchant
- **Requirements**: Freeze Gland (10), Wolf Pelt (10), Silver (10), Bonemass Trophy (1)
- **Sells**: Mountain resources and silver equipment

### 5. Plains Merchant
- **Requirements**: Barley (10), Black Metal Scrap (10), Deathsquito Needle (5), Moder Trophy (1)
- **Sells**: Plains resources and black metal equipment

### 6. Mistlands Merchant
- **Requirements**: Royal Jelly (10), Yggdrasil Wood (20), Carapace (5), Yagluth Trophy (1)
- **Sells**: Mistlands resources and carapace equipment

### 7. Ashlands Merchant
- **Requirements**: Blackwood (20), Flametal Ore (5), Fiddlehead Fern (10), Seeker Queen Trophy (1)
- **Sells**: Ashlands resources and flametal equipment

### 8. Deep North Merchant
- **Requirements**: Freeze Gland (200), Wolf Pelt (200), Fader Trophy (20)
- **Sells**: Deep North resources and frost equipment
</details>

<details>
<summary><b>Customizing Merchant Inventories</b></summary>

Merchant inventories can be customized by editing the text files in:
`BepInEx/config/MerchantNPCs/`

Each merchant type has its own file:
- `meadows.txt`
- `blackforest.txt`
- `swamp.txt`
- `mountain.txt`
- `plains.txt`
- `mistlands.txt`
- `ashlands.txt`
- `deepnorth.txt`

### File Format
Each line in the file represents one item with the following format:
```
ItemName:BuyPrice
```

Example:
```
Iron:30
IronNails:8
```

### Item Properties
- **ItemName**: The internal name of the item (e.g., "Iron", "IronNails")
- **BuyPrice**: How much the item costs to buy

Sell prices are automatically set to half of the buy price.
</details>

<details>
<summary><b>Customizing Merchant Build Costs</b></summary>

You can customize the resource requirements for building each merchant by editing the configuration file at:
`BepInEx/config/ruijven.merchantnpcs.cfg`

The configuration file is automatically generated the first time you run the game with the mod installed.

### Configuration Format

The configuration file is organized into sections for each merchant type:

```ini
[Meadows Merchant]
Resource1Type=Wood
Resource1Amount=50
Resource2Type=Stone
Resource2Amount=50
Resource3Type=Flint
Resource3Amount=25

[Black Forest Merchant]
Resource1Type=RoundLog
Resource1Amount=20
Resource2Type=TrollHide
Resource2Amount=10
Resource3Type=Copper
Resource3Amount=10
Resource4Type=TrophyEikthyr
Resource4Amount=1
```

### Customization Options

For each merchant, you can:

1. **Change Resource Types**: Modify what materials are needed to build each merchant by changing the `ResourceXType` values
2. **Adjust Resource Amounts**: Change how much of each material is required by modifying the `ResourceXAmount` values
3. **Add or Remove Requirements**: You can set an amount to 0 to effectively remove a requirement

### Item Type Names

When changing resource types, you must use the internal item name. Some common examples:

- `Wood` - Regular wood
- `ElderBark` - Ancient bark
- `TrophyTheElder` - Elder trophy


You can adjust the values to make merchants easier or harder to build based on your preferences. For example, setting `Resource1Amount=10` would reduce the wood requirement for the Meadows Merchant from 50 to 10.
</details>

<details>
<summary><b>Building Merchants</b></summary>

1. Craft a hammer if you don't have one
2. Open the build menu (right-click with hammer)
3. Navigate to the "Merchants" tab
4. Select a merchant type (you'll only see merchants you can build based on your progression)
5. Place the merchant in your base
6. Interact with the merchant to open the trading interface
</details>

<details>
<summary><b>Game Progression</b></summary>

The mod is designed to follow Valheim's natural progression:

1. Start with the Meadows Merchant (available from the beginning)
2. Defeat Eikthyr to unlock the Black Forest Merchant
3. Defeat The Elder to unlock the Swamp Merchant
4. Defeat Bonemass to unlock the Mountain Merchant
5. Defeat Moder to unlock the Plains Merchant
6. Defeat Yagluth to unlock the Mistlands Merchant
7. Defeat the Queen to unlock the Ashlands Merchant
8. Defeat the Fader to unlock the Deep North Merchant (future content)
</details>

<details>
<summary><b>Merchant Prefab Names</b></summary>

For developers and modders who need to reference the merchant prefabs:

### Biome-Specific Merchant Prefabs
- Meadows: `MeadowsMerch_ru`
- Black Forest: `BlackforestMerch_ru`
- Swamp: `SwampMerch_ru`
- Mountains: `MountainMerch_ru`
- Plains: `PlainsMerch_ru`
- Mistlands: `MistlandsMerch_ru`
- Ashlands: `AshlandsMerch_ru`
- Deep North: `DeepNorthMerch_ru`

</details>

<details>
<summary><b>Community & Feedback</b></summary>

## Join Our Discord Community

Join our [Discord server](https://discord.gg/qGf5FdqhVC) to:
- Share your experiences with the mod
- Report bugs and issues
- Suggest new features and improvements
- Get help from other users and developers
- See previews of upcoming updates

### Reporting Issues
When reporting issues, please include:
- Mod version (currently running)
- BepInEx log file (found in BepInEx/LogOutput.log)
- Steps to reproduce the issue
- Screenshots if applicable

### Common Solutions
- **Merchants not appearing**: Make sure you have discovered the materials required to build that merchant.
- **Items not showing up**: Check the console for error messages
- **Doesn't work with multiplayer**: No support for multiplayer at this time
- **Not working after an update**: Delete the config files in the BepInEx folder and restart
</details>


<details>
<summary><b>Changelog</b></summary>


### Version 1.0.1
- Improved merchant UI layout and appearance
- Repositioned buttons for improved usability
- Added a "Sell All" button and a "x50" button


### Version 1.0.0
- Removed debugging features
- Added a Sell Configuration
- Added a visual scroll bar in the UI

### Version 0.0.4
- Fixed Mountains Merchant inventory issue
- Improved UI layout for better readability

### Version 0.0.3
- Added more debugging with logging
- Initial public release

### Version 0.0.2
- Added ability to place merchants on built structures
- Fixed resource requirement enforcement
- Fixed persistence through logging

### Version 0.0.1
- Initial release with debugging code for testing
</details>



## Support the Mod
If you enjoy this mod and want to support its development, consider donating!

<a href="https://www.buymeacoffee.com/Ruijven" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/arial-blue.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;"></a>

You can also explore config files or download Plan Build files for additional builds!