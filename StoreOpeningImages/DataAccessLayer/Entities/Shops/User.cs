using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Shops
{
    public partial class User
    {
        public User()
        {
            ShopHistoryNotifications = new HashSet<ShopHistoryNotification>();
            UserContractSettings = new HashSet<UserContractSetting>();
            UserShopGridFilterSettings = new HashSet<UserShopGridFilterSetting>();
            UserShopGridSettings = new HashSet<UserShopGridSetting>();
            UserShopGridSortSettings = new HashSet<UserShopGridSortSetting>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<ShopHistoryNotification> ShopHistoryNotifications { get; set; }
        public virtual ICollection<UserContractSetting> UserContractSettings { get; set; }
        public virtual ICollection<UserShopGridFilterSetting> UserShopGridFilterSettings { get; set; }
        public virtual ICollection<UserShopGridSetting> UserShopGridSettings { get; set; }
        public virtual ICollection<UserShopGridSortSetting> UserShopGridSortSettings { get; set; }
    }
}
