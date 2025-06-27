[b][size=5]MerchantNPCs[/size][/b]

[b]Testing Stage[/b]
A Valheim mod that adds buildable merchant NPCs to your solo world. Each merchant is tied to a specific biome and progression stage.

[img]https://i.imgur.com/kNLAPQt.png[/img]

[img]https://i.imgur.com/y6Y5sC4.png[/img]

[spoiler=Features]
[list]
[*][b]Biome-Based Progression[/b]: Merchants unlock as you defeat bosses
[*][b]Eight Unique Merchants[/b]: One for each biome in Valheim
[*][b]Customizable Inventories[/b]: Easily modify what each merchant sells
[*][b]Customizable Merchant Build Requirements[/b]: Set the build material requirements for each merchant
[*][b]Automatic Selling[/b]: Sell items to merchants at half their buy price
[*][b]Easy to Use[/b]: Build merchants using the hammer's "Merchants" tab
[*][b]Solo Worlds Only[/b]: The mod is designed to work only in solo worlds. If you would like multiplayer, check out KG's Marketplace and Server NPCs mod.
[/list]
[/spoiler]

[spoiler=Installation]
[list=1]
[*]Install [url=https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/]BepInEx[/url]
[*]Install [url=https://valheim.thunderstore.io/package/ValheimModding/Jotunn/]Jotunn[/url]
[*]Download the latest release of MerchantNPCs
[*]Place the MerchantNPCs.dll in your BepInEx/plugins folder
[/list]
[/spoiler]

[spoiler=Merchant Types & Requirements]
[b]1. Meadows Merchant[/b]
[list]
[*][b]Requirements[/b]: Wood (50), Stone (50), Flint (25)
[*][b]Sells[/b]: Basic meadows resources and tools
[/list]

[b]2. Black Forest Merchant[/b]
[list]
[*][b]Requirements[/b]: Fine Wood (20), Troll Hide (10), Copper (10), Eikthyr Trophy (1)
[*][b]Sells[/b]: Black Forest resources and bronze equipment
[/list]

[b]3. Swamp Merchant[/b]
[list]
[*][b]Requirements[/b]: Ancient Bark (20), Guck (10), Iron (10), Elder Trophy (1)
[*][b]Sells[/b]: Swamp resources and iron equipment
[/list]

[b]4. Mountain Merchant[/b]
[list]
[*][b]Requirements[/b]: Freeze Gland (10), Wolf Pelt (10), Silver (10), Bonemass Trophy (1)
[*][b]Sells[/b]: Mountain resources and silver equipment
[/list]

[b]5. Plains Merchant[/b]
[list]
[*][b]Requirements[/b]: Barley (10), Black Metal Scrap (10), Deathsquito Needle (5), Moder Trophy (1)
[*][b]Sells[/b]: Plains resources and black metal equipment
[/list]

[b]6. Mistlands Merchant[/b]
[list]
[*][b]Requirements[/b]: Royal Jelly (10), Yggdrasil Wood (20), Carapace (5), Yagluth Trophy (1)
[*][b]Sells[/b]: Mistlands resources and carapace equipment
[/list]

[b]7. Ashlands Merchant[/b]
[list]
[*][b]Requirements[/b]: Blackwood (20), Flametal Ore (5), Fiddlehead Fern (10), Seeker Queen Trophy (1)
[*][b]Sells[/b]: Ashlands resources and flametal equipment
[/list]

[b]8. Deep North Merchant[/b]
[list]
[*][b]Requirements[/b]: Freeze Gland (200), Wolf Pelt (200), Fader Trophy (20)
[*][b]Sells[/b]: Deep North resources and frost equipment
[/list]
[/spoiler]

[spoiler=Customizing Merchant Inventories]
Merchant inventories can be customized by editing the text files in:
[code]BepInEx/config/MerchantNPCs/[/code]

Each merchant type has its own file:
[list]
[*]meadows.txt
[*]blackforest.txt
[*]swamp.txt
[*]mountain.txt
[*]plains.txt
[*]mistlands.txt
[*]ashlands.txt
[*]deepnorth.txt
[/list]

[b]File Format[/b]
Each line in the file represents one item with the following format:
[code]ItemName:BuyPrice[/code]

Example:
[code]Iron:30
IronNails:8[/code]

[b]Item Properties[/b]
[list]
[*][b]ItemName[/b]: The internal name of the item (e.g., "Iron", "IronNails")
[*][b]BuyPrice[/b]: How much the item costs to buy
[/list]
Sell prices are automatically set to half of the buy price.
[/spoiler]

[spoiler=Customizing Merchant Build Costs]
You can customize the resource requirements for building each merchant by editing the configuration file at:
[code]BepInEx/config/ruijven.merchantnpcs.cfg[/code]

The configuration file is automatically generated the first time you run the game with the mod installed.

[b]Configuration Format[/b]
The configuration file is organized into sections for each merchant type:
[code][Meadows Merchant]
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
Resource4Amount=1[/code]

[b]Customization Options[/b]
[list=1]
[*][b]Change Resource Types[/b]: Modify what materials are needed to build each merchant by changing the ResourceXType values
[*][b]Adjust Resource Amounts[/b]: Change how much of each material is required by modifying the ResourceXAmount values
[*][b]Add or Remove Requirements[/b]: You can set an amount to 0 to effectively remove a requirement
[/list]

[b]Item Type Names[/b]
When changing resource types, you must use the internal item name. Some common examples:
[list]
[*]Wood - Regular wood
[*]ElderBark - Ancient bark
[*]TrophyTheElder - Elder trophy
[/list]

You can adjust the values to make merchants easier or harder to build based on your preferences. For example, setting Resource1Amount=10 would reduce the wood requirement for the Meadows Merchant from 50 to 10.
[/spoiler]

[spoiler=Building Merchants]
[list=1]
[*]Craft a hammer if you don't have one
[*]Open the build menu (right-click with hammer)
[*]Navigate to the "Merchants" tab
[*]Select a merchant type (you'll only see merchants you can build based on your progression)
[*]Place the merchant in your base
[*]Interact with the merchant to open the trading interface
[/list]
[/spoiler]

[spoiler=Game Progression]
The mod is designed to follow Valheim's natural progression:
[list=1]
[*]Start with the Meadows Merchant (available from the beginning)
[*]Defeat Eikthyr to unlock the Black Forest Merchant
[*]Defeat The Elder to unlock the Swamp Merchant
[*]Defeat Bonemass to unlock the Mountain Merchant
[*]Defeat Moder to unlock the Plains Merchant
[*]Defeat Yagluth to unlock the Mistlands Merchant
[*]Defeat the Queen to unlock the Ashlands Merchant
[*]Defeat the Fader to unlock the Deep North Merchant (future content)
[/list]
[/spoiler]

[spoiler=Community & Feedback]
[b][size=4]Join Our Discord Community[/size][/b]

Join our [url=https://discord.gg/qGf5FdqhVC]Discord server[/url] to:
[list]
[*]Share your experiences with the mod
[*]Report bugs and issues
[*]Suggest new features and improvements
[*]Get help from other users and developers
[*]See previews of upcoming updates
[/list]

[b]Reporting Issues[/b]
When reporting issues, please include:
[list]
[*]Mod version (currently running)
[*]BepInEx log file (found in BepInEx/LogOutput.log)
[*]Steps to reproduce the issue
[*]Screenshots if applicable
[/list]

[b]Common Solutions[/b]
[list]
[*][b]Merchants not appearing[/b]: Make sure you have discovered the materials required
[*][b]Items not showing up[/b]: Check the console for error messages
[/list]
[/spoiler]
