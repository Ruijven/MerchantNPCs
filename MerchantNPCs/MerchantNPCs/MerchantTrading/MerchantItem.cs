using System;
using System.Collections.Generic;

namespace MerchantNPCs.MerchantTrading
{
    /// <summary>
    /// Represents an item that can be bought from or sold to a merchant
    /// </summary>
    public class MerchantItem
    {
        /// <summary>
        /// The name of the item in Valheim (must match the prefab name)
        /// </summary>
        public string ItemName { get; set; }
        
        /// <summary>
        /// The original name of the item as it appears in the config file (without $item_ prefix)
        /// </summary>
        public string OriginalItemName { get; set; }

        /// <summary>
        /// The price to buy the item from the merchant
        /// </summary>
        public int BuyPrice { get; set; }

        /// <summary>
        /// Gets the sell price of the item based on the configured sell percentage
        /// </summary>
        public int SellPrice => (int)(BuyPrice * (MerchantNPCsPlugin.SellPercentage.Value / 100f));
        
        /// <summary>
        /// Alias for BuyPrice to maintain compatibility with existing code
        /// </summary>
        public int Cost => BuyPrice;

        /// <summary>
        /// Reference to the actual item prefab (populated at runtime)
        /// </summary>
        public ItemDrop.ItemData ItemData { get; set; }
        
        /// <summary>
        /// The actual prefab name used in the game (may differ from ItemName)
        /// </summary>
        public string PrefabName { get; set; }
        
        /// <summary>
        /// Whether the item is available for purchase
        /// </summary>
        public bool IsAvailable => true;
    }

    /// <summary>
    /// Represents a merchant's inventory configuration
    /// </summary>
    public class MerchantInventory
    {
        /// <summary>
        /// The merchant type this inventory belongs to
        /// </summary>
        public string MerchantType { get; set; }

        /// <summary>
        /// The items this merchant sells
        /// </summary>
        public List<MerchantItem> Items { get; set; } = new List<MerchantItem>();
    }
}
