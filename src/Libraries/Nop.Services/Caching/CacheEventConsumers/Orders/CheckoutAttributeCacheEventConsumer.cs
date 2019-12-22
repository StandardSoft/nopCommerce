﻿using Nop.Core.Domain.Orders;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Orders
{
    public partial class CheckoutAttributeCacheEventConsumer : CacheEventConsumer<CheckoutAttribute>
    {
        public override void ClearCashe(CheckoutAttribute entity)
        {
            _cacheManager.RemoveByPrefix(NopOrderCachingDefaults.CheckoutAttributesPrefixCacheKey);
            _cacheManager.RemoveByPrefix(NopOrderCachingDefaults.CheckoutAttributeValuesPrefixCacheKey);
        }
    }
}
