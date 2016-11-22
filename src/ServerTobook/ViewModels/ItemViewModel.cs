using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerTobook.ViewModels
{
    /// <summary>
    /// 	All public members are serialized by default. Members can be excluded using JsonIgnoreAttribute or NonSerializedAttribute. This is the default member serialization mode.
    /// </summary>

    [JsonObject(MemberSerialization.OptOut)]
    public class ItemViewModel
    {
        #region Constructor
        public ItemViewModel()
        {

        }
        #endregion

        #region Properties

        public int Id { get; set; }

        public string Title { get; set; }

        [JsonIgnore]
        public string Description { get; set; }

        #endregion


    }
}
