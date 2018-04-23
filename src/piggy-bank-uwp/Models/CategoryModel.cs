﻿using piggy_bank_uwp.Models;

namespace piggy_bank_uwp.Models
{
    public sealed class CategoryModel : IBaseModel
    {
        public string HexColor { get; set; }

        public string Title { get; set; }

        public string Id { get ; set; }
    }
}
