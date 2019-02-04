// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Cosmos.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Cosmos-specific extension methods for <see cref="PropertyBuilder" />.
    /// </summary>
    public static class CosmosOwnershipBuilderExtensions
    {
        /// <summary>
        ///     Configures the property name that the entity is mapped to when stored as an embedded document.
        /// </summary>
        /// <remarks> If an empty string is supplied then the property will not be persisted. </remarks>
        /// <param name="entityTypeBuilder"> The builder for the entity type being configured. </param>
        /// <param name="name"> The name of the container. </param>
        /// <returns> The same builder instance so that multiple calls can be chained. </returns>
        public static ReferenceOwnershipBuilder ToProperty(
            [NotNull] this ReferenceOwnershipBuilder entityTypeBuilder,
            [CanBeNull] string name)
        {
            entityTypeBuilder.GetInfrastructure<InternalEntityTypeBuilder>()
                .Cosmos(ConfigurationSource.Explicit)
                .ToProperty(name);

            return entityTypeBuilder;
        }

        /// <summary>
        ///     Configures the property name that the entity is mapped to when stored as an embedded document.
        /// </summary>
        /// <remarks> If an empty string is supplied then the property will not be persisted. </remarks>
        /// <param name="entityTypeBuilder"> The builder for the entity type being configured. </param>
        /// <param name="name"> The name of the container. </param>
        /// <returns> The same builder instance so that multiple calls can be chained. </returns>
        public static ReferenceOwnershipBuilder<TEntity, TRelatedEntity> ToProperty<TEntity, TRelatedEntity>(
            [NotNull] this ReferenceOwnershipBuilder<TEntity, TRelatedEntity> entityTypeBuilder,
            [CanBeNull] string name)
            where TEntity : class
            where TRelatedEntity : class
        {
            entityTypeBuilder.GetInfrastructure<InternalEntityTypeBuilder>()
                .Cosmos(ConfigurationSource.Explicit)
                .ToProperty(name);

            return entityTypeBuilder;
        }

        /// <summary>
        ///     Configures the property name that the entity collection is mapped to when stored as an embedded document.
        /// </summary>
        /// <remarks> If an empty string is supplied then the property will not be persisted. </remarks>
        /// <param name="entityTypeBuilder"> The builder for the entity type being configured. </param>
        /// <param name="name"> The name of the container. </param>
        /// <returns> The same builder instance so that multiple calls can be chained. </returns>
        public static CollectionOwnershipBuilder ToProperty(
            [NotNull] this CollectionOwnershipBuilder entityTypeBuilder,
            [CanBeNull] string name)
        {
            entityTypeBuilder.GetInfrastructure<InternalEntityTypeBuilder>()
                .Cosmos(ConfigurationSource.Explicit)
                .ToProperty(name);

            return entityTypeBuilder;
        }

        /// <summary>
        ///     Configures the property name that the entity collection is mapped to when stored as an embedded document.
        /// </summary>
        /// <remarks> If an empty string is supplied then the property will not be persisted. </remarks>
        /// <param name="entityTypeBuilder"> The builder for the entity type being configured. </param>
        /// <param name="name"> The name of the container. </param>
        /// <returns> The same builder instance so that multiple calls can be chained. </returns>
        public static CollectionOwnershipBuilder<TEntity, TDependentEntity> ToProperty<TEntity, TDependentEntity>(
            [NotNull] this CollectionOwnershipBuilder<TEntity, TDependentEntity> entityTypeBuilder,
            [CanBeNull] string name)
            where TEntity : class
            where TDependentEntity : class
        {
            entityTypeBuilder.GetInfrastructure<InternalEntityTypeBuilder>()
                .Cosmos(ConfigurationSource.Explicit)
                .ToProperty(name);

            return entityTypeBuilder;
        }
    }
}