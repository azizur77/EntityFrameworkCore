﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public class DbContextPoolConfigurationSnapshot
    {
        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public DbContextPoolConfigurationSnapshot(
            bool? autoDetectChangesEnabled,
            QueryTrackingBehavior? queryTrackingBehavior,
            bool? autoTransactionsEnabled,
            bool? lazyLoadingEnabled,
            CascadeTiming? cascadeDeleteTiming,
            CascadeTiming? deleteOrphansTiming)
        {
            AutoDetectChangesEnabled = autoDetectChangesEnabled;
            QueryTrackingBehavior = queryTrackingBehavior;
            AutoTransactionsEnabled = autoTransactionsEnabled;
            LazyLoadingEnabled = lazyLoadingEnabled;
            CascadeDeleteTiming = cascadeDeleteTiming;
            DeleteOrphansTiming = deleteOrphansTiming;
        }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual bool? AutoDetectChangesEnabled { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual bool? LazyLoadingEnabled { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual CascadeTiming? CascadeDeleteTiming { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual CascadeTiming? DeleteOrphansTiming { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual QueryTrackingBehavior? QueryTrackingBehavior { get; }

        /// <summary>
        ///     This API supports the Entity Framework Core infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public virtual bool? AutoTransactionsEnabled { get; }
    }
}
