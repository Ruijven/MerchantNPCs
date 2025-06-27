# MerchantNPCs Asset Bundle Structure

This document outlines the expected structure and contents of the `merchantnpcs` asset bundle that will be used in the MerchantNPCs mod.

## Asset Bundle Name
- `merchantnpcs`

## Prefabs
The asset bundle should contain the following prefabs:

1. `merchant_general` - General merchant NPC prefab
   - Base model with merchant appearance
   - Includes MerchantBehavior component
   - Contains appropriate colliders and rigging

2. `merchant_weapons` - Weapons merchant NPC prefab
   - Specialized appearance for weapons merchant
   - Includes MerchantBehavior component
   - Contains appropriate colliders and rigging

3. `merchant_armor` - Armor merchant NPC prefab
   - Specialized appearance for armor merchant
   - Includes MerchantBehavior component
   - Contains appropriate colliders and rigging

4. `merchant_food` - Food merchant NPC prefab
   - Specialized appearance for food merchant
   - Includes MerchantBehavior component
   - Contains appropriate colliders and rigging

## Materials
The asset bundle should contain the following materials:

1. `merchant_general_material` - Material for general merchant
2. `merchant_weapons_material` - Material for weapons merchant
3. `merchant_armor_material` - Material for armor merchant
4. `merchant_food_material` - Material for food merchant
5. `merchant_stall_material` - Material for merchant stalls/structures

## Icons
The asset bundle should contain the following icons:

1. `merchant_tab_icon` - Icon for the Merchants tab in the hammer menu
2. `merchant_general_icon` - Icon for general merchant in the build menu
3. `merchant_weapons_icon` - Icon for weapons merchant in the build menu
4. `merchant_armor_icon` - Icon for armor merchant in the build menu
5. `merchant_food_icon` - Icon for food merchant in the build menu

## Additional Assets
The asset bundle may also contain:

1. UI elements for merchant interfaces
2. Sound effects for merchant interactions
3. Particle effects for merchant stalls

## Asset Bundle Import Settings
- The asset bundle should be marked as an Embedded Resource in the project
- Set to "Do Not Copy" in the build settings
- Referenced in the .csproj file as an EmbeddedResource

## Unity Export Settings
When creating the asset bundle in Unity:
- Target platform: Windows (Standalone)
- Compression: LZ4
- Include dependencies: Yes
