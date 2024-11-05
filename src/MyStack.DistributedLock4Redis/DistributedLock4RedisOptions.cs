﻿namespace Microsoft.Extensions.DistributedLock4Redis
{
    /// <summary>
    /// Represents the configuration options for a distributed lock
    /// </summary>
    public class DistributedLock4RedisOptions
    {
        /// <summary>
        /// Gets or sets the prefix for global keys
        /// </summary>
        public string KeyPrefix { get; set; } = default!;
        /// <summary>
        /// Gets or sets the Redis connection string
        /// </summary>
        public string ConnectionString { get; set; } = default!;
    }
}