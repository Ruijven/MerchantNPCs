using System.Collections.Generic;
using BepInEx.Configuration;

namespace MerchantNPCs
{
    /// <summary>
    /// Represents a configurable resource requirement
    /// </summary>
    public class ResourceRequirement
    {
        public ConfigEntry<string> ItemType { get; set; }
        public ConfigEntry<int> Amount { get; set; }
    }

    /// <summary>
    /// Manages configuration for merchant build costs
    /// </summary>
    public class MerchantCostConfig
    {
        // List to store resource requirements in order
        private List<ResourceRequirement> _requirements = new List<ResourceRequirement>();

        /// <summary>
        /// Creates a new resource cost configuration entry
        /// </summary>
        /// <param name="config">BepInEx configuration</param>
        /// <param name="merchantType">Merchant type (e.g., "Meadows Merchant")</param>
        /// <param name="index">Index of the requirement (1-based)</param>
        /// <param name="defaultItemType">Default item type (e.g., "Wood")</param>
        /// <param name="defaultAmount">Default amount required</param>
        public void AddResourceRequirement(ConfigFile config, string merchantType, int index, string defaultItemType, int defaultAmount)
        {
            var requirement = new ResourceRequirement
            {
                ItemType = config.Bind(merchantType, $"Resource{index}Type", defaultItemType, 
                    $"Item type for resource requirement #{index}"),
                Amount = config.Bind(merchantType, $"Resource{index}Amount", defaultAmount, 
                    $"Amount required for resource #{index} ({defaultItemType})")
            };
            
            _requirements.Add(requirement);
        }

        /// <summary>
        /// Gets all configured resource requirements
        /// </summary>
        /// <returns>List of resource requirements with item type and amount</returns>
        public List<(string itemType, int amount)> GetRequirements()
        {
            var result = new List<(string, int)>();
            
            foreach (var req in _requirements)
            {
                // Only add requirements with valid item types and amounts > 0
                if (!string.IsNullOrEmpty(req.ItemType.Value) && req.Amount.Value > 0)
                {
                    result.Add((req.ItemType.Value, req.Amount.Value));
                }
            }
            
            return result;
        }
    }
}
