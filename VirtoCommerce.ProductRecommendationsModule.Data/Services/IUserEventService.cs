﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtoCommerce.ProductRecommendationsModule.Data.Model;

namespace VirtoCommerce.ProductRecommendationsModule.Data.Services
{
    public interface IUserEventService
    {
        void Add(UserEvent userEvent);

        UserEvent[] Search(SearchUserEventCriteria criteria);
    }
}
