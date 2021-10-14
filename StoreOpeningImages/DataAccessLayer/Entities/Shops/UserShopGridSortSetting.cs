using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Entities.Shops
{
    public partial class UserShopGridSortSetting
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public string Direction { get; set; }
        public int UserRoleId { get; set; }
        public string GridName { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
