namespace Game.Protocol.Communication
{
    using Game.Protocol.Communication.DataEntity;
    using Newtonsoft.Json;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    /// <summary>
    /// ItemCardEffectManager
    /// </summary>
    public class ItemCardEffectManager : ConcurrentDictionary<long, ItemCardEffectSettingDTO>
    {
        /// <summary>
        /// ItemCardEffectManager
        /// </summary>
        public ItemCardEffectManager()
        {

        }

        /// <summary>
        /// 反序列化Json字串
        /// </summary>
        /// <param name="jsonString"></param>
        public void DeserializeByJsonString(string jsonString)
        {
            var itemCardEffectSettingDTOList = JsonConvert.DeserializeObject<List<ItemCardEffectSettingDTO>>(jsonString);
            this.DeserializeByList(itemCardEffectSettingDTOList);
        }

        /// <summary>
        /// 反序列化List
        /// </summary>
        /// <param name="itemCardEffectSettingDTOList"></param>
        public void DeserializeByList(List<ItemCardEffectSettingDTO> itemCardEffectSettingDTOList)
        {
            this.Clear();

            itemCardEffectSettingDTOList.ForEach(itemCardEffectSettingDTO =>
            {
                this.TryAdd(itemCardEffectSettingDTO.ItemCardEffectID, itemCardEffectSettingDTO);
            });
        }
    }
}
